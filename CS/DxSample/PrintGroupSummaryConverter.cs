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
