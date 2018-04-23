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
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Grid;

namespace DxSample
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            gridControl1.Columns["IsMarried"].GroupIndex = 0;
            gridControl1.Columns["FirstName"].GroupIndex = 1;
            PrintableControlLink link = new PrintableControlLink((TableView)gridControl1.View);
            LinkPreviewModel model = new LinkPreviewModel(link);
            documentPreview.Model = model;
            link.CreateDocument(true);
        }
    }
}
