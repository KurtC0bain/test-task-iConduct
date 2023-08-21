using System.Data;
using System.Data.SqlClient;

namespace EmployeeService.Helpers
{
    public static class SqlHelper
    {
        public static SqlDataAdapter GetSelectAdapter(SqlConnection connection)
        {
            var adapter = new SqlDataAdapter
            {
                SelectCommand = new SqlCommand("SELECT * FROM Employee", connection)
            };
            return adapter;
        }

        public static SqlDataAdapter GetUpdateAdapter(SqlConnection connection, int id, int enable)
        {
            var adapter = new SqlDataAdapter();

            var updateCommand = new SqlCommand("UPDATE Employee SET Enable = @enable WHERE ID = @id", connection);

            updateCommand.Parameters.Add("@id", SqlDbType.Int).Value = id;
            updateCommand.Parameters.Add("@enable", SqlDbType.Bit).Value = enable;

            adapter.UpdateCommand = updateCommand;
            
            return adapter;
        }
    }
}