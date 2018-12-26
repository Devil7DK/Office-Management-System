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
    Public Module Clients

        Function AddNew(ByVal Photo As Drawing.Image, ByVal PAN As String, ByVal ClientName As String, ByVal FatherName As String, ByVal Mobile As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal District As String, ByVal PinCode As String, ByVal Aadhar As String, ByVal Description As String, ByVal TypeOfEngagement As String,
                     ByVal TIN As String, ByVal CIN As String, ByVal PartnersOrDirectors As ComponentModel.BindingList(Of Partner), ByVal Type As String, ByVal Credentials As ComponentModel.BindingList(Of Credential), ByVal Jobs As List(Of Job), ByVal Status As String, ByVal GST As String, ByVal FileNo As String)
            Dim R As Client = Nothing

            Dim img As New System.IO.MemoryStream
            Photo.Save(img, Drawing.Imaging.ImageFormat.Png)

            Dim CommandString As String = "INSERT INTO Clients ([PAN],[ClientName],[FatherName],[Mobile],[Email],[DOB],[Address1],[Address2],[District],[Pincode],[State],[AadharNo],[Description],[TypeOfEngagement],[TIN],[CIN],[PartnerDirector],[Type],[Credentials],[Jobs],[Status],[Photo],[GST],[FileNo]) VALUES(@pan,@clientname,@fathername,@mobile,@email,@dob,@address1,@address2,@district,@pincode,@state,@aadharno,@description,@typeofengagement,@tin,@cin,@partnerdirector,@type,@credentials,@jobs,@status,@photo,@gst,@fileno);SELECT SCOPE_IDENTITY();"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@pan", PAN)
                AddParameter(Command, "@clientname", ClientName)
                AddParameter(Command, "@fathername", FatherName)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@dob", Date.Parse(DOB))
                AddParameter(Command, "@address1", AddressLine1)
                AddParameter(Command, "@address2", AddressLine2)
                AddParameter(Command, "@district", District)
                AddParameter(Command, "@pincode", PinCode)
                AddParameter(Command, "@state", "Tamilnadu")
                AddParameter(Command, "@aadharno", Aadhar)
                AddParameter(Command, "@description", Description)
                AddParameter(Command, "@typeofengagement", TypeOfEngagement)
                AddParameter(Command, "@tin", TIN)
                AddParameter(Command, "@cin", CIN)
                AddParameter(Command, "@partnerdirector", ObjectSerilizer.ToXML(PartnersOrDirectors))
                AddParameter(Command, "@type", Type)
                AddParameter(Command, "@credentials", ObjectSerilizer.ToXML(Credentials))
                AddParameter(Command, "@jobs", ObjectSerilizer.ToXML(Jobs))
                AddParameter(Command, "@status", Status)
                AddParameter(Command, "@photo", img.GetBuffer)
                AddParameter(Command, "@gst", GST)
                AddParameter(Command, "@fileno", FileNo)

                Dim ID As Integer = Command.ExecuteScalar
                If ID > 0 Then
                    R = New Client(ID, ClientName, PAN, FatherName, Mobile, Email, DOB, AddressLine1, AddressLine2, District, PinCode, Aadhar, Description, TypeOfEngagement, TIN, CIN, PartnersOrDirectors, Type, Credentials, Jobs, Status, Photo, GST, FileNo)
                Else
                    MsgBox("Unknown error while inserting client.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
                End If
            End Using

            Return R
        End Function

        Function Update(ByVal ID As Integer, ByVal Photo As Drawing.Image, ByVal PAN As String, ByVal ClientName As String, ByVal FatherName As String, ByVal Mobile As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal District As String, ByVal PinCode As String, ByVal Aadhar As String, ByVal Description As String, ByVal TypeOfEngagement As String,
                    ByVal TIN As String, ByVal CIN As String, ByVal PartnersOrDirectors As ComponentModel.BindingList(Of Partner), ByVal Type As String, ByVal Credentials As ComponentModel.BindingList(Of Credential), ByVal Jobs As List(Of Job), ByVal Status As String, ByVal GST As String, ByVal FileNo As String)
            Dim R As Boolean = False
            Dim img As New System.IO.MemoryStream
            Photo.Save(img, Drawing.Imaging.ImageFormat.Png)

            Dim CommandString As String = "UPDATE Clients SET [PAN]=@pan,[ClientName]=@clientname,[FatherName]=@fathername,[Mobile]=@mobile,[Email]=@email,[DOB]=@dob,[Address1]=@address1,[Address2]=@address2,[District]=@district,[Pincode]=@pincode,[State]=@state,[AadharNo]=@aadharno,[Description]=@description,[TypeOfEngagement]=@typeofengagement,[TIN]=@tin,[CIN]=@cin,[PartnerDirector]=@partnerdirector,[Type]=@type,[Credentials]=@credentials,[Jobs]=@jobs,[Status]=@status,[Photo]=@photo,[GST]=@gst,[FileNo]=@fileno WHERE [ID]=@id;"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()

            Using Command As New SqlCommand(CommandString, Connection)
                AddParameter(Command, "@id", ID)
                AddParameter(Command, "@pan", PAN)
                AddParameter(Command, "@clientname", ClientName)
                AddParameter(Command, "@fathername", FatherName)
                AddParameter(Command, "@mobile", Mobile)
                AddParameter(Command, "@email", Email)
                AddParameter(Command, "@dob", DOB)
                AddParameter(Command, "@address1", AddressLine1)
                AddParameter(Command, "@address2", AddressLine2)
                AddParameter(Command, "@district", District)
                AddParameter(Command, "@pincode", PinCode)
                AddParameter(Command, "@state", "Tamilnadu")
                AddParameter(Command, "@aadharno", Aadhar)
                AddParameter(Command, "@description", Description)
                AddParameter(Command, "@typeofengagement", TypeOfEngagement)
                AddParameter(Command, "@tin", TIN)
                AddParameter(Command, "@cin", CIN)
                AddParameter(Command, "@partnerdirector", ObjectSerilizer.ToXML(PartnersOrDirectors))
                AddParameter(Command, "@type", Type)
                AddParameter(Command, "@credentials", ObjectSerilizer.ToXML(Credentials))
                AddParameter(Command, "@jobs", ObjectSerilizer.ToXML(Jobs))
                AddParameter(Command, "@status", Status)
                AddParameter(Command, "@photo", img.GetBuffer)
                AddParameter(Command, "@gst", GST)
                AddParameter(Command, "@fileno", FileNo)

                Dim Result As Integer = Command.ExecuteNonQuery
                If Result > 0 Then
                    R = True
                Else
                    R = False
                    MsgBox("Unknown error while editing client.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Failed!")
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

        Private Function Read(ByVal Reader As SqlDataReader) As Client
            Dim ID As Integer = CInt(Reader.Item("ID").ToString.Trim)
            Dim Name As String = Reader.Item("ClientName").ToString.Trim
            Dim PAN As String = Reader.Item("PAN").ToString.Trim
            Dim FatherName As String = Reader.Item("FatherName").ToString.Trim
            Dim Mobile As String = Reader.Item("Mobile").ToString.Trim
            Dim Email As String = Reader.Item("Email").ToString.Trim
            Dim DOB As String = Reader.Item("DOB").ToString.Trim
            Dim AddressLine1 As String = Reader.Item("Address1").ToString.Trim
            Dim AddressLine2 As String = Reader.Item("Address2").ToString.Trim
            Dim District As String = Reader.Item("District").ToString.Trim
            Dim PinCode As String = Reader.Item("Pincode").ToString.Trim
            Dim AadharNo As String = Reader.Item("AadharNo").ToString.Trim
            Dim Description As String = Reader.Item("Description").ToString.Trim
            Dim TypeOfEngagement As String = Reader.Item("TypeOfEngagement").ToString.Trim
            Dim TIN As String = Reader.Item("TIN").ToString.Trim
            Dim CIN As String = Reader.Item("CIN").ToString.Trim
            Dim Partners As System.ComponentModel.BindingList(Of Partner) = ObjectSerilizer.FromXML(Of System.ComponentModel.BindingList(Of Partner))(Reader.Item("PartnerDirector").ToString.Trim)
            Dim Type As String = Reader.Item("Type").ToString.Trim
            Dim Credentials As System.ComponentModel.BindingList(Of Credential) = ObjectSerilizer.FromXML(Of System.ComponentModel.BindingList(Of Credential))(Reader.Item("Credentials").ToString.Trim)
            Dim Jobs As List(Of Job) = ObjectSerilizer.FromXML(Of List(Of Job))(Reader.Item("Jobs").ToString.Trim)
            Dim Status As String = Reader.Item("Status").ToString.Trim
            Dim Photo As Drawing.Image = If(TypeOf Reader.Item("Photo") Is DBNull, Res.My.Resources.Client_Default, Drawing.Image.FromStream(New IO.MemoryStream(CType(Reader.Item("Photo"), Byte()))))
            Dim GST As String = Reader.Item("GST").ToString.Trim
            Dim FileNo As String = Reader.Item("FileNo").ToString.Trim
            Return New Client(ID, Name, PAN, FatherName, Mobile, Email, DOB, AddressLine1, AddressLine2, District, PinCode, AadharNo, Description, TypeOfEngagement, TIN, CIN, Partners, Type, Credentials, Jobs, Status, Photo, GST, FileNo)
        End Function

        Private Function ReadMinimal(ByVal Reader As SqlDataReader) As ClientMinimal
            Dim ID As Integer = CInt(Reader.Item("ID").ToString.Trim)
            Dim Name As String = Reader.Item("ClientName").ToString.Trim
            Dim PAN As String = Reader.Item("PAN").ToString.Trim
            Return New ClientMinimal(ID, Name, PAN)
        End Function

        Function GetClientByID(ByVal ID As Integer) As Client
            Dim R As Client = Nothing

            Dim CommandString As String = "SELECT * FROM [Clients] WHERE [ID]=@ID"
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

        Function GetAll(ByVal CloseConnection As Boolean) As IEnumerable(Of Client)
            Dim R As New List(Of Client)

            Dim CommandString As String = "SELECT * FROM [Clients]"
            Dim Connection As SqlConnection = GetConnection()

            If Connection.State <> ConnectionState.Open Then Connection.Open()


            Using Command As New SqlCommand(CommandString, Connection)
                Using Reader As SqlDataReader = Command.ExecuteReader
                    While Reader.Read
                        R.Add(Read(Reader))
                    End While
                End Using
            End Using

            Return R
        End Function

    End Module
End Namespace