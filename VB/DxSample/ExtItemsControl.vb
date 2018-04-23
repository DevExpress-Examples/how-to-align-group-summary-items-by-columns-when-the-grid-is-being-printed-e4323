Imports Microsoft.VisualBasic
Imports System
Imports System.Windows
Imports System.Windows.Controls

Namespace DxSample
	Public Class ExtItemsControl
		Inherits ItemsControl
		Public Shared ReadOnly ItemTemplateSelectorProperty As DependencyProperty = DependencyProperty.Register("ItemTemplateSelector", GetType(DataTemplateSelector), GetType(ExtItemsControl), Nothing)
		Public Overloads Property ItemTemplateSelector() As DataTemplateSelector
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
