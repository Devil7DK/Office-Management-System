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

Imports Devil7.Automation.OMS.Lib.Objects

Namespace Dialogs
    Public Class frm_JobUser

#Region "Variables"
        Dim Mode As Enums.DialogMode = Enums.DialogMode.Add
        Dim Jobs As List(Of Job)
        Dim Users As List(Of User)
#End Region

#Region "Properties"
        Property JobUser As JobUser
#End Region

#Region "Constructor"
        Sub New(ByVal Mode As Enums.DialogMode, ByVal Jobs As List(Of Job), ByVal Users As List(Of User), Optional ByRef JobUser As Objects.JobUser = Nothing)
            InitializeComponent()
            Me.Mode = Mode
            Me.JobUser = JobUser
            Me.Users = Users
            Me.Jobs = Jobs

            cmb_Job.Properties.Items.AddRange(Jobs.ToArray)
            cmb_User.Properties.Items.AddRange(Users.ToArray)
        End Sub
#End Region

#Region "Form Events"
        Private Sub frm_Job_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Mode = Enums.DialogMode.Edit AndAlso JobUser IsNot Nothing Then
                cmb_Job.SelectedIndex = Jobs.FindIndex(Function(c) c.ID = JobUser.Job.ID)
                cmb_User.SelectedIndex = Users.FindIndex(Function(c) c.ID = JobUser.User.ID)
            End If
            cmb_Job.Focus()
        End Sub
#End Region

#Region "Button Events"
        Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
            Me.JobUser = New JobUser(cmb_Job.SelectedItem, cmb_User.SelectedItem)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
#End Region

    End Class
End Namespace