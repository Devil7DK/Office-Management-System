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
Imports System.Data.SqlClient

Public Class frm_WorkBook
    Dim Mode As Enums.DialogMode = Enums.DialogMode.Add
    Dim Jobs As List(Of Objects.Job)
    Dim ClientsMinimal As List(Of Objects.ClientMinimal)
    Dim Users As List(Of Objects.User)
    Dim ID As Integer = -1
    Dim UserData As Objects.User
    Sub New(ByVal Mode As Enums.DialogMode, ByVal UserData As Objects.User, ByVal Jobs As List(Of Objects.Job),
            ByVal MinimalClients As List(Of Objects.ClientMinimal), ByVal Users As List(Of Objects.User), Optional ByVal ID As Integer = -1)
        InitializeComponent()
        Me.Mode = Mode
        Me.Jobs = Jobs
        Me.ClientsMinimal = ClientsMinimal
        Me.Users = Users
        Me.ID = ID
        Me.UserData = UserData
    End Sub
    Private Sub frm_WorkBook_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 3
            cmb_Status.Properties.Items.Add([Enum].GetName(GetType(Enums.WorkStatus), i))
        Next
        For i As Integer = -2 To 2
            cmb_Priority.Properties.Items.Add([Enum].GetName(GetType(Enums.Priority), i))
        Next

        LookUpEdit1.Properties.DataSource = ClientsMinimal
        LookUpEdit1.Properties.DisplayMember = "ClientName"
        LookUpEdit1.Properties.ValueMember = "ID"
        LookUpEdit1.Properties.Columns.Item("ID").Visible = False

        cmb_Job.Properties.Items.AddRange(Jobs.ToArray)
        cmb_User.Properties.Items.AddRange(Users.ToArray)
        cmb_CurrentlyAssignedTo.Properties.Items.AddRange(Users.ToArray)
        If Mode = Enums.DialogMode.Edit Then
            cmb_User.Enabled = False
            cmb_Job.Enabled = False
            LookUpEdit1.Enabled = False
            cmb_Status.Enabled = False
            cmb_Priority.Enabled = False
            cmb_Steps.Enabled = False
            cmb_CurrentlyAssignedTo.Enabled = True
            txt_FinancialYearMonth.Enabled = False
            txt_AssessmentYearMonth.Enabled = False
        End If

        If Mode = Enums.DialogMode.Edit AndAlso ID <> -1 Then
            Dim ClientID As Integer
            Dim JobId As String = ""
            Dim CurrentUserID As Integer
            Dim OwnerID As Integer
            Dim Priority As String
            Dim Status As String
            Dim CurrentStep As String = ""
            Dim Work = Database.Workbook.GetWorkbookItemByID(ID)
            OwnerID = Work.Owner.ID
            JobId = Work.Job.ID
            ClientID = Work.Client.ID
            txt_DueDate.DateTime = Work.DueDate
            txt_TargetDate.DateTime = Work.TargetDate
            Priority = Work.PriorityOfWork
            txt_FinancialYearMonth.Value = Work.FinancialDetail
            txt_AssessmentYearMonth.Value = Work.AssementDetail
            txt_Description.Text = Work.Description
            txt_Remarks.Text = Work.Remarks
            Status = Work.Status
            CurrentStep = Work.CurrentStep
            CurrentUserID = Work.AssignedTo.ID
            Dim History As String = ""
            For Each i As String In Work.History
                History &= i & vbNewLine
            Next
            txt_History.Text = History.Trim
            For Each i As Objects.ClientMinimal In LookUpEdit1.Properties.DataSource
                If i.ID = ClientID Then
                    LookUpEdit1.EditValue = i.ID
                    Exit For
                End If
            Next
            For Each i As Objects.Job In cmb_Job.Properties.Items
                If i.ID = JobId Then
                    cmb_Job.SelectedItem = i
                    Exit For
                End If
            Next
            For Each i As Objects.User In cmb_User.Properties.Items
                If i.ID = OwnerID Then
                    cmb_User.SelectedItem = i
                    Exit For
                End If
            Next
            For Each i As Objects.User In cmb_CurrentlyAssignedTo.Properties.Items
                If i.ID = CurrentUserID Then
                    cmb_CurrentlyAssignedTo.SelectedItem = i
                    Exit For
                End If
            Next
            cmb_Steps.SelectedIndex = cmb_Steps.Properties.Items.IndexOf(CurrentStep)
            cmb_Priority.SelectedIndex = Enums.Functions.StringToEnum(Of Enums.Priority)(Priority)
            cmb_Status.SelectedIndex = Enums.Functions.StringToEnum(Of Enums.WorkStatus)(Status)
        Else
            On Error Resume Next
            cmb_User.SelectedIndex = 0
            cmb_Job.SelectedIndex = 0
            If ClientsMinimal.Count > 0 Then LookUpEdit1.EditValue = ClientsMinimal(0).ID
            txt_DueDate.DateTime = Now.AddDays(10)
            txt_TargetDate.DateTime = Now.AddDays(8)
            cmb_Priority.SelectedIndex = 2
            cmb_Status.SelectedIndex = 0
            cmb_Steps.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmb_Job_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_Job.SelectedIndexChanged
        Try
            Dim item As Objects.Job = cmb_Job.SelectedItem
            cmb_Steps.Properties.Items.Clear()
            cmb_Steps.Properties.Items.AddRange(item.Steps)
            If cmb_Steps.Properties.Items.Count > 0 Then cmb_Steps.SelectedIndex = 0

            txt_AssessmentYearMonth.PeriodType = item.Type
            txt_FinancialYearMonth.PeriodType = item.Type
        Catch ex As Exception

        End Try
    End Sub
    Function GetDefaultStorage() As String
        If My.Settings.DefaultStorage = "" Then
            Return My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Else
            Return My.Settings.DefaultStorage
        End If
    End Function
    Property WorkItemSelected As Objects.WorkbookItem
    Private Sub btn_Done_Click(sender As System.Object, e As System.EventArgs) Handles btn_Done.Click
        If Mode = Enums.DialogMode.Add Then
            Try
                WorkItemSelected = Nothing
                WorkItemSelected = Database.Workbook.AddNew(CType(cmb_User.SelectedItem, Objects.User), CType(cmb_Job.SelectedItem, Objects.Job), txt_DueDate.DateTime, ClientsMinimal.Find(Function(c) c.ID = LookUpEdit1.EditValue), cmb_Status.SelectedIndex, txt_Description.Text, txt_Remarks.Text, txt_TargetDate.DateTime, cmb_Priority.SelectedIndex - 2, cmb_Steps.SelectedItem.ToString, txt_AssessmentYearMonth.Value, txt_FinancialYearMonth.Value, Utils.Misc.GetFolder(GetDefaultStorage, Database.Clients.GetClientByID(LookUpEdit1.EditValue), CType(cmb_Job.SelectedItem, Objects.Job), txt_AssessmentYearMonth.Value.ToString, Now.Year), CType(cmb_User.SelectedItem, Objects.User), "New work assigned to " & CType(cmb_User.SelectedItem, Objects.User).Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
                If WorkItemSelected IsNot Nothing Then
                    MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        ElseIf Mode = Enums.DialogMode.Edit AndAlso ID > -1 Then
            Try
                If Database.Workbook.Update(ID, txt_DueDate.DateTime, txt_Description.Text, txt_Remarks.Text, txt_TargetDate.DateTime, CType(cmb_CurrentlyAssignedTo.SelectedItem, Objects.User), (txt_History.Text & vbNewLine & "Item editted at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).Trim & " by user " & UserData.Username) Then
                    MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub cmb_User_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_User.SelectedIndexChanged
        Try
            cmb_CurrentlyAssignedTo.SelectedItem = CType(cmb_User.SelectedItem, Objects.User)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class