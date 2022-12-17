Imports System.Data

Namespace MasterDetailInside

    Public Class ViewModel

        Public Sub New()
            ParentData = New DataTable()
            ParentData.Columns.Add("Id", GetType(Integer))
            ParentData.Columns.Add("Text", GetType(String))
            ChildData = New DataTable()
            ChildData.Columns.Add("ParentId", GetType(Integer))
            ChildData.Columns.Add("Text", GetType(String))
            For i As Integer = 0 To 100 - 1
                ParentData.Rows.Add(i, "Master" & i)
                For j As Integer = 0 To 50 - 1
                    ChildData.Rows.Add(i, "Detail" & j & " Master" & i)
                Next
            Next
        End Sub

        Public Property ParentData As DataTable

        Public Property ChildData As DataTable
    End Class
End Namespace
