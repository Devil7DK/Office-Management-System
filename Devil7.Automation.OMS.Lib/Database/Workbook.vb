'=========================================================================='
'                                                                          '
'                    (C) Copyright 2018 Devil7 Softwares.                  '
'                                                                          '
' Licensed under the Apache License, Version 2.0 (the "License");          '
' you may not use this file except in compliance with the License.         '
' You may obtain a copy of the License at                                  '
'                                                                          '
'                http://www.apache.org/licenses/LICENSE-2.0                '
'                                                                          '
' Unless required by applicable law or agreed to in writing, software      '
' distributed under the License is distributed on an "AS IS" BASIS,        '
' WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. '
' See the License for the specific language governing permissions and      '
' limitations under the License.                                           '
'                                                                          '
' Contributors :                                                           '
'     Dineshkumar T                                                        '
'                                                                          '
'=========================================================================='

Imports System.Data.SqlClient
Imports Devil7.Automation.OMS.Lib.Objects
Imports Devil7.Automation.OMS.Lib.Utils

Namespace Database
    Public Module Workbook

        Function AddNew(ByVal User As User, ByVal Job As Job, ByVal DueDate As Date, _
                   ByVal Client As Client, ByVal Status As String, ByVal Description As String, ByVal Remarks As String, ByVal TargetDate As Date, _
                   ByVal Priority As String, ByVal CurrentStep As String, ByVal Assessment As String, ByVal Financial As String, ByVal DefaultStorage As String, ByVal Owner As User, ByVal History As String) As WorkbookItem
            Dim R As WorkbookItem = Nothing

            Dim CommandString As String = "INSERT INTO Workbook ([User],[Job],[DueDate],[Client],[DateAdded],[DateCompleted],[Status],[Description],[Remarks],[Folder],[TargetDate],[Priority],[DateUpdated],[CurrentStep],[AssessmentDetails],[FinancialDetails],[Owner],[History]) VALUES (@User,@Job,@DueDate,@Client,@DateAdded,@DateCompleted,@Status,@Description,@Remarks,@Folder,@TargetDate,@Priority,@DateUpdated,@CurrentStep,@AssessmentDetails,@FinancialDetails,@Owner,@History);SELECT SCOPE_IDENTITY();"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@User", User.ID)
                AddParameter(Command, "@Job", Job.JID)
                AddParameter(Command, "@DueDate", DueDate)
                AddParameter(Command, "@Client", Client.ID)
                AddParameter(Command, "@DateAdded", Now)
                AddParameter(Command, "@DateCompleted", Now)
                AddParameter(Command, "@Status", Status)
                AddParameter(Command, "@Description", Description)
                AddParameter(Command, "@Remarks", Remarks)
                AddParameter(Command, "@Folder", GetFolder(DefaultStorage, Client, Job, Assessment, Now.Year))
                AddParameter(Command, "@TargetDate", TargetDate)
                AddParameter(Command, "@Priority", Priority)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@CurrentStep", CurrentStep)
                AddParameter(Command, "@AssessmentDetails", Assessment)
                AddParameter(Command, "@FinancialDetails", Financial)
                AddParameter(Command, "@Owner", Owner.ID)
                AddParameter(Command, "@History", History)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New WorkbookItem(ID, User, Job, Client, DueDate, Now, Now, Now, Description, Remarks, TargetDate, Priority, Status, CurrentStep, Owner, History)
                Else
                    MsgBox("Unknown error while inserting workbook item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
                End If
            End Using

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal DueDate As Date, _
                  ByVal Description As String, ByVal Remarks As String, ByVal TargetDate As Date, _
                   ByVal AssignedTo As User, ByVal History As String) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [DueDate]=@DueDate,[DateCompleted]=@DateCompleted,[Description]=@Description,[Remarks]=@Remarks,[TargetDate]=@TargetDate,[DateUpdated]=@DateUpdated,[User]=@User,[History]=@History WHERE [ID]=@id;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@id", ID)
                AddParameter(Command, "@DueDate", DueDate)
                AddParameter(Command, "@DateCompleted", Now)
                AddParameter(Command, "@Description", Description)
                AddParameter(Command, "@Remarks", Remarks)
                AddParameter(Command, "@TargetDate", TargetDate)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@History", History)
                AddParameter(Command, "@User", AssignedTo.ID)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    MsgBox("Unknown error while editing workbook item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
                End If
            End Using

            Return R
        End Function

        Function Remove(ByVal ID As Integer) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "DELETE FROM Workbook WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                End If
            End Using

            Return R
        End Function

        Function GetWorkbookItemByID(ByVal ID As Integer) As WorkbookItem
            Dim R As WorkbookItem = Nothing

            Dim CommandString As String = "SELECT * FROM [Workbook] WHERE [ID]=@ID"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)

                Dim AssignedTo As User
                Dim AssignedID As Integer
                Dim Job As Job
                Dim JobID As String
                Dim Client As Client
                Dim ClientID As Integer
                Dim DueDate As Date
                Dim AddedOn As Date
                Dim CompletedOn As Date
                Dim UpdatedOn As Date
                Dim Description As String
                Dim Remarks As String
                Dim TargetDate As Date
                Dim PriorityOfWork As Enums.Priority
                Dim Status As Enums.WorkStatus
                Dim Folder As String
                Dim AssementDetail As String
                Dim FinancialDetail As String
                Dim CurrentStep As String
                Dim Owner As User
                Dim OwnerID As Integer
                Dim History As String
                Dim Read As Boolean = False

                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        AssignedID = Reader.Item("User")
                        JobID = Reader.Item("Job").ToString
                        ClientID = Reader.Item("Client")
                        DueDate = Reader.Item("DueDate")
                        AddedOn = Reader.Item("DateAdded")
                        CompletedOn = Reader.Item("DateCompleted")
                        UpdatedOn = Reader.Item("DateUpdated")
                        Description = Reader.Item("Description").ToString
                        Remarks = Reader.Item("Remarks").ToString
                        TargetDate = Reader.Item("TargetDate")
                        PriorityOfWork = Reader.Item("Priority")
                        Status = DirectCast([Enum].Parse(GetType(Enums.WorkStatus), Reader.Item("Status").ToString), Enums.WorkStatus)
                        Folder = Reader.Item("Folder").ToString
                        AssementDetail = Reader.Item("AssessmentDetails").ToString
                        FinancialDetail = Reader.Item("FinancialDetails").ToString
                        CurrentStep = Reader.Item("CurrentStep").ToString
                        OwnerID = Reader.Item("Owner").ToString
                        History = Reader.Item("History").ToString.Trim
                        Read = True
                    End If
                End Using
                If Read Then
                    AssignedTo = GetUserByID(AssignedID)
                    Job = GetJobByID(JobID, False)
                    Client = GetClientByID(ClientID)
                    Owner = GetUserByID(OwnerID)
                    R = New WorkbookItem(ID, AssignedTo, Job, Client, DueDate, AddedOn, CompletedOn, UpdatedOn, Description, Remarks, TargetDate, PriorityOfWork, Status, CurrentStep, Owner, History)
                End If
            End Using

            Return R
        End Function

        Function GetAll(ByVal CloseConnection As Boolean, ByVal Clients As List(Of Client), ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As IEnumerable(Of WorkbookItem)
            Dim R As New List(Of WorkbookItem)

            Dim CommandString As String = "SELECT * FROM [Workbook]"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Jobs.Sort(New Comparers.JobComparer)
            Clients.Sort(New Comparers.CompareByID)
            Users.Sort(New Comparers.CompareByID)

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                         Dim ID As Integer = reader.Item("ID")
                        Dim AssignedTo As User = Users(Users.BinarySearch(New User(Reader.Item("User")), New Comparers.CompareByID))
                        Dim Job As Job = Jobs(Jobs.BinarySearch(New Job(Reader.Item("Job").ToString), New Comparers.JobComparer))
                        Dim Client As Client = Clients(Clients.BinarySearch(New Client(Reader.Item("Client")), New Comparers.CompareByID))
                        Dim DueDate As Date = Reader.Item("DueDate")
                        Dim AddedOn As Date = Reader.Item("DateAdded")
                        Dim CompletedOn As Date = Reader.Item("DateCompleted")
                        Dim UpdatedOn As Date = Reader.Item("DateUpdated")
                        Dim Description As String = Reader.Item("Description").ToString
                        Dim Remarks As String = Reader.Item("Remarks").ToString
                        Dim TargetDate As Date = Reader.Item("TargetDate")
                        Dim PriorityOfWork As Enums.Priority = DirectCast([Enum].Parse(GetType(Enums.Priority), Reader.Item("Priority").ToString), Enums.Priority)
                        Dim Status As Enums.WorkStatus = DirectCast([Enum].Parse(GetType(Enums.WorkStatus), Reader.Item("Status").ToString), Enums.WorkStatus)
                        Dim Folder As String = Reader.Item("Folder").ToString
                        Dim AssementDetail As String = Reader.Item("AssessmentDetails").ToString
                        Dim FinancialDetail As String = Reader.Item("FinancialDetails").ToString
                        Dim CurrentStep As String = Reader.Item("CurrentStep").ToString
                        Dim Owner As User = Users(Users.BinarySearch(New User(Reader.Item("Owner")), New Comparers.CompareByID))
                        Dim History As String = Reader.Item("History").ToString.Trim
                        R.Add(New WorkbookItem(ID, AssignedTo, Job, Client, DueDate, AddedOn, CompletedOn, UpdatedOn, Description, Remarks, TargetDate, PriorityOfWork, Status, CurrentStep, Owner, History))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function GetAllForUser(ByVal CloseConnection As Boolean, ByVal Clients As List(Of Client), ByVal Jobs As List(Of Job), ByVal Users As List(Of User), ByVal UserID As Integer) As IEnumerable(Of WorkbookItem)
            Dim R As New List(Of WorkbookItem)

            Dim CommandString As String = "SELECT * FROM [Workbook] WHERE [User] = @UID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Jobs.Sort(New Comparers.JobComparer)
            Clients.Sort(New Comparers.CompareByID)
            Users.Sort(New Comparers.CompareByID)

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@UID", UserID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        Dim ID As Integer = Reader.Item("ID")
                        Dim AssignedTo As User = Users(Users.BinarySearch(New User(Reader.Item("User")), New Comparers.CompareByID))
                        Dim Job As Job = Jobs(Jobs.BinarySearch(New Job(Reader.Item("Job").ToString), New Comparers.JobComparer))
                        Dim Client As Client = Clients(Clients.BinarySearch(New Client(Reader.Item("Client")), New Comparers.CompareByID))
                        Dim DueDate As Date = Reader.Item("DueDate")
                        Dim AddedOn As Date = Reader.Item("DateAdded")
                        Dim CompletedOn As Date = Reader.Item("DateCompleted")
                        Dim UpdatedOn As Date = Reader.Item("DateUpdated")
                        Dim Description As String = Reader.Item("Description").ToString
                        Dim Remarks As String = Reader.Item("Remarks").ToString
                        Dim TargetDate As Date = Reader.Item("TargetDate")
                        Dim PriorityOfWork As Enums.Priority = DirectCast([Enum].Parse(GetType(Enums.Priority), Reader.Item("Priority").ToString), Enums.Priority)
                        Dim Status As Enums.WorkStatus = DirectCast([Enum].Parse(GetType(Enums.WorkStatus), Reader.Item("Status").ToString), Enums.WorkStatus)
                        Dim Folder As String = Reader.Item("Folder").ToString
                        Dim AssementDetail As String = Reader.Item("AssessmentDetails").ToString
                        Dim FinancialDetail As String = Reader.Item("FinancialDetails").ToString
                        Dim CurrentStep As String = Reader.Item("CurrentStep").ToString
                        Dim Owner As User = Users(Users.BinarySearch(New User(Reader.Item("Owner")), New Comparers.CompareByID))
                        Dim History As String = Reader.Item("History").ToString.Trim
                        R.Add(New WorkbookItem(ID, AssignedTo, Job, Client, DueDate, AddedOn, CompletedOn, UpdatedOn, Description, Remarks, TargetDate, PriorityOfWork, Status, CurrentStep, Owner, History))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function UpdateStep(ByVal ID As Integer, ByVal Step_ As String, ByVal History As String) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [CurrentStep]=@CurrentStep,[History]=@History WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@CurrentStep", Step_)
                AddParameter(Command, "@History", History)
                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            Return R
        End Function

        Function UpdateStatus(ByVal ID As Integer, ByVal Status As Integer, ByVal History As String)
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [Status]=@Status,[History]=@History WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@Status", Status)
                AddParameter(Command, "@History", History)
                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            Return R
        End Function

        Function UpdatePriority(ByVal ID As Integer, ByVal Priority As Integer, ByVal History As String)
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [Priority]=@Priority,[History]=@History WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@Priority", Priority)
                AddParameter(Command, "@History", History)
                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            Return R
        End Function

        Function AssignTo(ByVal ID As Integer, ByVal NewUser As Integer, ByVal History As String)
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [User]=@User,[History]=@History WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@User", NewUser)
                AddParameter(Command, "@History", History)
                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            Return R
        End Function

    End Module
End Namespace