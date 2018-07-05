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
    Function GetCount(Path As String) As Integer
        Return My.Computer.FileSystem.GetFiles(Path, FileIO.SearchOption.SearchAllSubDirectories, "*.lnk").Count
    End Function
    Sub AddFiles(ByVal Path As String, ByVal Menu As Object)
        For Each i As String In My.Computer.FileSystem.GetFiles(Path, FileIO.SearchOption.SearchTopLevelOnly, "*.lnk")
            AddFile2Menu(IO.Path.GetFileNameWithoutExtension(i), i, Menu)
        Next
        For Each i As String In My.Computer.FileSystem.GetDirectories(Path, FileIO.SearchOption.SearchTopLevelOnly, "*")
            If GetCount(i) > 0 Then
                AddFolder2Menu(New IO.DirectoryInfo(i).Name, i, Menu)
            End If
        Next
    End Sub
    Function GetIcon(ByVal FileName As String) As Icon
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(FileName)
        Return Icon.ExtractAssociatedIcon(Shortcut.TargetPath)
    End Function
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddFiles(Application.StartupPath & "\SC", RadialMenu1)
        RadialMenu1.AddItem(btn_Close)
        RadialMenu1.ShowPopup(New Point(100, 100))
        CanReShow = False
        RadialMenu1.HidePopup()
        Timer2.Start()
    End Sub
    Dim CanReShow As Boolean = True
    Private Sub RadialMenu1_CloseUp(sender As Object, e As System.EventArgs) Handles RadialMenu1.CloseUp
        If CanReShow = True Then
            RadialMenu1.ShowPopup(cl)
        End If
    End Sub
    Sub AddFile2Menu(ByVal Name As String, ByVal Path As String, ByVal Menu As Object)
        Dim i As New DevExpress.XtraBars.BarButtonItem() With {.Caption = Name, .Glyph = GetIcon(Path).ToBitmap, .LargeGlyph = GetIcon(Path).ToBitmap, .Tag = Path}
        AddHandler i.ItemClick, AddressOf BarButtonItem1_ItemClick
        If TypeOf Menu Is DevExpress.XtraBars.BarSubItem Then
            CType(Menu, DevExpress.XtraBars.BarSubItem).AddItem(i)
        Else
            Menu.AddItem(i)
        End If
    End Sub
    Sub AddFolder2Menu(ByVal Name As String, ByVal Path As String, ByVal Menu As Object)
        Dim i As New DevExpress.XtraBars.BarSubItem() With {.Caption = Name}
        If TypeOf Menu Is DevExpress.XtraBars.BarSubItem Then
            CType(Menu, DevExpress.XtraBars.BarSubItem).AddItem(i)
        Else
            Menu.AddItem(i)
        End If
        AddFiles(Path, i)
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
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
    Dim MDLoc As Point = New Point(0, 0)
    Private Sub mHook_Mouse_Left_Down(ptLocat As System.Drawing.Point) Handles mHook.Mouse_Left_Down
        isMouseDown = False
        Dim rect As New Rectangle(cl, New Size(50, 50))
        If rect.Contains(ptLocat) Then
            isMouseDown = True
            MDLoc = ptLocat
        End If
    End Sub
    Dim isMoving As Boolean = False
    Private Sub mHook_Mouse_Left_Up(ptLocat As System.Drawing.Point) Handles mHook.Mouse_Left_Up
        isMouseDown = False
        If isMoving = True AndAlso MDLoc <> ptLocat Then
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


    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        End
    End Sub

    Private Sub ribbonControl1_Click(sender As System.Object, e As System.EventArgs) Handles ribbonControl1.Click

    End Sub
End Class
