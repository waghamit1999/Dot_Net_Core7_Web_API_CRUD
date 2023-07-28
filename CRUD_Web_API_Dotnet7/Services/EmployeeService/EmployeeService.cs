using Microsoft.AspNetCore.Mvc;

namespace CRUD_Web_API_Dotnet7.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employees> employees = new List<Employees>{
                new Employees
                   {
                    Id = 1,
                    Name = "Amit",
                    Designation = "Software Developer",
                    Address = "Chiplun",
                    Email = "amit.waghmare@arconnet.com",
                    Gender = "Male",
                    PhoneNumber = 9988776655,
                   },
                new Employees
                   {
                    Id = 2,
                    Name = "Janam",
                    Designation = "Software Developer Team Lead",
                    Address = "Pune",
                    Email = "jb@arconnet.com",
                    Gender = "Male",
                    PhoneNumber = 4455336622,
                   },
                new Employees
                   {
                    Id = 3,
                    Name = "Raj",
                    Designation = "Software Developer",
                    Address = "Mumbai",
                    Email = "rs@arconnet.com",
                    Gender = "Male",
                    PhoneNumber = 9944334422,
                   },
                new Employees
                   {
                    Id = 4,
                    Name = "Hetvi",
                    Designation = "Intern Software Developer",
                    Address = "Mumbai",
                    Email = "hs@arconnet.com",
                    Gender = "Female",
                    PhoneNumber = 6677554433,
                   },
                new Employees
                   {
                    Id = 5,
                    Name = "Jenson",
                    Designation = "Intern Software Developer",
                    Address = "Mumbai",
                    Email = "jj@arconnet.com",
                    Gender = "Male",
                    PhoneNumber = 9900000055,
                   }
                };

        public List<Employees> AddEmployee([FromBody] Employees employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employees> GetAllEmployees()
        {
            return employees;
        }

        public Employees? GetSingleEmployee(int id)
        {
            var employee = employees.Find(x => x.Id == id);
            if (employee is null)
                return null;

            return employee;
        }

        public List<Employees>? UpdateEmployee(int id, Employees request)
        {
            var employee = employees.Find(x => x.Id == id);
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
                return employees;
            }
        }

        public List<Employees>? DeleteEmployee(int id)
        {
            var employee = employees.Find(x => x.Id == id);
            if (employee is null)
            {
                return null;
            }
            else
            {
                employees.Remove(employee);
                return employees;
            }
        }
    }
}
