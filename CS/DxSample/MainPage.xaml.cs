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
