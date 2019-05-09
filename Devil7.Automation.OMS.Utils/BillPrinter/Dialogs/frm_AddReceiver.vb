Public Class frm_AddReceiver

#Region "Variables"
    Dim ExistingPAN As List(Of String)
#End Region

#Region "Properties"
    Property Receiver As [Lib].Objects.Receiver
#End Region

#Region "Constructor"
    Sub New(ByVal ExistingPAN As List(Of String))
        InitializeComponent()

        Me.ExistingPAN = ExistingPAN
    End Sub
#End Region

#Region "Events"
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Dim InputControls As New Dictionary(Of String, DevExpress.XtraEditors.BaseEdit)
        InputControls.Add("PAN", txt_PAN)
        InputControls.Add("Name", txt_Name)
        InputControls.Add("Legal Name", txt_LegalName)
        InputControls.Add("Mobile", txt_Mobile)
        InputControls.Add("Phone Number", txt_Phone)
        InputControls.Add("E-Mail ID", txt_EMail)
        InputControls.Add("Address Line 1", txt_AddressLine1)
        InputControls.Add("Address Line 2", txt_AddressLine2)
        InputControls.Add("City", txt_City)
        InputControls.Add("PIN Code", txt_PINCode)
        InputControls.Add("State", txt_State)
        InputControls.Add("GSTIN", txt_GSTIN)

        For Each Key As String In InputControls.Keys
            Dim Edit As DevExpress.XtraEditors.BaseEdit = InputControls.Item(Key)
            If Edit Is Nothing OrElse Edit.Text.Trim = "" Then
                DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("{0} can't be empty!", Key), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next

        If Not [Lib].Utils.isValidPAN(txt_PAN.Text) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("PAN is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        If ExistingPAN.Contains(txt_PAN.Text.Trim) Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Receiver with PAN already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Me.Receiver = New [Lib].Objects.Receiver("", txt_Name.Text, txt_LegalName.Text, txt_PAN.Text, txt_Mobile.Text, txt_Phone.Text, txt_EMail.Text, txt_AddressLine1.Text, txt_AddressLine2.Text, txt_City.Text, txt_PINCode.Text, txt_State.Text, txt_State.SelectedIndex + 1, txt_GSTIN.Text)
        [Lib].Database.Receivers.AddNew(Me.Receiver)
        DialogResult = DialogResult.OK
        Close()
    End Sub
#End Region

End Class