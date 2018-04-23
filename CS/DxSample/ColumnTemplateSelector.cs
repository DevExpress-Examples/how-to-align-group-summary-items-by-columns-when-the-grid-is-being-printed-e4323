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
