<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits TCPChat.XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WizardControl1 = New DevExpress.XtraWizard.WizardControl()
        Me.WelcomeWizardPage1 = New DevExpress.XtraWizard.WelcomeWizardPage()
        Me.WizardPage1 = New DevExpress.XtraWizard.WizardPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup()
        Me.CompletionWizardPage1 = New DevExpress.XtraWizard.CompletionWizardPage()
        Me.WizardPage2 = New DevExpress.XtraWizard.WizardPage()
        Me.ListBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardControl1.SuspendLayout()
        Me.WizardPage1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WizardPage2.SuspendLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WizardControl1
        '
        Me.WizardControl1.Controls.Add(Me.WelcomeWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage1)
        Me.WizardControl1.Controls.Add(Me.CompletionWizardPage1)
        Me.WizardControl1.Controls.Add(Me.WizardPage2)
        Me.WizardControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WizardControl1.Location = New System.Drawing.Point(0, 0)
        Me.WizardControl1.Name = "WizardControl1"
        Me.WizardControl1.Pages.AddRange(New DevExpress.XtraWizard.BaseWizardPage() {Me.WelcomeWizardPage1, Me.WizardPage1, Me.WizardPage2, Me.CompletionWizardPage1})
        Me.WizardControl1.Size = New System.Drawing.Size(453, 348)
        Me.WizardControl1.Text = ""
        '
        'WelcomeWizardPage1
        '
        Me.WelcomeWizardPage1.IntroductionText = "This is an simple chat application that can act as an server or client. This appl" & _
    "ication uses IP Address based TCP Communication."
        Me.WelcomeWizardPage1.Name = "WelcomeWizardPage1"
        Me.WelcomeWizardPage1.Size = New System.Drawing.Size(236, 192)
        Me.WelcomeWizardPage1.Text = "Welcome to Devil7 TCPChat Program"
        '
        'WizardPage1
        '
        Me.WizardPage1.Controls.Add(Me.Label1)
        Me.WizardPage1.Controls.Add(Me.LabelControl1)
        Me.WizardPage1.Controls.Add(Me.RadioGroup1)
        Me.WizardPage1.DescriptionText = "Select type of your role in this chat session."
        Me.WizardPage1.Name = "WizardPage1"
        Me.WizardPage1.Size = New System.Drawing.Size(421, 203)
        Me.WizardPage1.Text = "Which you want to be.."
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(3, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 144)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Type of your Role :"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = CType(2, Long)
        Me.RadioGroup1.Location = New System.Drawing.Point(102, 3)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Columns = 1
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Long), "Client"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Long), "Server")})
        Me.RadioGroup1.Size = New System.Drawing.Size(316, 53)
        Me.RadioGroup1.TabIndex = 0
        '
        'CompletionWizardPage1
        '
        Me.CompletionWizardPage1.FinishText = "Your chat has been ended. Thankyou for using this application."
        Me.CompletionWizardPage1.Name = "CompletionWizardPage1"
        Me.CompletionWizardPage1.Size = New System.Drawing.Size(236, 215)
        Me.CompletionWizardPage1.Text = "Chat Ended"
        '
        'WizardPage2
        '
        Me.WizardPage2.Controls.Add(Me.Label3)
        Me.WizardPage2.Controls.Add(Me.ListBoxControl1)
        Me.WizardPage2.Controls.Add(Me.Label2)
        Me.WizardPage2.DescriptionText = "Now you are acting as a server. Give your IP Address and password shown below to " & _
    "the clients to connect. You can only choose the password."
        Me.WizardPage2.Name = "WizardPage2"
        Me.WizardPage2.Size = New System.Drawing.Size(421, 203)
        Me.WizardPage2.Text = "Server"
        '
        'ListBoxControl1
        '
        Me.ListBoxControl1.HorizontalScrollbar = True
        Me.ListBoxControl1.Location = New System.Drawing.Point(98, 9)
        Me.ListBoxControl1.Name = "ListBoxControl1"
        Me.ListBoxControl1.Size = New System.Drawing.Size(307, 106)
        Me.ListBoxControl1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "IP Address(s) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 348)
        Me.Controls.Add(Me.WizardControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.WizardControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardControl1.ResumeLayout(False)
        Me.WizardPage1.ResumeLayout(False)
        Me.WizardPage1.PerformLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WizardPage2.ResumeLayout(False)
        Me.WizardPage2.PerformLayout()
        CType(Me.ListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WizardControl1 As DevExpress.XtraWizard.WizardControl
    Friend WithEvents WelcomeWizardPage1 As DevExpress.XtraWizard.WelcomeWizardPage
    Friend WithEvents WizardPage1 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents CompletionWizardPage1 As DevExpress.XtraWizard.CompletionWizardPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WizardPage2 As DevExpress.XtraWizard.WizardPage
    Friend WithEvents ListBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
