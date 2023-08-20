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
            var statement = "SELECT * FROM Employee";

            using (var connection = new SqlConnection(_сonnectionString))
            {
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = statement;

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}

