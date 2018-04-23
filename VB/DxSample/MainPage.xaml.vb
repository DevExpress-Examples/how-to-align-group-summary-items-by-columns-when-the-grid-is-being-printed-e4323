Imports Microsoft.VisualBasic
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
