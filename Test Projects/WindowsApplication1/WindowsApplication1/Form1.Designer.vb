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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.WDOMElement2 = New WindowsApplication1.wDOMElement()
        Me.WDOMElement1 = New WindowsApplication1.wDOMElement()
        CType(Me.WDOMElement2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WDOMElement1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(162, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 180)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'WDOMElement2
        '
        Me.WDOMElement2.Location = New System.Drawing.Point(126, 26)
        Me.WDOMElement2.Name = "WDOMElement2"
        Me.WDOMElement2.Size = New System.Drawing.Size(75, 65)
        Me.WDOMElement2.TabIndex = 0
        Me.WDOMElement2.TabStop = False
        Me.WDOMElement2.Text = "WDOMElement1"
        '
        'WDOMElement1
        '
        Me.WDOMElement1.Location = New System.Drawing.Point(29, 12)
        Me.WDOMElement1.Name = "WDOMElement1"
        Me.WDOMElement1.Size = New System.Drawing.Size(75, 65)
        Me.WDOMElement1.TabIndex = 0
        Me.WDOMElement1.TabStop = False
        Me.WDOMElement1.Text = "WDOMElement1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WDOMElement2)
        Me.Controls.Add(Me.WDOMElement1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.WDOMElement2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WDOMElement1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WDOMElement1 As WindowsApplication1.wDOMElement
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents WDOMElement2 As WindowsApplication1.wDOMElement

End Class
