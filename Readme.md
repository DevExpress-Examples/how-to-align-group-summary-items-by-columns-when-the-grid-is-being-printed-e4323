# How to align Group Summary items by columns when the grid is being printed


<p>This example demonstrates how to align Group Summary items by columns when the grid is being printed.  For this, it is necessary to override the default PrintGroupRowTemplate and place an additional ItemsControl descendant within it. Note that the descendant must contain the ItemTemplateSelector property that selects the ItemTemplate depending on the column type. This new ItemsControl will be used to display group values via TextEdits that are placed within the ItemsControl's ItemTemplate and are arranged by the column.</p>

<br/>


