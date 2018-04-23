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
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace DxSample
	Public Class ColumnTemplateSelector
		Inherits DataTemplateSelector

		Public Property IsFirstColumnTemplate() As DataTemplate
		Public Property IsLastColumnTemplate() As DataTemplate
		Public Property IsMiddleColumnTemplate() As DataTemplate

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			If item IsNot Nothing Then
				If (TryCast(item, GridCellData)).Column.IsFirst Then
					Return IsFirstColumnTemplate
				End If
				If (TryCast(item, GridCellData)).Column.IsLast Then
					Return IsLastColumnTemplate
				End If
				Return IsMiddleColumnTemplate
			End If
			Return Nothing
		End Function
	End Class
End Namespace
