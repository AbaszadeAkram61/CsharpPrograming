using Microsoft.AspNetCore.Mvc;

namespace lesson17_WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private static List<Employee> _employess = new List<Employee>();

        [HttpGet("All")]
        public List<Employee> GetEmployees()
        {
            return _employess;
        }

        [HttpPost("Create")]
        public Employee CreateEmployee(Employee employee)
        {
            _employess.Add(employee);
            return employee;
        }

        [HttpPut("Update")]
        public Employee UpdateEmployee(int id,Employee newemployee)
        {
            var emplyee = _employess.FirstOrDefault(x => x.Id == id);
            emplyee.Name = newemployee.Name;
            return newemployee;

        }
        [HttpDelete("Delete")]
        public Employee DeleteEmployee(int id, Employee employee)
        {
            var employye = _employess.FirstOrDefault(x => x.Id == id);
            _employess.Remove(employye);
            return employee;
        }


    }
}
