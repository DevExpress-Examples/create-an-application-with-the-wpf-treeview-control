using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace TreeViewGettingStarted {
    public class MainWindowViewModel : INotifyPropertyChanged {
        public MainWindowViewModel() {
            var employeeDepartments = Stuff.GetStuff()
                .GroupBy(x => x.Department)
                .Select(x => new EmployeeDepartment(x.Key, x.ToArray()));
            EmployeeDepartments = new ObservableCollection<EmployeeDepartment>(employeeDepartments.ToArray());
        }
        public ObservableCollection<EmployeeDepartment> EmployeeDepartments { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class EmployeeDepartment {
        public string Name { get; set; }
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeeDepartment(string name, IEnumerable<Employee> employees) {
            Name = name;
            Employees = new ObservableCollection<Employee>(employees);
        }
        public override string ToString() {
            return Name;
        }
    }
}
