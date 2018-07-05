Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports IMAPI2.Interop
Imports SSPLM.MediaItems
Public Class Burner

    Private Const _ClientName As String = "SSPL"

    Private _totalDiscSize As Long

    Private _isBurning As Boolean
    Private _isFormatting As Boolean
    Private _verificationLevel As IMAPI_BURN_VERIFICATION_LEVEL = IMAPI_BURN_VERIFICATION_LEVEL.IMAPI_BURN_VERIFICATION_NONE
    Private _closeMedia As Boolean
    Private _ejectMedia As Boolean

    Private _burnData As BurnData = New BurnData()
    Dim files As List(Of String)
    Public Sub New(ByVal Files As List(Of String))

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.files = Files

    End Sub


#Region "File ListBox Events"

    ''' <summary>
    ''' The user has selected a file or folder
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub listBoxFiles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxFiles.SelectedIndexChanged

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub listBoxFiles_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles listBoxFiles.DrawItem
        Dim mediaItem As iMediaItem = CType(listBoxFiles.Items(e.Index), iMediaItem)

        If mediaItem Is Nothing Then

            Return
        End If


        e.DrawBackground()

        If ((e.State And DrawItemState.Focus) <> 0) Then

            e.DrawFocusRectangle()

        End If

        If mediaItem.FileIconImage IsNot Nothing Then

            e.Graphics.DrawImage(mediaItem.FileIconImage, New Rectangle(4, e.Bounds.Y + 4, 16, 16))

        End If
        Dim font As Font = New Font(FontFamily.GenericSansSerif, 11)
        Dim width As Single = e.Graphics.MeasureString(mediaItem.ToString, font).Width

        'Dim rectF As RectangleF = New RectangleF(e.Bounds.X + 24, e.Bounds.Y, e.Bounds.Width - 24, e.Bounds.Height)
        Dim rectF As RectangleF = New RectangleF(e.Bounds.X + 24, e.Bounds.Y, width, e.Bounds.Height)
        Dim StringFormat As StringFormat = New StringFormat
        With StringFormat
            .LineAlignment = StringAlignment.Center
            .Alignment = StringAlignment.Near
            .Trimming = StringTrimming.EllipsisCharacter
        End With
        e.Graphics.DrawString(mediaItem.ToString(), font, New SolidBrush(e.ForeColor), rectF, StringFormat)
    End Sub

#End Region


#Region "Add/Remove File(s)/Folder(s)"

    Public Sub AddFiles()
        Try
            For Each i As String In files
                Dim fileItem As FileItem = New FileItem(i)
                listBoxFiles.Items.Add(fileItem)
                UpdateCapacity()
                EnableBurnButton()
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error")
            Me.Close()
        End Try
    End Sub

#End Region




