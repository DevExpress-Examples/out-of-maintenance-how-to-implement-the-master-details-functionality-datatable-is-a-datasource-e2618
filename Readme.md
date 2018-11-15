<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication15/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/WpfApplication15/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/WpfApplication15/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication15/MainWindow.xaml.vb))
<!-- default file list end -->
# How to implement the Master-Details functionality (DataTable is a DataSource)


<p>DataRow does not have a property that includes all child rows. To get child data, implement a multi binding converter that will filter the child data table based on the master row id.</p>

<br/>


