using Microsoft.AspNetCore.Mvc;

namespace CRUD_Web_API_Dotnet7.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Employees>> AddEmployee([FromBody] Employees employee)
        {
            _context.Employees.Add(employee);

            await _context.SaveChangesAsync();

            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employees>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employees?> GetSingleEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee is null)
                return null;

            return employee;
        }

        public async Task<List<Employees>?> UpdateEmployee(int id, Employees request)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee is null)
            {
                return null;
            }
            else
            {
                employee.Name = request.Name;
                employee.Designation = request.Designation;
                employee.Gender = request.Gender;
                employee.Address = request.Address;
                employee.Email = request.Email;
                employee.PhoneNumber = request.PhoneNumber;

                await _context.SaveChangesAsync();

                return await _context.Employees.ToListAsync();
            }
        }

        public async Task<List<Employees>?> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee is null)
            {
                return null;
            }
            else
            {
                _context.Employees.Remove(employee);

                await _context.SaveChangesAsync();

                return await _context.Employees.ToListAsync();
            }
        }
    }
}
