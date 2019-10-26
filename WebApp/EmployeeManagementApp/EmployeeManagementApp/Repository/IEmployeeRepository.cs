using EmployeeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll { get; }
        Employee GetById(int Id);
        void Add(Employee Employee);
        void Delete(Employee Employee);
        Employee Update(Employee Employee);
        int Commit();
    }
}
