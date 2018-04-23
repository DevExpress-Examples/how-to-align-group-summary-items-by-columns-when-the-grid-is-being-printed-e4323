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

namespace DxSample
{
    public class ExtItemsControl : ItemsControl
    {
        public static readonly DependencyProperty ItemTemplateSelectorProperty = DependencyProperty.Register("ItemTemplateSelector", typeof(DataTemplateSelector), typeof(ExtItemsControl), null);
        public DataTemplateSelector ItemTemplateSelector
        {
            get
            {
                return (DataTemplateSelector)this.GetValue(ItemTemplateSelectorProperty);
            }
            set
            {
                this.SetValue(ItemTemplateSelectorProperty, value);
            }
        }

        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);
            DataTemplateSelector selector = this.ItemTemplateSelector;
            if (selector != null)
            {
                ((ContentPresenter)element).ContentTemplate = selector.SelectTemplate(item, element);
            }
        }
    }
}
