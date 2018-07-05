
Imports System.Collections.Generic
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks

Public NotInheritable Class AllowAllAssemblyVersionsDeserializationBinder
    Inherits System.Runtime.Serialization.SerializationBinder
    Public Overrides Function BindToType(ByVal assemblyName As String, ByVal typeName As String) As Type
        Dim typeToDeserialize As Type = Nothing

        Dim currentAssembly As [String] = Assembly.GetExecutingAssembly().FullName

        ' In this case we are always using the current assembly
        assemblyName = currentAssembly

        ' Get the type using the typeName and assemblyName
        typeToDeserialize = Type.[GetType]([String].Format("{0}, {1}", typeName, assemblyName))

        Return typeToDeserialize
    End Function
End Class


'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
