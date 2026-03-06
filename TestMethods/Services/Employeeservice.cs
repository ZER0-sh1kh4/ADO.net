using System;
using System.Collections.Generic;
using System.Text;
using TestMethods.Repository;
using TestMethods.Model;

namespace TestMethods.Services
{
    public sealed class Employeeservice
    {
        private readonly IEmployeeRepository _repo;
        public Employeeservice(IEmployeeRepository repo)
        {
            _repo = repo;
        }
        public Employee GetEmployeeOrThrow(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "Id must be positive");
            var employee = _repo.GetById(id);
            if(employee is null)
            {
                throw new KeyNotFoundException("Employee with id " + id + " not found");
            }
            return employee;
        }
        public void AddEmployee(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));

            if (string.IsNullOrWhiteSpace(employee.Name))
                throw new ArgumentException("Name is required");

            _repo.Add(employee);
        }
    }
}
