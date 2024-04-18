using BLL.Interfaces;
using DAL;
using DAL.Models;

namespace BLL
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public void AddEmployee(Employee employee)
        {
            _employeeRepository.Add(employee);
        }
    }
}
