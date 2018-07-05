Option Explicit On
Option Strict On

Imports System.Runtime.InteropServices


Class Win32

    Public Const SHGFI_ICON As System.UInt32 = &H100
    Public Const SHGFI_LARGEICON As System.UInt32 = &H0  ' Large icon
    Public Const SHGFI_SMALLICON As System.UInt32 = &H1  ' Small icon


    Public Const FILE_ATTRIBUTE_NORMAL As System.UInt32 = &H80

    Public Const STGM_DELETEONRELEASE As System.UInt32 = &H4000000
    Public Const STGM_SHARE_DENY_WRITE As System.UInt32 = &H20
    Public Const STGM_SHARE_DENY_NONE As System.UInt32 = &H40
    Public Const STGM_READ As System.UInt32 = &H0

    <DllImport("shlwapi.dll", CharSet:=CharSet.Unicode, ExactSpelling:=True, PreserveSig:=False, EntryPoint:="SHCreateStreamOnFileW")> _
    Public Shared Sub SHCreateStreamOnFile(ByVal fileName As String, ByVal mode As System.UInt32, ByRef stream As System.Runtime.InteropServices.ComTypes.IStream)

    End Sub
    <DllImport("shell32.dll")> Public Shared Function SHGetFileInfo(ByVal pszPath As String, ByVal dwFileAttributes As System.UInt32, ByRef psfi As SHFILEINFO, ByVal cbSizeFileInfo As System.UInt32, ByVal uFlags As System.UInt32) As IntPtr

    End Function
    <DllImport("user32.dll")> Public Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean

    End Function
    <StructLayout(LayoutKind.Sequential)> Public Structure SHFILEINFO
        Public hIcon As IntPtr
        Public iIcon As IntPtr
        Public dwAttributes As System.UInt32
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> Public szDisplayName As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> Public szTypeName As String
    End Structure
End Class
