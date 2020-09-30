Imports DevExpress.Mvvm
Imports System.Collections.Generic

Namespace TreeViewGettingStarted
	Public Class MainWindowViewModel
		Inherits ViewModelBase

		Public Sub New()
			EmployeeDepartments = Departments.GetDepartments()
		End Sub
		Public Property EmployeeDepartments() As List(Of EmployeeDepartment)
	End Class
End Namespace
