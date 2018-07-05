Imports System.Data.SqlClient
Imports System.ComponentModel

Public Module DatabaseIO
#Region "LoadData"
    Function LoadClients(ByVal ConnectionString As String, ByVal Jobs_ As BindingList(Of Job), Optional CredentialList As System.ComponentModel.BindingList(Of CredentialWithClient) = Nothing) As System.ComponentModel.BindingList(Of Client)
        Dim Clients As New System.ComponentModel.BindingList(Of Client)
        Clients = New System.ComponentModel.BindingList(Of Client)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Clients", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim jl = Jobs_.ToList
        While reader.Read
            Dim ID_ As Integer = CInt(reader.Item("ID").ToString)
            Dim Name As String = reader.Item("ClientName").ToString
            Dim PAN As String = reader.Item("PAN").ToString
            Dim FatherName As String = reader.Item("FatherName").ToString
            Dim Mobile As String = reader.Item("Mobile").ToString
            Dim Email As String = reader.Item("Email").ToString
            Dim DOB As String = reader.Item("DOB").ToString
            Dim AddressLine1 As String = reader.Item("Address1").ToString
            Dim AddressLine2 As String = reader.Item("Address2").ToString
            Dim District As String = reader.Item("District").ToString
            Dim PinCode As String = reader.Item("Pincode").ToString
            Dim AadharNo As String = reader.Item("AadharNo").ToString
            Dim Description As String = reader.Item("Description").ToString
            Dim TypeOfEngagement As String = reader.Item("TypeOfEngagement").ToString
            Dim TIN As String = reader.Item("TIN").ToString
            Dim CIN As String = reader.Item("CIN").ToString
            Dim Partners As System.ComponentModel.BindingList(Of Partner) = XMLParsers.Partners.FromXML(reader.Item("PartnerDirector").ToString)
            Dim Type As String = reader.Item("Type").ToString
            Dim Credentials As System.ComponentModel.BindingList(Of Credential) = XMLParsers.Credentials.FromXML(reader.Item("Credentials").ToString)
            Dim Jobs As System.ComponentModel.BindingList(Of Job) = XMLParsers.Jobs.FromXML(reader.Item("Jobs").ToString, jl)
            Dim Status As String = reader.Item("Status").ToString
            Dim Photo As Image = ImageFromBytes(reader.Item("Photo"))
            Dim CL As Client = New Client(ID_, Name, FatherName, Mobile, Email, DOB, AddressLine1, AddressLine2, District, PinCode, AadharNo, Description, TypeOfEngagement, TIN, CIN, Partners, Type, Credentials, Jobs, Status, Photo)
            Clients.Add(CL)
            If CredentialList IsNot Nothing Then
                XMLParsers.CredentialsWithClient.FromXML(reader.Item("Credentials").ToString, CL, CredentialList)
            End If
        End While
        conn.Close()
        Return Clients
    End Function
    Function LoadWorks(ByVal ConnectionString As String, ByVal Clients As BindingList(Of Client), ByVal Jobs As BindingList(Of Job), ByVal Users As BindingList(Of User)) As System.ComponentModel.BindingList(Of WorkbookItem)
        Dim Works As New System.ComponentModel.BindingList(Of WorkbookItem)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Workbook", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim Jobs_ = Jobs.ToList
        Jobs_.Sort(New JobComparer)
        Dim Users_ = Users.ToList
        Users_.Sort(New CompareByID)
        Dim Clients_ = Clients.ToList
        Clients_.Sort(New CompareByID)
        While reader.Read
            Dim ID As Integer = reader.Item("ID")
            Dim AssignedTo As User = Users_(Users_.BinarySearch(New User(reader.Item("User")), New CompareByID))
            Dim Job As Job = Jobs_(Jobs_.BinarySearch(New Job(reader.Item("Job").ToString), New JobComparer))
            Dim Client As Client = Clients_(Clients_.BinarySearch(New Client(reader.Item("Client")), New CompareByID))
            Dim DueDate As Date = reader.Item("DueDate")
            Dim AddedOn As Date = reader.Item("DateAdded")
            Dim CompletedOn As Date = reader.Item("DateCompleted")
            Dim UpdatedOn As Date = reader.Item("DateUpdated")
            Dim Description As String = reader.Item("Description").ToString
            Dim Remarks As String = reader.Item("Remarks").ToString
            Dim TargetDate As Date = reader.Item("TargetDate")
            Dim PriorityOfWork As Priority = DirectCast([Enum].Parse(GetType(Priority), reader.Item("Priority").ToString), Priority)
            Dim Status As WorkStatus = DirectCast([Enum].Parse(GetType(WorkStatus), reader.Item("Status").ToString), WorkStatus)
            Dim Folder As String = reader.Item("Folder").ToString
            Dim AssementDetail As String = reader.Item("AssessmentDetails").ToString
            Dim FinancialDetail As String = reader.Item("FinancialDetails").ToString
            Dim CurrentStep As String = reader.Item("CurrentStep").ToString
            Dim Owner As User = Users_(Users_.BinarySearch(New User(reader.Item("Owner")), New CompareByID))
            Dim History As String = reader.Item("History").ToString.Trim
            Works.Add(New WorkbookItem(ID, AssignedTo, Job, Client, DueDate, AddedOn, CompletedOn, UpdatedOn, Description, Remarks, TargetDate, PriorityOfWork, Status, CurrentStep, Owner, History))
        End While
        conn.Close()
        Return Works
    End Function
    Function LoadJob(ByVal ConnectionString As String) As System.ComponentModel.BindingList(Of Job)
        Dim Jobs As New System.ComponentModel.BindingList(Of Job)
        Jobs = New System.ComponentModel.BindingList(Of Job)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Jobs", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        While reader.Read()
            Dim ID_ As Integer = CInt(reader.Item("ID").ToString)
            Dim Name As String = reader.Item("JobName").ToString
            Dim Group As String = reader.Item("Group").ToString
            Dim SubGroup As String = reader.Item("SubGroup").ToString
            Dim Type As JobType = DirectCast([Enum].Parse(GetType(JobType), reader.Item("Type").ToString), JobType)
            Dim Steps As List(Of String) = XMLParsers.ListOfString.FromXML(reader.Item("Steps").ToString)
            Dim Templates As List(Of String) = XMLParsers.ListOfString.FromXML(reader.Item("Templates").ToString)
            Dim JID As String = reader.Item("JID").ToString
            Jobs.Add(New Job(ID_, JID, Name, Group, SubGroup, Type, Steps, Templates))
        End While
        conn.Close()
        Return Jobs
    End Function
    Function LoadUsers(ByVal ConnectionString As String) As System.ComponentModel.BindingList(Of User)
        Dim r As New System.ComponentModel.BindingList(Of User)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Users", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim i As Integer = -1
        While reader.Read()
            Dim PH As Image = My.Resources.User_Default
            Try
                PH = Image.FromStream(New IO.MemoryStream(CType(reader.Item("Photo"), Byte())))
            Catch ex As Exception

            End Try
            Dim Credentials_ As String = reader.Item("Credentials").ToString
            Dim cls As System.ComponentModel.BindingList(Of Credential) = Nothing
            If Credentials_ <> "" Then
                cls = XMLParsers.Credentials.FromXML(Credentials_)
            End If
            Dim Permissions_ As String = reader.Item("Permissions").ToString
            Dim Per As New List(Of String)
            If Permissions_ <> "" Then
                Per = XMLParsers.ListOfString.FromXML(Permissions_)
            End If
            r.Add(New User(reader.Item("ID").ToString, reader.Item("Username").ToString, reader.Item("Password").ToString, reader.Item("Desktop").ToString, reader.Item("Home").ToString, reader.Item("UserType").ToString, reader.Item("Address").ToString, reader.Item("Mobile").ToString, reader.Item("Email").ToString, Per.ToArray, reader.Item("Status").ToString, PH, cls))
        End While
        conn.Close()
        Return r
    End Function
    Function LoadUserByID(ByVal ConnectionString As String, ByVal ID As Integer) As User
        Dim r As User = Nothing
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Users WHERE [ID]=" & ID & ";", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim i As Integer = -1
        While reader.Read()
            Dim PH As Image = My.Resources.User_Default
            Try
                PH = Image.FromStream(New IO.MemoryStream(CType(reader.Item("Photo"), Byte())))
            Catch ex As Exception

            End Try
            Dim Credentials_ As String = reader.Item("Credentials").ToString
            Dim cls As System.ComponentModel.BindingList(Of Credential) = Nothing
            If Credentials_ <> "" Then
                cls = XMLParsers.Credentials.FromXML(Credentials_)
            End If
            Dim Permissions_ As String = reader.Item("Permissions").ToString
            Dim Per As New List(Of String)
            If Permissions_ <> "" Then
                Per = XMLParsers.ListOfString.FromXML(Permissions_)
            End If
            r = (New User(reader.Item("ID").ToString, reader.Item("Username").ToString, reader.Item("Password").ToString, reader.Item("Desktop").ToString, reader.Item("Home").ToString, reader.Item("UserType").ToString, reader.Item("Address").ToString, reader.Item("Mobile").ToString, reader.Item("Email").ToString, Per.ToArray, reader.Item("Status").ToString, PH, cls))
        End While
        conn.Close()
        Return r
    End Function
