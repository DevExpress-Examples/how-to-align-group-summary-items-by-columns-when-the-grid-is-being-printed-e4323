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

Namespace DxSample
	Public Class ExtItemsControl
		Inherits ItemsControl

		Public Shared ReadOnly ItemTemplateSelectorProperty As DependencyProperty = DependencyProperty.Register("ItemTemplateSelector", GetType(DataTemplateSelector), GetType(ExtItemsControl), Nothing)
		Public Property ItemTemplateSelector() As DataTemplateSelector
			Get
				Return CType(Me.GetValue(ItemTemplateSelectorProperty), DataTemplateSelector)
			End Get
			Set(ByVal value As DataTemplateSelector)
				Me.SetValue(ItemTemplateSelectorProperty, value)
			End Set
		End Property

		Protected Overrides Sub PrepareContainerForItemOverride(ByVal element As DependencyObject, ByVal item As Object)
			MyBase.PrepareContainerForItemOverride(element, item)
			Dim selector As DataTemplateSelector = Me.ItemTemplateSelector
			If selector IsNot Nothing Then
				CType(element, ContentPresenter).ContentTemplate = selector.SelectTemplate(item, element)
			End If
		End Sub
	End Class
End Namespace
