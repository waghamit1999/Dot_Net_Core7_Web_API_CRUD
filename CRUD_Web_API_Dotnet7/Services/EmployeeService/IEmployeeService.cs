using Microsoft.AspNetCore.Mvc;

namespace CRUD_Web_API_Dotnet7.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employees>> GetAllEmployees();
        Task<Employees?> GetSingleEmployee(int id);
        Task<List<Employees>> AddEmployee([FromBody] Employees employee);
        Task<List<Employees>?> UpdateEmployee(int id, Employees request);
        Task<List<Employees>?> DeleteEmployee(int id);
    }
}