#End Region
#Region "User"
    Sub NewUser(ByVal ConnectionString As String, ByVal Photo As Image, ByVal Name As String, ByVal UserType As String, ByVal Password As String, ByVal Address As String, ByVal Mobile As String, ByVal Email As String, ByVal Permissions As List(Of String), ByVal Status As String, ByVal Credentials As BindingList(Of Credential))
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("INSERT INTO Users ([Username],[UserType],[Password],[Address],[Mobile],[Email],[Permissions],[Status],[Photo],[Credentials]) VALUES (@username,@usertype,@password,@address,@mobile,@email,@permissions,@status,@photo,@credentials);", conn)
        Dim ms As New IO.MemoryStream
        Photo.Save(ms, Imaging.ImageFormat.Jpeg)
        AddParameter(comm, "@username", Name)
        AddParameter(comm, "@usertype", UserType)
        AddParameter(comm, "@password", EncryptString(Password))
        AddParameter(comm, "@address", Address)
        AddParameter(comm, "@mobile", Mobile)
        AddParameter(comm, "@email", Email)
        AddParameter(comm, "@permissions", XMLParsers.ListOfString.ToXml(Permissions))
        AddParameter(comm, "@status", Status)
        AddParameter(comm, "@photo", ms.ToArray)
        AddParameter(comm, "@credentials", XMLParsers.Credentials.ToXml(Credentials))
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub UpdateUser(ByVal ConnectionString As String, ByVal ID As Integer, ByVal Photo As Image, ByVal Name As String, ByVal UserType As String, ByVal Password As String, ByVal Address As String, ByVal Mobile As String, ByVal Email As String, ByVal Permissions As List(Of String), ByVal Status As String, ByVal Credentials As BindingList(Of Credential))
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("UPDATE Users SET [Username]=@username,[UserType]=@usertype,[Password]=@password,[Address]=@address,[Mobile]=@mobile,[Email]=@email,[Permissions]=@permissions,[Status]=@status,[Photo]=@photo,[Credentials]=@credentials WHERE [ID]=" & ID & ";", conn)
        Dim ms As New IO.MemoryStream
        Photo.Save(ms, Imaging.ImageFormat.Jpeg)
        AddParameter(comm, "@username", Name)
        AddParameter(comm, "@usertype", UserType)
        AddParameter(comm, "@password", EncryptString(Password))
        AddParameter(comm, "@address", Address)
        AddParameter(comm, "@mobile", Mobile)
        AddParameter(comm, "@email", Email)
        AddParameter(comm, "@permissions", XMLParsers.ListOfString.ToXml(Permissions))
        AddParameter(comm, "@status", Status)
        AddParameter(comm, "@photo", ms.ToArray)
        AddParameter(comm, "@credentials", XMLParsers.Credentials.ToXml(Credentials))
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub GetUserByID(ByVal ConnectionString As String, ByVal ID As Integer, ByRef Username As String, ByRef UserType As String, ByRef Password As String, ByRef Address As String, ByRef Mobile As String, ByRef EMail As String, ByRef Permissions As List(Of String), ByRef Credentials As BindingList(Of Credential), ByRef Status As String, ByRef Photo As Image)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Users WHERE [ID]=" & ID & ";", conn)
        Dim Reader As SqlDataReader = comm.ExecuteReader
        While Reader.Read
            Dim PhotoData As Byte()
            Dim Permissions_ As String
            Dim Credentials_ As String
            Username = Reader.Item("Username").ToString
            UserType = Reader.Item("UserType").ToString
            Password = DecryptString(Reader.Item("Password").ToString)
            Address = Reader.Item("Address").ToString
            Mobile = Reader.Item("Mobile").ToString
            EMail = Reader.Item("Email").ToString
            Permissions_ = Reader.Item("Permissions").ToString
            Status = Reader.Item("Status").ToString
            PhotoData = Reader.Item("Photo")
            Credentials_ = Reader.Item("Credentials").ToString
            If Credentials_ <> "" Then
                Credentials = XMLParsers.Credentials.FromXML(Credentials_)
            Else
                Credentials = New BindingList(Of Credential)
            End If
            If Permissions_ <> "" Then
                Permissions = XMLParsers.ListOfString.FromXML(Permissions_)
            Else
                Permissions = New List(Of String)
            End If
            Try
                Photo = Image.FromStream(New IO.MemoryStream(PhotoData))
            Catch ex As Exception

            End Try
        End While
        conn.Close()
    End Sub
