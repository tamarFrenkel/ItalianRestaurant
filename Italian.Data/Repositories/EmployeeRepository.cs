using Italian.Core.Models;
using Italyano.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Data.Repositories
{
    public class EmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public List<Employee> GetEmployee()
        {
            return _context.employees.ToList();

        }

        //public Employee AddEmployee(Employee employee)
        //{
        //    _context.employees.Add(employee);
        //    _context.SaveChanges();
        //    return employee;
        //}

        //public Employee UpdateEmployee(int id, Employee employee)
        //{
        //    var existEmployee = GetById(id);

        //    existEmployee.FirstName = employee.FirstName;
        //    existEmployee.LastName = employee.LastName;

        //    _context.SaveChanges();
        //    return existEmployee;
        //}

        //public void DeleteEmployee(Employee employee)
        //{
        //    var employee = GetById(id);
        //    _context.users.Remove(employee);
        //    _context.SaveChanges();
        //}


        // add , update, delete - user
    }
}
