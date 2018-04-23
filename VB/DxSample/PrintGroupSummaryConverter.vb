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
Imports DevExpress.Xpf.Grid
Imports System.Windows.Data
Imports System.Text

Namespace DxSample
	Public Class PrintGroupSummaryConverter
		Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
            Dim data As GridCellData = CType(value, GridCellData)

            Dim rowHandle As Integer = data.RowData.RowHandle.Value
            Dim fieldName As String = data.Column.FieldName

            Dim view As TableView = CType(data.View, TableView)
            Dim summaries As GridSummaryItemCollection = view.Grid.GroupSummary

            Dim sb As New StringBuilder()
            For Each item As GridSummaryItem In summaries
                If item.FieldName = fieldName OrElse item.ShowInColumn = fieldName Then
                    If sb.Length <> 0 Then
                        sb.Append(Environment.NewLine)
                    End If
                    If String.IsNullOrWhiteSpace(item.DisplayFormat) Then
                        sb.Append(item.SummaryType & " is " & view.Grid.GetGroupSummaryValue(rowHandle, item).ToString())
                    Else
                        sb.Append(String.Format(item.DisplayFormat, view.Grid.GetGroupSummaryValue(rowHandle, item).ToString()))
                    End If
                End If
            Next item
            Return sb.ToString()
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
	End Class
End Namespace
