Option Explicit On
Option Strict On

Imports IMAPI2.Interop

Namespace MediaItems

    Public Interface iMediaItem

        ''' <summary>
        ''' Returns the full path of the file or directory
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property Path() As String

        ''' <summary>
        ''' Returns the size of the file or directory to the next largest sector
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property SizeOnDisc() As Long

        ''' <summary>
        ''' Returns the Icon of the file or directory
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ReadOnly Property FileIconImage() As System.Drawing.Image


        ''' <summary>
        ''' Adds the file or directory to the directory item, usually the root.
        ''' </summary>
        ''' <param name="rootItem"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Function AddToFileSystem(ByVal rootItem As IFsiDirectoryItem) As Boolean

    End Interface

End Namespace