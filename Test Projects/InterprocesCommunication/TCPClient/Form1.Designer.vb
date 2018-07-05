<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_ServerIP = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Console = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Command = New System.Windows.Forms.TextBox()
        Me.btn_Send = New System.Windows.Forms.Button()
        Me.btn_Connect = New System.Windows.Forms.Button()
        Me.pnl_color = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Server IP :"
        '
        'txt_Name
        '
        Me.txt_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Name.Location = New System.Drawing.Point(79, 6)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(265, 20)
        Me.txt_Name.TabIndex = 0
        '
        'txt_ServerIP
        '
        Me.txt_ServerIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ServerIP.Location = New System.Drawing.Point(79, 31)
        Me.txt_ServerIP.Name = "txt_ServerIP"
        Me.txt_ServerIP.Size = New System.Drawing.Size(184, 20)
        Me.txt_ServerIP.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_Console)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 173)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Console"
        '
        'txt_Console
        '
        Me.txt_Console.BackColor = System.Drawing.Color.Black
        Me.txt_Console.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Console.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Console.ForeColor = System.Drawing.Color.White
        Me.txt_Console.Location = New System.Drawing.Point(3, 16)
        Me.txt_Console.Multiline = True
        Me.txt_Console.Name = "txt_Console"
        Me.txt_Console.ReadOnly = True
        Me.txt_Console.Size = New System.Drawing.Size(319, 154)
        Me.txt_Console.TabIndex = 0
        Me.txt_Console.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Command :"
        '
        'txt_Command
        '
        Me.txt_Command.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Command.Location = New System.Drawing.Point(82, 236)
        Me.txt_Command.Name = "txt_Command"
        Me.txt_Command.Size = New System.Drawing.Size(262, 20)
        Me.txt_Command.TabIndex = 2
        '
        'btn_Send
        '
        Me.btn_Send.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Send.Location = New System.Drawing.Point(269, 262)
        Me.btn_Send.Name = "btn_Send"
        Me.btn_Send.Size = New System.Drawing.Size(75, 27)
        Me.btn_Send.TabIndex = 7
        Me.btn_Send.TabStop = False
        Me.btn_Send.Text = "Send"
        Me.btn_Send.UseVisualStyleBackColor = True
        '
        'btn_Connect
        '
        Me.btn_Connect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Connect.Location = New System.Drawing.Point(269, 30)
        Me.btn_Connect.Name = "btn_Connect"
        Me.btn_Connect.Size = New System.Drawing.Size(75, 22)
        Me.btn_Connect.TabIndex = 7
        Me.btn_Connect.TabStop = False
        Me.btn_Connect.Text = "Connect"
        Me.btn_Connect.UseVisualStyleBackColor = True
        '
        'pnl_color
        '
        Me.pnl_color.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl_color.Location = New System.Drawing.Point(19, 262)
        Me.pnl_color.Name = "pnl_color"
        Me.pnl_color.Size = New System.Drawing.Size(68, 27)
        Me.pnl_color.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 300)
        Me.Controls.Add(Me.pnl_color)
        Me.Controls.Add(Me.btn_Connect)
        Me.Controls.Add(Me.btn_Send)
        Me.Controls.Add(Me.txt_Command)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_ServerIP)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TCP Client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_ServerIP As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Console As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Command As System.Windows.Forms.TextBox
    Friend WithEvents btn_Send As System.Windows.Forms.Button
    Friend WithEvents btn_Connect As System.Windows.Forms.Button
    Friend WithEvents pnl_color As System.Windows.Forms.Panel

End Class
