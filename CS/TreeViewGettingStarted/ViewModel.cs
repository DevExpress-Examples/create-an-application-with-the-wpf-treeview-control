using DevExpress.Mvvm;
using System.Collections.Generic;

namespace TreeViewGettingStarted {
    public class MainWindowViewModel : ViewModelBase {
        public MainWindowViewModel() {
            EmployeeDepartments = Departments.GetDepartments();
        }
        public List<EmployeeDepartment> EmployeeDepartments { get; set; }
    }    
}
