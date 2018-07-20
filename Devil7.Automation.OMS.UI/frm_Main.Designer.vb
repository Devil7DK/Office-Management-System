<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition5 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition6 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan3 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan4 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan5 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan6 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement10 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement11 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement12 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.TVC_Client_Photo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Client_Name = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Client_PAN = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Client_Type = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Client_AddressLine1 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Client_AddressLine2 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Client_District = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Client_Pincode = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Name = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_UserType = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Mobile = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.TVC_Photo = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
        Me.btn_EditProfile = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_ChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Exit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AddClient = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_EditClient = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RemoveClient = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_AddWork = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_EditWork = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RemoveWork = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RefreshWork = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RefreshClients = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RefreshJobs = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RefreshUsers = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Clients_CardView = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Clients_DetailsView = New DevExpress.XtraBars.BarButtonItem()
        Me.grp_btn_Clients_View = New DevExpress.XtraBars.BarButtonGroup()
        Me.btn_RefreshHome = New DevExpress.XtraBars.BarButtonItem()
        Me.rp_Edit = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.rpg_Home = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Workbook = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Clients = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpg_Jobs = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btn_NewJob = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_EditJob = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RemoveJob = New DevExpress.XtraBars.BarButtonItem()
        Me.rpg_Users = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btn_AddUser = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_EditUser = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_RemoveUser = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_ResetPassword = New DevExpress.XtraBars.BarButtonItem()
        Me.rpg_Skin = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SkinSelector = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.MainPane = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.np_Home = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ProgressPanel_Home = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.gc_Home = New DevExpress.XtraGrid.GridControl()
        Me.gv_Home = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.np_Utilities = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ProgressPanel_Utilites = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.Panel_Utilities = New DevExpress.XtraEditors.TileControl()
        Me.np_Workbook = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ProgressPanel_Workbook = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.gc_WorkBook = New DevExpress.XtraGrid.GridControl()
        Me.gv_WorkBook = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.np_Clients = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ProgressPanel_Clients = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.gc_Clients = New DevExpress.XtraGrid.GridControl()
        Me.tv_Clients = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.gv_Clients = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.np_Jobs = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ProgressPanel_Jobs = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.gc_Jobs = New DevExpress.XtraGrid.GridControl()
        Me.gv_Jobs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.np_Users = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.ProgressPanel_Users = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.gc_Users = New DevExpress.XtraGrid.GridControl()
        Me.tv_Users = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.Loader_Users = New System.ComponentModel.BackgroundWorker()
        Me.Loader_Jobs = New System.ComponentModel.BackgroundWorker()
        Me.Loader_Clients = New System.ComponentModel.BackgroundWorker()
        Me.Loader_Workbook = New System.ComponentModel.BackgroundWorker()
        Me.Loader_Home = New System.ComponentModel.BackgroundWorker()
        Me.Loader_Utilities = New System.ComponentModel.BackgroundWorker()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPane.SuspendLayout()
        Me.np_Home.SuspendLayout()
        CType(Me.gc_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.np_Utilities.SuspendLayout()
        Me.np_Workbook.SuspendLayout()
        CType(Me.gc_WorkBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_WorkBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.np_Clients.SuspendLayout()
        CType(Me.gc_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tv_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Clients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.np_Jobs.SuspendLayout()
        CType(Me.gc_Jobs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Jobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.np_Users.SuspendLayout()
        CType(Me.gc_Users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tv_Users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TVC_Client_Photo
        '
        Me.TVC_Client_Photo.Caption = "Photo"
        Me.TVC_Client_Photo.FieldName = "Photo"
        Me.TVC_Client_Photo.Name = "TVC_Client_Photo"
        Me.TVC_Client_Photo.Visible = True
        Me.TVC_Client_Photo.VisibleIndex = 0
        '
        'TVC_Client_Name
        '
        Me.TVC_Client_Name.Caption = "Name"
        Me.TVC_Client_Name.FieldName = "Name"
        Me.TVC_Client_Name.Name = "TVC_Client_Name"
        Me.TVC_Client_Name.Visible = True
        Me.TVC_Client_Name.VisibleIndex = 1
        '
        'TVC_Client_PAN
        '
        Me.TVC_Client_PAN.Caption = "PAN"
        Me.TVC_Client_PAN.FieldName = "PAN"
        Me.TVC_Client_PAN.Name = "TVC_Client_PAN"
        Me.TVC_Client_PAN.Visible = True
        Me.TVC_Client_PAN.VisibleIndex = 2
        '
        'TVC_Client_Type
        '
        Me.TVC_Client_Type.Caption = "Type"
        Me.TVC_Client_Type.FieldName = "Type"
        Me.TVC_Client_Type.Name = "TVC_Client_Type"
        Me.TVC_Client_Type.Visible = True
        Me.TVC_Client_Type.VisibleIndex = 3
        '
        'TVC_Client_AddressLine1
        '
        Me.TVC_Client_AddressLine1.Caption = "Address Line 1"
        Me.TVC_Client_AddressLine1.FieldName = "AddressLine1"
        Me.TVC_Client_AddressLine1.Name = "TVC_Client_AddressLine1"
        Me.TVC_Client_AddressLine1.Visible = True
        Me.TVC_Client_AddressLine1.VisibleIndex = 4
        '
        'TVC_Client_AddressLine2
        '
        Me.TVC_Client_AddressLine2.Caption = "Address Line 2"
        Me.TVC_Client_AddressLine2.FieldName = "AddressLine2"
        Me.TVC_Client_AddressLine2.Name = "TVC_Client_AddressLine2"
        Me.TVC_Client_AddressLine2.Visible = True
        Me.TVC_Client_AddressLine2.VisibleIndex = 5
        '
        'TVC_Client_District
        '
        Me.TVC_Client_District.Caption = "District"
        Me.TVC_Client_District.FieldName = "District"
        Me.TVC_Client_District.Name = "TVC_Client_District"
        Me.TVC_Client_District.Visible = True
        Me.TVC_Client_District.VisibleIndex = 7
        '
        'TVC_Client_Pincode
        '
        Me.TVC_Client_Pincode.Caption = "Pincode"
        Me.TVC_Client_Pincode.FieldName = "PinCode"
        Me.TVC_Client_Pincode.Name = "TVC_Client_Pincode"
        Me.TVC_Client_Pincode.Visible = True
        Me.TVC_Client_Pincode.VisibleIndex = 6
        '
        'TVC_Name
        '
        Me.TVC_Name.Caption = "Name"
        Me.TVC_Name.FieldName = "Username"
        Me.TVC_Name.Name = "TVC_Name"
        Me.TVC_Name.Visible = True
        Me.TVC_Name.VisibleIndex = 0
        '
        'TVC_UserType
        '
        Me.TVC_UserType.Caption = "Type"
        Me.TVC_UserType.FieldName = "UserType"
        Me.TVC_UserType.Name = "TVC_UserType"
        Me.TVC_UserType.Visible = True
        Me.TVC_UserType.VisibleIndex = 1
        '
        'TVC_Mobile
        '
        Me.TVC_Mobile.Caption = "Mobile"
        Me.TVC_Mobile.FieldName = "Mobile"
        Me.TVC_Mobile.Name = "TVC_Mobile"
        Me.TVC_Mobile.Visible = True
        Me.TVC_Mobile.VisibleIndex = 2
        '
        'TVC_Photo
        '
        Me.TVC_Photo.Caption = "Photo"
        Me.TVC_Photo.FieldName = "Photo"
        Me.TVC_Photo.Name = "TVC_Photo"
        Me.TVC_Photo.Visible = True
        Me.TVC_Photo.VisibleIndex = 3
        '
        'RibbonControl
        '
        Me.RibbonControl.ApplicationButtonDropDownControl = Me.RibbonMenu
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.btn_AddClient, Me.btn_EditClient, Me.btn_RemoveClient, Me.btn_AddWork, Me.btn_EditWork, Me.btn_RemoveWork, Me.btn_RefreshWork, Me.btn_RefreshClients, Me.btn_RefreshJobs, Me.btn_RefreshUsers, Me.btn_EditProfile, Me.btn_ChangePassword, Me.btn_Exit, Me.btn_Clients_CardView, Me.btn_Clients_DetailsView, Me.grp_btn_Clients_View, Me.btn_RefreshHome})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 33
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.rp_Edit})
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1285, 143)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'RibbonMenu
        '
        Me.RibbonMenu.ItemLinks.Add(Me.btn_EditProfile)
        Me.RibbonMenu.ItemLinks.Add(Me.btn_ChangePassword)
        Me.RibbonMenu.ItemLinks.Add(Me.btn_Exit)
        Me.RibbonMenu.Name = "RibbonMenu"
        Me.RibbonMenu.Ribbon = Me.RibbonControl
        '
        'btn_EditProfile
        '
        Me.btn_EditProfile.Caption = "Edit Profile"
        Me.btn_EditProfile.Description = "Edit your user details."
        Me.btn_EditProfile.Id = 19
        Me.btn_EditProfile.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.edit_profile
        Me.btn_EditProfile.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.edit_profile
        Me.btn_EditProfile.Name = "btn_EditProfile"
        '
        'btn_ChangePassword
        '
        Me.btn_ChangePassword.Caption = "Change Password"
        Me.btn_ChangePassword.Description = "Change your login password of this application"
        Me.btn_ChangePassword.Id = 20
        Me.btn_ChangePassword.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.edit_password
        Me.btn_ChangePassword.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.edit_password
        Me.btn_ChangePassword.Name = "btn_ChangePassword"
        '
        'btn_Exit
        '
        Me.btn_Exit.Caption = "Exit"
        Me.btn_Exit.Description = "Logout & Close Application"
        Me.btn_Exit.Id = 21
        Me.btn_Exit.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources._exit
        Me.btn_Exit.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources._exit
        Me.btn_Exit.Name = "btn_Exit"
        '
        'btn_AddClient
        '
        Me.btn_AddClient.Caption = "Add New Client"
        Me.btn_AddClient.Id = 9
        Me.btn_AddClient.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.client_add
        Me.btn_AddClient.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.client_add
        Me.btn_AddClient.Name = "btn_AddClient"
        '
        'btn_EditClient
        '
        Me.btn_EditClient.Caption = "Edit Client"
        Me.btn_EditClient.Id = 10
        Me.btn_EditClient.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.client_edit
        Me.btn_EditClient.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.client_edit
        Me.btn_EditClient.Name = "btn_EditClient"
        '
        'btn_RemoveClient
        '
        Me.btn_RemoveClient.Caption = "Remove Client"
        Me.btn_RemoveClient.Id = 11
        Me.btn_RemoveClient.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.client_remove
        Me.btn_RemoveClient.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.client_remove
        Me.btn_RemoveClient.Name = "btn_RemoveClient"
        '
        'btn_AddWork
        '
        Me.btn_AddWork.Caption = "Add New Work"
        Me.btn_AddWork.Id = 12
        Me.btn_AddWork.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.calendar_new
        Me.btn_AddWork.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.calendar_new
        Me.btn_AddWork.Name = "btn_AddWork"
        '
        'btn_EditWork
        '
        Me.btn_EditWork.Caption = "Edit Work"
        Me.btn_EditWork.Id = 13
        Me.btn_EditWork.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.calendar_edit
        Me.btn_EditWork.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.calendar_edit
        Me.btn_EditWork.Name = "btn_EditWork"
        '
        'btn_RemoveWork
        '
        Me.btn_RemoveWork.Caption = "Remove Work"
        Me.btn_RemoveWork.Id = 14
        Me.btn_RemoveWork.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.calendar_remove
        Me.btn_RemoveWork.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.calendar_remove
        Me.btn_RemoveWork.Name = "btn_RemoveWork"
        '
        'btn_RefreshWork
        '
        Me.btn_RefreshWork.Caption = "Refresh Workbook"
        Me.btn_RefreshWork.Id = 15
        Me.btn_RefreshWork.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshWork.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshWork.Name = "btn_RefreshWork"
        '
        'btn_RefreshClients
        '
        Me.btn_RefreshClients.Caption = "Refresh Clients"
        Me.btn_RefreshClients.Id = 16
        Me.btn_RefreshClients.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshClients.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshClients.Name = "btn_RefreshClients"
        '
        'btn_RefreshJobs
        '
        Me.btn_RefreshJobs.Caption = "Refresh Jobs"
        Me.btn_RefreshJobs.Id = 17
        Me.btn_RefreshJobs.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshJobs.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshJobs.Name = "btn_RefreshJobs"
        '
        'btn_RefreshUsers
        '
        Me.btn_RefreshUsers.Caption = "Refresh Users"
        Me.btn_RefreshUsers.Id = 18
        Me.btn_RefreshUsers.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshUsers.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshUsers.Name = "btn_RefreshUsers"
        '
        'btn_Clients_CardView
        '
        Me.btn_Clients_CardView.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btn_Clients_CardView.Caption = "Card View"
        Me.btn_Clients_CardView.Id = 23
        Me.btn_Clients_CardView.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.card_view
        Me.btn_Clients_CardView.Name = "btn_Clients_CardView"
        '
        'btn_Clients_DetailsView
        '
        Me.btn_Clients_DetailsView.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btn_Clients_DetailsView.Caption = "Details View"
        Me.btn_Clients_DetailsView.Id = 24
        Me.btn_Clients_DetailsView.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.details_view
        Me.btn_Clients_DetailsView.Name = "btn_Clients_DetailsView"
        '
        'grp_btn_Clients_View
        '
        Me.grp_btn_Clients_View.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.grp_btn_Clients_View.Id = 25
        Me.grp_btn_Clients_View.ItemLinks.Add(Me.btn_Clients_DetailsView)
        Me.grp_btn_Clients_View.ItemLinks.Add(Me.btn_Clients_CardView)
        Me.grp_btn_Clients_View.Name = "grp_btn_Clients_View"
        '
        'btn_RefreshHome
        '
        Me.btn_RefreshHome.Caption = "Refresh Home"
        Me.btn_RefreshHome.Id = 28
        Me.btn_RefreshHome.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshHome.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.refresh
        Me.btn_RefreshHome.Name = "btn_RefreshHome"
        '
        'rp_Edit
        '
        Me.rp_Edit.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpg_Home, Me.rpg_Workbook, Me.rpg_Clients, Me.rpg_Jobs, Me.rpg_Users, Me.rpg_Skin})
        Me.rp_Edit.Name = "rp_Edit"
        Me.rp_Edit.Text = "Edit"
        '
        'rpg_Home
        '
        Me.rpg_Home.ItemLinks.Add(Me.btn_RefreshHome)
        Me.rpg_Home.Name = "rpg_Home"
        Me.rpg_Home.ShowCaptionButton = False
        Me.rpg_Home.Text = "Actions"
        '
        'rpg_Workbook
        '
        Me.rpg_Workbook.ItemLinks.Add(Me.btn_RefreshWork)
        Me.rpg_Workbook.ItemLinks.Add(Me.btn_AddWork, True)
        Me.rpg_Workbook.ItemLinks.Add(Me.btn_EditWork)
        Me.rpg_Workbook.ItemLinks.Add(Me.btn_RemoveWork)
        Me.rpg_Workbook.Name = "rpg_Workbook"
        Me.rpg_Workbook.ShowCaptionButton = False
        Me.rpg_Workbook.Text = "Actions"
        '
        'rpg_Clients
        '
        Me.rpg_Clients.ItemLinks.Add(Me.btn_RefreshClients)
        Me.rpg_Clients.ItemLinks.Add(Me.btn_AddClient, True)
        Me.rpg_Clients.ItemLinks.Add(Me.btn_EditClient)
        Me.rpg_Clients.ItemLinks.Add(Me.btn_RemoveClient)
        Me.rpg_Clients.Name = "rpg_Clients"
        Me.rpg_Clients.ShowCaptionButton = False
        Me.rpg_Clients.Text = "Actions"
        '
        'rpg_Jobs
        '
        Me.rpg_Jobs.ItemLinks.Add(Me.btn_RefreshJobs)
        Me.rpg_Jobs.ItemLinks.Add(Me.btn_NewJob, True)
        Me.rpg_Jobs.ItemLinks.Add(Me.btn_EditJob)
        Me.rpg_Jobs.ItemLinks.Add(Me.btn_RemoveJob)
        Me.rpg_Jobs.Name = "rpg_Jobs"
        Me.rpg_Jobs.ShowCaptionButton = False
        Me.rpg_Jobs.Text = "Actions"
        '
        'btn_NewJob
        '
        Me.btn_NewJob.Caption = "Define New Job"
        Me.btn_NewJob.Id = 2
        Me.btn_NewJob.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.form_new
        Me.btn_NewJob.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.form_new
        Me.btn_NewJob.Name = "btn_NewJob"
        '
        'btn_EditJob
        '
        Me.btn_EditJob.Caption = "Edit Job"
        Me.btn_EditJob.Id = 3
        Me.btn_EditJob.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.form_edit
        Me.btn_EditJob.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.form_edit
        Me.btn_EditJob.Name = "btn_EditJob"
        '
        'btn_RemoveJob
        '
        Me.btn_RemoveJob.Caption = "Remove Job"
        Me.btn_RemoveJob.Id = 4
        Me.btn_RemoveJob.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.form_delete
        Me.btn_RemoveJob.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.form_delete
        Me.btn_RemoveJob.Name = "btn_RemoveJob"
        '
        'rpg_Users
        '
        Me.rpg_Users.ItemLinks.Add(Me.btn_RefreshUsers)
        Me.rpg_Users.ItemLinks.Add(Me.btn_AddUser, True)
        Me.rpg_Users.ItemLinks.Add(Me.btn_EditUser)
        Me.rpg_Users.ItemLinks.Add(Me.btn_RemoveUser)
        Me.rpg_Users.ItemLinks.Add(Me.btn_ResetPassword, True)
        Me.rpg_Users.Name = "rpg_Users"
        Me.rpg_Users.ShowCaptionButton = False
        Me.rpg_Users.Text = "Actions"
        '
        'btn_AddUser
        '
        Me.btn_AddUser.Caption = "Add New User"
        Me.btn_AddUser.Id = 5
        Me.btn_AddUser.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_add
        Me.btn_AddUser.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_add
        Me.btn_AddUser.Name = "btn_AddUser"
        '
        'btn_EditUser
        '
        Me.btn_EditUser.Caption = "Edit User"
        Me.btn_EditUser.Id = 6
        Me.btn_EditUser.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_edit
        Me.btn_EditUser.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_edit
        Me.btn_EditUser.Name = "btn_EditUser"
        '
        'btn_RemoveUser
        '
        Me.btn_RemoveUser.Caption = "Remove User"
        Me.btn_RemoveUser.Id = 7
        Me.btn_RemoveUser.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_remove
        Me.btn_RemoveUser.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_remove
        Me.btn_RemoveUser.Name = "btn_RemoveUser"
        '
        'btn_ResetPassword
        '
        Me.btn_ResetPassword.Caption = "Reset Password"
        Me.btn_ResetPassword.Id = 8
        Me.btn_ResetPassword.ImageOptions.Image = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_reset_password
        Me.btn_ResetPassword.ImageOptions.LargeImage = Global.Devil7.Automation.OMS.UI.My.Resources.Resources.user_reset_password
        Me.btn_ResetPassword.Name = "btn_ResetPassword"
        '
        'rpg_Skin
        '
        Me.rpg_Skin.ItemLinks.Add(Me.SkinSelector)
        Me.rpg_Skin.Name = "rpg_Skin"
        Me.rpg_Skin.ShowCaptionButton = False
        Me.rpg_Skin.Text = "Theme"
        '
        'SkinSelector
        '
        Me.SkinSelector.Caption = "SkinRibbonGalleryBarItem1"
        Me.SkinSelector.Id = 1
        Me.SkinSelector.Name = "SkinSelector"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.grp_btn_Clients_View)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 418)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(1285, 31)
        '
        'MainPane
        '
        Me.MainPane.Controls.Add(Me.np_Home)
        Me.MainPane.Controls.Add(Me.np_Utilities)
        Me.MainPane.Controls.Add(Me.np_Workbook)
        Me.MainPane.Controls.Add(Me.np_Clients)
        Me.MainPane.Controls.Add(Me.np_Jobs)
        Me.MainPane.Controls.Add(Me.np_Users)
        Me.MainPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPane.Location = New System.Drawing.Point(0, 143)
        Me.MainPane.Name = "MainPane"
        Me.MainPane.PageProperties.ShowCollapseButton = False
        Me.MainPane.PageProperties.ShowExpandButton = False
        Me.MainPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.np_Home, Me.np_Workbook, Me.np_Clients, Me.np_Jobs, Me.np_Users, Me.np_Utilities})
        Me.MainPane.RegularSize = New System.Drawing.Size(1285, 275)
        Me.MainPane.SelectedPage = Me.np_Utilities
        Me.MainPane.Size = New System.Drawing.Size(1285, 275)
        Me.MainPane.TabIndex = 2
        Me.MainPane.Text = "NavigationPane1"
        '
        'np_Home
        '
        Me.np_Home.Caption = "Home"
        Me.np_Home.Controls.Add(Me.ProgressPanel_Home)
        Me.np_Home.Controls.Add(Me.gc_Home)
        Me.np_Home.Name = "np_Home"
        Me.np_Home.Size = New System.Drawing.Size(696, 229)
        '
        'ProgressPanel_Home
        '
        Me.ProgressPanel_Home.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Home.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Home.BarAnimationElementThickness = 2
        Me.ProgressPanel_Home.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Home.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel_Home.Name = "ProgressPanel_Home"
        Me.ProgressPanel_Home.Size = New System.Drawing.Size(696, 229)
        Me.ProgressPanel_Home.TabIndex = 6
        '
        'gc_Home
        '
        Me.gc_Home.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Home.Location = New System.Drawing.Point(0, 0)
        Me.gc_Home.MainView = Me.gv_Home
        Me.gc_Home.MenuManager = Me.RibbonControl
        Me.gc_Home.Name = "gc_Home"
        Me.gc_Home.Size = New System.Drawing.Size(696, 229)
        Me.gc_Home.TabIndex = 0
        Me.gc_Home.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Home})
        '
        'gv_Home
        '
        Me.gv_Home.GridControl = Me.gc_Home
        Me.gv_Home.Name = "gv_Home"
        Me.gv_Home.OptionsBehavior.Editable = False
        Me.gv_Home.OptionsBehavior.ReadOnly = True
        '
        'np_Utilities
        '
        Me.np_Utilities.Caption = "Utilities"
        Me.np_Utilities.Controls.Add(Me.ProgressPanel_Utilites)
        Me.np_Utilities.Controls.Add(Me.Panel_Utilities)
        Me.np_Utilities.Name = "np_Utilities"
        Me.np_Utilities.Size = New System.Drawing.Size(1203, 229)
        '
        'ProgressPanel_Utilites
        '
        Me.ProgressPanel_Utilites.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Utilites.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Utilites.BarAnimationElementThickness = 2
        Me.ProgressPanel_Utilites.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Utilites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Utilites.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel_Utilites.Name = "ProgressPanel_Utilites"
        Me.ProgressPanel_Utilites.Size = New System.Drawing.Size(1203, 229)
        Me.ProgressPanel_Utilites.TabIndex = 3
        '
        'Panel_Utilities
        '
        Me.Panel_Utilities.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Utilities.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Utilities.MaxId = 5
        Me.Panel_Utilities.Name = "Panel_Utilities"
        Me.Panel_Utilities.Size = New System.Drawing.Size(1203, 229)
        Me.Panel_Utilities.TabIndex = 1
        Me.Panel_Utilities.Text = "Utilities"
        '
        'np_Workbook
        '
        Me.np_Workbook.Caption = "Workbook"
        Me.np_Workbook.Controls.Add(Me.ProgressPanel_Workbook)
        Me.np_Workbook.Controls.Add(Me.gc_WorkBook)
        Me.np_Workbook.Name = "np_Workbook"
        Me.np_Workbook.Size = New System.Drawing.Size(778, 275)
        '
        'ProgressPanel_Workbook
        '
        Me.ProgressPanel_Workbook.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Workbook.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Workbook.BarAnimationElementThickness = 2
        Me.ProgressPanel_Workbook.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Workbook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Workbook.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel_Workbook.Name = "ProgressPanel_Workbook"
        Me.ProgressPanel_Workbook.Size = New System.Drawing.Size(778, 275)
        Me.ProgressPanel_Workbook.TabIndex = 5
        '
        'gc_WorkBook
        '
        Me.gc_WorkBook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_WorkBook.Location = New System.Drawing.Point(0, 0)
        Me.gc_WorkBook.MainView = Me.gv_WorkBook
        Me.gc_WorkBook.MenuManager = Me.RibbonControl
        Me.gc_WorkBook.Name = "gc_WorkBook"
        Me.gc_WorkBook.Size = New System.Drawing.Size(778, 275)
        Me.gc_WorkBook.TabIndex = 1
        Me.gc_WorkBook.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_WorkBook})
        '
        'gv_WorkBook
        '
        Me.gv_WorkBook.GridControl = Me.gc_WorkBook
        Me.gv_WorkBook.Name = "gv_WorkBook"
        Me.gv_WorkBook.OptionsBehavior.Editable = False
        Me.gv_WorkBook.OptionsBehavior.ReadOnly = True
        '
        'np_Clients
        '
        Me.np_Clients.Caption = "Clients"
        Me.np_Clients.Controls.Add(Me.ProgressPanel_Clients)
        Me.np_Clients.Controls.Add(Me.gc_Clients)
        Me.np_Clients.Name = "np_Clients"
        Me.np_Clients.Size = New System.Drawing.Size(778, 275)
        '
        'ProgressPanel_Clients
        '
        Me.ProgressPanel_Clients.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Clients.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Clients.BarAnimationElementThickness = 2
        Me.ProgressPanel_Clients.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Clients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Clients.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel_Clients.Name = "ProgressPanel_Clients"
        Me.ProgressPanel_Clients.Size = New System.Drawing.Size(778, 275)
        Me.ProgressPanel_Clients.TabIndex = 4
        '
        'gc_Clients
        '
        Me.gc_Clients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Clients.Location = New System.Drawing.Point(0, 0)
        Me.gc_Clients.MainView = Me.tv_Clients
        Me.gc_Clients.MenuManager = Me.RibbonControl
        Me.gc_Clients.Name = "gc_Clients"
        Me.gc_Clients.Size = New System.Drawing.Size(778, 275)
        Me.gc_Clients.TabIndex = 1
        Me.gc_Clients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tv_Clients, Me.gv_Clients})
        '
        'tv_Clients
        '
        Me.tv_Clients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TVC_Client_Photo, Me.TVC_Client_Name, Me.TVC_Client_PAN, Me.TVC_Client_Type, Me.TVC_Client_AddressLine1, Me.TVC_Client_AddressLine2, Me.TVC_Client_District, Me.TVC_Client_Pincode})
        Me.tv_Clients.GridControl = Me.gc_Clients
        Me.tv_Clients.Name = "tv_Clients"
        Me.tv_Clients.OptionsBehavior.ReadOnly = True
        Me.tv_Clients.OptionsTiles.ItemSize = New System.Drawing.Size(332, 134)
        Me.tv_Clients.OptionsTiles.RowCount = 0
        TableColumnDefinition1.Length.Value = 73.0R
        TableColumnDefinition2.Length.Value = 160.0R
        TableColumnDefinition2.PaddingLeft = 10
        TableColumnDefinition3.Length.Value = 75.0R
        Me.tv_Clients.TileColumns.Add(TableColumnDefinition1)
        Me.tv_Clients.TileColumns.Add(TableColumnDefinition2)
        Me.tv_Clients.TileColumns.Add(TableColumnDefinition3)
        Me.tv_Clients.TileRows.Add(TableRowDefinition1)
        Me.tv_Clients.TileRows.Add(TableRowDefinition2)
        Me.tv_Clients.TileRows.Add(TableRowDefinition3)
        Me.tv_Clients.TileRows.Add(TableRowDefinition4)
        Me.tv_Clients.TileRows.Add(TableRowDefinition5)
        Me.tv_Clients.TileRows.Add(TableRowDefinition6)
        TableSpan1.ColumnIndex = 1
        TableSpan1.ColumnSpan = 2
        TableSpan2.RowSpan = 6
        TableSpan3.ColumnIndex = 1
        TableSpan3.ColumnSpan = 2
        TableSpan3.RowIndex = 1
        TableSpan4.ColumnIndex = 1
        TableSpan4.ColumnSpan = 2
        TableSpan4.RowIndex = 2
        TableSpan5.ColumnIndex = 1
        TableSpan5.ColumnSpan = 2
        TableSpan5.RowIndex = 3
        TableSpan6.ColumnIndex = 1
        TableSpan6.ColumnSpan = 2
        TableSpan6.RowIndex = 4
        Me.tv_Clients.TileSpans.Add(TableSpan1)
        Me.tv_Clients.TileSpans.Add(TableSpan2)
        Me.tv_Clients.TileSpans.Add(TableSpan3)
        Me.tv_Clients.TileSpans.Add(TableSpan4)
        Me.tv_Clients.TileSpans.Add(TableSpan5)
        Me.tv_Clients.TileSpans.Add(TableSpan6)
        TileViewItemElement1.Column = Me.TVC_Client_Photo
        TileViewItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement1.RowIndex = 1
        TileViewItemElement1.Text = "TVC_Client_Photo"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.Appearance.Hovered.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        TileViewItemElement2.Appearance.Hovered.Options.UseFont = True
        TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        TileViewItemElement2.Appearance.Normal.Options.UseFont = True
        TileViewItemElement2.Appearance.Pressed.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        TileViewItemElement2.Appearance.Pressed.Options.UseFont = True
        TileViewItemElement2.Appearance.Selected.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement2.Appearance.Selected.Options.UseFont = True
        TileViewItemElement2.Column = Me.TVC_Client_Name
        TileViewItemElement2.ColumnIndex = 1
        TileViewItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement2.Text = "TVC_Client_Name"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement3.Column = Me.TVC_Client_PAN
        TileViewItemElement3.ColumnIndex = 1
        TileViewItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement3.RowIndex = 1
        TileViewItemElement3.Text = "TVC_Client_PAN"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement4.Column = Me.TVC_Client_Type
        TileViewItemElement4.ColumnIndex = 1
        TileViewItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement4.RowIndex = 2
        TileViewItemElement4.Text = "TVC_Client_Type"
        TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement5.Column = Me.TVC_Client_AddressLine1
        TileViewItemElement5.ColumnIndex = 1
        TileViewItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement5.RowIndex = 3
        TileViewItemElement5.Text = "TVC_Client_AddressLine1"
        TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement6.Column = Me.TVC_Client_AddressLine2
        TileViewItemElement6.ColumnIndex = 1
        TileViewItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement6.RowIndex = 4
        TileViewItemElement6.Text = "TVC_Client_AddressLine2"
        TileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement7.Column = Me.TVC_Client_District
        TileViewItemElement7.ColumnIndex = 1
        TileViewItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement7.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement7.RowIndex = 5
        TileViewItemElement7.Text = "TVC_Client_District"
        TileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement8.Column = Me.TVC_Client_Pincode
        TileViewItemElement8.ColumnIndex = 2
        TileViewItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement8.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
        TileViewItemElement8.RowIndex = 5
        TileViewItemElement8.Text = "TVC_Client_Pincode"
        TileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement1)
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement2)
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement3)
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement4)
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement5)
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement6)
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement7)
        Me.tv_Clients.TileTemplate.Add(TileViewItemElement8)
        '
        'gv_Clients
        '
        Me.gv_Clients.GridControl = Me.gc_Clients
        Me.gv_Clients.Name = "gv_Clients"
        Me.gv_Clients.OptionsBehavior.Editable = False
        Me.gv_Clients.OptionsBehavior.ReadOnly = True
        '
        'np_Jobs
        '
        Me.np_Jobs.Caption = "Jobs"
        Me.np_Jobs.Controls.Add(Me.ProgressPanel_Jobs)
        Me.np_Jobs.Controls.Add(Me.gc_Jobs)
        Me.np_Jobs.Name = "np_Jobs"
        Me.np_Jobs.Size = New System.Drawing.Size(778, 275)
        '
        'ProgressPanel_Jobs
        '
        Me.ProgressPanel_Jobs.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Jobs.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Jobs.BarAnimationElementThickness = 2
        Me.ProgressPanel_Jobs.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Jobs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Jobs.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel_Jobs.Name = "ProgressPanel_Jobs"
        Me.ProgressPanel_Jobs.Size = New System.Drawing.Size(778, 275)
        Me.ProgressPanel_Jobs.TabIndex = 3
        '
        'gc_Jobs
        '
        Me.gc_Jobs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Jobs.Location = New System.Drawing.Point(0, 0)
        Me.gc_Jobs.MainView = Me.gv_Jobs
        Me.gc_Jobs.MenuManager = Me.RibbonControl
        Me.gc_Jobs.Name = "gc_Jobs"
        Me.gc_Jobs.Size = New System.Drawing.Size(778, 275)
        Me.gc_Jobs.TabIndex = 1
        Me.gc_Jobs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Jobs})
        '
        'gv_Jobs
        '
        Me.gv_Jobs.GridControl = Me.gc_Jobs
        Me.gv_Jobs.Name = "gv_Jobs"
        Me.gv_Jobs.OptionsBehavior.Editable = False
        Me.gv_Jobs.OptionsBehavior.ReadOnly = True
        '
        'np_Users
        '
        Me.np_Users.Caption = "Users"
        Me.np_Users.Controls.Add(Me.ProgressPanel_Users)
        Me.np_Users.Controls.Add(Me.gc_Users)
        Me.np_Users.Name = "np_Users"
        Me.np_Users.Size = New System.Drawing.Size(696, 229)
        '
        'ProgressPanel_Users
        '
        Me.ProgressPanel_Users.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel_Users.Appearance.Options.UseBackColor = True
        Me.ProgressPanel_Users.BarAnimationElementThickness = 2
        Me.ProgressPanel_Users.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel_Users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressPanel_Users.Location = New System.Drawing.Point(0, 0)
        Me.ProgressPanel_Users.Name = "ProgressPanel_Users"
        Me.ProgressPanel_Users.Size = New System.Drawing.Size(696, 229)
        Me.ProgressPanel_Users.TabIndex = 2
        '
        'gc_Users
        '
        Me.gc_Users.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Users.Location = New System.Drawing.Point(0, 0)
        Me.gc_Users.MainView = Me.tv_Users
        Me.gc_Users.MenuManager = Me.RibbonControl
        Me.gc_Users.Name = "gc_Users"
        Me.gc_Users.Size = New System.Drawing.Size(696, 229)
        Me.gc_Users.TabIndex = 1
        Me.gc_Users.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.tv_Users})
        '
        'tv_Users
        '
        Me.tv_Users.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.TVC_Name, Me.TVC_UserType, Me.TVC_Mobile, Me.TVC_Photo})
        Me.tv_Users.GridControl = Me.gc_Users
        Me.tv_Users.Name = "tv_Users"
        Me.tv_Users.OptionsTiles.RowCount = 5
        TileViewItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement9.Appearance.Normal.Options.UseFont = True
        TileViewItemElement9.Column = Me.TVC_Name
        TileViewItemElement9.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement9.ImageLocation = New System.Drawing.Point(105, 0)
        TileViewItemElement9.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileViewItemElement9.Text = "TVC_Name"
        TileViewItemElement10.Column = Me.TVC_UserType
        TileViewItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement10.ImageLocation = New System.Drawing.Point(115, 20)
        TileViewItemElement10.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top
        TileViewItemElement10.Text = "TVC_UserType"
        TileViewItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileViewItemElement11.Appearance.Normal.Options.UseFont = True
        TileViewItemElement11.Column = Me.TVC_Mobile
        TileViewItemElement11.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement11.ImageLocation = New System.Drawing.Point(105, 40)
        TileViewItemElement11.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileViewItemElement11.Text = "TVC_Mobile"
        TileViewItemElement12.Column = Me.TVC_Photo
        TileViewItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
        TileViewItemElement12.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.SingleBorder
        TileViewItemElement12.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside
        TileViewItemElement12.ImageSize = New System.Drawing.Size(100, 100)
        TileViewItemElement12.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileViewItemElement12.Text = "TVC_Photo"
        Me.tv_Users.TileTemplate.Add(TileViewItemElement9)
        Me.tv_Users.TileTemplate.Add(TileViewItemElement10)
        Me.tv_Users.TileTemplate.Add(TileViewItemElement11)
        Me.tv_Users.TileTemplate.Add(TileViewItemElement12)
        '
        'Loader_Users
        '
        '
        'Loader_Jobs
        '
        '
        'Loader_Clients
        '
        '
        'Loader_Workbook
        '
        '
        'Loader_Home
        '
        '
        'Loader_Utilities
        '
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 449)
        Me.Controls.Add(Me.MainPane)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Main"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Devil7 - Office Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPane.ResumeLayout(False)
        Me.np_Home.ResumeLayout(False)
        CType(Me.gc_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.np_Utilities.ResumeLayout(False)
        Me.np_Workbook.ResumeLayout(False)
        CType(Me.gc_WorkBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_WorkBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.np_Clients.ResumeLayout(False)
        CType(Me.gc_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tv_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Clients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.np_Jobs.ResumeLayout(False)
        CType(Me.gc_Jobs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Jobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.np_Users.ResumeLayout(False)
        CType(Me.gc_Users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tv_Users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rp_Edit As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents SkinSelector As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents rpg_Skin As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents MainPane As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents np_Home As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents np_Utilities As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents np_Workbook As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents np_Clients As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents np_Jobs As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents np_Users As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents gc_Home As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Home As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel_Utilities As DevExpress.XtraEditors.TileControl
    Friend WithEvents gc_WorkBook As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_WorkBook As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_Clients As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Clients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_Jobs As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Jobs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gc_Users As DevExpress.XtraGrid.GridControl
    Friend WithEvents tv_Users As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TVC_Name As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_UserType As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Mobile As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Photo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents rpg_Workbook As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpg_Clients As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpg_Jobs As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpg_Users As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btn_NewJob As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_EditJob As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RemoveJob As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AddUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_EditUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RemoveUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_ResetPassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AddClient As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_EditClient As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RemoveClient As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_AddWork As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_EditWork As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RemoveWork As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RefreshWork As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RefreshClients As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RefreshJobs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_RefreshUsers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Loader_Users As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressPanel_Users As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents btn_EditProfile As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_ChangePassword As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
    Friend WithEvents btn_Exit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProgressPanel_Jobs As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Loader_Jobs As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressPanel_Clients As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Loader_Clients As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Clients_CardView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Clients_DetailsView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents tv_Clients As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents TVC_Client_Photo As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Client_Name As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Client_PAN As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Client_Type As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents grp_btn_Clients_View As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents TVC_Client_AddressLine1 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Client_AddressLine2 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Client_District As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents TVC_Client_Pincode As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents Loader_Workbook As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressPanel_Workbook As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents ProgressPanel_Home As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Loader_Home As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_RefreshHome As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpg_Home As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ProgressPanel_Utilites As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents Loader_Utilities As System.ComponentModel.BackgroundWorker


End Class
