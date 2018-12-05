using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSS.DataLayer.Entities;

namespace KSS.DataLayer.Repository
{
    public class EmployeeRepository
    {
        private readonly KSSDBContext _kssdbContext;

        public EmployeeRepository()
        {
            _kssdbContext = new KSSDBContext();
        }

        public List<Employee> GetListOfEmployees()
        {
            return _kssdbContext.Employees.ToList();
        }

        public int AddEmployee(Employee employee)
        {
            _kssdbContext.Employees.Add(employee);

            return _kssdbContext.SaveChanges();
        }
    }
}