#End Region
#Region "Client"
    Sub AddNewClient(ByVal ConnectionString As String, ByVal Photo As Image, ByVal PAN As String, ByVal ClientName As String, ByVal FatherName As String, ByVal Mobile As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal District As String, ByVal PinCode As String, ByVal Aadhar As String, ByVal Description As String, ByVal TypeOfEngagement As String, _
                     ByVal TIN As String, ByVal CIN As String, ByVal PartnersOrDirectors As BindingList(Of Partner), ByVal Type As String, ByVal Credentials As BindingList(Of Credential), ByVal Jobs As BindingList(Of Job), ByVal Status As String)
        Dim img As New System.IO.MemoryStream
        Photo.Save(img, Imaging.ImageFormat.Jpeg)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("INSERT INTO Clients ([PAN],[ClientName],[FatherName],[Mobile],[Email],[DOB],[Address1],[Address2],[District],[Pincode],[State],[AadharNo],[Description],[TypeOfEngagement],[TIN],[CIN],[PartnerDirector],[Type],[Credentials],[Jobs],[Status],[Photo]) VALUES(@pan,@clientname,@fathername,@mobile,@email,@dob,@address1,@address2,@district,@pincode,@state,@aadharno,@description,@typeofengagement,@tin,@cin,@partnerdirector,@type,@credentials,@jobs,@status,@photo);", conn)
        AddParameter(comm, "@pan", PAN)
        AddParameter(comm, "@clientname", ClientName)
        AddParameter(comm, "@fathername", FatherName)
        AddParameter(comm, "@mobile", Mobile)
        AddParameter(comm, "@email", Email)
        AddParameter(comm, "@dob", Date.Parse(DOB))
        AddParameter(comm, "@address1", AddressLine1)
        AddParameter(comm, "@address2", AddressLine2)
        AddParameter(comm, "@district", District)
        AddParameter(comm, "@pincode", PinCode)
        AddParameter(comm, "@state", "Tamilnadu")
        AddParameter(comm, "@aadharno", Aadhar)
        AddParameter(comm, "@description", Description)
        AddParameter(comm, "@typeofengagement", TypeOfEngagement)
        AddParameter(comm, "@tin", TIN)
        AddParameter(comm, "@cin", CIN)
        AddParameter(comm, "@partnerdirector", XMLParsers.Partners.ToXml(PartnersOrDirectors))
        AddParameter(comm, "@type", Type)
        AddParameter(comm, "@credentials", XMLParsers.Credentials.ToXml(Credentials))
        AddParameter(comm, "@jobs", XMLParsers.Jobs.ToXml(Jobs))
        AddParameter(comm, "@status", Status)
        AddParameter(comm, "@photo", img.GetBuffer)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub EditClient(ByVal ConnectionString As String, ByVal ID As Integer, ByVal Photo As Image, ByVal PAN As String, ByVal ClientName As String, ByVal FatherName As String, ByVal Mobile As String, ByVal Email As String, ByVal DOB As String, ByVal AddressLine1 As String, ByVal AddressLine2 As String, ByVal District As String, ByVal PinCode As String, ByVal Aadhar As String, ByVal Description As String, ByVal TypeOfEngagement As String, _
                    ByVal TIN As String, ByVal CIN As String, ByVal PartnersOrDirectors As BindingList(Of Partner), ByVal Type As String, ByVal Credentials As BindingList(Of Credential), ByVal Jobs As BindingList(Of Job), ByVal Status As String)
        Dim img As New System.IO.MemoryStream
        Photo.Save(img, Imaging.ImageFormat.Jpeg)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("UPDATE Clients SET [PAN]=@pan,[ClientName]=@clientname,[FatherName]=@fathername,[Mobile]=@mobile,[Email]=@email,[DOB]=@dob,[Address1]=@address1,[Address2]=@address2,[District]=@district,[Pincode]=@pincode,[State]=@state,[AadharNo]=@aadharno,[Description]=@description,[TypeOfEngagement]=@typeofengagement,[TIN]=@tin,[CIN]=@cin,[PartnerDirector]=@partnerdirector,[Type]=@type,[Credentials]=@credentials,[Jobs]=@jobs,[Status]=@status,[Photo]=@photo WHERE [ID]=" & ID & ";", conn)
        AddParameter(comm, "@pan", PAN)
        AddParameter(comm, "@clientname", ClientName)
        AddParameter(comm, "@fathername", FatherName)
        AddParameter(comm, "@mobile", Mobile)
        AddParameter(comm, "@email", Email)
        AddParameter(comm, "@dob", DOB)
        AddParameter(comm, "@address1", AddressLine1)
        AddParameter(comm, "@address2", AddressLine2)
        AddParameter(comm, "@district", District)
        AddParameter(comm, "@pincode", PinCode)
        AddParameter(comm, "@state", "Tamilnadu")
        AddParameter(comm, "@aadharno", Aadhar)
        AddParameter(comm, "@description", Description)
        AddParameter(comm, "@typeofengagement", TypeOfEngagement)
        AddParameter(comm, "@tin", TIN)
        AddParameter(comm, "@cin", CIN)
        AddParameter(comm, "@partnerdirector", XMLParsers.Partners.ToXml(PartnersOrDirectors))
        AddParameter(comm, "@type", Type)
        AddParameter(comm, "@credentials", XMLParsers.Credentials.ToXml(Credentials))
        AddParameter(comm, "@jobs", XMLParsers.Jobs.ToXml(Jobs))
        AddParameter(comm, "@status", Status)
        AddParameter(comm, "@photo", img.GetBuffer)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub GetClientByID(ByVal ConnectionString As String, ByVal ID As Integer, ByRef PAN As String, ByRef ClientName As String, ByRef FatherName As String, ByRef Mobile As String, ByRef Email As String, ByRef DOB As String, ByRef AddressLine1 As String, ByRef AddressLine2 As String, ByRef District As String, ByRef PinCode As String, ByRef Aadhar As String, ByRef Description As String, ByRef TypeOfEngagement As String, _
                           ByRef TIN As String, ByRef CIN As String, ByRef PartnersOrDirectors As Object, ByRef Type As Object, ByRef Credentials As Object, ByRef Jobs As Object, ByRef Status As String, ByRef Photo As Image)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Clients WHERE [ID]=" & ID & ";", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        While reader.Read
            PAN = reader.Item("PAN").ToString
            ClientName = reader.Item("ClientName").ToString
            FatherName = reader.Item("FatherName").ToString
            Mobile = reader.Item("Mobile").ToString
            Email = reader.Item("Email").ToString
            DOB = reader.Item("DOB").ToString
            AddressLine1 = reader.Item("Address1").ToString
            AddressLine2 = reader.Item("Address2").ToString
            District = reader.Item("District").ToString
            PinCode = reader.Item("Pincode").ToString
            Aadhar = reader.Item("AadharNo").ToString
            Description = reader.Item("Description").ToString
            TypeOfEngagement = reader.Item("TypeOfEngagement").ToString
            TIN = reader.Item("TIN").ToString
            CIN = reader.Item("CIN").ToString
            PartnersOrDirectors = XMLParsers.Partners.FromXML(reader.Item("PartnerDirector").ToString)
            Type = reader.Item("Type").ToString
            Credentials = XMLParsers.Credentials.FromXML(reader.Item("Credentials").ToString)
            Jobs = XMLParsers.Jobs.FromXML(reader.Item("Jobs").ToString(), Jobs.ToList)
            Status = reader.Item("Status").ToString
            Dim b As Byte() = reader.Item("Photo")
            Dim ms As New IO.MemoryStream(b)
            Photo = Image.FromStream(ms)
            ms.Dispose()
            GC.Collect()
        End While
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
#End Region
#Region "Workbook"
    Sub AddNewWork(ByVal ConnectionString As String, ByVal User As User, ByVal Job As Job, ByVal DueDate As Date, _
                   ByVal Client As Client, ByVal Status As String, ByVal Description As String, ByVal Remarks As String, ByVal TargetDate As Date, _
                   ByVal Priority As String, ByVal CurrentStep As String, ByVal Assessment As String, ByVal Financial As String, ByVal DefaultStorage As String, ByVal Owner As User, ByVal History As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("INSERT INTO Workbook ([User],[Job],[DueDate],[Client],[DateAdded],[DateCompleted],[Status],[Description],[Remarks],[Folder],[TargetDate],[Priority],[DateUpdated],[CurrentStep],[AssessmentDetails],[FinancialDetails],[Owner],[History]) VALUES (@User,@Job,@DueDate,@Client,@DateAdded,@DateCompleted,@Status,@Description,@Remarks,@Folder,@TargetDate,@Priority,@DateUpdated,@CurrentStep,@AssessmentDetails,@FinancialDetails,@Owner,@History);", conn)
        AddParameter(comm, "@User", User.ID)
        AddParameter(comm, "@Job", Job.JID)
        AddParameter(comm, "@DueDate", DueDate)
        AddParameter(comm, "@Client", Client.ID)
        AddParameter(comm, "@DateAdded", Now)
        AddParameter(comm, "@DateCompleted", Now)
        AddParameter(comm, "@Status", Status)
        AddParameter(comm, "@Description", Description)
        AddParameter(comm, "@Remarks", Remarks)
        AddParameter(comm, "@Folder", GetFolder(DefaultStorage, Client, Job, Assessment, Now.Year))
        AddParameter(comm, "@TargetDate", TargetDate)
        AddParameter(comm, "@Priority", Priority)
        AddParameter(comm, "@DateUpdated", Now)
        AddParameter(comm, "@CurrentStep", CurrentStep)
        AddParameter(comm, "@AssessmentDetails", Assessment)
        AddParameter(comm, "@FinancialDetails", Financial)
        AddParameter(comm, "@Owner", Owner.ID)
        AddParameter(comm, "@History", History)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub EditWork(ByVal ConnectionString As String, ByVal ID As Integer, ByVal User As User, ByVal Job As Job, ByVal DueDate As Date, _
                  ByVal Client As Client, ByVal Status As String, ByVal Description As String, ByVal Remarks As String, ByVal TargetDate As Date, _
                  ByVal Priority As String, ByVal CurrentStep As String, ByVal Assessment As String, ByVal Financial As String, ByVal DefaultStorage As String, ByVal Owner As User, ByVal History As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("UPDATE Workbook SET [DueDate]=@DueDate,[DateCompleted]=@DateCompleted,[Status]=@Status,[Description]=@Description,[Remarks]=@Remarks,[TargetDate]=@TargetDate,[Priority]=@Priority,[DateUpdated]=@DateUpdated,[CurrentStep]=@CurrentStep,[History]=@History WHERE [ID]=" & ID & ";", conn)
        AddParameter(comm, "@DueDate", DueDate)
        AddParameter(comm, "@DateCompleted", Now)
        AddParameter(comm, "@Status", Status)
        AddParameter(comm, "@Description", Description)
        AddParameter(comm, "@Remarks", Remarks)
        AddParameter(comm, "@TargetDate", TargetDate)
        AddParameter(comm, "@Priority", Priority)
        AddParameter(comm, "@DateUpdated", Now)
        AddParameter(comm, "@CurrentStep", CurrentStep)
        AddParameter(comm, "@History", History)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub GetWorkByID(ByVal ConnectionString As String, ByVal ID As Integer, ByRef OwnerUser As Integer, ByRef Job As String, ByRef Client As Integer, ByRef DueDate As Date, ByRef TargetDate As Date, ByRef Priority As String, ByRef FinancialDetail As String, ByRef AssessmentDetail As String, ByRef Description As String, ByRef Remarks As String, ByRef Status As String, ByRef CurrentStep As String, ByRef CurrentlyAssignedTo As Integer, ByRef History As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Workbook WHERE [ID]=" & ID & ";", conn)
        Dim Reader As SqlDataReader = comm.ExecuteReader
        While Reader.Read
            CurrentlyAssignedTo = CInt(Reader.Item("User").ToString)
            Job = Reader.Item("Job").ToString
            DueDate = Date.Parse(Reader.Item("DueDate").ToString)
            Client = CInt(Reader.Item("Client").ToString)
            Status = Reader.Item("Status").ToString
            Description = Reader.Item("Description").ToString
            Remarks = Reader.Item("Remarks").ToString
            TargetDate = Reader.Item("TargetDate").ToString
            Priority = Reader.Item("Priority").ToString
            CurrentStep = Reader.Item("CurrentStep").ToString
            AssessmentDetail = Reader.Item("AssessmentDetails").ToString()
            FinancialDetail = Reader.Item("FinancialDetails").ToString()
            OwnerUser = CInt(Reader.Item("Owner").ToString)
            History = Reader.Item("History").ToString
        End While
        conn.Close()
    End Sub
    Sub UpdateStep(ByVal ConnectionString As String, ByVal ID As Integer, ByVal Step_ As String, ByVal History As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("UPDATE Workbook SET [CurrentStep]=@CurrentStep,[History]=@History WHERE [ID]=" & ID & ";", conn)
        AddParameter(comm, "@DateUpdated", Now)
        AddParameter(comm, "@CurrentStep", Step_)
        AddParameter(comm, "@History", History)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub UpdateStatus(ByVal ConnectionString As String, ByVal ID As Integer, ByVal Status As String, ByVal History As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("UPDATE Workbook SET [Status]=@Status,[History]=@History WHERE [ID]=" & ID & ";", conn)
        AddParameter(comm, "@DateUpdated", Now)
        AddParameter(comm, "@Status", Status)
        AddParameter(comm, "@History", History)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub AssignTo(ByVal ConnectionString As String, ByVal ID As Integer, ByVal NewUser As Integer, ByVal History As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("UPDATE Workbook SET [User]=@User,[History]=@History WHERE [ID]=" & ID & ";", conn)
        AddParameter(comm, "@DateUpdated", Now)
        AddParameter(comm, "@User", NewUser)
        AddParameter(comm, "@History", History)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
#End Region
#Region "Job"
    Sub AddNewJob(ByVal ConnectionString As String, ByVal Name As String, ByVal Group As String, ByVal Type As String, ByVal Steps As List(Of String), ByVal SubGroup As String, ByVal Templates As List(Of String), ByVal JobID As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("INSERT INTO Jobs ([JobName],[Group],[Type],[Steps],[SubGroup],[Templates],[JID]) VALUES (@jobname,@group,@type,@steps,@subgroup,@templates,@jid);", conn)
        AddParameter(comm, "@jobname", Name)
        AddParameter(comm, "@group", Group)
        AddParameter(comm, "@type", Type)
        AddParameter(comm, "@steps", XMLParsers.ListOfString.ToXml(Steps))
        AddParameter(comm, "@subgroup", SubGroup)
        AddParameter(comm, "@templates", XMLParsers.ListOfString.ToXml(Templates))
        AddParameter(comm, "@jid", JobID)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub EditJob(ByVal ConnectionString As String, ByVal ID As Integer, ByVal Name As String, ByVal Group As String, ByVal Type As String, ByVal Steps As List(Of String), ByVal SubGroup As String, ByVal Templates As List(Of String), ByVal JobID As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("UPDATE Jobs SET [JobName]=@jobname,[Group]=@group,[Type]=@type,[Steps]=@steps,[SubGroup]=@subgroup,[Templates]=@templates,[JID]=@jid WHERE [ID]=" & ID & ";", conn)
        AddParameter(comm, "@jobname", Name)
        AddParameter(comm, "@group", Group)
        AddParameter(comm, "@type", Type)
        AddParameter(comm, "@steps", XMLParsers.ListOfString.ToXml(Steps))
        AddParameter(comm, "@subgroup", SubGroup)
        AddParameter(comm, "@templates", XMLParsers.ListOfString.ToXml(Templates))
        AddParameter(comm, "@jid", JobID)
        comm.ExecuteNonQuery()
        conn.Close()
    End Sub
    Sub LoadJobByID(ByVal ConnectionString As String, ByVal JID As String, ByRef ID_ As String, _
                    ByRef Name As String, ByRef Group As String, ByRef Type As String, ByRef SubGroup As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Jobs WHERE JID=" & JID & ";", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        Dim i As Integer = -1
        While reader.Read()
            ID_ = reader.Item("ID")
            Name = reader.Item("JobName")
            Group = reader.Item("Group")
            Type = reader.Item("Type")
            SubGroup = reader.Item("SubGroup")
        End While
    End Sub
    Sub GetJobByID(ByVal ConnectionString As String, ByVal ID As Integer, ByRef Name As String, ByRef Group As String, ByRef SubGroup As String, ByRef Type As String, _
                   ByRef StepsText As String, ByVal TemplatesBox As ListBox, ByRef JobID As String)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Jobs WHERE [ID]=" & ID & ";", conn)
        Dim reader As SqlDataReader = comm.ExecuteReader
        While reader.Read()
            Name = reader.Item("JobName").ToString
            Group = reader.Item("Group").ToString
            SubGroup = reader.Item("SubGroup").ToString
            Type = reader.Item("Type").ToString
            Dim steps As List(Of String) = XMLParsers.ListOfString.FromXML(reader.Item("Steps").ToString)
            Dim templates As List(Of String) = XMLParsers.ListOfString.FromXML(reader.Item("Templates").ToString)
            For Each i As String In steps
                StepsText &= i & vbNewLine
            Next
            StepsText = StepsText.Trim
            TemplatesBox.Items.AddRange(templates.ToArray)
            JobID = reader.Item("JID").ToString
        End While
        conn.Close()
    End Sub
    Function GetJID(ByVal ConnectionString As String, ByVal Group As String, ByVal SubGroup As String) As String
        Dim SV As String = Group.ToString.Substring(0, 1) & SubGroup.ToString.Substring(0, 1)
        Dim conn As New SqlConnection(ConnectionString)
        conn.Open()
        Dim comm As New SqlCommand("SELECT * FROM Jobs WHERE [JID] LIKE '%" & SV & "%'", conn)
        Dim c As Integer = 0
        Dim reader = comm.ExecuteReader
        While reader.Read
            c += 1
        End While
        conn.Close()
        Return SV & CInt(c + 1).ToString("000")
    End Function
#End Region
End Module
