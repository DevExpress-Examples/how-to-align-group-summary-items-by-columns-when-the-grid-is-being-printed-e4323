Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Grid
Imports System.Windows.Data
Imports System.Text

Namespace DxSample
	Public Class PrintGroupSummaryConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
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
                        sb.Append(item.SummaryType.ToString() & " is " & view.Grid.GetGroupSummaryValue(rowHandle, item).ToString())
					Else
						sb.Append(String.Format(item.DisplayFormat, view.Grid.GetGroupSummaryValue(rowHandle, item).ToString()))
					End If
				End If
			Next item
			Return sb.ToString()
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
