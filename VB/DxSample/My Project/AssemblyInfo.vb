' Developer Express Code Central Example:
' How to align Group Summary items by columns when the grid is being printed
' 
' This example demonstrates how to align Group Summary items by columns when the
' grid is being printed. For this, it is necessary to override the default
' PrintGroupRowTemplate and place an additional ItemsControl descendant within it.
' Note that the descendant must contain the ItemTemplateSelector property that
' selects the ItemTemplate depending on the column type. This new ItemsControl
' will be used to display group values via TextEdits that are placed within the
' ItemsControl's ItemTemplate and are arranged by the column.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4323

Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("DxSample")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("DxSample")>
<Assembly: AssemblyCopyright("Copyright ©  2012")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("02aa5e93-ab69-4049-b7fc-bf53dc4e1ff7")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
