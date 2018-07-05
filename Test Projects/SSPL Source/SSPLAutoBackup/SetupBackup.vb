Imports System.IO

Public Class SetupBackup
    Function GetSize(ByVal SizeInBytes As Long) As String
        Dim size As String = ""
        Dim sizemode As String = ""
        Dim current As Long = 0
        If SizeInBytes < 1024 Then
            size = SizeInBytes
            sizemode = " Byte(s)"
        ElseIf SizeInBytes > 1024
            size = SizeInBytes / 1024
            sizemode = " KB(s)"
            current = SizeInBytes / 1024
            If current > 1023 Then
                size = current / 1024
                sizemode = " MB(s)"
                current = current / 1024
                If current > 1023 Then
                    size = current / 1024
                    sizemode = " GB(s)"
                    current = current / 1024
                    If current > 1023 Then
                        size = current / 1024
                        sizemode = " TB(s)"
                        current = current / 1024
                    End If
                End If
            End If
        End If
        If size.Contains(".") Then
            Dim s As String() = Split(size, ".")
            size = s(0) & "." & s(1).Substring(0, 2)
        End If
        Return size & sizemode
    End Function
    Sub AddDrive(ByVal i As DriveInfo)
        Dim l As String = ""
        l = i.VolumeLabel
        Dim li As ListViewItem = lv_Drives.Items.Add(If(l = "", "No Label", l))
        Try
            li.SubItems.Add(i.Name)
        Catch ex As Exception

        End Try
        Try
            li.SubItems.Add(i.DriveType)
        Catch ex As Exception

        End Try
        Try
            li.SubItems.Add(GetSize(i.TotalSize))
        Catch ex As Exception

        End Try
        Try
            li.SubItems.Add(GetSize(i.TotalFreeSpace))
        Catch ex As Exception

        End Try
        Try
            li.SubItems.Add(GetSize(i.AvailableFreeSpace))
        Catch ex As Exception

        End Try
        Try
            ImageList1.Images.Add(i.Name, Icon.ExtractAssociatedIcon(i.Name))
            li.ImageKey = i.Name
        Catch ex As Exception
            li.ImageIndex = 0
        End Try
    End Sub
    Sub LoadDrives()
        lv_Drives.Items.Clear()
        On Error Resume Next
        For Each i As DriveInfo In IO.DriveInfo.GetDrives
            AddDrive(i)
        Next
    End Sub

    Private Sub SetupBackup_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadDrives()
    End Sub

    Private Sub btn_Setup_Click(sender As Object, e As EventArgs) Handles btn_Setup.Click
        If lv_Drives.SelectedItems.Count = 1 Then
            Try
                Dim Drive_ As String = lv_Drives.SelectedItems(0).SubItems(1).Text.ToString
                My.Computer.FileSystem.WriteAllText(Drive_ & "SSPLBACKUP.THIS", "SSPLBACKUPDRIVE", False)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class