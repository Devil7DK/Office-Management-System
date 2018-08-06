Imports Devil7.Automation.OMS.Lib

Public Class frm_DetailedWorkbookItem
    Dim Loaded As Boolean = False
    Sub New(ByVal Location As Point, ByVal Item As Objects.WorkbookItem)
        InitializeComponent()
        Dim Loc As Point = Location
        If (Location.X + Me.Width) > My.Computer.Screen.WorkingArea.Width Then
            Loc.X = Location.X - Me.Width
        End If
        If (Location.Y + Me.Height) > My.Computer.Screen.WorkingArea.Height Then
            Loc.Y = Location.Y - Me.Height
        End If
        Me.Location = Loc

        txt_AddedOn.Text = Item.AddedOn
        txt_AssignedTo.Text = Item.AssignedTo.Username
        txt_Client.Text = Item.Client.Name
        txt_Description.Text = Item.Description
        txt_DueDate.Text = Item.DueDate
        txt_Job.Text = Item.Job.Name
        txt_Owner.Text = Item.Owner.Username
        txt_Remarks.Text = Item.Remarks
        txt_Status.Text = [Enum].GetName(GetType(Enums.WorkStatus), Item.Status)
        txt_Step.Text = Item.CurrentStep
        txt_TargetDate.Text = Item.TargetDate
        txt_UpdatedOn.Text = Item.UpdatedOn

    End Sub
    Private Sub frm_DetailedWorkbookItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnimationTimer.Start()
    End Sub

    Private Sub frm_DetailedWorkbookItem_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        If Loaded Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_DetailedWorkbookItem_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Loaded = True
    End Sub

    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub AnimationTimer_Tick(sender As Object, e As EventArgs) Handles AnimationTimer.Tick
        If Me.Opacity >= 1 Then
            AnimationTimer.Stop()
        Else
            Me.Opacity += 0.1
        End If
    End Sub
End Class