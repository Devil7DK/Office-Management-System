<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Drop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Drop))
        Me.OpenAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CloseAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.DropAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.Notification = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowOnLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightBottonCornerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RightLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeftTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TcpClientEx1 = New GlobalCode.TCPClientEx(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenAnimation
        '
        Me.OpenAnimation.Interval = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.OMSFileBox.My.Resources.Resources.DB_01
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CloseAnimation
        '
        Me.CloseAnimation.Interval = 5
        '
        'DropAnimation
        '
        Me.DropAnimation.Interval = 5
        '
        'Notification
        '
        Me.Notification.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Notification.Icon = CType(resources.GetObject("Notification.Icon"), System.Drawing.Icon)
        Me.Notification.Text = "OMS File Drop Box"
        Me.Notification.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowOnLeftToolStripMenuItem, Me.HideToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(158, 76)
        '
        'ShowOnLeftToolStripMenuItem
        '
        Me.ShowOnLeftToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RightBottonCornerToolStripMenuItem, Me.RightLeftToolStripMenuItem, Me.LeftBottomToolStripMenuItem, Me.LeftTopToolStripMenuItem})
        Me.ShowOnLeftToolStripMenuItem.Name = "ShowOnLeftToolStripMenuItem"
        Me.ShowOnLeftToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ShowOnLeftToolStripMenuItem.Text = "Move to Corner"
        '
        'RightBottonCornerToolStripMenuItem
        '
        Me.RightBottonCornerToolStripMenuItem.Name = "RightBottonCornerToolStripMenuItem"
        Me.RightBottonCornerToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RightBottonCornerToolStripMenuItem.Text = "Right Bottom"
        '
        'RightLeftToolStripMenuItem
        '
        Me.RightLeftToolStripMenuItem.Name = "RightLeftToolStripMenuItem"
        Me.RightLeftToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.RightLeftToolStripMenuItem.Text = "Right Top"
        '
        'LeftBottomToolStripMenuItem
        '
        Me.LeftBottomToolStripMenuItem.Name = "LeftBottomToolStripMenuItem"
        Me.LeftBottomToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LeftBottomToolStripMenuItem.Text = "Left Bottom"
        '
        'LeftTopToolStripMenuItem
        '
        Me.LeftTopToolStripMenuItem.Name = "LeftTopToolStripMenuItem"
        Me.LeftTopToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.LeftTopToolStripMenuItem.Text = "Left Top"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'TcpClientEx1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_Drop
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(150, 127)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Drop"
        Me.ShowInTaskbar = False
        Me.Text = "File Drop Box"
        Me.TransparencyKey = System.Drawing.Color.CadetBlue
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenAnimation As System.Windows.Forms.Timer
    Friend WithEvents CloseAnimation As System.Windows.Forms.Timer
    Friend WithEvents DropAnimation As System.Windows.Forms.Timer
    Friend WithEvents Notification As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowOnLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightBottonCornerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RightLeftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeftTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TcpClientEx1 As GlobalCode.TCPClientEx
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
