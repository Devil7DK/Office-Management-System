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
    Public Module Clients

#Region "Update Functions"
        Function AddNew(ByVal Photo As Drawing.Image, ByVal PAN As String, ByVal ClientName As String, ByVal FatherName As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As String, ByVal State As String, ByVal StateCode As String, ByVal Aadhar As String, ByVal Description As String, ByVal TypeOfEngagement As String,
                      ByVal PartnersOrDirectors As List(Of Partner), ByVal Type As String, ByVal Jobs As List(Of JobUser), ByVal Status As String, ByVal GST As String, ByVal FileNo As String, ByVal RPerson As User) As Client
            Dim R As Client = Nothing

            Dim img As New System.IO.MemoryStream
            Photo.Save(img, Drawing.Imaging.ImageFormat.Png)

            Dim CommandString As String = "INSERT INTO Clients ([PAN],[ClientName],[FatherName],[Mobile],[Phone],[Email],[DOB],[Address1],[Address2],[City],[Pincode],[State],[StateCode],[AadharNo],[Description],[TypeOfEngagement],[PartnerDirector],[Type],[Jobs],[Status],[Photo],[GST],[FileNo],[RPerson]) VALUES(@pan,@clientname,@fathername,@mobile,@phone,@email,@dob,@address1,@address2,@city,@pincode,@state,@statecode,@aadharno,@description,@typeofengagement,@partnerdirector,@type,@jobs,@status,@photo,@gst,@fileno,@rperson);SELECT SCOPE_IDENTITY();"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@pan", PAN)
                AddParameter(Command, "@clientname", ClientName)
                AddParameter(Command, "@fathername", FatherName)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@phone", Phone)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@dob", Date.Parse(DOB))
                AddParameter(Command, "@address1", AddressLine1)
                AddParameter(Command, "@address2", AddressLine2)
                AddParameter(Command, "@city", City)
                AddParameter(Command, "@pincode", PinCode)
                AddParameter(Command, "@state", State)
                AddParameter(Command, "@statecode", StateCode)
                AddParameter(Command, "@aadharno", Aadhar)
                AddParameter(Command, "@description", Description)
                AddParameter(Command, "@typeofengagement", TypeOfEngagement)
                AddParameter(Command, "@partnerdirector", ObjectSerilizer.ToXML(PartnersOrDirectors))
                AddParameter(Command, "@type", Type)
                AddParameter(Command, "@jobs", JobUser.ToXml(Jobs))
                AddParameter(Command, "@status", Status)
                AddParameter(Command, "@photo", img.GetBuffer)
                AddParameter(Command, "@gst", GST)
                AddParameter(Command, "@fileno", FileNo)
                AddParameter(Command, "@rperson", RPerson.ID)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Client(ID, ClientName, PAN, FatherName, Mobile, Phone, Email, DOB, AddressLine1, AddressLine2, City, PinCode, State, StateCode, Aadhar, Description, TypeOfEngagement, PartnersOrDirectors, Type, Jobs, RPerson, Status, Photo, GST, FileNo)
                Else
                    DevExpress.XtraEditors.XtraMessageBox.Show("Unknown error while inserting client.", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End Using

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Photo As Drawing.Image, ByVal PAN As String, ByVal ClientName As String, ByVal FatherName As String, ByVal Mobile As String, ByVal Phone As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal City As String, ByVal PinCode As String, ByVal State As String, ByVal StateCode As Integer, ByVal Aadhar As String, ByVal Description As String, ByVal TypeOfEngagement As String,
                     ByVal PartnersOrDirectors As List(Of Partner), ByVal Type As String, ByVal Jobs As List(Of JobUser), ByVal Status As String, ByVal GST As String, ByVal FileNo As String, ByVal RPerson As User)
            Dim R As Boolean = False
            Dim img As New System.IO.MemoryStream
            Photo.Save(img, Drawing.Imaging.ImageFormat.Png)

            Dim CommandString As String = "UPDATE Clients SET [PAN]=@pan,[ClientName]=@clientname,[FatherName]=@fathername,[Mobile]=@mobile,[Phone]=@phone,[Email]=@email,[DOB]=@dob,[Address1]=@address1,[Address2]=@address2,[City]=@City,[Pincode]=@pincode,[State]=@state,[StateCode]=@statecode,[AadharNo]=@aadharno,[Description]=@description,[TypeOfEngagement]=@typeofengagement,[PartnerDirector]=@partnerdirector,[Type]=@type,[Jobs]=@jobs,[Status]=@status,[Photo]=@photo,[GST]=@gst,[FileNo]=@fileno,[RPerson]=@rperson WHERE [ID]=@id;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@id", ID)
                AddParameter(Command, "@pan", PAN)
                AddParameter(Command, "@clientname", ClientName)
                AddParameter(Command, "@fathername", FatherName)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@phone", Phone)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@dob", DOB)
                AddParameter(Command, "@address1", AddressLine1)
                AddParameter(Command, "@address2", AddressLine2)
                AddParameter(Command, "@city", City)
                AddParameter(Command, "@pincode", PinCode)
                AddParameter(Command, "@state", State)
                AddParameter(Command, "@statecode", StateCode)
                AddParameter(Command, "@aadharno", Aadhar)
                AddParameter(Command, "@description", Description)
                AddParameter(Command, "@typeofengagement", TypeOfEngagement)
                AddParameter(Command, "@partnerdirector", ObjectSerilizer.ToXML(PartnersOrDirectors))
                AddParameter(Command, "@type", Type)
                AddParameter(Command, "@jobs", JobUser.ToXml(Jobs))
                AddParameter(Command, "@status", Status)
                AddParameter(Command, "@photo", img.GetBuffer)
                AddParameter(Command, "@gst", GST)
                AddParameter(Command, "@fileno", FileNo)
                AddParameter(Command, "@rperson", RPerson.ID)

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
        Function GetClientByID(ByVal ID As Integer, ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As Client
            Dim R As Client = Nothing

            Dim CommandString As String = "SELECT * FROM [Clients] WHERE [ID]=@ID"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@ID", ID)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    If Reader.Read Then
                        R = Read(Reader, Jobs, Users)
                    End If
                End Using
            End Using

            Return R
        End Function

        Function GetMinimal() As IEnumerable(Of ClientMinimal)
            Dim R As New List(Of ClientMinimal)

            Dim CommandString As String = "SELECT [ID],[ClientName],[PAN] FROM [Clients]"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(ReadMinimal(Reader))
                    End While
                End Using
            End Using

            Return R
        End Function

        Function GetAll(ByVal Jobs As List(Of Job), ByVal Users As List(Of User), ByVal CloseConnection As Boolean) As IEnumerable(Of Client)
            Dim R As New List(Of Client)

            Dim CommandString As String = "SELECT * FROM [Clients]"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader, Jobs, Users))
                    End While
                End Using
            End Using

            Return R
        End Function
