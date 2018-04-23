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
