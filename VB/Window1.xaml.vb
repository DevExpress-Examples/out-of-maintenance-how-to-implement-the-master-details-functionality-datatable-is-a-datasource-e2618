Imports System
Imports System.Windows
Imports System.Globalization
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Data

Namespace MasterDetailInside

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class DetailSourceConverter
        Inherits MarkupExtension
        Implements IMultiValueConverter

        Public Function Convert(ByVal values As Object(), ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim masterRowId = values(0)
            Dim childData = CType(values(1), DataTable)
            Dim childView = New DataView(childData)
            childView.RowFilter = String.Format("ParentId = '{0}'", masterRowId.ToString())
            Return childView
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes As Type(), ByVal parameter As Object, ByVal culture As CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
End Namespace
