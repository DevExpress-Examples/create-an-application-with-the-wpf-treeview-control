Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace TreeViewGettingStarted
	Public Class MainWindowViewModel
		Public Sub New()
'INSTANT VB NOTE: The variable employeeDepartments was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim employeeDepartments_Conflict = Stuff.GetStuff().GroupBy(Function(x) x.Department).Select(Function(x) New EmployeeDepartment(x.Key, x.ToArray()))
			EmployeeDepartments = New ObservableCollection(Of EmployeeDepartment)(employeeDepartments_Conflict.ToArray())
		End Sub
		Public Property EmployeeDepartments() As ObservableCollection(Of EmployeeDepartment)
	End Class

	Public Class EmployeeDepartment
		Public Property Name() As String
		Public Property Employees() As ObservableCollection(Of Employee)

		Public Sub New(ByVal name As String, ByVal employees As IEnumerable(Of Employee))
			Me.Name = name
			Me.Employees = New ObservableCollection(Of Employee)(employees)
		End Sub
		Public Overrides Function ToString() As String
			Return Name
		End Function
	End Class
End Namespace
