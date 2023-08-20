using Models;
using System.Collections.Generic;
using System.Linq;

namespace Helpers
{
    public static class EmployeeHelper
    {
        public static Employee GetById(List<Employee> allEmployees, int id)
        {
            var employeeDictionary = allEmployees.ToDictionary(e => e.ID, e => e);
            if (employeeDictionary.TryGetValue(id, out var employee))
            {
                AssignEmployeesTree(employeeDictionary, employee);
                return employee;
            }
            return null;
        }

        private static void AssignEmployeesTree(Dictionary<int, Employee> employeeDictionary, Employee employee)
        {
            employee.Employees = new List<Employee>();
            foreach (var subEmployee in employeeDictionary.Values)
            {
                if (subEmployee.ManagerID == employee.ID)
                {
                    AssignEmployeesTree(employeeDictionary, subEmployee);
                    employee.Employees.Add(subEmployee);
                }
            }
        }
    }
}

