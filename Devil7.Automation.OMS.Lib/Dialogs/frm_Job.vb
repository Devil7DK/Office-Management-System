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
'                                                                          '
'=========================================================================='

Imports Devil7.Automation.OMS.Lib
Imports Devil7.Automation.OMS.Lib.Objects

Namespace Dialogs
    Public Class frm_Job
        Dim Mode As Enums.DialogMode
        Dim ID As Integer
        Property Job As Job = Nothing
        Dim Users As New List(Of User)
        Sub New(ByVal Mode As Enums.DialogMode, ByVal Groups As String(), ByVal SubGroups As String(), ByVal Users As List(Of User), Optional ByVal ID As Integer = -1)
            InitializeComponent()
            Me.Mode = Mode
            Me.ID = ID
            On Error Resume Next
            cmb_Group.Properties.Items.AddRange(Groups)
            cmb_SubGroup.Properties.Items.AddRange(SubGroups)
            Me.Users = Users
        End Sub
        Private Sub btn_Template_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Template_Add.Click
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                lst_Templates.Items.AddRange(OpenFileDialog1.FileNames)
            End If
        End Sub

        Private Sub btn_Template_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Template_Remove.Click
            lst_Templates.Items.RemoveAt(lst_Templates.SelectedIndex)
        End Sub

        Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
            Dim lstTMPL As New List(Of String)
            For Each i As String In lst_Templates.Items
                lstTMPL.Add(i)
            Next
            Dim lstSteps As New List(Of String)
            lstSteps.AddRange(txt_Steps.Lines)
            If Mode = Enums.DialogMode.Add Then
                Job = Database.Jobs.AddNew(txt_Name.Text, cmb_Group.Text, cmb_Type.SelectedIndex, lstSteps, cmb_SubGroup.Text, lstTMPL, CType(gc_FollowUps.DataSource, List(Of Job)), CType(gc_AutoForwards.DataSource, List(Of AutoForward)), txt_NotifyInterval.Value, txt_DueInterval.Value, txt_PrimaryPeriod.SelectedIndex, True)
            ElseIf Mode = Enums.DialogMode.Edit Then
                Database.Jobs.Update(ID, txt_Name.Text, cmb_Group.Text, cmb_Type.SelectedIndex, lstSteps, cmb_SubGroup.Text, lstTMPL, CType(gc_FollowUps.DataSource, List(Of Job)), CType(gc_AutoForwards.DataSource, List(Of AutoForward)), txt_NotifyInterval.Value, txt_DueInterval.Value, txt_PrimaryPeriod.SelectedIndex, True)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub frm_Job_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Mode = Enums.DialogMode.Edit Then
                Try
                    Dim Job As Job = Database.Jobs.GetJobByID(ID, True)
                    txt_Name.Text = Job.Name
                    cmb_Group.Text = Job.Group
                    cmb_SubGroup.Text = Job.SubGroup
                    cmb_Type.SelectedIndex = Job.Type
                    Dim Steps As String = ""
                    For Each i As String In Job.Steps
                        Steps &= i & vbNewLine
                    Next
                    txt_Steps.Text = Steps.Trim
                    lst_Templates.Items.AddRange(Job.Templates.ToArray)
                    gc_FollowUps.DataSource = Job.FollowUps
                    txt_NotifyInterval.Value = Job.NotifyInterval
                    txt_DueInterval.Value = Job.DueInterval
                    txt_PrimaryPeriod.SelectedIndex = Job.PrimaryPeriodType
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                txt_PrimaryPeriod.SelectedIndex = 0
            End If
            txt_Name.Focus()
        End Sub

        Private Sub btn_FollowUps_Add_Click(sender As Object, e As EventArgs) Handles btn_FollowUps_Add.Click
            Dim d As New frm_Job_Lite(Enums.DialogMode.Add)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                If gc_FollowUps.DataSource Is Nothing Then gc_FollowUps.DataSource = New List(Of Job)
                If d.Job.ID = ID Then
                    MsgBox("You can't add the job itself to its follow up...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                ElseIf d.Job.FollowUps.Find(Function(c) c.ID = ID) IsNot Nothing Then
                    MsgBox("You can't add a job which has the current job as its follow up...", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                Else
                    CType(gc_FollowUps.DataSource, List(Of Job)).Add(d.Job)
                    gc_FollowUps.RefreshDataSource()
                End If
            End If
        End Sub

        Private Sub btn_FollowUps_Remove_Click(sender As Object, e As EventArgs) Handles btn_FollowUps_Remove.Click
            If gv_FollowUps.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_FollowUps.GetSelectedRows
                    Dim row As Integer = (i)
                    Dim obj As Job = TryCast(gv_FollowUps.GetRow(row), Job)
                    CType(gc_FollowUps.DataSource, List(Of Job)).Remove(obj)
                Next
                gc_FollowUps.RefreshDataSource()
            End If
        End Sub

        Private Sub btn_AutoForwards_Add_Click(sender As Object, e As EventArgs) Handles btn_AutoForwards_Add.Click
            Dim d As New frm_AutoForwards(New List(Of String)(txt_Steps.Lines), Users)
            If d.ShowDialog = Windows.Forms.DialogResult.OK Then
                If gc_AutoForwards.DataSource Is Nothing Then gc_AutoForwards.DataSource = New List(Of AutoForward)
                CType(gc_AutoForwards.DataSource, List(Of AutoForward)).Add(d.AutoForward)
                gc_AutoForwards.RefreshDataSource()
            End If
        End Sub

        Private Sub btn_AutoForwards_Remove_Click(sender As Object, e As EventArgs) Handles btn_AutoForwards_Remove.Click
            If gv_AutoForwards.SelectedRowsCount > 0 Then
                For Each i As Integer In gv_AutoForwards.GetSelectedRows
                    Dim row As Integer = (i)
                    Dim obj As AutoForward = TryCast(gv_AutoForwards.GetRow(row), AutoForward)
                    CType(gc_AutoForwards.DataSource, List(Of AutoForward)).Remove(obj)
                Next
                gc_AutoForwards.RefreshDataSource()
            End If
        End Sub
    End Class
End Namespace