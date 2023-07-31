using CRUD_Web_API_Dotnet7.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Web_API_Dotnet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Employees>>> GetAllEmployees()
        {
            var result = await _employeeService.GetAllEmployees();
            return result;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetSingleEmployee(int id)
        {
            var result = await _employeeService.GetSingleEmployee(id);
            if (result is null)
                return NotFound("No such employee is available!!!");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Employees>>> AddEmployee([FromBody] Employees employee)
        {
            var result = await _employeeService.AddEmployee(employee);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Employees>>> UpdateEmployee(int id, Employees request)
        {

            var result = await _employeeService.UpdateEmployee(id, request);
            if (result is null)
                return NotFound("No such employee is available to update !!!");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Employees>>> DeleteEmployee(int id)
        {
            var result = await _employeeService.DeleteEmployee(id);
            if (result is null)
                return NotFound("No such employee is available to Delete !!!");
            return Ok(result);
        }
    }
}
