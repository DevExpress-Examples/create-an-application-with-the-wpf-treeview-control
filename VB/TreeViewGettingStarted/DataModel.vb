Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace TreeViewGettingStarted

    Public Class Employee

        Public Sub New(ByVal id As Integer, ByVal name As String)
            Me.ID = id
            Me.Name = name
        End Sub

        Public Property ID As Integer

        Public Property Name As String
    End Class

    Public Class EmployeeDepartment

        Public Property Name As String

        Public ReadOnly Property Employees As ObservableCollection(Of Employee)

        Public Sub New(ByVal name As String, ByVal employees As IEnumerable(Of Employee))
            Me.Name = name
            Me.Employees = New ObservableCollection(Of Employee)(employees)
        End Sub
    End Class

    Public Module DepartmentData

        Public Function GetDepartments() As ObservableCollection(Of EmployeeDepartment)
            Dim departments = New ObservableCollection(Of EmployeeDepartment)()
            departments.Add(New EmployeeDepartment("Management", New Employee() {New Employee(0, "Gregory S. Price")}))
            departments.Add(New EmployeeDepartment("Marketing", New Employee() {New Employee(1, "Irma R. Marshall"), New Employee(2, "Brian C. Cowling"), New Employee(3, "Thomas C. Dawson"), New Employee(4, "Bryan R. Henderson")}))
            departments.Add(New EmployeeDepartment("Operations", New Employee() {New Employee(5, "John C. Powell"), New Employee(6, "Harold S. Brandes"), New Employee(7, "Jan K. Sisk"), New Employee(8, "Sidney L. Holder")}))
            departments.Add(New EmployeeDepartment("Production", New Employee() {New Employee(9, "Christian P. Laclair"), New Employee(10, "James L. Kelsey"), New Employee(11, "Howard M. Carpenter"), New Employee(12, "Jennifer T. Tapia")}))
            departments.Add(New EmployeeDepartment("Finance", New Employee() {New Employee(13, "Karen J. Kelly"), New Employee(14, "Judith P. Underhill"), New Employee(15, "Russell E. Belton")}))
            Return departments
        End Function
    End Module
End Namespace
