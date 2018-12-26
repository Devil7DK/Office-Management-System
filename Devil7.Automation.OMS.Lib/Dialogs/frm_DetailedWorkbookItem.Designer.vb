Imports System.Windows.Forms

Namespace Dialogs
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_DetailedWorkbookItem
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.MainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Client = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Job = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Owner = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_AssignedTo = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Step = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Status = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_AddedOn = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_UpdatedOn = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_DueDate = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_TargetDate = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Description = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
            Me.txt_Remarks = New DevExpress.XtraEditors.LabelControl()
            Me.AnimationTimer = New System.Windows.Forms.Timer(Me.components)
            CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MainPanel.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MainPanel
            '
            Me.MainPanel.Controls.Add(Me.TableLayoutPanel1)
            Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainPanel.Location = New System.Drawing.Point(0, 0)
            Me.MainPanel.Name = "MainPanel"
            Me.MainPanel.Size = New System.Drawing.Size(517, 222)
            Me.MainPanel.TabIndex = 0
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 4
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Client, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl3, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Job, 1, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl5, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Owner, 1, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl7, 2, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_AssignedTo, 3, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl9, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Step, 1, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl11, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Status, 1, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl13, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_AddedOn, 1, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl15, 2, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_UpdatedOn, 3, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl17, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_DueDate, 1, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl19, 2, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_TargetDate, 3, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl21, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Description, 1, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.LabelControl23, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Remarks, 1, 8)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 9
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(513, 218)
            Me.TableLayoutPanel1.TabIndex = 0
            '
            'LabelControl1
            '
            Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl1.Location = New System.Drawing.Point(45, 3)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl1.Size = New System.Drawing.Size(34, 18)
            Me.LabelControl1.TabIndex = 0
            Me.LabelControl1.Text = "Client :"
            '
            'txt_Client
            '
            Me.txt_Client.Appearance.Options.UseTextOptions = True
            Me.txt_Client.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.TableLayoutPanel1.SetColumnSpan(Me.txt_Client, 3)
            Me.txt_Client.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Client.Location = New System.Drawing.Point(85, 3)
            Me.txt_Client.Name = "txt_Client"
            Me.txt_Client.Size = New System.Drawing.Size(425, 18)
            Me.txt_Client.TabIndex = 1
            Me.txt_Client.Text = "-"
            '
            'LabelControl3
            '
            Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl3.Location = New System.Drawing.Point(55, 27)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl3.Size = New System.Drawing.Size(24, 18)
            Me.LabelControl3.TabIndex = 2
            Me.LabelControl3.Text = "Job :"
            '
            'txt_Job
            '
            Me.txt_Job.Appearance.Options.UseTextOptions = True
            Me.txt_Job.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.TableLayoutPanel1.SetColumnSpan(Me.txt_Job, 3)
            Me.txt_Job.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Job.Location = New System.Drawing.Point(85, 27)
            Me.txt_Job.Name = "txt_Job"
            Me.txt_Job.Size = New System.Drawing.Size(425, 18)
            Me.txt_Job.TabIndex = 3
            Me.txt_Job.Text = "-"
            '
            'LabelControl5
            '
            Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl5.Location = New System.Drawing.Point(40, 51)
            Me.LabelControl5.Name = "LabelControl5"
            Me.LabelControl5.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl5.Size = New System.Drawing.Size(39, 18)
            Me.LabelControl5.TabIndex = 4
            Me.LabelControl5.Text = "Owner :"
            '
            'txt_Owner
            '
            Me.txt_Owner.Appearance.Options.UseTextOptions = True
            Me.txt_Owner.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_Owner.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Owner.Location = New System.Drawing.Point(85, 51)
            Me.txt_Owner.Name = "txt_Owner"
            Me.txt_Owner.Size = New System.Drawing.Size(174, 18)
            Me.txt_Owner.TabIndex = 5
            Me.txt_Owner.Text = "-"
            '
            'LabelControl7
            '
            Me.LabelControl7.Location = New System.Drawing.Point(265, 51)
            Me.LabelControl7.Name = "LabelControl7"
            Me.LabelControl7.Size = New System.Drawing.Size(65, 13)
            Me.LabelControl7.TabIndex = 6
            Me.LabelControl7.Text = "Assigned To :"
            '
            'txt_AssignedTo
            '
            Me.txt_AssignedTo.Appearance.Options.UseTextOptions = True
            Me.txt_AssignedTo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_AssignedTo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_AssignedTo.Location = New System.Drawing.Point(335, 51)
            Me.txt_AssignedTo.Name = "txt_AssignedTo"
            Me.txt_AssignedTo.Size = New System.Drawing.Size(175, 18)
            Me.txt_AssignedTo.TabIndex = 7
            Me.txt_AssignedTo.Text = "-"
            '
            'LabelControl9
            '
            Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl9.Location = New System.Drawing.Point(18, 75)
            Me.LabelControl9.Name = "LabelControl9"
            Me.LabelControl9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl9.Size = New System.Drawing.Size(61, 18)
            Me.LabelControl9.TabIndex = 8
            Me.LabelControl9.Text = "Step/Stage :"
            '
            'txt_Step
            '
            Me.txt_Step.Appearance.Options.UseTextOptions = True
            Me.txt_Step.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_Step.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Step.Location = New System.Drawing.Point(85, 75)
            Me.txt_Step.Name = "txt_Step"
            Me.txt_Step.Size = New System.Drawing.Size(174, 18)
            Me.txt_Step.TabIndex = 9
            Me.txt_Step.Text = "-"
            '
            'LabelControl11
            '
            Me.LabelControl11.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl11.Location = New System.Drawing.Point(41, 99)
            Me.LabelControl11.Name = "LabelControl11"
            Me.LabelControl11.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl11.Size = New System.Drawing.Size(38, 18)
            Me.LabelControl11.TabIndex = 10
            Me.LabelControl11.Text = "Status :"
            '
            'txt_Status
            '
            Me.txt_Status.Appearance.Options.UseTextOptions = True
            Me.txt_Status.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_Status.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Status.Location = New System.Drawing.Point(85, 99)
            Me.txt_Status.Name = "txt_Status"
            Me.txt_Status.Size = New System.Drawing.Size(174, 18)
            Me.txt_Status.TabIndex = 11
            Me.txt_Status.Text = "-"
            '
            'LabelControl13
            '
            Me.LabelControl13.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl13.Location = New System.Drawing.Point(24, 123)
            Me.LabelControl13.Name = "LabelControl13"
            Me.LabelControl13.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl13.Size = New System.Drawing.Size(55, 18)
            Me.LabelControl13.TabIndex = 12
            Me.LabelControl13.Text = "Added On :"
            '
            'txt_AddedOn
            '
            Me.txt_AddedOn.Appearance.Options.UseTextOptions = True
            Me.txt_AddedOn.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_AddedOn.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_AddedOn.Location = New System.Drawing.Point(85, 123)
            Me.txt_AddedOn.Name = "txt_AddedOn"
            Me.txt_AddedOn.Size = New System.Drawing.Size(174, 18)
            Me.txt_AddedOn.TabIndex = 13
            Me.txt_AddedOn.Text = "-"
            '
            'LabelControl15
            '
            Me.LabelControl15.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl15.Location = New System.Drawing.Point(265, 123)
            Me.LabelControl15.Name = "LabelControl15"
            Me.LabelControl15.Size = New System.Drawing.Size(65, 13)
            Me.LabelControl15.TabIndex = 14
            Me.LabelControl15.Text = "Updated On :"
            '
            'txt_UpdatedOn
            '
            Me.txt_UpdatedOn.Appearance.Options.UseTextOptions = True
            Me.txt_UpdatedOn.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_UpdatedOn.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_UpdatedOn.Location = New System.Drawing.Point(335, 123)
            Me.txt_UpdatedOn.Name = "txt_UpdatedOn"
            Me.txt_UpdatedOn.Size = New System.Drawing.Size(175, 18)
            Me.txt_UpdatedOn.TabIndex = 15
            Me.txt_UpdatedOn.Text = "-"
            '
            'LabelControl17
            '
            Me.LabelControl17.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl17.Location = New System.Drawing.Point(27, 147)
            Me.LabelControl17.Name = "LabelControl17"
            Me.LabelControl17.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl17.Size = New System.Drawing.Size(52, 18)
            Me.LabelControl17.TabIndex = 16
            Me.LabelControl17.Text = "Due Date :"
            '
            'txt_DueDate
            '
            Me.txt_DueDate.Appearance.Options.UseTextOptions = True
            Me.txt_DueDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_DueDate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_DueDate.Location = New System.Drawing.Point(85, 147)
            Me.txt_DueDate.Name = "txt_DueDate"
            Me.txt_DueDate.Size = New System.Drawing.Size(174, 18)
            Me.txt_DueDate.TabIndex = 17
            Me.txt_DueDate.Text = "-"
            '
            'LabelControl19
            '
            Me.LabelControl19.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl19.Location = New System.Drawing.Point(265, 147)
            Me.LabelControl19.Name = "LabelControl19"
            Me.LabelControl19.Size = New System.Drawing.Size(65, 13)
            Me.LabelControl19.TabIndex = 18
            Me.LabelControl19.Text = "Target Date :"
            '
            'txt_TargetDate
            '
            Me.txt_TargetDate.Appearance.Options.UseTextOptions = True
            Me.txt_TargetDate.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.txt_TargetDate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_TargetDate.Location = New System.Drawing.Point(335, 147)
            Me.txt_TargetDate.Name = "txt_TargetDate"
            Me.txt_TargetDate.Size = New System.Drawing.Size(175, 18)
            Me.txt_TargetDate.TabIndex = 19
            Me.txt_TargetDate.Text = "-"
            '
            'LabelControl21
            '
            Me.LabelControl21.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl21.Location = New System.Drawing.Point(19, 171)
            Me.LabelControl21.Name = "LabelControl21"
            Me.LabelControl21.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl21.Size = New System.Drawing.Size(60, 18)
            Me.LabelControl21.TabIndex = 20
            Me.LabelControl21.Text = "Description :"
            '
            'txt_Description
            '
            Me.txt_Description.Appearance.Options.UseTextOptions = True
            Me.txt_Description.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.TableLayoutPanel1.SetColumnSpan(Me.txt_Description, 3)
            Me.txt_Description.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Description.Location = New System.Drawing.Point(85, 171)
            Me.txt_Description.Name = "txt_Description"
            Me.txt_Description.Size = New System.Drawing.Size(425, 18)
            Me.txt_Description.TabIndex = 21
            Me.txt_Description.Text = "-"
            '
            'LabelControl23
            '
            Me.LabelControl23.Dock = System.Windows.Forms.DockStyle.Right
            Me.LabelControl23.Location = New System.Drawing.Point(31, 195)
            Me.LabelControl23.Name = "LabelControl23"
            Me.LabelControl23.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
            Me.LabelControl23.Size = New System.Drawing.Size(48, 18)
            Me.LabelControl23.TabIndex = 22
            Me.LabelControl23.Text = "Remarks :"
            '
            'txt_Remarks
            '
            Me.txt_Remarks.Appearance.Options.UseTextOptions = True
            Me.txt_Remarks.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.TableLayoutPanel1.SetColumnSpan(Me.txt_Remarks, 3)
            Me.txt_Remarks.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Remarks.Location = New System.Drawing.Point(85, 195)
            Me.txt_Remarks.Name = "txt_Remarks"
            Me.txt_Remarks.Size = New System.Drawing.Size(425, 20)
            Me.txt_Remarks.TabIndex = 23
            Me.txt_Remarks.Text = "-"
            '
            'AnimationTimer
            '
            Me.AnimationTimer.Interval = 5
            '
            'frm_DetailedWorkbookItem
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(517, 222)
            Me.Controls.Add(Me.MainPanel)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "frm_DetailedWorkbookItem"
            Me.Opacity = 0R
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "frm_DetailedWorkbookItem"
            CType(Me.MainPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MainPanel.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainPanel As DevExpress.XtraEditors.PanelControl
        Friend WithEvents AnimationTimer As Timer
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Client As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Job As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Owner As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_AssignedTo As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Step As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Status As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_AddedOn As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_UpdatedOn As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_DueDate As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_TargetDate As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Description As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents txt_Remarks As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace