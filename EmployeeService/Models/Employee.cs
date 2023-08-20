using System.Collections.Generic;

namespace Models
{
    public class Employee
    { 
        public int ID { get; set; }
        public string Name { get; set; }
        public int? ManagerID { get; set; }
        public bool Enable { get; set; }
        public List<Employee> Employees { get; set; }
    }
}