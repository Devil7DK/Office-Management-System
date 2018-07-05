Option Explicit On
Option Strict On

'
' FIX THIS

Imports IMAPI2.Interop

Namespace MediaItems

    Public Class FileItem
        Implements iMediaItem

        '
        ' Data Members
        '

        ' variables
        Private m_fileLength As Long = 0
        Private m_filePath As String
        Private m_fileIconImage As System.Drawing.Image = Nothing
        Private m_displayName As String

        ' objects


        '
        ' Constant Members
        '

        Private Const c_SECTOR_SIZE As Long = 2048

        '
        ' Properties
        '

        Public ReadOnly Property SizeOnDisc() As Long Implements iMediaItem.SizeOnDisc
            Get

                If (m_fileLength > 0) Then

                    Return CLng(((m_fileLength / c_SECTOR_SIZE) + 1) * c_SECTOR_SIZE)

                End If

                Return 0

            End Get
        End Property

        Public ReadOnly Property Path() As String Implements iMediaItem.Path
            Get
                Return m_filePath
            End Get
        End Property

        Public ReadOnly Property FileIconImage() As System.Drawing.Image Implements iMediaItem.FileIconImage
            Get
                Return m_fileIconImage
            End Get
        End Property

        '
        ' Methods
        '

        Public Overrides Function ToString() As String

            Return m_displayName

        End Function


        Public Sub New(ByVal path As String)

            '
            If System.IO.File.Exists(path) = False Then

                Throw New System.IO.FileNotFoundException("The file added to FileItem was not found!", path)

            End If

            m_filePath = path

            Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(m_filePath)
            m_displayName = fileInfo.Name
            m_fileLength = fileInfo.Length

            '
            ' Get the File icon
            '

            Dim shinfo As Win32.SHFILEINFO = New Win32.SHFILEINFO

            Dim hImg As IntPtr = Win32.SHGetFileInfo(m_filePath, 0, shinfo, CType(System.Runtime.InteropServices.Marshal.SizeOf(shinfo), System.UInt32), Win32.SHGFI_ICON Or Win32.SHGFI_SMALLICON)

            If shinfo.hIcon <> System.IntPtr.Zero Then

                ' The icon is returned in the hIcon member of the shinfo struct
                Dim imageConverter As System.Drawing.IconConverter = New System.Drawing.IconConverter()
                Dim icon As System.Drawing.Icon = System.Drawing.Icon.FromHandle(shinfo.hIcon)
                Try

                    m_fileIconImage = CType(imageConverter.ConvertTo(icon, GetType(System.Drawing.Image)), System.Drawing.Image)

                Catch ex As NotSupportedException

                End Try

                Win32.DestroyIcon(shinfo.hIcon)
            End If

        End Sub

        Public Function AddToFileSystem(ByVal rootItem As IFsiDirectoryItem) As Boolean Implements iMediaItem.AddToFileSystem

            Dim stream As System.Runtime.InteropServices.ComTypes.IStream = Nothing

            Try

                '
                Win32.SHCreateStreamOnFile(m_filePath, Win32.STGM_READ Or Win32.STGM_SHARE_DENY_WRITE, stream)

                If stream IsNot Nothing Then

                    rootItem.AddFile(m_displayName, CType(stream, FsiStream))
                    Return True

                End If


            Catch ex As Exception

                MessageBox.Show(ex.Message, "Error adding file", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally

                If stream IsNot Nothing Then

                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(stream)

                End If

            End Try

            Return False


        End Function

    End Class

End Namespace
