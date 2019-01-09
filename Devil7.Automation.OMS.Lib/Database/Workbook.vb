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

#Region "Update Functions - Normal"
        Function AddNew(ByVal User As User, ByVal Job As Job, ByVal DueDate As Date,
                   ByVal Client As ClientMinimal, ByVal Status As Enums.WorkStatus, ByVal Description As String, ByVal Remarks As String, ByVal TargetDate As Date,
                   ByVal Priority As Enums.Priority, ByVal CurrentStep As String, ByVal Assessment As YearMonth, ByVal Financial As YearMonth, ByVal DefaultStorage As String, ByVal Owner As User, ByVal History As String, ByVal WorkType As Enums.WorkType) As WorkbookItem
            Dim R As WorkbookItem = Nothing

            Dim CommandString As String = "INSERT INTO Workbook ([User],[Job],[DueDate],[ClientID],[Client],[DateAdded],[DateCompleted],[Status],[Description],[Remarks],[Folder],[TargetDate],[Priority],[DateUpdated],[CurrentStep],[AssessmentDetails],[FinancialDetails],[Owner],[History],[Billed],[WorkType]) VALUES (@User,@Job,@DueDate,@ClientID,@Client,@DateAdded,@DateCompleted,@Status,@Description,@Remarks,@Folder,@TargetDate,@Priority,@DateUpdated,@CurrentStep,@AssessmentDetails,@FinancialDetails,@Owner,@History,@Billed,@WorkType);SELECT SCOPE_IDENTITY();"
            Dim Connection As SqlConnection = GetConnection()

            Dim FullClient As Client = GetClientByID(Client.ID)

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@User", User.ID)
                AddParameter(Command, "@Job", Job.ID)
                AddParameter(Command, "@DueDate", DueDate)
                AddParameter(Command, "@ClientID", Client.ID)
                AddParameter(Command, "@Client", Utils.ToXML(Of Objects.ClientMinimal)(Client))
                AddParameter(Command, "@DateAdded", Now)
                AddParameter(Command, "@DateCompleted", Now)
                AddParameter(Command, "@Status", Status)
                AddParameter(Command, "@Description", Description)
                AddParameter(Command, "@Remarks", Remarks)
                AddParameter(Command, "@Folder", If(DefaultStorage Is Nothing, "", DefaultStorage))
                AddParameter(Command, "@TargetDate", TargetDate)
                AddParameter(Command, "@Priority", Priority)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@CurrentStep", CurrentStep)
                AddParameter(Command, "@AssessmentDetails", Assessment.ToString)
                AddParameter(Command, "@FinancialDetails", Financial.ToString)
                AddParameter(Command, "@Owner", Owner.ID)
                AddParameter(Command, "@History", History)
                AddParameter(Command, "@Billed", Enums.BillingStatus.NotBilled)
                AddParameter(Command, "@WorkType", WorkType)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New WorkbookItem(ID, User, Job, Client, DueDate, Now, Now, Now, Description, Remarks, TargetDate, Priority, Status, CurrentStep, Owner, History, False, Assessment, Financial, WorkType)
                Else
                    MsgBox("Unknown error while inserting workbook item.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
                End If
            End Using

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal DueDate As Date,
                  ByVal Description As String, ByVal Remarks As String, ByVal TargetDate As Date,
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
#End Region

#Region "Update Functions - Special"
        Function UpdateStep(ByVal ID As Integer, ByVal Step_ As String, ByVal History As String) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [DateUpdated]=@DateUpdated,[CurrentStep]=@CurrentStep,[History]=@History WHERE [ID]=@ID;"
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

        Function UpdateRemarks(ByVal ID As Integer, ByVal Remarks As String, ByVal History As String) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [DateUpdated]=@DateUpdated,[Remarks]=@Remarks,[History]=@History WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@Remarks", Remarks)
                AddParameter(Command, "@History", History)
                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            Return R
        End Function

        Function UpdateStatus(ByVal WorkbookItem As WorkbookItem, ByVal CurrentStep As String, ByVal Status As Integer, ByVal History As String)
            Dim R As Boolean = False

            If WorkbookItem Is Nothing Then Return False

            If Status = Enums.WorkStatus.Completed Then
                Dim Forward As AutoForward = WorkbookItem.Job.AutoForwards.Find(Function(c) c.RequiredStep.ToUpper.Equals(CurrentStep.ToUpper))
                If Forward IsNot Nothing Then
                    Return AssignTo(WorkbookItem.ID, Forward.UserID, (History & vbNewLine & "AutoForward: Work transferred to User with ID " & Forward.UserID & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).ToString.Trim, Enums.WorkType.AutoForward)
                End If
            End If

            Dim CommandString As String = "UPDATE Workbook SET [DateUpdated]=@DateUpdated,[Status]=@Status,[History]=@History WHERE [ID]=@ID;"

            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", WorkbookItem.ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@Status", Status)
                AddParameter(Command, "@History", History)
                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            If R AndAlso Status = Enums.WorkStatus.Completed Then
                If WorkbookItem.Job.FollowUps.Count > 0 Then
                    For Each i As Job In WorkbookItem.Job.FollowUps
                        Dim w = AddNew(WorkbookItem.Owner, i, WorkbookItem.DueDate, WorkbookItem.Client, Enums.WorkStatus.Initialized, "Follow Up Job of Work ID " & WorkbookItem.ID, WorkbookItem.Remarks, WorkbookItem.TargetDate, Enums.Priority.Normal, i.Steps(0), WorkbookItem.AssessmentDetail, WorkbookItem.FinancialDetail, WorkbookItem.Folder, WorkbookItem.Owner, "Followup Job Added", Enums.WorkType.Followup)
                        If w Is Nothing Then
                            MsgBox("Unable to add followup job.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                        End If
                    Next
                End If
            End If

            Return R
        End Function

        Function UpdatePriority(ByVal ID As Integer, ByVal Priority As Integer, ByVal History As String)
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [DateUpdated]=@DateUpdated,[Priority]=@Priority,[History]=@History WHERE [ID]=@ID;"
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

        Function AssignTo(ByVal ID As Integer, ByVal NewUser As Integer, ByVal History As String, Optional WorkType As Enums.WorkType = Enums.WorkType.Transfer)
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [DateUpdated]=@DateUpdated,[User]=@User,[History]=@History,[WorkType]=@WorkType WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@User", NewUser)
                AddParameter(Command, "@History", History)
                AddParameter(Command, "@WorkType", WorkType)

                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            Return R
        End Function

        Function UpdateBilledStatus(ByVal ID As Integer, ByVal BilledStatus As Enums.BillingStatus, ByVal History As String)
            Dim R As Boolean = False

            Dim CommandString As String = "UPDATE Workbook SET [DateUpdated]=@DateUpdated,[Billed]=@Billed,[History]=@History WHERE [ID]=@ID;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                AddParameter(Command, "@DateUpdated", Now)
                AddParameter(Command, "@Billed", BilledStatus)
                AddParameter(Command, "@History", History)
                If Command.ExecuteNonQuery() = 1 Then
                    R = True
                End If
            End Using

            Return R
        End Function
#End Region

#Region "Load Functions - Single"
        Function GetWorkbookItemByID(ByVal ID As Integer) As WorkbookItem
            Dim R As WorkbookItem = Nothing

            Dim CommandString As String = "SELECT * FROM [Workbook] WHERE [ID]=@ID"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        R = Read(Reader)
                    End If
                End Using
            End Using

            Return R
        End Function
#End Region

#Region "Load Functions - Multi"
        Function GetIncomplete(ByVal CloseConnection As Boolean, ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As IEnumerable(Of WorkbookItem)
            Dim R As New List(Of WorkbookItem)

            Dim CommandString As String = "SELECT * FROM [Workbook] WHERE [Status]<3;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Jobs.Sort(New Comparers.CompareByID)
            Users.Sort(New Comparers.CompareByID)

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader, Jobs, Users))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function GetCompleted(ByVal CloseConnection As Boolean, ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As IEnumerable(Of WorkbookItem)
            Dim R As New List(Of WorkbookItem)

            Dim CommandString As String = "SELECT * FROM [Workbook] WHERE [Status]=3 AND [Billed]=0;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Jobs.Sort(New Comparers.CompareByID)
            Users.Sort(New Comparers.CompareByID)

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader, Jobs, Users))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function GetPending(ByVal CloseConnection As Boolean, ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As IEnumerable(Of WorkbookItem)
            Dim R As New List(Of WorkbookItem)

            Dim CommandString As String = "SELECT * FROM [Workbook] WHERE [Status]=3 AND [Billed]=2;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Jobs.Sort(New Comparers.CompareByID)
            Users.Sort(New Comparers.CompareByID)

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader, Jobs, Users))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function GetForUser(ByVal CloseConnection As Boolean, ByVal Jobs As List(Of Job), ByVal Users As List(Of User), ByVal UserID As Integer, ByVal WorkTypes As Enums.WorkType(), ByVal MatchWithOwner As Boolean) As IEnumerable(Of WorkbookItem)
            Dim R As New List(Of WorkbookItem)

            Dim CommandString As String = String.Format("SELECT * FROM [Workbook] WHERE [{0}] = @UID AND [Status]<3 AND [WorkType] IN ({1});", If(MatchWithOwner, "Owner", "User"), String.Join(Of Integer)(",", WorkTypes))
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Jobs.Sort(New Comparers.CompareByID)
            Users.Sort(New Comparers.CompareByID)

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@UID", UserID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader, Jobs, Users))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function GetForClientsBetweenDates(ByVal CloseConnection As Boolean, ByVal ClientIDs As List(Of Integer), ByVal FromDate As Date, ByVal ToDate As Date) As IEnumerable(Of WorkbookItem)
            Dim R As New List(Of WorkbookItem)

            Dim CommandString As String = "SELECT * FROM [Workbook] WHERE charindex(',' + CAST([ClientID] as nvarchar(5)) + ',', @ClientIDs) > 0 AND (([DateAdded] between @FromDate and @ToDate) OR ([DateCompleted] between @FromDate and @ToDate));"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ClientIDs", "," & String.Join(",", ClientIDs) & ",")
                AddParameter(Command, "@FromDate", FromDate)
                AddParameter(Command, "@ToDate", ToDate)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function GetWorkbookItemsCount(ByVal Client As Integer, ByVal Job As String, ByVal Period As String, ByVal PeriodType As Enums.PeriodType) As Integer
            Dim R As Integer = 0

            Dim CommandString As String = String.Format("SELECT COUNT(*) FROM [Workbook] WHERE [ClientID]=@Client AND [Job]=@Job AND [{0}]=@{0};", If(PeriodType = Enums.PeriodType.Assessment, "AssessmentDetails", "FinancialDetails"))
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@Client", Client)
                AddParameter(Command, "@Job", Job)
                AddParameter(Command, If(PeriodType = Enums.PeriodType.Assessment, "@AssessmentDetails", "@FinancialDetails"), Period)

                R = Command.ExecuteScalar
            End Using

            Return R
        End Function
