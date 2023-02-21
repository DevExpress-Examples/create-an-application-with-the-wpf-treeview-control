using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace TreeViewGettingStarted {
    public class MainWindowViewModel : ViewModelBase {
        public MainWindowViewModel() {
            EmployeeDepartments = DepartmentData.GetDepartments();
        }
        public ObservableCollection<EmployeeDepartment> EmployeeDepartments { get; set; }
    }    
}
