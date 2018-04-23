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
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Grid;

namespace DxSample
{
    public class ColumnTemplateSelector:DataTemplateSelector
    {
        public DataTemplate IsFirstColumnTemplate { get; set; }
        public DataTemplate IsLastColumnTemplate { get; set; }
        public DataTemplate IsMiddleColumnTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item != null)
            {
                if ((item as GridCellData).Column.IsFirst)
                {
                    return IsFirstColumnTemplate;
                }
                if ((item as GridCellData).Column.IsLast)
                {
                    return IsLastColumnTemplate;
                }
                return IsMiddleColumnTemplate;
            }
            return null;
        }
    }
}
