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
'=========================================================================='

Imports Devil7.Automation.OMS.Lib.Objects

Public Class data_Bill

#Region "Properties/Variables"
    Property SerialNumber As String
    Property EstimateDate As Date
    Property Sender As Sender
    Property Receiver As Receiver
    Property Services As List(Of Service)
    Property TotalFees As Double
    Property HasGSTIN As Boolean
    Property FeesInWords As String
    Property PrintTaxDetails As Boolean
    Property GSTPercentage As Double
    Property Heading As String
    Property SubHeading As String
    ReadOnly Property Logo As Image
        Get
            If Sender IsNot Nothing AndAlso Sender.Logo IsNot Nothing Then
                Return Sender.Logo
            Else
                Return GenerateLogo(Sender.Name)
            End If
        End Get
    End Property


    ReadOnly Property SenderAddress As String
        Get
            Dim Address As String = ""

            If Sender IsNot Nothing Then
                Address = String.Format("{1},{0}{2},{0}{3} - {4}", vbNewLine, Sender.AddressLine1.Trim.TrimEnd(","), Sender.AddressLine2.Trim.TrimEnd(","), Sender.City.Trim.TrimEnd(","), Sender.PINCode)
            End If

            Return Address
        End Get
    End Property

    ReadOnly Property ReceiversAddress As String
        Get
            Dim Address As String = ""

            If Sender IsNot Nothing Then
                Address = String.Format("{1},{0}{2},{0}{3} - {4}{0}{5} ({6})", vbNewLine, Receiver.AddressLine1.Trim.TrimEnd(","), Receiver.AddressLine2.Trim.TrimEnd(","), Receiver.City.Trim.TrimEnd(","), Receiver.PinCode, Receiver.State, Receiver.StateCode)
            End If

            Return Address
        End Get
    End Property

    ReadOnly Property GST As Double
        Get
            Return TotalFees * (GSTPercentage / 100)
        End Get
    End Property

    ReadOnly Property GrandTotal As Double
        Get
            Return TotalFees + GST
        End Get
    End Property
#End Region

#Region "Constructor"
    Sub New(ByVal Bill As Bill, ByVal Receiver As Receiver, ByVal PrintTaxDetails As Boolean, ByVal GSTPercentage As Double)
        Me.SerialNumber = Bill.SerialNo
        Me.EstimateDate = Bill.Date
        Me.Sender = Bill.Sender
        Me.Receiver = Receiver
        Me.Services = Bill.Services
        Me.TotalFees = Bill.Fees
        Me.HasGSTIN = Bill.HasGSTIN
        Me.FeesInWords = [Lib].Utils.Misc.AmountInWords(Bill.Fees)
        Me.PrintTaxDetails = PrintTaxDetails
        Me.GSTPercentage = GSTPercentage

        If Bill.Sender.BillHeading.Contains("|") Then
            Me.Heading = Bill.Sender.BillHeading.Split("|")(0)
            Me.SubHeading = Bill.Sender.BillHeading.Split("|")(1)
        Else
            Me.Heading = Bill.Sender.BillHeading
            Me.SubHeading = ""
        End If
    End Sub
#End Region

#Region "Functions"
    Function GenerateLogo(ByVal Name As String) As Image
        If String.IsNullOrEmpty(Name) Then
            Name = "D"
        End If

        Dim Image As New Bitmap(100, 100)
        Dim G As Graphics = Graphics.FromImage(Image)
        Dim Rect As New Rectangle(10, 10, 80, 80)
        G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
        G.FillEllipse(Brushes.LightGreen, Rect)
        G.DrawEllipse(New Pen(Brushes.Black, 2), Rect)
        G.DrawString(Name.Substring(0, 1), New Font("Century Gothic", 30, FontStyle.Bold), Brushes.White, Rect, New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
        G.Dispose()

        Return Image
    End Function
#End Region

End Class
