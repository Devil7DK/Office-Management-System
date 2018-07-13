Imports Devil7.Automation.OMS.Lib
Imports System.Data.SqlClient

Public Class frm_Job
    Dim Mode As Enums.DialogMode
    Dim ID As Integer
    Dim DJID As String = ""
    Property Job As Objects.Job = Nothing
    Sub New(ByVal Mode As Enums.DialogMode, ByVal Groups As String(), ByVal SubGroups As String(), Optional ByVal ID As Integer = -1)
        InitializeComponent()
        Me.Mode = Mode
        Me.ID = ID
        On Error Resume Next
        cmb_Group.Properties.Items.AddRange(Groups)
        cmb_SubGroup.Properties.Items.AddRange(SubGroups)
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
            Dim JID As String = Database.GetJID(cmb_Group.Text, cmb_SubGroup.Text, False)
            If MsgBox("A job will be created with the details given by you. The Job ID will be " & JID & ". Do you wan't to continue?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "?") = MsgBoxResult.Yes Then
                Job = Database.Jobs.AddNew(txt_Name.Text, cmb_Group.Text, cmb_Type.SelectedIndex, lstSteps, cmb_SubGroup.Text, lstTMPL, JID, True)
            Else
                Exit Sub
            End If
        ElseIf Mode = Enums.DialogMode.Edit Then
            Database.Jobs.Update(ID, txt_Name.Text, cmb_Group.Text, cmb_Type.SelectedIndex, lstSteps, cmb_SubGroup.Text, lstTMPL, DJID, True)
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frm_Job_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Mode = Enums.DialogMode.Edit Then
            Try
                Dim Job As Objects.Job = Database.Jobs.GetJobByID(ID, True)
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
                DJID = Job.JID
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        txt_Name.Focus()
    End Sub

End Class