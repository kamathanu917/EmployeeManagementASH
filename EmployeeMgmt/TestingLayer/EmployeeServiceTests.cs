using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using DAL;
using BLL.Interfaces;
using DAL.Models;
using DAL.Interfaces;
using BLL;

namespace TestingLayer
{
    [TestFixture]
    public class EmployeeServiceTests
    {
        private Mock<EmployeeRepository> _mockEmployeeRepository;
        private IEmployeeService _employeeService;

        [SetUp]
        public void SetUp()
        {
            _mockEmployeeRepository = new Mock<IEmployeeRepository>();
            _employeeService = new EmployeeService(_mockEmployeeRepository.Object);
        }

        [Test]
        public void GetAllEmployees_ReturnsListOfEmployees()
        {
            // Arrange
            var employees = new List<Employee>
        {
            new Employee { EmployeeID = 1, FirstName = "John", LastName = "Doe", Address1 = "123 Main St" },
            new Employee { EmployeeID = 2, FirstName = "Jane", LastName = "Smith", Address1 = "456 Elm St" }
        };
            _mockEmployeeRepository.Setup(r => r.GetAll()).Returns(employees);

            // Act
            var result = _employeeService.GetAllEmployees();

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("John", result[0].FirstName);
            Assert.AreEqual("Doe", result[0].LastName);
            Assert.AreEqual("123 Main St", result[0].Address1);
            Assert.AreEqual("Jane", result[1].FirstName);
            Assert.AreEqual("Smith", result[1].LastName);
            Assert.AreEqual("456 Elm St", result[1].Address1);
        }

        [Test]
        public void AddEmployee_ValidEmployee_AddsEmployeeSuccessfully()
        {
            // Arrange
            var employee = new Employee { EmployeeID = 3, FirstName = "Alice", LastName = "Johnson", Address1 = "789 Oak St" };

            // Act
            _employeeService.AddEmployee(employee);

            // Assert
            _mockEmployeeRepository.Verify(r => r.Add(employee), Times.Once);
        }
    }
}