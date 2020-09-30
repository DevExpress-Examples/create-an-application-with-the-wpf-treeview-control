using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TreeViewGettingStarted {
    public class Employee {
        public Employee(int id, string name) {
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class EmployeeDepartment {
        public string Name { get; set; }
        public ObservableCollection<Employee> Employees { get; }

        public EmployeeDepartment(string name, IEnumerable<Employee> employees) {
            Name = name;
            Employees = new ObservableCollection<Employee>(employees);
        }
    }

    public static class Departments {
        public static List<EmployeeDepartment> GetDepartments() {
            List<EmployeeDepartment> departments = new List<EmployeeDepartment>();
            departments.Add(new EmployeeDepartment("Management", new Employee[] { 
                new Employee(0, "Gregory S. Price") 
            }));
            departments.Add(new EmployeeDepartment("Marketing", new Employee[] { 
                new Employee(1, "Irma R. Marshall"),
                new Employee(2, "Brian C. Cowling"),
                new Employee(3, "Thomas C. Dawson"),
                new Employee(4, "Bryan R. Henderson"),
            }));
            departments.Add(new EmployeeDepartment("Operations", new Employee[] {
                new Employee(5, "John C. Powell"),
                new Employee(6, "Harold S. Brandes"),
                new Employee(7, "Jan K. Sisk"),
                new Employee(8, "Sidney L. Holder"),
            }));
            departments.Add(new EmployeeDepartment("Production", new Employee[] {
                new Employee(9, "Christian P. Laclair"),
                new Employee(10, "James L. Kelsey"),
                new Employee(11, "Howard M. Carpenter"),
                new Employee(12, "Jennifer T. Tapia"),
            }));
            departments.Add(new EmployeeDepartment("Finance", new Employee[] {
                new Employee(13, "Karen J. Kelly"),
                new Employee(14, "Judith P. Underhill"),
                new Employee(15, "Russell E. Belton"),
            }));   
            return departments;
        }
    }
}
