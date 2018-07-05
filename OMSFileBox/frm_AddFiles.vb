Imports GlobalCode
Imports System.Data.SqlClient
Imports System.Collections.Specialized
Imports System.ComponentModel

Public Class frm_AddFiles
    Dim prn As frm_Drop

    Sub New(ByVal DropedFiles As StringCollection, ByVal DropedFolders As StringCollection, Parent As frm_Drop)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DropedFiles = DropedFiles
        Me.DropedDirectories = DropedFolders
        If DropedFiles.Count <= 0 Then
            np_Sent.PageVisible = False
        End If
        Me.prn = Parent
    End Sub
    Dim DropedFiles As New StringCollection
    Dim DropedDirectories As New StringCollection
    Public ConnectionString As String = String.Format("Server={0};Database={1};User Id={2};Password={3};Application Name=Office Management System;Pooling={4};", My.Settings.Server, My.Settings.Database, My.Settings.UserID, GlobalCode.DecryptString(My.Settings.Password), My.Settings.Pooling)
    Dim Jobs As New System.ComponentModel.BindingList(Of Job)
    Dim Clients As New System.ComponentModel.BindingList(Of Client)
    Dim Users As New System.ComponentModel.BindingList(Of User)
    Private Sub frm_AddFiles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmb_Job.Properties.DataSource = LoadJob(ConnectionString)
        Jobs = cmb_Job.Properties.DataSource
        cmb_Clients.Properties.DataSource = DatabaseIO.LoadClients(ConnectionString, Jobs)
        cmb_Users.Properties.DataSource = LoadUsers(ConnectionString)
        cmb_Users.Properties.DisplayMember = "Username"
        cmb_Users.Properties.ValueMember = "Username"
        Users = cmb_Users.Properties.DataSource
        Clients = cmb_Clients.Properties.DataSource
        cmb_Works.Properties.DataSource = LoadWorks(ConnectionString, Clients, Jobs, Users)
    End Sub
    Delegate Sub StringArgReturningVoidDelegate([text] As String)
    Private Sub SetStatusText(ByVal [text] As String)
        If Me.lbl_Status_FileTrans.InvokeRequired Then
            Dim d As New StringArgReturningVoidDelegate(AddressOf SetStatusText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.lbl_Status_FileTrans.Text = [text]
        End If
    End Sub
    Delegate Sub SetMaxVoidDelegate([max] As Integer)
    Private Sub SetMax(ByVal [max] As Integer)
        If Me.prog_total.InvokeRequired Then
            Dim d As New SetMaxVoidDelegate(AddressOf SetMax)
            Me.Invoke(d, New Object() {[max]})
        Else
            Me.prog_total.Properties.Maximum = [max]
        End If
    End Sub
    Delegate Sub SetValueVoidDelegate([value] As Integer)
    Private Sub SetValue(ByVal [value] As Integer)
        If Me.prog_total.InvokeRequired Then
            Dim d As New SetMaxVoidDelegate(AddressOf SetValue)
            Me.Invoke(d, New Object() {[value]})
        Else
            Me.prog_total.Position = [value]
        End If
    End Sub
    
    Private Sub btn_Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Send.Click
        '  btn_Send.Enabled = False
        ' Dim t As New Threading.Thread(AddressOf Send)
        't.Start()
    End Sub
End Class