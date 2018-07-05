Imports System.Runtime.InteropServices

Public Class NotificationForm
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height - Me.Height)
    End Sub

    <DllImport("user32.dll", EntryPoint:="GetDesktopWindow")> _
    Public Shared Function GetDesktopWindow() As IntPtr
    End Function

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp = MyBase.CreateParams
            ' Retrieve the normal parameters.
            cp.Style = &H40000000 Or &H4000000
            ' WS_CHILD | WS_CLIPSIBLINGS
            cp.ExStyle = cp.ExStyle And &H80000
            ' WS_EX_LAYERED
            cp.Parent = GetDesktopWindow()
            ' Make "GetDesktopWindow()" from your own namespace.
            Return cp
        End Get
    End Property
    Dim x As Integer
    Dim y As Integer
    Dim Min_X As Integer
    Dim Max_X As Integer

   
    Private Sub ClickHandler(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        On Error Resume Next
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Start()
    End Sub
    Sub AddClickHandler(ByVal Parent As Control)
        For Each c As Control In Parent.Controls
            AddHandler c.MouseClick, AddressOf ClickHandler
            AddClickHandler(c)
        Next
    End Sub
    Private Sub NotificationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        x = My.Computer.Screen.Bounds.Width
        y = My.Computer.Screen.WorkingArea.Height - Me.Height
        Min_X = My.Computer.Screen.WorkingArea.Width - Me.Width
        Max_X = My.Computer.Screen.Bounds.Width
        Timer1.Start()
        AddClickHandler(Me)
    End Sub
    Overloads Sub Show(ByVal Title As String, ByVal Message As String)
        Me.lbl_Title.Text = Title
        Me.lbl_Message.Text = Message
        MyBase.Show()
    End Sub
    Property Timeout As Integer = 10
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If x < Min_X Then
            Me.Location = New Point(Min_X, y)
            Timer2.Start()
            Timer1.Stop()
        Else
            Me.Location = New Point(x, y)
            x -= 15
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If x > Max_X Then
            Me.Location = New Point(Max_X, y)
            Timer1.Stop()
            Me.Close()
            Me.Dispose()
        Else
            Me.Location = New Point(x, y)
            x += 15
        End If
    End Sub
    Dim TimeCount As Integer = 0
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If TimeCount > Timeout Then
            Timer1.Stop()
            Timer3.Start()
            Timer2.Stop()
        Else
            TimeCount += 1
        End If
    End Sub
End Class