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

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Grid

Namespace DxSample
	Partial Public Class MainPage
		Inherits UserControl

		Public Sub New()
			InitializeComponent()

			AddHandler Me.Loaded, AddressOf MainPage_Loaded
		End Sub

		Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			gridControl1.Columns("IsMarried").GroupIndex = 0
			gridControl1.Columns("FirstName").GroupIndex = 1
			Dim link As New PrintableControlLink(CType(gridControl1.View, TableView))
			Dim model As New LinkPreviewModel(link)
			documentPreview.Model = model
			link.CreateDocument(True)
		End Sub
	End Class
End Namespace
