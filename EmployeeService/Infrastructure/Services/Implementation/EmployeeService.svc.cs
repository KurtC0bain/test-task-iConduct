﻿using Helpers;
using Infrastructure.Repositories.Abstraction;
using Infrastructure.Repositories.Implementation;
using Infrastructure.Services.Abstraction;
using Models;
using System.Collections.Generic;
using System.Linq;

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
            var employees = EmployeeHelper.GetEmployees(_employeeRepository);

            var employee = EmployeeHelper.GetById(employees.ToList(), id);

            return !(employee is null);
        }


        public void EnableEmployee(int id, int enable)
        {
            _employeeRepository.EnableEmployee(id, enable);
        }

    }

}