#End Region

#Region "Functions"
        Private Function Read(ByVal Reader As SqlDataReader, ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As WorkbookItem
            Dim ID As Integer = Reader.Item("ID")
            Dim AssignedTo As User = Users(Users.BinarySearch(New User(Reader.Item("User")), New Comparers.CompareByID))
            Dim Job As Job = Jobs.Find(Function(c) c.ID = Reader.Item("Job").ToString)
            Dim Client As ClientMinimal = Utils.ObjectSerilizer.FromXML(Of ClientMinimal)(Reader.Item("Client").ToString)
            Dim DueDate As Date = Reader.Item("DueDate")
            Dim AddedOn As Date = Reader.Item("DateAdded")
            Dim CompletedOn As Date = Reader.Item("DateCompleted")
            Dim UpdatedOn As Date = Reader.Item("DateUpdated")
            Dim Description As String = Reader.Item("Description").ToString
            Dim Remarks As String = Reader.Item("Remarks").ToString
            Dim TargetDate As Date = Reader.Item("TargetDate")
            Dim PriorityOfWork As Enums.Priority = Reader.Item("Priority")
            Dim Status As Enums.WorkStatus = Reader.Item("Status")
            Dim Folder As String = Reader.Item("Folder").ToString
            Dim AssessmentDetail As String = Reader.Item("AssessmentDetails").ToString
            Dim FinancialDetail As String = Reader.Item("FinancialDetails").ToString
            Dim CurrentStep As String = Reader.Item("CurrentStep").ToString
            Dim Owner As User = Users(Users.BinarySearch(New User(Reader.Item("Owner")), New Comparers.CompareByID))
            Dim History As String = Reader.Item("History").ToString.Trim
            Dim Billed As Enums.BillingStatus = Reader.Item("Billed")
            Dim WorkType As Enums.WorkType = Reader.Item("WorkType")

            Return New WorkbookItem(ID, AssignedTo, Job, Client, DueDate, AddedOn, CompletedOn, UpdatedOn, Description, Remarks, TargetDate, PriorityOfWork, Status, CurrentStep, Owner, History, Billed, YearMonth.Parse(AssessmentDetail), YearMonth.Parse(FinancialDetail), WorkType)
        End Function

        Private Function Read(ByVal Reader As SqlDataReader) As WorkbookItem
            Dim ID As Integer = Reader.Item("ID")
            Dim AssignedTo As User = Users.GetUserByID(Reader.Item("User"))
            Dim Job As Job = Jobs.GetJobByID(Reader.Item("Job"), False)
            Dim Client As ClientMinimal = Utils.ObjectSerilizer.FromXML(Of ClientMinimal)(Reader.Item("Client").ToString)
            Dim DueDate As Date = Reader.Item("DueDate")
            Dim AddedOn As Date = Reader.Item("DateAdded")
            Dim CompletedOn As Date = Reader.Item("DateCompleted")
            Dim UpdatedOn As Date = Reader.Item("DateUpdated")
            Dim Description As String = Reader.Item("Description").ToString
            Dim Remarks As String = Reader.Item("Remarks").ToString
            Dim TargetDate As Date = Reader.Item("TargetDate")
            Dim PriorityOfWork As Enums.Priority = Reader.Item("Priority")
            Dim Status As Enums.WorkStatus = Reader.Item("Status")
            Dim Folder As String = Reader.Item("Folder").ToString
            Dim AssessmentDetail As String = Reader.Item("AssessmentDetails").ToString
            Dim FinancialDetail As String = Reader.Item("FinancialDetails").ToString
            Dim CurrentStep As String = Reader.Item("CurrentStep").ToString
            Dim Owner As User = Users.GetUserByID(Reader.Item("Owner"))
            Dim History As String = Reader.Item("History").ToString.Trim
            Dim Billed As Enums.BillingStatus = Reader.Item("Billed")
            Dim WorkType As Enums.WorkType = Reader.Item("WorkType")

            Return New WorkbookItem(ID, AssignedTo, Job, Client, DueDate, AddedOn, CompletedOn, UpdatedOn, Description, Remarks, TargetDate, PriorityOfWork, Status, CurrentStep, Owner, History, Billed, YearMonth.Parse(AssessmentDetail), YearMonth.Parse(FinancialDetail), WorkType)
        End Function
#End Region

    End Module
End Namespace