#End Region

#Region "Other Functions"
        Private Function Read(ByVal Reader As SqlDataReader, ByVal Jobs As List(Of Job), ByVal Users As List(Of User)) As Client
            Dim ID As Integer = CInt(Reader.Item("ID").ToString.Trim)
            Dim Name As String = Reader.Item("ClientName").ToString.Trim
            Dim PAN As String = Reader.Item("PAN").ToString.Trim
            Dim FatherName As String = Reader.Item("FatherName").ToString.Trim
            Dim Mobile As String = Reader.Item("Mobile").ToString.Trim
            Dim Phone As String = Reader.Item("Phone").ToString.Trim
            Dim Email As String = Reader.Item("Email").ToString.Trim
            Dim DOB As String = Reader.Item("DOB").ToString.Trim
            Dim AddressLine1 As String = Reader.Item("Address1").ToString.Trim
            Dim AddressLine2 As String = Reader.Item("Address2").ToString.Trim
            Dim City As String = Reader.Item("City").ToString.Trim
            Dim PinCode As String = Reader.Item("Pincode").ToString.Trim
            Dim State As String = Reader.Item("State").ToString.Trim
            Dim StateCode As String = Reader.Item("StateCode").ToString.Trim
            Dim AadharNo As String = Reader.Item("AadharNo").ToString.Trim
            Dim Description As String = Reader.Item("Description").ToString.Trim
            Dim TypeOfEngagement As String = Reader.Item("TypeOfEngagement").ToString.Trim
            Dim Partners As List(Of Partner) = ObjectSerilizer.FromXML(Of List(Of Partner))(Reader.Item("PartnerDirector").ToString.Trim)
            Dim Type As String = Reader.Item("Type").ToString.Trim
            Dim JobUsers As List(Of JobUser) = JobUser.FromXML(Reader.Item("Jobs").ToString.Trim, Jobs, Users)
            Dim Status As String = Reader.Item("Status").ToString.Trim
            Dim Photo As Drawing.Image = If(TypeOf Reader.Item("Photo") Is DBNull, Res.My.Resources.Client_Default, Drawing.Image.FromStream(New IO.MemoryStream(CType(Reader.Item("Photo"), Byte()))))
            Dim GST As String = Reader.Item("GST").ToString.Trim
            Dim FileNo As String = Reader.Item("FileNo").ToString.Trim
            Dim RPerson As User = Users.Find(Function(C) C.ID = CInt(Reader.Item("RPerson")))
            Return New Client(ID, Name, PAN, FatherName, Mobile, Phone, Email, DOB, AddressLine1, AddressLine2, City, PinCode, State, StateCode, AadharNo, Description, TypeOfEngagement, Partners, Type, JobUsers, RPerson, Status, Photo, GST, FileNo)
        End Function

        Private Function ReadMinimal(ByVal Reader As SqlDataReader) As ClientMinimal
            Dim ID As Integer = CInt(Reader.Item("ID").ToString.Trim)
            Dim Name As String = Reader.Item("ClientName").ToString.Trim
            Dim PAN As String = Reader.Item("PAN").ToString.Trim
            Return New ClientMinimal(ID, Name, PAN)
        End Function
#End Region


    End Module
End Namespace