#Region "Device ComboBox"
    Private Shared Function GetMediaTypeString(ByVal mediaType As IMAPI_MEDIA_PHYSICAL_TYPE) As String

        Select Case (mediaType)

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_UNKNOWN
                Return "Unknown Media Type"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDROM
                Return "CD-ROM"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDR
                Return "CD-R"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_CDRW
                Return "CD-RW"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDROM
                Return "DVD ROM"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDRAM
                Return "DVD-RAM"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSR
                Return "DVD+R"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSRW
                Return "DVD+RW"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSR_DUALLAYER
                Return "DVD+R Dual Layer"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHR
                Return "DVD-R"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHRW
                Return "DVD-RW"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDDASHR_DUALLAYER
                Return "DVD-R Dual Layer"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DISK
                Return "random-access writes"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_DVDPLUSRW_DUALLAYER
                Return "DVD+RW DL"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDROM
                Return "HD DVD-ROM"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDR
                Return "HD DVD-R"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_HDDVDRAM
                Return "HD DVD-RAM"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDROM
                Return "Blu-ray DVD (BD-ROM)"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDR
                Return "Blu-ray media"

            Case IMAPI_MEDIA_PHYSICAL_TYPE.IMAPI_MEDIA_TYPE_BDRE
                Return "Blu-ray Rewritable media"

            Case Else
                Return "Unknown Media Type"

        End Select

    End Function

    ''' <summary>
    ''' converts an IMAPI_PROFILE_TYPE to it's string
    ''' </summary>
    ''' <param name="profileType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetProfileTypeString(ByVal profileType As IMAPI_PROFILE_TYPE) As String

        Select Case (profileType)

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_CD_RECORDABLE
                Return "CD-R"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_CD_REWRITABLE
                Return "CD-RW"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVDROM
                Return "DVD ROM"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_RECORDABLE
                Return "DVD-R"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_RAM
                Return "DVD-RAM"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_R
                Return "DVD+R"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_RW
                Return "DVD+RW"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_R_DUAL
                Return "DVD+R Dual Layer"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_REWRITABLE
                Return "DVD-RW"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_RW_SEQUENTIAL
                Return "DVD-RW Sequential"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_SEQUENTIAL
                Return "DVD-R DL Sequential"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_LAYER_JUMP
                Return "DVD-R Dual Layer"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_DVD_PLUS_RW_DUAL
                Return "DVD+RW DL"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_ROM
                Return "HD DVD-ROM"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_RECORDABLE
                Return "HD DVD-R"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_HD_DVD_RAM
                Return "HD DVD-RAM"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_ROM
                Return "Blu-ray DVD (BD-ROM)"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_R_SEQUENTIAL
                Return "Blu-ray media Sequential"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_R_RANDOM_RECORDING
                Return "Blu-ray media"

            Case IMAPI_PROFILE_TYPE.IMAPI_PROFILE_TYPE_BD_REWRITABLE
                Return "Blu-ray Rewritable media"


            Case Else
                Return String.Empty

        End Select

    End Function


#End Region


#Region "Media Size"




    ''' <summary>
    ''' Updates the capacity progressbar
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateCapacity()

        '
        ' Get the text for the Max Size
        '

        If _totalDiscSize = 0 Then

            lbl_MediaSize.Text = "Size : 0 MB"
            Return
        End If

        lbl_MediaSize.Text = "Size : " & CStr(IIf(_totalDiscSize < 1000000000, String.Format("{0} MB", _totalDiscSize / 1000000), String.Format("{0:F2} GB", CDbl(_totalDiscSize / 1000000000.0))))

        '
        ' Calculate the size of the files
        '
        Dim totalMediaSize As Long = 0
        Dim mediaItem As iMediaItem

        For Each mediaItem In listBoxFiles.Items

            totalMediaSize += mediaItem.SizeOnDisc

        Next

        If totalMediaSize = 0 Then
            DiskSize.Value = 0
        Else

            Dim percent As Integer = CInt((totalMediaSize * 100) / _totalDiscSize)

            DiskSize.Value = percent
        End If

    End Sub

#End Region


