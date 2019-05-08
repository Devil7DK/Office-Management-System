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

Namespace Controls
    Public Class BillItemSelect

#Region "Properties"
        Property Templates As List(Of Objects.BillItemTemplate)

        ReadOnly Property BillItem As String
            Get
                If cmb_Item.SelectedItem Is Nothing Then
                    Return ""
                Else
                    Return String.Format(CType(cmb_Item.SelectedItem, Objects.BillItemTemplate).Template, select_Args.Value)
                End If
            End Get
        End Property
#End Region

#Region "Subs"
        Sub RefreshTemplates()
            cmb_Group.Properties.Items.Clear()

            For Each Template As Objects.BillItemTemplate In Templates
                If Not cmb_Group.Properties.Items.Contains(Template.Group.Trim) Then cmb_Group.Properties.Items.Add(Template.Group.Trim)
            Next

            If cmb_Group.Properties.Items.Count > 0 Then
                cmb_Group.SelectedIndex = 0
                cmb_Group_SelectedIndexChanged(cmb_Group, New EventArgs)
            End If
        End Sub
#End Region

#Region "Events"
        Private Sub cmb_Group_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Group.SelectedIndexChanged
            Try
                cmb_Item.Properties.Items.Clear()

                Dim Templates_ As List(Of Objects.BillItemTemplate) = Templates.FindAll(Function(c) c.Group.Trim = cmb_Group.SelectedItem.ToString.Trim)
                For Each Template As Objects.BillItemTemplate In Templates_
                    cmb_Item.Properties.Items.Add(Template)
                Next

                If cmb_Item.Properties.Items.Count > 0 Then cmb_Item.SelectedIndex = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub cmb_Item_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Item.SelectedIndexChanged
            Try
                Dim Item As Objects.BillItemTemplate = CType(cmb_Item.SelectedItem, Objects.BillItemTemplate)
                select_Args.Type = Item.Type
                txt_Preview.Text = BillItem
            Catch ex As Exception

            End Try
        End Sub

        Private Sub select_Args_ValueChanged(sender As Object, e As EventArgs) Handles select_Args.ValueChanged
            txt_Preview.Text = BillItem
        End Sub

        Private Sub txt_Preview_Click(sender As Object, e As EventArgs) Handles txt_Preview.Click
            txt_Preview.Text = BillItem
        End Sub
#End Region

    End Class
End Namespace