Public Class PasswordShowButton
    Inherits UserControl
    Sub New()
        Me.Height = 28
        Me.Width = 50
        Me.BackColor = Color.Transparent
    End Sub
    Dim img As Image = My.Resources._100px_Eye_Gray
    Property PasswordTextBox As Object
    Property PasswordChar As String = ""
    Property UseSystemPasswordChar As Boolean = True
    Private Sub PasswordShowButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If PasswordTextBox IsNot Nothing Then
            If UseSystemPasswordChar = True Then
                Try
                    PasswordTextBox.UseSystemPasswordChar = False
                Catch ex As Exception
                    Try
                        CType(PasswordTextBox, DevExpress.XtraEditors.TextEdit).Properties.UseSystemPasswordChar = False
                    Catch ex1 As Exception

                    End Try
                End Try
            Else
                Try
                    PasswordTextBox.PasswordChar = ""
                Catch ex As Exception
                    Try
                        CType(PasswordTextBox, DevExpress.XtraEditors.TextEdit).Properties.PasswordChar = ""
                    Catch ex1 As Exception

                    End Try
                End Try
            End If
            img = My.Resources._100px_Eye_Black
            Me.Refresh()
        End If
    End Sub

    Private Sub PasswordShowButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        If PasswordTextBox IsNot Nothing Then
            If UseSystemPasswordChar = True Then
                Try
                    PasswordTextBox.UseSystemPasswordChar = True
                Catch ex As Exception
                    Try
                        CType(PasswordTextBox, DevExpress.XtraEditors.TextEdit).Properties.UseSystemPasswordChar = True
                    Catch ex1 As Exception

                    End Try
                End Try
            Else
                Try
                    PasswordTextBox.PasswordChar = PasswordChar.Substring(0, 1)
                Catch ex As Exception
                    Try
                        CType(PasswordTextBox, DevExpress.XtraEditors.TextEdit).Properties.PasswordChar = PasswordChar.Substring(0, 1)
                    Catch ex1 As Exception

                    End Try
                End Try
            End If
            img = My.Resources._100px_Eye_Gray
            Me.Refresh()
        End If
    End Sub

    Private Sub PasswordShowButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If PasswordTextBox IsNot Nothing Then
            If UseSystemPasswordChar = True Then
                Try
                    PasswordTextBox.UseSystemPasswordChar = True
                Catch ex As Exception
                    Try
                        CType(PasswordTextBox, DevExpress.XtraEditors.TextEdit).Properties.UseSystemPasswordChar = True
                    Catch ex1 As Exception

                    End Try
                End Try
            Else
                Try
                    PasswordTextBox.PasswordChar = PasswordChar.Substring(0, 1)
                Catch ex As Exception
                    Try
                        CType(PasswordTextBox, DevExpress.XtraEditors.TextEdit).Properties.PasswordChar = PasswordChar.Substring(0, 1)
                    Catch ex1 As Exception

                    End Try
                End Try
            End If
            img = My.Resources._100px_Eye_Gray
            Me.Refresh()
        End If
    End Sub
    Private Sub PasswordShowButton_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawImage(img, New Rectangle(0, 0, Me.Width, Me.Height))
    End Sub
    Private Sub PasswordShowButton_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        Me.Height = Me.Width * (56 / 100)
    End Sub
End Class
