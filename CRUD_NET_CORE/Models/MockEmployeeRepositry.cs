using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_NET_CORE.Models
{
    public class MockEmployeeRepositry : IEmployeeRepositry
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepositry()
        {
            _employeeList = new List<Employee>
            {
                new Employee{Id=1,Name="Bilal",Department="CS",Email="bilal@gmail.com"},
                new Employee{Id=2,Name="Ahsan",Department="CS",Email="bilal@gmail.com"},
                new Employee{Id=3,Name="Ahmad",Department="CS",Email="bilal@gmail.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
