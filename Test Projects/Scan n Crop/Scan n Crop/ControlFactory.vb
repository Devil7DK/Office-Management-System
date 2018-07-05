
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary


#Region "ControlFactory"
''' <summary>
''' Summary description for FormControlFactory.
''' </summary>
Public Class ControlFactory
    '
    ' TODO: Add constructor logic here
    '
    Public Sub New()
    End Sub
    Public Shared Function CreateControl(ByVal ctrlName As String, ByVal partialName As String) As Control
        'Try
        Dim ctrl As Control
        Select Case ctrlName
            Case "Label"
                ctrl = New Label()
                Exit Select
            Case "TextBox"
                ctrl = New TextBox()
                Exit Select
            Case "PictureBox"
                ctrl = New PictureBox()
                Exit Select
            Case "ListView"
                ctrl = New ListView()
                Exit Select
            Case "ComboBox"
                ctrl = New ComboBox()
                Exit Select
            Case "Button"
                ctrl = New Button()
                Exit Select
            Case "CheckBox"
                ctrl = New CheckBox()
                Exit Select
            Case "MonthCalender"
                ctrl = New MonthCalendar()
                Exit Select
            Case "DateTimePicker"
                ctrl = New DateTimePicker()
                Exit Select
            Case Else
                Dim controlAsm As Assembly = Assembly.LoadWithPartialName(partialName)
                Dim controlType As Type = controlAsm.[GetType](Convert.ToString(partialName & Convert.ToString(".")) & ctrlName)
                ctrl = DirectCast(Activator.CreateInstance(controlType), Control)
                Exit Select

        End Select

        Return ctrl
        ' Catch ex As Exception
        'System.Diagnostics.Trace.WriteLine("create control failed:" + ex.Message)
        'Return New Control()
        ' End Try
    End Function
    Public Shared Function CreateControl(ByVal Source_Ctrl As Control, ByVal ctrlName As String, ByVal partialName As String) As Control
        'Try
        Dim ctrl As Control
        Select Case ctrlName
            Case "Label"
                ctrl = New Label()
                Exit Select
            Case "TextBox"
                ctrl = New TextBox()
                Exit Select
            Case "PictureBox"
                ctrl = New PictureBox()
                Exit Select
            Case "ListView"
                ctrl = New ListView()
                Exit Select
            Case "ComboBox"
                ctrl = New ComboBox()
                Exit Select
            Case "Button"
                ctrl = New Button()
                Exit Select
            Case "CheckBox"
                ctrl = New CheckBox()
                Exit Select
            Case "MonthCalender"
                ctrl = New MonthCalendar()
                Exit Select
            Case "DateTimePicker"
                ctrl = New DateTimePicker()
                Exit Select
            Case Else
                ' Dim controlAsm As Assembly = 
                Dim controlType As Type = Source_Ctrl.GetType
                ctrl = DirectCast(Activator.CreateInstance(controlType), Control)
                Exit Select

        End Select

        Return ctrl
        ' Catch ex As Exception
        'System.Diagnostics.Trace.WriteLine("create control failed:" + ex.Message)
        'Return New Control()
        ' End Try
    End Function

    Public Shared Sub SetControlProperties(ByVal ctrl As Control, ByVal propertyList As Hashtable)
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(ctrl)

        For Each myProperty As PropertyDescriptor In properties
            If propertyList.Contains(myProperty.Name) Then
                Dim obj As [Object] = propertyList(myProperty.Name)
                Try
                    If TypeOf obj Is Image Then
                        myProperty.SetValue(ctrl, CType(obj, Image).Clone)
                    Else
                        myProperty.SetValue(ctrl, obj)
                    End If
                Catch ex As Exception
                    'do nothing, just continue
                    System.Diagnostics.Trace.WriteLine(ex.Message)

                End Try

            End If
        Next

    End Sub

    Public Shared Function CloneCtrl(ByVal ctrl As Control) As Control

        Dim cbCtrl As New CBFormCtrl(ctrl)
        Dim newCtrl As Control = ControlFactory.CreateControl(ctrl, cbCtrl.CtrlName, cbCtrl.PartialName)

        ControlFactory.SetControlProperties(newCtrl, cbCtrl.PropertyList)

        Return newCtrl
    End Function

    Public Shared Sub CopyCtrl2ClipBoard(ByVal ctrl As Control)
        Dim cbCtrl As New CBFormCtrl(ctrl)
        Dim ido As IDataObject = New DataObject()

        ido.SetData(CBFormCtrl.Format.Name, True, cbCtrl)
        Clipboard.SetDataObject(ido, False)

    End Sub

    Public Shared Function GetCtrlFromClipBoard() As Control
        Dim ctrl As New Control()

        Dim ido As IDataObject = Clipboard.GetDataObject()
        If ido.GetDataPresent(CBFormCtrl.Format.Name) Then
            Dim cbCtrl As CBFormCtrl = TryCast(ido.GetData(CBFormCtrl.Format.Name), CBFormCtrl)

            ctrl = ControlFactory.CreateControl(cbCtrl.CtrlName, cbCtrl.PartialName)

            ControlFactory.SetControlProperties(ctrl, cbCtrl.PropertyList)
        End If
        Return ctrl
    End Function


End Class

#End Region

#Region "Clipboard Support"
''' <summary>
''' Summary description for CBFormCtrl.
''' </summary>
<Serializable()> _
Public Class CBFormCtrl
    'clipboard form control
    Private Shared m_format As DataFormats.Format
    Private m_ctrlName As String
    Private m_partialName As String
    Private m_propertyList As New Hashtable()

    Shared Sub New()
        ' Registers a new data format with the windows Clipboard
        m_format = DataFormats.GetFormat(GetType(CBFormCtrl).FullName)
    End Sub

    Public Shared ReadOnly Property Format() As DataFormats.Format
        Get
            Return m_format
        End Get
    End Property
    Public Property CtrlName() As String
        Get
            Return m_ctrlName
        End Get
        Set(ByVal value As String)
            m_ctrlName = value
        End Set
    End Property

    Public Property PartialName() As String
        Get
            Return m_partialName
        End Get
        Set(ByVal value As String)
            m_partialName = value
        End Set
    End Property

    Public ReadOnly Property PropertyList() As Hashtable
        Get
            Return m_propertyList
        End Get
    End Property




    Public Sub New()
    End Sub

    Public Sub New(ByVal ctrl As Control)
        CtrlName = ctrl.[GetType]().Name
        PartialName = ctrl.[GetType]().[Namespace]

        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(ctrl)

        For Each myProperty As PropertyDescriptor In properties
            Try
                If myProperty.PropertyType.IsSerializable Then
                    m_propertyList.Add(myProperty.Name, myProperty.GetValue(ctrl))
                End If
            Catch ex As Exception
                'do nothing, just continue
                System.Diagnostics.Trace.WriteLine(ex.Message)

            End Try

        Next
    End Sub


End Class
#End Region