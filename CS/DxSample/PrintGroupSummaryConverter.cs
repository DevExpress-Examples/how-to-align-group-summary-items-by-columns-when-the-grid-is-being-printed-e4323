// Developer Express Code Central Example:
// How to align Group Summary items by columns when the grid is being printed
// 
// This example demonstrates how to align Group Summary items by columns when the
// grid is being printed. For this, it is necessary to override the default
// PrintGroupRowTemplate and place an additional ItemsControl descendant within it.
// Note that the descendant must contain the ItemTemplateSelector property that
// selects the ItemTemplate depending on the column type. This new ItemsControl
// will be used to display group values via TextEdits that are placed within the
// ItemsControl's ItemTemplate and are arranged by the column.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4323

using System;
using DevExpress.Xpf.Grid;
using System.Windows.Data;
using System.Text;

namespace DxSample
{
    public class PrintGroupSummaryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            GridCellData data = (GridCellData)value;

            int rowHandle = data.RowData.RowHandle.Value;
            string fieldName = data.Column.FieldName;

            TableView view = (TableView)data.View;
            GridSummaryItemCollection summaries = view.Grid.GroupSummary;

            StringBuilder sb = new StringBuilder();
            foreach (GridSummaryItem item in summaries)
            {
                if (item.FieldName == fieldName || item.ShowInColumn == fieldName)
                {
                    if (sb.Length != 0) sb.Append(Environment.NewLine);
                    if (string.IsNullOrWhiteSpace(item.DisplayFormat))
                    {
                        sb.Append(item.SummaryType + " is " + view.Grid.GetGroupSummaryValue(rowHandle, item).ToString());
                    }
                    else
                    {
                        sb.Append(string.Format(item.DisplayFormat, view.Grid.GetGroupSummaryValue(rowHandle, item).ToString()));
                    }
                }
            }
            return sb.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