#Region "Burn Media Process"


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="progress"></param>
    ''' <remarks></remarks>
    ''' 
    Sub discFormatData_Update(ByVal sender As Object, ByVal progress As Object)
        'Public Sub discFormatData_Update(<[In]()> <MarshalAs(UnmanagedType.IDispatch)> ByVal sender As Object, <[In]()> <MarshalAs(UnmanagedType.IDispatch)> ByVal progress As Object)

        '
        ' Check if we've cancelled
        '
        If Burn_Worker.CancellationPending = True Then

            Dim format2Data As IDiscFormat2Data = CType(sender, IDiscFormat2Data)
            format2Data.CancelWrite()
            Return
        End If

        Dim eventArgs As IDiscFormat2DataEventArgs = CType(progress, IDiscFormat2DataEventArgs)

        _burnData.task = BURN_MEDIA_TASK.BURN_MEDIA_TASK_WRITING

        ' IDiscFormat2DataEventArgs Interface
        _burnData.elapsedTime = eventArgs.ElapsedTime
        _burnData.remainingTime = eventArgs.RemainingTime
        _burnData.totalTime = eventArgs.TotalTime

        ' IWriteEngine2EventArgs Interface
        _burnData.currentAction = eventArgs.CurrentAction
        _burnData.startLba = eventArgs.StartLba
        _burnData.sectorCount = eventArgs.SectorCount
        _burnData.lastReadLba = eventArgs.LastReadLba
        _burnData.lastWrittenLba = eventArgs.LastWrittenLba
        _burnData.totalSystemBuffer = eventArgs.TotalSystemBuffer
        _burnData.usedSystemBuffer = eventArgs.UsedSystemBuffer
        _burnData.freeSystemBuffer = eventArgs.FreeSystemBuffer

        '
        ' Report back to the UI
        '
        Burn_Worker.ReportProgress(0, _burnData)

    End Sub




    ''' <summary>
    ''' Enables/Disables the "Burn" User Interface
    ''' </summary>
    ''' <param name="enable"></param>
    ''' <remarks></remarks>
    Private Sub EnableBurnUI(ByVal enable As Boolean)

        btn_Start.Text = CStr(IIf(enable = True, "Start", "Stop"))
        btn_DetectMedia.Enabled = enable

        cb_Devices.Enabled = enable
        listBoxFiles.Enabled = enable


        check_Eject.Enabled = enable
        check_CloseMedia.Enabled = enable
        txt_Lable.Enabled = enable
        cb_Verification.Enabled = enable

    End Sub



    ''' <summary>
    ''' Enable the Burn Button if items in the file listbox
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub EnableBurnButton()

        btn_Start.Enabled = (listBoxFiles.Items.Count > 0)

    End Sub


#End Region


#Region "File System Process"

    Private Function CreateMediaFileSystem(ByVal discRecorder As IDiscRecorder2, ByVal multisessionInterfaces() As Object, ByRef dataStream As System.Runtime.InteropServices.ComTypes.IStream) As Boolean


        Dim fileSystemImage As MsftFileSystemImage = Nothing

        Try

            fileSystemImage = New MsftFileSystemImage()
            fileSystemImage.ChooseImageDefaults(discRecorder)
            fileSystemImage.FileSystemsToCreate = FsiFileSystems.FsiFileSystemJoliet Or FsiFileSystems.FsiFileSystemISO9660
            fileSystemImage.VolumeName = txt_Lable.Text

            AddHandler fileSystemImage.Update, AddressOf fileSystemImage_Update

            ''/
            ' If multisessions, then import previous sessions
            '
            If multisessionInterfaces IsNot Nothing Then

                fileSystemImage.MultisessionInterfaces = multisessionInterfaces
                fileSystemImage.ImportFileSystem()

            End If

            '
            ' Get the image root
            '
            Dim rootItem As IFsiDirectoryItem = fileSystemImage.Root

            '
            ' Add Files and Directories to File System Image
            '

            Dim mediaItem As iMediaItem

            For Each mediaItem In listBoxFiles.Items

                '
                ' Check if we've cancelled
                '
                If Burn_Worker.CancellationPending = True Then Exit For

                '
                ' Add to File System
                '
                mediaItem.AddToFileSystem(rootItem)

            Next

            RemoveHandler fileSystemImage.Update, AddressOf fileSystemImage_Update

            '
            ' did we cancel?
            '
            If Burn_Worker.CancellationPending = True Then

                dataStream = Nothing
                Return False
            End If

            dataStream = CType(fileSystemImage.CreateResultImage().ImageStream, System.Runtime.InteropServices.ComTypes.IStream)

        Catch ex As COMException

            MessageBox.Show(Me, ex.Message, "Create File System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dataStream = Nothing
            Return False

        Finally

            If fileSystemImage IsNot Nothing Then

                Marshal.ReleaseComObject(fileSystemImage)

            End If

        End Try

        Return True

    End Function


    ''' <summary>
    ''' Event Handler for File System Progress Updates
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="currentFile"></param>
    ''' <param name="copiedSectors"></param>
    ''' <param name="totalSectors"></param>
    ''' <remarks></remarks>
    Private Sub fileSystemImage_Update(ByVal sender As Object, ByVal currentFile As String, ByVal copiedSectors As Integer, ByVal totalSectors As Integer)
        'Private Sub fileSystemImage_Update(<MarshalAs(UnmanagedType.IDispatch)> ByVal sender As Object, <MarshalAs(UnmanagedType.BStr)> ByVal currentFile As String, ByVal copiedSectors As Integer, ByVal totalSectors As Integer)
        Dim percentProgress As Integer = 0
        If (copiedSectors > 0) And (totalSectors > 0) Then

            percentProgress = CInt((copiedSectors * 100) / totalSectors)

        End If

        If String.IsNullOrEmpty(currentFile) = False Then

            Dim fileInfo As System.IO.FileInfo = New System.IO.FileInfo(currentFile)
            _burnData.statusMessage = "Adding " & fileInfo.Name & " to image..."

            '
            ' report back to the ui
            '
            _burnData.task = BURN_MEDIA_TASK.BURN_MEDIA_TASK_FILE_SYSTEM
            Burn_Worker.ReportProgress(percentProgress, _burnData)

        End If

    End Sub

