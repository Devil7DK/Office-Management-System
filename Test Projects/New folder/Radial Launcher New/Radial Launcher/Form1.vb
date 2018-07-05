Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm
    Private WithEvents mHook As New MouseHook
  Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
	Public Sub New()
		InitializeComponent()
	End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddFile("Calculator", "C:\Windows\system32\calc.exe")
        RadialMenu1.ShowPopup(New Point(100, 100))
    End Sub
    Dim CanReShow As Boolean = True
    Private Sub RadialMenu1_CloseUp(sender As Object, e As System.EventArgs) Handles RadialMenu1.CloseUp
        If CanReShow = True Then
            RadialMenu1.ShowPopup(cl)
        End If
    End Sub
    Sub AddFile(ByVal Name As String, ByVal Path As String)
        Dim i As New DevExpress.XtraBars.BarButtonItem() With {.Caption = Name, .Glyph = Icon.ExtractAssociatedIcon(Path).ToBitmap, .LargeGlyph = Icon.ExtractAssociatedIcon(Path).ToBitmap, .Tag = Path}
        AddHandler i.ItemClick, AddressOf BarButtonItem1_ItemClick
        RadialMenu1.AddItem(i)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Process.Start(e.Item.Tag.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim rectangle As New Rectangle(cl, New Size(50, 50))
        Label1.Text = cl.ToString & "," & rectangle.Contains(MousePosition.X, MousePosition.Y).ToString & "," & isMouseDown
    End Sub
    Dim isMouseDown As Boolean = False
    Private Sub mHook_Mouse_Left_Down(ptLocat As System.Drawing.Point) Handles mHook.Mouse_Left_Down
        Dim rect As New Rectangle(cl, New Size(50, 50))
        If rect.Contains(rect) Then
            isMouseDown = True
        End If
    End Sub
    Dim isMoving As Boolean = False
    Private Sub mHook_Mouse_Left_Up(ptLocat As System.Drawing.Point) Handles mHook.Mouse_Left_Up
        isMouseDown = False
        If isMoving = True Then
            CanReShow = False
            RadialMenu1.HidePopup()
            Timer2.Start()
            isMoving = False
        End If
    End Sub
    Dim cl As Point = New Point(100, 100)
    Private Sub mHook_Mouse_Move(ptLocat As System.Drawing.Point) Handles mHook.Mouse_Move
        If isMouseDown = True Then
            cl = ptLocat
            isMoving = True
        End If
    End Sub
    Dim i2 As Integer = 0

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        i2 += 1
        If 12 >= 2 Then
            RadialMenu1.ShowPopup(cl)
            i2 = 0
            Timer2.Stop()
        End If
    End Sub

    Private Sub RadialMenu1_Popup(sender As Object, e As System.EventArgs) Handles RadialMenu1.Popup
        CanReShow = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        CanReShow = False
        RadialMenu1.HidePopup()
        RadialMenu1.ShowPopup(New Point(200, 500))
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CanReShow = False
        RadialMenu1.HidePopup()
        RadialMenu1.ShowPopup(New Point(100, 100))
    End Sub
End Class
