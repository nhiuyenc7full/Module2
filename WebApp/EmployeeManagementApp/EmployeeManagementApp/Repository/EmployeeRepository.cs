using EmployeeManagementApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;

        public EmployeeRepository(AppDbContext _context)
        {
            this.context = _context;
        }
        public IEnumerable<Employee> GetAll
        {
            get
            {
                return context.Employees.Include(e => e.Group);
            }
        }

        public void Add(Employee Employee)
        {
            context.Add(Employee);
        }

        public int Commit()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (System.Exception)
            {
                return 0;
            }
        }

        public void Delete(Employee Employee)
        {
            context.Remove(Employee);
        }

        public Employee GetById(int Id)
        {
            return context.Employees.Include(d => d.Group).FirstOrDefault(d => d.Id == Id);
        }

        public Employee Update(Employee Employee)
        {
            context.Update(Employee);
            return Employee;
        }
    }
}
