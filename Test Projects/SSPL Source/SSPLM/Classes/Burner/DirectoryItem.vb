Option Explicit On
Option Strict On


'
' FIX THIS

Imports IMAPI2.Interop

Namespace MediaItems

    Public Class DirectoryItem
        Implements iMediaItem

        '
        ' Data Members
        '

        ' variables
        Private m_fileIconImage As System.Drawing.Image = Nothing
        Private m_directoryPath As String
        Private m_displayName As String

        ' objects
        Private mediaItems As System.Collections.Generic.List(Of iMediaItem) = New System.Collections.Generic.List(Of iMediaItem)

        '
        ' Properties
        '

        Public ReadOnly Property Path() As String Implements iMediaItem.Path
            Get
                '
                Path = m_directoryPath
            End Get
        End Property

        Public ReadOnly Property SizeOnDisc() As Long Implements iMediaItem.SizeOnDisc
            Get

                Dim totalSize As Long = 0
                Dim mediaItem As iMediaItem

                For Each mediaItem In mediaItems

                    totalSize += mediaItem.SizeOnDisc
                Next
                Return totalSize
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

        Public Sub New(ByVal directoryPath As String)

            If System.IO.Directory.Exists(directoryPath) = False Then

                Throw New System.IO.FileNotFoundException("The directory added to DirectoryItem was not found!", directoryPath)

            End If

            m_directoryPath = directoryPath
            Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(m_directoryPath)
            m_displayName = fileInfo.Name

            '
            ' Get all the files in the directory
            '
            Dim files() As String = System.IO.Directory.GetFiles(m_directoryPath)
            Dim file As String
            For Each file In files

                mediaItems.Add(New FileItem(file))

            Next

            '
            ' Get all the subdirectories
            '
            Dim directories() As String = System.IO.Directory.GetDirectories(m_directoryPath)
            Dim directory As String

            For Each directory In directories

                mediaItems.Add(New DirectoryItem(directory))
            Next

            '
            ' Get the Directory icon
            '

            '
            ' FIX THIS
            '

            Dim shinfo As Win32.SHFILEINFO = New Win32.SHFILEINFO()
            Dim hImg As IntPtr = Win32.SHGetFileInfo(m_directoryPath, 0, shinfo, CType(System.Runtime.InteropServices.Marshal.SizeOf(shinfo), System.UInt32), Win32.SHGFI_ICON Or Win32.SHGFI_SMALLICON)

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

            Try

                rootItem.AddTree(m_directoryPath, True)

                Return True

            Catch ex As Exception

                '
                MessageBox.Show(ex.Message, "Error adding folder", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return False

            End Try

        End Function

    End Class

End Namespace
