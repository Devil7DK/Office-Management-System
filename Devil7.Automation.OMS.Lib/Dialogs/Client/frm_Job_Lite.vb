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

Namespace Dialogs
    Public Class frm_Job_Lite

        Dim Mode As Enums.DialogMode = Enums.DialogMode.Add

        Sub New(ByVal Type As Enums.DialogMode, Optional ByRef Job_ As Objects.Job = Nothing)
            InitializeComponent()
            Me.Mode = Type
            Me.Job = Job_
            Try
                cmb_Name.Properties.Items.AddRange(Database.Jobs.GetAll(False).ToArray)
            Catch ex As Exception

            End Try
        End Sub

        Property Job As Objects.Job

        Private Sub frm_Job_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Mode = Enums.DialogMode.Edit AndAlso Job IsNot Nothing Then
                For Each i As Objects.Job In cmb_Name.Properties.Items
                    If i.ID = Job.ID Then
                        cmb_Name.SelectedItem = i
                        Exit For
                    End If
                Next
            End If
            cmb_Name.Focus()
        End Sub

        Private Sub btn_Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Done.Click
            Me.Job = cmb_Name.SelectedItem
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub

        Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

    End Class
End Namespace