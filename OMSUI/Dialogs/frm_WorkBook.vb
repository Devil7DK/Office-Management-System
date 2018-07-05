Imports GlobalCode
Imports System.Data.SqlClient

Public Class frm_WorkBook
    Dim Mode As DialogMode = DialogMode.Add
    Dim Jobs As System.ComponentModel.BindingList(Of Job)
    Dim Clients As System.ComponentModel.BindingList(Of Client)
    Dim Users As System.ComponentModel.BindingList(Of User)
    Dim ID As Integer = -1
    Dim UserData As User
    Sub New(ByVal Mode As DialogMode, ByVal UserData As User, ByVal Jobs As System.ComponentModel.BindingList(Of Job), _
            ByVal Clients As System.ComponentModel.BindingList(Of Client), ByVal Users As System.ComponentModel.BindingList(Of User), Optional ByVal ID As Integer = -1)
        InitializeComponent()
        Me.Mode = Mode
        Me.Jobs = Jobs
        Me.Clients = Clients
        Me.Users = Users
        Me.ID = ID
        Me.UserData = UserData
    End Sub
    Private Sub frm_WorkBook_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmb_Status.Properties.Items.AddRange([Enum].GetNames(GetType(WorkStatus)))
        cmb_Priority.Properties.Items.AddRange([Enum].GetNames(GetType(Priority)))
        cmb_Client.Properties.Items.AddRange(Clients.ToArray)
        cmb_Job.Properties.Items.AddRange(Jobs.ToArray)
        cmb_User.Properties.Items.AddRange(Users.ToArray)
        cmb_CurrentlyAssignedTo.Properties.Items.AddRange(Users.ToArray)
        If Mode = DialogMode.Edit Then
            cmb_User.Enabled = False
            cmb_Job.Enabled = False
            cmb_Client.Enabled = False
            txt_FinancialYear.Enabled = False
            txt_AssessmentYear.Enabled = False
        End If

        If Mode = DialogMode.Edit AndAlso ID <> -1 Then
            Dim ClientID As Integer
            Dim JobId As String = ""
            Dim CurrentUserID As Integer
            Dim OwnerID As Integer
            Dim Priority As String
            Dim Status As String
            Dim CurrentStep As String = ""
            GetWorkByID(ConnectionString, ID, OwnerID, JobId, ClientID, txt_DueDate.DateTime, txt_TargetDate.DateTime, Priority, txt_FinancialYear.Text, txt_AssessmentYear.Text, txt_Description.Text, txt_Remarks.Text, Status, CurrentStep, CurrentUserID, txt_History.Text)
            For Each i As Client In cmb_Client.Properties.Items
                If i.ID = ClientID Then
                    cmb_Client.SelectedItem = i
                    Exit For
                End If
            Next
            For Each i As Job In cmb_Job.Properties.Items
                If i.JID = JobId Then
                    cmb_Job.SelectedItem = i
                    Exit For
                End If
            Next
            For Each i As User In cmb_CurrentlyAssignedTo.Properties.Items
                If i.ID = CurrentUserID Then
                    cmb_CurrentlyAssignedTo.SelectedItem = i
                    Exit For
                End If
            Next
            For Each i As User In cmb_User.Properties.Items
                If i.ID = OwnerID Then
                    cmb_User.SelectedItem = i
                    Exit For
                End If
            Next
            cmb_Steps.SelectedIndex = cmb_Steps.Properties.Items.IndexOf(CurrentStep)
            cmb_Priority.SelectedIndex = StringToEnum(Of Priority)(Priority)
            cmb_Status.SelectedIndex = StringToEnum(Of WorkStatus)(Status)
        End If
    End Sub

    Private Sub cmb_Job_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_Job.SelectedIndexChanged
        Try
            Dim item As Job = cmb_Job.SelectedItem
            cmb_Steps.Properties.Items.Clear()
            cmb_Steps.Properties.Items.AddRange(item.Steps)
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
    Property WorkItemSelected As WorkbookItem
    Private Sub btn_Done_Click(sender As System.Object, e As System.EventArgs) Handles btn_Done.Click
        If Mode = DialogMode.Add Then
            Try
                AddNewWork(ConnectionString, CType(cmb_User.SelectedItem, User), CType(cmb_Job.SelectedItem, Job), txt_DueDate.DateTime, CType(cmb_Client.SelectedItem, Client), cmb_Status.SelectedItem.ToString, txt_Description.Text, txt_Remarks.Text, txt_TargetDate.DateTime, cmb_Priority.SelectedItem.ToString, cmb_Steps.SelectedItem.ToString, txt_AssessmentYear.Text, txt_FinancialYear.Text, GetFolder(GetDefaultStorage, CType(cmb_Client.SelectedItem, Client), CType(cmb_Job.SelectedItem, Job), txt_AssessmentYear.Text, Now.Year), CType(cmb_User.SelectedItem, User), "New work assigned to " & CType(cmb_User.SelectedItem, User).Username & " at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt"))
                MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        ElseIf Mode = DialogMode.Edit AndAlso ID > -1 Then
            Try
                EditWork(ConnectionString, ID, CType(cmb_User.SelectedItem, User), CType(cmb_Job.SelectedItem, Job), txt_DueDate.DateTime, CType(cmb_Client.SelectedItem, Client), cmb_Status.SelectedItem.ToString, txt_Description.Text, txt_Remarks.Text, txt_TargetDate.DateTime, cmb_Priority.SelectedItem.ToString, cmb_Steps.SelectedItem.ToString, txt_AssessmentYear.Text, txt_FinancialYear.Text, My.Settings.DefaultStorage, CType(cmb_User.SelectedItem, User), (txt_History.Text & vbNewLine & "Item editted at " & Now.ToString("dd/MM/yyyy hh:mm:ss tt")).Trim & " by user " & userdata.Username)
                MsgBox("Process Completed Successfully", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub cmb_User_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmb_User.SelectedIndexChanged
        Try
            cmb_CurrentlyAssignedTo.SelectedItem = CType(cmb_User.SelectedItem, User)
        Catch ex As Exception

        End Try
    End Sub
End Class