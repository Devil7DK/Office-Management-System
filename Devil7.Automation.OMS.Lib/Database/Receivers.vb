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
Imports System.Windows.Forms
Imports Devil7.Automation.OMS.Lib.Objects
Imports Devil7.Automation.OMS.Lib.Utils

Namespace Database
    Public Module Receivers

#Region "Variables"
        Dim Table1Name As String = "Receivers"
        Dim Table2Name As String = "Clients"
#End Region

#Region "Update Functions"
        Function AddNew(ByVal PAN As String, ByVal ClientName As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As String, ByVal State As String, ByVal StateCode As String, ByVal GST As String) As Receiver
            Dim R As Receiver = Nothing

            Dim CommandString As String = String.Format("INSERT INTO {0} ([PAN],[ClientName],[Mobile],[Phone],[Email],[Address1],[Address2],[City],[Pincode],[State],[StateCode],[GST]) VALUES(@pan,@clientname,@mobile,@phone,@email,@address1,@address2,@city,@pincode,@state,@statecode,@gst);SELECT SCOPE_IDENTITY();", Table1Name)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@pan", PAN)
                AddParameter(Command, "@clientname", ClientName)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@phone", Phone)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@address1", AddressLine1)
                AddParameter(Command, "@address2", AddressLine2)
                AddParameter(Command, "@city", City)
                AddParameter(Command, "@pincode", PinCode)
                AddParameter(Command, "@state", State)
                AddParameter(Command, "@statecode", StateCode)
                AddParameter(Command, "@gst", GST)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Receiver(ID, ClientName, PAN, Mobile, Phone, Email, AddressLine1, AddressLine2, City, PinCode, State, StateCode, GST)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting client.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal PAN As String, ByVal ClientName As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As String, ByVal State As String, ByVal StateCode As String, ByVal GST As String) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = String.Format("UPDATE {0} SET [PAN]=@pan,[ClientName]=@clientname,[Mobile]=@mobile,[Phone]=@phone,[Email]=@email,[Address1]=@address1,[Address2]=@address2,[City]=@City,[Pincode]=@pincode,[State]=@state,[StateCode]=@statecode,[GST]=@gst WHERE [ID]=@id;", Table1Name)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@id", ID)
                AddParameter(Command, "@pan", PAN)
                AddParameter(Command, "@clientname", ClientName)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@phone", Phone)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@address1", AddressLine1)
                AddParameter(Command, "@address2", AddressLine2)
                AddParameter(Command, "@city", City)
                AddParameter(Command, "@pincode", PinCode)
                AddParameter(Command, "@state", State)
                AddParameter(Command, "@statecode", StateCode)
                AddParameter(Command, "@gst", GST)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while editing client.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            Return R
        End Function

        Function Remove(ByVal ID As Integer) As Boolean
            Dim R As Boolean = False

            Dim CommandString As String = "DELETE FROM Clients WHERE [ID]=@ID;"
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

#Region "Load Functions"
        Function GetAll(ByVal CloseConnection As Boolean) As IEnumerable(Of Receiver)
            Dim R As New List(Of Receiver)

            LoadFromTable(Table1Name, R, False)
            LoadFromTable(Table2Name, R, CloseConnection)

            Return R
        End Function

        Private Sub LoadFromTable(ByVal TableName As String, ByVal List As List(Of Receiver), ByVal CloseConnection As Boolean)
            Dim CommandString As String = String.Format("SELECT [ID],[PAN],[ClientName],[Mobile],[Phone],[Email],[Address1],[Address2],[City],[Pincode],[State],[StateCode],[GST] FROM [{0}];", TableName)
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        List.Add(Read(Reader, TableName.Substring(0, 1)))
                    End While
                End Using
            End Using

            If CloseConnection Then Connection.Close()
        End Sub
#End Region

#Region "Other Functions"
        Private Function Read(ByVal Reader As SqlDataReader, ByVal Prefix As String) As Receiver
            Dim RID As String = Prefix & Reader.Item("ID").ToString
            Dim Name As String = Reader.Item("ClientName").ToString.Trim
            Dim PAN As String = Reader.Item("PAN").ToString.Trim
            Dim Mobile As String = Reader.Item("Mobile").ToString.Trim
            Dim Phone As String = Reader.Item("Phone").ToString.Trim
            Dim Email As String = Reader.Item("Email").ToString.Trim
            Dim AddressLine1 As String = Reader.Item("Address1").ToString.Trim
            Dim AddressLine2 As String = Reader.Item("Address2").ToString.Trim
            Dim City As String = Reader.Item("City").ToString.Trim
            Dim PinCode As String = Reader.Item("Pincode").ToString.Trim
            Dim State As String = Reader.Item("State").ToString.Trim
            Dim StateCode As String = Reader.Item("StateCode").ToString.Trim
            Dim GST As String = Reader.Item("GST").ToString.Trim
            Return New Receiver(RID, Name, PAN, Mobile, Phone, Email, AddressLine1, AddressLine2, City, PinCode, State, StateCode, GST)
        End Function
#End Region

    End Module
End Namespace