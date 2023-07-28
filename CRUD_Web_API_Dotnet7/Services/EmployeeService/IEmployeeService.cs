using Microsoft.AspNetCore.Mvc;

namespace CRUD_Web_API_Dotnet7.Services.EmployeeService
{
    public interface IEmployeeService
    {
        List<Employees> GetAllEmployees();
        Employees? GetSingleEmployee(int id);
        List<Employees> AddEmployee([FromBody] Employees employee);
        List<Employees>? UpdateEmployee(int id, Employees request);
        List<Employees>? DeleteEmployee(int id);
    }
}
