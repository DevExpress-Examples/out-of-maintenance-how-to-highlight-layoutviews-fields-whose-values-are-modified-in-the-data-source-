<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E1885/Form1.cs) (VB: [Form1.vb](./VB/E1885/Form1.vb))
<!-- default file list end -->
# How to highlight LayoutView's fields whose values are modified in the data source


<p>This example demonstrates how to track changes in the data source, and change the font of the modified field value for some time.</p>


<h3>Description</h3>

<p>To accomplish this task, it&#39;s necessary to use the BindingSource, containing objects that implement the INotifyPropertyChanged interface. Within the BindingSource.ListChanged event handler, it&#39;s possible to obtain the row index, and the name of a modified property. Within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGridViewsLayoutLayoutView_CustomFieldValueStyletopic">LayoutView.CustomFieldValueStyle</a> event handler, the font of the field&#39;s value is changed to bold, if there is a value in the cache corresponding to the current row handle and column. This cache is populated within the ListChanged event handler based on the row index and property name. Values are automatically deleted from the cache after a second.</p>

<br/>


