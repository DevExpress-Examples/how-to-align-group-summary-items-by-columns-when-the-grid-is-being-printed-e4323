Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Grid

Namespace DxSample
	Public Class ColumnTemplateSelector
		Inherits DataTemplateSelector
		Private privateIsFirstColumnTemplate As DataTemplate
		Public Property IsFirstColumnTemplate() As DataTemplate
			Get
				Return privateIsFirstColumnTemplate
			End Get
			Set(ByVal value As DataTemplate)
				privateIsFirstColumnTemplate = value
			End Set
		End Property
		Private privateIsLastColumnTemplate As DataTemplate
		Public Property IsLastColumnTemplate() As DataTemplate
			Get
				Return privateIsLastColumnTemplate
			End Get
			Set(ByVal value As DataTemplate)
				privateIsLastColumnTemplate = value
			End Set
		End Property
		Private privateIsMiddleColumnTemplate As DataTemplate
		Public Property IsMiddleColumnTemplate() As DataTemplate
			Get
				Return privateIsMiddleColumnTemplate
			End Get
			Set(ByVal value As DataTemplate)
				privateIsMiddleColumnTemplate = value
			End Set
		End Property

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
