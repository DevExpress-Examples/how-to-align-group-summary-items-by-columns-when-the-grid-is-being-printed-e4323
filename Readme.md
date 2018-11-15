<!-- default file list -->
*Files to look at*:

* [ColumnTemplateSelector.cs](./CS/DxSample/ColumnTemplateSelector.cs) (VB: [ColumnTemplateSelector.vb](./VB/DxSample/ColumnTemplateSelector.vb))
* [ExtItemsControl.cs](./CS/DxSample/ExtItemsControl.cs) (VB: [ExtItemsControl.vb](./VB/DxSample/ExtItemsControl.vb))
* [MainPage.xaml](./CS/DxSample/MainPage.xaml) (VB: [MainPage.xaml.vb](./VB/DxSample/MainPage.xaml.vb))
* [MainPage.xaml.cs](./CS/DxSample/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/DxSample/MainPage.xaml.vb))
* [PersonsViewModel.cs](./CS/DxSample/PersonsViewModel.cs) (VB: [PersonsViewModel.vb](./VB/DxSample/PersonsViewModel.vb))
* [PrintGroupSummaryConverter.cs](./CS/DxSample/PrintGroupSummaryConverter.cs) (VB: [PrintGroupSummaryConverter.vb](./VB/DxSample/PrintGroupSummaryConverter.vb))
<!-- default file list end -->
# How to align Group Summary items by columns when the grid is being printed


<p>This example demonstrates how to align Group Summary items by columns when the grid is being printed.  For this, it is necessary to override the default PrintGroupRowTemplate and place an additional ItemsControl descendant within it. Note that the descendant must contain the ItemTemplateSelector property that selects the ItemTemplate depending on the column type. This new ItemsControl will be used to display group values via TextEdits that are placed within the ItemsControl's ItemTemplate and are arranged by the column.</p>

<br/>


