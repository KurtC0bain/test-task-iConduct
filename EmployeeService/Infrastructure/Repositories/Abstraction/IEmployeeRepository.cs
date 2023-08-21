using System.Data;

namespace Infrastructure.Repositories.Abstraction
{
    public interface IEmployeeRepository
    {
        DataTable GetAllEmployees();

        void EnableEmployee(int employeeId, int enable);
    }
}
