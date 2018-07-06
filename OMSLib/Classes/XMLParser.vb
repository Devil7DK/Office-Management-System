Imports System.Xml
Imports System.ComponentModel
Namespace XMLParsers

    Public Module CredentialsWithClient
        Sub FromXML(ByVal Value As String, ByVal Client As Client, ByRef CredentialList As System.ComponentModel.BindingList(Of CredentialWithClient))
            Dim Stream_ As New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(Value.Replace("''", """")))
            Dim XMLReader As XmlReader = New XmlTextReader(Stream_)
            With XMLReader
                Do While .Read
                    If .Name = "Credential" Then
                        CredentialList.Add(New CredentialWithClient(Client, .GetAttribute("Name"), .GetAttribute("Template"), .GetAttribute("Username"), .GetAttribute("Password"), .GetAttribute("Password2"), .GetAttribute("Password3")))
                    End If
                Loop
                .Close()
            End With
        End Sub
    End Module
    Public Module Credentials
        Function ToXml(ByVal Values As BindingList(Of Credential)) As String
            Dim sb As New System.Text.StringBuilder
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            Dim XmlWrt As XmlWriter = XmlWriter.Create(sb, settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteStartElement("Credentials")
                For Each a As Credential In Values
                    .WriteStartElement("Credential")
                    .WriteAttributeString("Name", a.Name)
                    .WriteAttributeString("Template", a.Template)
                    .WriteAttributeString("Username", a.Username)
                    .WriteAttributeString("Password", a.Password)
                    .WriteAttributeString("Password2", a.Password2)
                    .WriteAttributeString("Password3", a.Password3)
                    .WriteEndElement()
                Next
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
            Return sb.ToString
        End Function
        Function FromXML(ByVal Value As String) As BindingList(Of Credential)
            Dim ReturnDetails As New BindingList(Of Credential)
            Dim Stream_ As New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(Value.Replace("''", """")))
            Dim XMLReader As XmlReader = New XmlTextReader(Stream_)
            With XMLReader
                Do While .Read
                    If .Name = "Credential" Then
                        ReturnDetails.Add(New Credential(.GetAttribute("Name"), .GetAttribute("Template"), .GetAttribute("Username"), .GetAttribute("Password"), .GetAttribute("Password2"), .GetAttribute("Password3")))
                    End If
                Loop
                .Close()
            End With
            Return ReturnDetails
        End Function
    End Module
    Public Module Jobs
        Function ToXml(ByVal Values As BindingList(Of Job)) As String
            Dim sb As New System.Text.StringBuilder
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            Dim XmlWrt As XmlWriter = XmlWriter.Create(sb, settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteStartElement("StringCollection")
                For Each a As Job In Values
                    .WriteStartElement("Job")
                    .WriteAttributeString("ID", a.JID)
                    .WriteEndElement()
                Next
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
            Return sb.ToString
        End Function
        Function FromXML(ByVal Value As String) As BindingList(Of String)
            Dim ReturnDetails As New BindingList(Of String)
            Dim Stream_ As New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(Value.Replace("''", """")))
            Dim XMLReader As XmlReader = New XmlTextReader(Stream_)
            With XMLReader
                Do While .Read
                    If .Name = "Job" Then
                        ReturnDetails.Add(.GetAttribute("ID"))
                    End If
                Loop
                .Close()
            End With
            Return ReturnDetails
        End Function
        Function FromXML(ByVal Value As String, ByVal Jobs As List(Of Job)) As BindingList(Of Job)
            Jobs.Sort(New Job.Comparer)
            Dim ReturnDetails As New BindingList(Of Job)
            Dim Stream_ As New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(Value.Replace("''", """")))
            Dim XMLReader As XmlReader = New XmlTextReader(Stream_)
            With XMLReader
                Do While .Read
                    If .Name = "Job" Then
                        Dim j As Job = Jobs(Jobs.BinarySearch(New Job(.GetAttribute("ID")), New Job.Comparer))
                        ReturnDetails.Add(j)
                    End If
                Loop
                .Close()
            End With
            Return ReturnDetails
        End Function
    End Module
    Public Module ListOfString
        Function ToXml(ByVal Values As List(Of String)) As String
            Dim sb As New System.Text.StringBuilder
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            Dim XmlWrt As XmlWriter = XmlWriter.Create(sb, settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteStartElement("StringCollection")
                For Each a As String In Values
                    .WriteStartElement("String")
                    .WriteString(a)
                    .WriteEndElement()
                Next
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
            Return sb.ToString
        End Function
        Function FromXML(ByVal Value As String) As List(Of String)
            Dim ReturnDetails As New List(Of String)
            Dim Stream_ As New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(Value.Replace("''", """")))
            Dim XMLReader As XmlReader = New XmlTextReader(Stream_)
            With XMLReader
                Do While .Read
                    If .Name = "String" Then
                        ReturnDetails.Add(.ReadInnerXml())
                    End If
                Loop
                .Close()
            End With
            Return ReturnDetails
        End Function
    End Module
    Public Module Partners
        Function ToXml(ByVal Values As BindingList(Of Partner)) As String
            Dim sb As New System.Text.StringBuilder
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            Dim XmlWrt As XmlWriter = XmlWriter.Create(sb, settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteStartElement("Partners")
                For Each a As Partner In Values
                    .WriteStartElement("Partner")
                    .WriteAttributeString("Name", a.Name)
                    .WriteAttributeString("DOB", a.DOB)
                    .WriteAttributeString("Address", a.Address)
                    .WriteAttributeString("PAN", a.PAN)
                    .WriteEndElement()
                Next
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
            Return sb.ToString
        End Function
        Function FromXML(ByVal Value As String) As BindingList(Of Partner)
            Dim ReturnDetails As New BindingList(Of Partner)
            Dim Stream_ As New IO.MemoryStream(System.Text.Encoding.Unicode.GetBytes(Value.Replace("''", """")))
            Dim XMLReader As XmlReader = New XmlTextReader(Stream_)
            With XMLReader
                Do While .Read
                    If .Name = "Partner" Then
                        ReturnDetails.Add(New Partner(.GetAttribute("Name"), .GetAttribute("Address"), .GetAttribute("PAN"), .GetAttribute("DOB")))
                    End If
                Loop
                .Close()
            End With
            Return ReturnDetails
        End Function
    End Module

End Namespace
