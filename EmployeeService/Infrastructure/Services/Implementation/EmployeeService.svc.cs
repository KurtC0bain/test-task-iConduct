using Helpers;
using Infrastructure.Repositories.Abstraction;
using Infrastructure.Repositories.Implementation;
using Infrastructure.Services.Abstraction;
using Models;

namespace Infrastructure.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public bool GetEmployeeById(int id)
        {
            var employeesDataTable = _employeeRepository.GetAllEmployees();

            var employees = ConvertHelper.ConvertDataTable<Employee>(employeesDataTable);

            var employee = EmployeeHelper.GetById(employees, id);

            return !(employee is null);
        }



        public void EnableEmployee(int id, int enable)
        {

        }




    }


}