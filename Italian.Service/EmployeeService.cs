using Italian.Core.Models;
using Italian.Core.Services;
using Italian.Data.Repositories;
using Italyano.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italyano.Service
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> GetAll()
        {
            // להוסיף לוגיקה עסקית.
            return _employeeRepository.GetEmployee();
        }
    }
}
