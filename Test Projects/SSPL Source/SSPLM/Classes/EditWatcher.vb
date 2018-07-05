Public Class EditWatcher
    Friend ReportNumber As Boolean = False
    Friend Surname As Boolean = False
    Friend Fullname As Boolean = False
    Friend Age As Boolean = False
    Friend Gender As Boolean = False
    Friend Test As Boolean = False
    Friend Sites As Boolean = False
    Friend Diagnostics As Boolean = False
    Friend AddressLine1 As Boolean = False
    Friend AddressLine2 As Boolean = False
    Friend City As Boolean = False
    Friend State As Boolean = False
    Friend Mobile As Boolean = False
    Friend Email As Boolean = False
    Friend Doctor As Boolean = False
    Friend HospitalNumber As Boolean = False
    Friend PreviousReport As Boolean = False
    Friend ReceivedDate As Boolean = False
    Friend ReportedDate As Boolean = False
    Friend Report As Boolean = False
    Friend Notes As Boolean = False
    Friend Image1 As Boolean = False
    Friend Image2 As Boolean = False
    Friend Image3 As Boolean = False
    Friend Image4 As Boolean = False
    Friend Function GetHistory() As String
        Dim RS As String = ""
        If ReportNumber = True Then
            RS &= vbNewLine & "ReportNumber Edited."
        End If
        If Surname = True Then
            RS &= vbNewLine & "Surname Edited."
        End If
        If Fullname = True Then
            RS &= vbNewLine & "Fullname Edited."
        End If
        If Age = True Then
            RS &= vbNewLine & "Age Edited."
        End If
        If Gender = True Then
            RS &= vbNewLine & "Gender Edited."
        End If
        If Test = True Then
            RS &= vbNewLine & "Test Edited."
        End If
        If Sites = True Then
            RS &= vbNewLine & "Sites Edited."
        End If
        If Diagnostics = True Then
            RS &= vbNewLine & "Diagnostics Edited."
        End If
        If AddressLine1 = True Then
            RS &= vbNewLine & "AddressLine1 Edited."
        End If
        If AddressLine2 = True Then
            RS &= vbNewLine & "AddressLine2 Edited."
        End If
        If City = True Then
            RS &= vbNewLine & "City Edited."
        End If
        If State = True Then
            RS &= vbNewLine & "State Edited."
        End If
        If Mobile = True Then
            RS &= vbNewLine & "Mobile Edited."
        End If
        If Email = True Then
            RS &= vbNewLine & "Email Edited."
        End If
        If Doctor = True Then
            RS &= vbNewLine & "Doctor Edited."
        End If
        If HospitalNumber = True Then
            RS &= vbNewLine & "HospitalNumber Edited."
        End If
        If PreviousReport = True Then
            RS &= vbNewLine & "PreviousReportNumber Edited."
        End If
        If ReceivedDate = True Then
            RS &= vbNewLine & "ReceivedDate Edited."
        End If
        If ReportedDate = True Then
            RS &= vbNewLine & "ReportedDate Edited."
        End If
        If Report = True Then
            RS &= vbNewLine & "Report Edited."
        End If
        If Notes = True Then
            RS &= vbNewLine & "Notes Edited."
        End If
        If Image1 = True Then
            RS &= vbNewLine & "Image1 Edited."
        End If
        If Image2 = True Then
            RS &= vbNewLine & "Image2 Edited."
        End If
        If Image3 = True Then
            RS &= vbNewLine & "Image3 Edited."
        End If
        If Image4 = True Then
            RS &= vbNewLine & "Image4 Edited."
        End If
        Return RS
    End Function
End Class
