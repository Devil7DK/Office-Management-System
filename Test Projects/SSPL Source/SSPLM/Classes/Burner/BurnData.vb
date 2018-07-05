
Public Enum BURN_MEDIA_TASK
    BURN_MEDIA_TASK_FILE_SYSTEM
    BURN_MEDIA_TASK_WRITING
End Enum

Public Class BurnData

    Public uniqueRecorderId As String
    Public statusMessage As String
    Public task As BURN_MEDIA_TASK

    ' IDiscFormat2DataEventArgs Interface
    Public elapsedTime As Long          ' Elapsed time in seconds
    Public remainingTime As Long        ' Remaining time in seconds
    Public totalTime As Long            ' total estimated time in seconds

    ' IWriteEngine2EventArgs Interface
    Public currentAction As IMAPI2.Interop.IMAPI_FORMAT2_DATA_WRITE_ACTION
    Public startLba As Long             ' the starting lba of the current operation
    Public sectorCount As Long          ' the total sectors to write in the current operation
    Public lastReadLba As Long          ' the last read lba address
    Public lastWrittenLba As Long       ' the last written lba address
    Public totalSystemBuffer As Long    ' total size of the system buffer
    Public usedSystemBuffer As Long     ' size of used system buffer
    Public freeSystemBuffer As Long     ' size of the free system buffer

End Class

'End Namespace