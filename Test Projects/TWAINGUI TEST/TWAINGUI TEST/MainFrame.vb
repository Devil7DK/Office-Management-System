
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports TwainLib

Namespace TwainGui
	Public Class MainFrame
		Inherits System.Windows.Forms.Form
		Implements IMessageFilter
		Private mdiClient1 As System.Windows.Forms.MdiClient
		Private menuMainFile As System.Windows.Forms.MenuItem
        Private WithEvents menuItemScan As System.Windows.Forms.MenuItem
        Private WithEvents menuItemSelSrc As System.Windows.Forms.MenuItem
		Private menuMainWindow As System.Windows.Forms.MenuItem
        Private WithEvents menuItemExit As System.Windows.Forms.MenuItem
		Private menuItemSepr As System.Windows.Forms.MenuItem
        Private mainFrameMenu As System.Windows.Forms.MainMenu
        Private components As System.ComponentModel.IContainer


		Public Sub New()
			InitializeComponent()
			tw = New Twain()
			tw.Init(Me.Handle)
		End Sub

		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing Then
				tw.Finish()
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.menuMainFile = New System.Windows.Forms.MenuItem()
            Me.menuItemSelSrc = New System.Windows.Forms.MenuItem()
            Me.menuItemScan = New System.Windows.Forms.MenuItem()
            Me.menuItemSepr = New System.Windows.Forms.MenuItem()
            Me.menuItemExit = New System.Windows.Forms.MenuItem()
            Me.mainFrameMenu = New System.Windows.Forms.MainMenu(Me.components)
            Me.menuMainWindow = New System.Windows.Forms.MenuItem()
            Me.mdiClient1 = New System.Windows.Forms.MdiClient()
            Me.SuspendLayout()
            '
            'menuMainFile
            '
            Me.menuMainFile.Index = 0
            Me.menuMainFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemSelSrc, Me.menuItemScan, Me.menuItemSepr, Me.menuItemExit})
            Me.menuMainFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems
            Me.menuMainFile.Text = "&File"
            '
            'menuItemSelSrc
            '
            Me.menuItemSelSrc.Index = 0
            Me.menuItemSelSrc.MergeOrder = 11
            Me.menuItemSelSrc.Text = "&Select Source..."
            '
            'menuItemScan
            '
            Me.menuItemScan.Index = 1
            Me.menuItemScan.MergeOrder = 12
            Me.menuItemScan.Text = "&Acquire..."
            '
            'menuItemSepr
            '
            Me.menuItemSepr.Index = 2
            Me.menuItemSepr.MergeOrder = 19
            Me.menuItemSepr.Text = "-"
            '
            'menuItemExit
            '
            Me.menuItemExit.Index = 3
            Me.menuItemExit.MergeOrder = 21
            Me.menuItemExit.Text = "&Exit"
            '
            'mainFrameMenu
            '
            Me.mainFrameMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuMainFile, Me.menuMainWindow})
            '
            'menuMainWindow
            '
            Me.menuMainWindow.Index = 1
            Me.menuMainWindow.MdiList = True
            Me.menuMainWindow.Text = "&Window"
            '
            'mdiClient1
            '
            Me.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mdiClient1.Location = New System.Drawing.Point(0, 0)
            Me.mdiClient1.Name = "mdiClient1"
            Me.mdiClient1.Size = New System.Drawing.Size(600, 345)
            Me.mdiClient1.TabIndex = 0
            '
            'MainFrame
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(600, 345)
            Me.Controls.Add(Me.mdiClient1)
            Me.IsMdiContainer = True
            Me.Menu = Me.mainFrameMenu
            Me.Name = "MainFrame"
            Me.Text = "TWAIN GUI"
            Me.ResumeLayout(False)

        End Sub
		#End Region



        Private Sub menuItemExit_Click(sender As Object, e As System.EventArgs) Handles menuItemExit.Click
            Close()
        End Sub

        Private Sub menuItemScan_Click(sender As Object, e As System.EventArgs) Handles menuItemScan.Click
            If Not msgfilter Then
                Me.Enabled = False
                msgfilter = True
                Application.AddMessageFilter(Me)
            End If
            tw.Acquire()
        End Sub

        Private Sub menuItemSelSrc_Click(sender As Object, e As System.EventArgs) Handles menuItemSelSrc.Click
            tw.[Select]()
        End Sub


		Private Function IMessageFilter_PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
			Dim cmd As TwainCommand = tw.PassMessage(m)
			If cmd = TwainCommand.[Not] Then
				Return False
			End If

			Select Case cmd
				Case TwainCommand.CloseRequest
					If True Then
						EndingScan()
						tw.CloseSrc()
						Exit Select
					End If
				Case TwainCommand.CloseOk
					If True Then
						EndingScan()
						tw.CloseSrc()
						Exit Select
					End If
				Case TwainCommand.DeviceEvent
					If True Then
						Exit Select
					End If
				Case TwainCommand.TransferReady
					If True Then
						Dim pics As ArrayList = tw.TransferPictures()
						EndingScan()
						tw.CloseSrc()
						picnumber += 1
						For i As Integer = 0 To pics.Count - 1
							Dim img As IntPtr = DirectCast(pics(i), IntPtr)
							Dim newpic As New PicForm(img)
							newpic.MdiParent = Me
							Dim picnum As Integer = i + 1
							newpic.Text = "ScanPass" + picnumber.ToString() + "_Pic" + picnum.ToString()
							newpic.Show()
						Next
						Exit Select
					End If
			End Select

			Return True
		End Function

		Private Sub EndingScan()
			If msgfilter Then
				Application.RemoveMessageFilter(Me)
				msgfilter = False
				Me.Enabled = True
				Me.Activate()
			End If
		End Sub

		Private msgfilter As Boolean
		Private tw As Twain
		Private picnumber As Integer = 0








		<STAThread> _
		Private Shared Sub Main()
			If Twain.ScreenBitDepth < 15 Then
				MessageBox.Show("Need high/true-color video mode!", "Screen Bit Depth", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Return
			End If

			Dim mf As New MainFrame()
			Application.Run(mf)
		End Sub

	End Class
	' class MainFrame
End Namespace
' namespace TwainGui

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
