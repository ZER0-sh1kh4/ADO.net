using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using NUnit.Framework;
using TestMethods.Repository;
using TestMethods.Services;
using TestMethods.Model;

namespace TestMethods.Test
{
    [TestFixture]
    public sealed class EmployeeTest {
        private Mock<IEmployeeRepository> _repoMock = default;
        private Employeeservice _service = default;
        [SetUp]
        public void Setup()
        {
            _repoMock=new Mock<IEmployeeRepository>(MockBehavior.Strict);
            _service = new Employeeservice(_repoMock.Object);

        }
        [Test]
        public void GetEmployeeOrThrow_ShouldRecturnEmployee_WhenEmployeeExists()
        {
            var employee = new Employee { Id = 1, Name = "shikha", Email = "sh1kh4g@gmail.com" };
            _repoMock.Setup(r => r.GetById(1)).Returns(employee);
            // Act
            var result = _service.GetEmployeeOrThrow(1);

            // Assert
            Assert.AreEqual(1, result.Id);
            Assert.IsNotNull(result);
            Assert.AreEqual("shikha", result.Name);
            Assert.AreSame(employee, result);
           
            _repoMock.Verify(r => r.GetById(1), Times.Once);

        }
        [Test]
        public void AddEmployee_ShouldCallRepository_WhenEmployeeIsValid()
        {
            // Arrange
            var employee = new Employee { Id = 2, Name = "aakarsh", Email = "aakarsh@gmail.com" };
            _repoMock.Setup(r => r.Add(employee));
            // Act
            _service.AddEmployee(employee);
            // Assert
            _repoMock.Verify(r => r.Add(employee), Times.Once);
        }
    }


}
