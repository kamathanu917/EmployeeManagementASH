using BLL.Interfaces;
using DAL.Models;
using EmployeeMgmt.Models;
using System.Web.Http;

namespace EmployeeMgmt.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            var employees = _employeeService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public IHttpActionResult AddEmployee(EmployeeModel employeeModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var employee = MapToEmployee(employeeModel);
            _employeeService.AddEmployee(employee);

            return Ok();
        }

        private Employee MapToEmployee(EmployeeModel employeeModel)
        {
            // Mapping logic...
            return null;
        }
    }
}
