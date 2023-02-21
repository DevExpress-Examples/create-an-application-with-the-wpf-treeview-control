Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace TreeViewGettingStarted

    Public Class MainWindowViewModel
        Inherits ViewModelBase

        Public Sub New()
            EmployeeDepartments = GetDepartments()
        End Sub

        Public Property EmployeeDepartments As ObservableCollection(Of EmployeeDepartment)
    End Class
End Namespace