#End Region
    Private Sub cb_Verification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Verification.SelectedIndexChanged
        _verificationLevel = CType(cb_Verification.SelectedIndex, IMAPI_BURN_VERIFICATION_LEVEL)
    End Sub

    Private Sub Burn_Worker_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles Burn_Worker.ProgressChanged
        ' int percent = e.ProgressPercentage;
        Dim burnData As BurnData = CType(e.UserState, BurnData)

        If burnData.task = BURN_MEDIA_TASK.BURN_MEDIA_TASK_FILE_SYSTEM Then

            lbl_BurnStatus.Text = burnData.statusMessage

        ElseIf burnData.task = BURN_MEDIA_TASK.BURN_MEDIA_TASK_WRITING Then

            Select Case burnData.currentAction

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_VALIDATING_MEDIA
                    lbl_BurnStatus.Text = "Validating current media..."

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_FORMATTING_MEDIA
                    lbl_BurnStatus.Text = "Formatting media..."

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_INITIALIZING_HARDWARE
                    lbl_BurnStatus.Text = "Initializing hardware..."

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_CALIBRATING_POWER
                    lbl_BurnStatus.Text = "Optimizing laser intensity..."

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_WRITING_DATA
                    Dim writtenSectors As Long = burnData.lastWrittenLba - burnData.startLba

                    If (writtenSectors > 0) And (burnData.sectorCount > 0) Then

                        Dim percent As Integer = CInt((100 * writtenSectors) / burnData.sectorCount)
                        lbl_BurnStatus.Text = String.Format("Progress: {0}%", percent)
                        BurnProgress.Value = percent

                    Else

                        lbl_BurnStatus.Text = "Progress 0%"
                        BurnProgress.Value = 0
                    End If

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_FINALIZATION
                    lbl_BurnStatus.Text = "Finalizing writing..."

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_COMPLETED
                    lbl_BurnStatus.Text = "Completed!"

                Case IMAPI_FORMAT2_DATA_WRITE_ACTION.IMAPI_FORMAT2_DATA_WRITE_ACTION_VERIFYING
                    lbl_BurnStatus.Text = "Verifying"

            End Select

        End If
    End Sub

    Private Sub Burner_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim discRecorder2 As MsftDiscRecorder2
        For Each discRecorder2 In cb_Devices.Items
            If discRecorder2 IsNot Nothing Then
                Marshal.ReleaseComObject(discRecorder2)
            End If
        Next
    End Sub

    Private Sub Burn_Worker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Burn_Worker.RunWorkerCompleted


        ' did an exception occur?
        If e.Error Is Nothing Then
            ' no exception

            ' cancelled?
            If e.Cancelled = True Then
                ' yes - cancelled

                '
                lbl_BurnStatus.Text = "Operation cancelled."

            Else
                ' no - not cancelled; operation completed

                '
                lbl_BurnStatus.Text = CStr(IIf(CInt(e.Result) = 0, "Finished Burning Disc!", "Error Burning Disc!"))

            End If


        Else
            ' yes - exception occured

            '
            lbl_BurnStatus.Text = "An error occurred during processing." & vbCrLf _
                                        & "Message: " & e.Error.Message

        End If

        BurnProgress.Value = 0

        _isBurning = False
        EnableBurnUI(True)
        btn_Start.Enabled = True

    End Sub

    Private Sub cb_Devices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Devices.SelectedIndexChanged
        If cb_Devices.SelectedIndex = -1 Then Return

        Dim discRecorder As MsftDiscRecorder2 = CType(cb_Devices.Items(cb_Devices.SelectedIndex), MsftDiscRecorder2)

        txt_SupportedMedia.Text = String.Empty

        '
        ' Verify recorder is supported
        '
        Dim discFormatData As IDiscFormat2Data = Nothing

        Try

            discFormatData = New MsftDiscFormat2Data()

            If discFormatData.IsRecorderSupported(discRecorder) = False Then

                MessageBox.Show("Recorder not supported", discFormatData.ClientName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim supportedMediaTypes As System.Text.StringBuilder = New System.Text.StringBuilder()

            Dim profileType As IMAPI_PROFILE_TYPE

            For Each profileType In discRecorder.SupportedProfiles

                Dim profileName As String = GetProfileTypeString(profileType)

                If String.IsNullOrEmpty(profileName) = False Then

                    If supportedMediaTypes.Length > 0 Then
                        supportedMediaTypes.Append(", ")

                    End If

                    supportedMediaTypes.Append(profileName)
                End If

            Next

            txt_SupportedMedia.Text = supportedMediaTypes.ToString()

        Catch ex As COMException

            txt_SupportedMedia.Text = "Error getting supported types"

        Finally

            If discFormatData IsNot Nothing Then

                Marshal.ReleaseComObject(discFormatData)

            End If

        End Try
    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        If cb_Devices.SelectedIndex = -1 Then Return

        If _isBurning = True Then

            btn_Start.Enabled = False
            Burn_Worker.CancelAsync()

        Else

            _isBurning = True
            _closeMedia = check_CloseMedia.Checked
            _ejectMedia = check_Eject.Checked

            EnableBurnUI(False)

            Dim discRecorder As IDiscRecorder2 = CType(cb_Devices.Items(cb_Devices.SelectedIndex), IDiscRecorder2)
            _burnData.uniqueRecorderId = discRecorder.ActiveDiscRecorder

            Burn_Worker.RunWorkerAsync(_burnData)

        End If

    End Sub

    Private Sub btn_DetectMedia_Click(sender As Object, e As EventArgs) Handles btn_DetectMedia.Click

        If cb_Devices.SelectedIndex = -1 Then Return

        Dim discRecorder As MsftDiscRecorder2 = CType(cb_Devices.Items(cb_Devices.SelectedIndex), MsftDiscRecorder2)

        Dim fileSystemImage As MsftFileSystemImage = Nothing
        Dim discFormatData As MsftDiscFormat2Data = Nothing

        Try

            '
            ' Create and initialize the IDiscFormat2Data
            '
            discFormatData = New MsftDiscFormat2Data()
            If discFormatData.IsCurrentMediaSupported(discRecorder) = False Then

                lbl_MediaType.Text = "Media not supported!"
                _totalDiscSize = 0
                Return

            Else

                '
                ' Get the media type in the recorder
                '
                discFormatData.Recorder = discRecorder
                Dim mediaType As IMAPI_MEDIA_PHYSICAL_TYPE = discFormatData.CurrentPhysicalMediaType
                lbl_MediaType.Text = GetMediaTypeString(mediaType)

                '
                ' Create a file system and select the media type
                '
                fileSystemImage = New MsftFileSystemImage()
                fileSystemImage.ChooseImageDefaultsForMediaType(CType(mediaType, IMAPI_MEDIA_PHYSICAL_TYPE))

                '
                ' See if there are other recorded sessions on the disc
                '
                If discFormatData.MediaHeuristicallyBlank = False Then

                    fileSystemImage.MultisessionInterfaces = discFormatData.MultisessionInterfaces
                    fileSystemImage.ImportFileSystem()
                End If

                Dim freeMediaBlocks As Long = fileSystemImage.FreeMediaBlocks
                _totalDiscSize = 2048 * freeMediaBlocks

            End If

        Catch ex As System.Runtime.InteropServices.COMException

            MessageBox.Show(Me, ex.Message, "Detect Media Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            If discFormatData IsNot Nothing Then

                Marshal.ReleaseComObject(discFormatData)

            End If

            If fileSystemImage IsNot Nothing Then

                Marshal.ReleaseComObject(fileSystemImage)

            End If
        End Try


        UpdateCapacity()
    End Sub

    Private Sub cb_Devices_Format(sender As Object, e As ListControlConvertEventArgs) Handles cb_Devices.Format

        Dim discRecorder2 As IDiscRecorder2 = CType(e.ListItem, IDiscRecorder2)
        Dim devicePaths As String = String.Empty
        Dim volumePath As String = CStr(discRecorder2.VolumePathNames.GetValue(0))
        Dim volPath As String

        For Each volPath In discRecorder2.VolumePathNames

            If String.IsNullOrEmpty(devicePaths) = False Then

                devicePaths &= ","
            End If

            devicePaths &= volumePath
        Next

        e.Value = String.Format("{0} [{1}]", devicePaths, discRecorder2.ProductId)
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        'AddFiles()
        check_CloseMedia.Checked = False
        check_Eject.Checked = True
        '
        ' Determine the current recording devices
        '
        Dim discMaster As MsftDiscMaster2 = Nothing

        ' Try
        discMaster = New MsftDiscMaster2()

        If discMaster.IsSupportedEnvironment = False Then Return

        Dim uniqueRecorderId As String
        Dim discRecorder2 As MsftDiscRecorder2

        For Each uniqueRecorderId In discMaster

            discRecorder2 = New MsftDiscRecorder2()
            discRecorder2.InitializeDiscRecorder(uniqueRecorderId)
            cb_Devices.Items.Add(discRecorder2)
        Next

        If cb_Devices.Items.Count > 0 Then
            cb_Devices.SelectedIndex = 0
        End If
        'Catch ex As System.Runtime.InteropServices.COMException
        'MessageBox.Show(ex.Message, String.Format("Error:{0} - Please install IMAPI2", ex.ErrorCode), MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'Return
        'Finally
        'If discMaster IsNot Nothing Then
        'Marshal.ReleaseComObject(discMaster)
        'End If
        'End Try


        '
        ' Create the volume label based on the current date
        '
        Dim now1 As DateTime = DateTime.Now
        txt_Lable.Text = "SSPLBackup_" & now1.Year & "_" & now1.Month & "_" & now1.Day

        lbl_BurnStatus.Text = "Ready"

        '
        ' Select no verification, by default
        '
        cb_Verification.SelectedIndex = 0
        UpdateCapacity()
    End Sub

    Private Sub Burn_Worker_DoWork(sender As Object, e As DoWorkEventArgs) Handles Burn_Worker.DoWork
        Dim discRecorder As MsftDiscRecorder2 = Nothing
        Dim discFormatData As MsftDiscFormat2Data = Nothing

        Dim burnData As BurnData

        Dim fileSystem As System.Runtime.InteropServices.ComTypes.IStream = Nothing

        Dim burnVerification As IBurnVerification

        Try

            '
            ' Create and initialize the IDiscRecorder2 object
            '
            discRecorder = New MsftDiscRecorder2()
            burnData = CType(e.Argument, BurnData)
            discRecorder.InitializeDiscRecorder(burnData.uniqueRecorderId)

            '
            ' Create and initialize the IDiscFormat2Data
            '
            discFormatData = New MsftDiscFormat2Data
            With discFormatData
                .Recorder = discRecorder
                .ClientName = _ClientName
                .ForceMediaToBeClosed = _closeMedia
            End With

            '
            ' Set the verification level
            '
            burnVerification = CType(discFormatData, IBurnVerification)
            burnVerification.BurnVerificationLevel = _verificationLevel

            '
            ' Check if media is blank, (for RW media)
            '
            Dim multisessionInterfaces() As Object = Nothing
            If discFormatData.MediaHeuristicallyBlank = False Then

                multisessionInterfaces = CType(discFormatData.MultisessionInterfaces, Object())

            End If

            '
            ' Create the file system
            '


            If CreateMediaFileSystem(CType(discRecorder, IDiscRecorder2), multisessionInterfaces, fileSystem) = False Then

                e.Result = -1
                Return

            End If

            '
            ' add the Update event handler
            '
            AddHandler discFormatData.Update, AddressOf discFormatData_Update

            '
            ' Write the data here
            '
            'Try

            discFormatData.Write(CType(fileSystem, System.Runtime.InteropServices.ComTypes.IStream))
            e.Result = 0

            ' process user feedback to exception in Complete handler
            'Catch ex As COMException

            '    e.Result = ex.ErrorCode

            '    ' no UI in a worker thread
            '    'MessageBox.Show(ex.Message, "IDiscFormat2Data.Write failed", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            'Finally

            '    If FileSystem IsNot Nothing Then

            '        Marshal.FinalReleaseComObject(FileSystem)

            '    End If

            'End Try

        Finally

            If fileSystem IsNot Nothing Then

                Marshal.FinalReleaseComObject(fileSystem)

            End If

            '
            ' remove the Update event handler
            '
            RemoveHandler discFormatData.Update, AddressOf discFormatData_Update

            If _ejectMedia = True Then

                discRecorder.EjectMedia()

            End If

            ' process user feedback to exception in Complete handler
            'Catch ex As System.Runtime.InteropServices.COMException

            '    '
            '    ' If anything happens during the format, show the message
            '    '

            '    ' no UI in a worker thread
            '    'MessageBox.Show(ex.Message)
            '    e.Result = ex.ErrorCode



            If discRecorder IsNot Nothing Then

                Marshal.ReleaseComObject(discRecorder)

            End If

            If discFormatData IsNot Nothing Then

                Marshal.ReleaseComObject(discFormatData)

            End If

        End Try
    End Sub

    Private Sub Burner_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddFiles()
        check_CloseMedia.Checked = False
        check_Eject.Checked = True
        '
        ' Determine the current recording devices
        '
        Dim discMaster As MsftDiscMaster2 = Nothing

        Try
            discMaster = New MsftDiscMaster2()

            If discMaster.IsSupportedEnvironment = False Then Return

            Dim uniqueRecorderId As String
            Dim discRecorder2 As MsftDiscRecorder2

            For Each uniqueRecorderId In discMaster

                discRecorder2 = New MsftDiscRecorder2()
                discRecorder2.InitializeDiscRecorder(uniqueRecorderId)
                cb_Devices.Items.Add(discRecorder2)
            Next

            If cb_Devices.Items.Count > 0 Then
                cb_Devices.SelectedIndex = 0
            End If
        Catch ex As System.Runtime.InteropServices.COMException
            MessageBox.Show(ex.Message, String.Format("Error:{0} - Please install IMAPI2", ex.ErrorCode), MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return
        Finally
            If discMaster IsNot Nothing Then
                Marshal.ReleaseComObject(discMaster)
            End If
        End Try


        '
        ' Create the volume label based on the current date
        '
        Dim now1 As DateTime = DateTime.Now
        txt_Lable.Text = "SSPLBackup_" & now1.Year & "_" & now1.Month & "_" & now1.Day

        lbl_BurnStatus.Text = "Ready"

        '
        ' Select no verification, by default
        '
        cb_Verification.SelectedIndex = 0
        UpdateCapacity()
    End Sub
End Class