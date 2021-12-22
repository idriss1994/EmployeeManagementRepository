using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee { Id = 1, Name ="Mary",Department= Dept.HR, Email = "mary@gmial.com"},
                new Employee { Id = 2, Name = "Idriss", Department = Dept.IT,Email = "idriss19942@gmail.com"},
                new Employee { Id = 3, Name="Sam", Department = Dept.IT, Email = "sam@gmail.com"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return this.Find(id);
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);

            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            var oldEmployee = this.Find(employeeChanges.Id);
            
            if(oldEmployee != null)
            {
                oldEmployee.Name = employeeChanges.Name;
                oldEmployee.Email = employeeChanges.Email;
                oldEmployee.Department = employeeChanges.Department;
            }

            return oldEmployee;
        }

        public Employee Delete(int id)
        {
            var employee = this.Find(id);
            if(employee != null)
            {
                _employeeList.Remove(employee);
            }

            return employee;
        }

    }
}
