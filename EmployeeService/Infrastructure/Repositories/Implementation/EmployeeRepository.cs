using EmployeeService.Helpers;
using Infrastructure.Repositories.Abstraction;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.Repositories.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly string _сonnectionString;

        public EmployeeRepository()
        {
            _сonnectionString = "Data Source=(local);Initial Catalog=Test;Integrated Security=true";
        }

        public DataTable GetAllEmployees()
        {
            var dt = new DataTable();

            using (var connection = new SqlConnection(_сonnectionString))
            {
                connection.Open();

                SqlHelper.GetSelectAdapter(connection).Fill(dt);

                connection.Close();
            }
            return dt;
        }
        public void EnableEmployee(int employeeId, int enable)
        {
            using (var connection = new SqlConnection(_сonnectionString))
            {
                connection.Open();

                SqlHelper.GetUpdateAdapter(connection, employeeId, enable).UpdateCommand.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}

