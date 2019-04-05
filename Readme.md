<!-- default file list -->
*Files to look at*:

* [ViewModel.cs](./CS/ViewModel.cs) (VB: [ViewModel.vb](./VB/ViewModel.vb))
* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to implement the Master-Details functionality (DataTable is a DataSource)


<p>DataRow does not have a property that includes all child rows. To get child data, implement a multi binding converter that will filter the child data table based on the master row id.</p>

<br/>


