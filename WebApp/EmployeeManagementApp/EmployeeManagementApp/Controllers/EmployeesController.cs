using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementApp.Models;
using EmployeeManagementApp.Repository;
using EmployeeManagementApp.ViewModels;

namespace EmployeeManagementApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IGroupRepository groupRepository;


        public EmployeesController(AppDbContext context, IEmployeeRepository EmployeeRepository, IGroupRepository GroupRepository)
        {
            _context = context;
            this.employeeRepository = EmployeeRepository;
            this.groupRepository = GroupRepository;
        }

        public IActionResult Index()
        {
            var appDbContext = employeeRepository.GetAll.OrderBy(e => e.Name);
            return View(appDbContext.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = employeeRepository.GetAll.FirstOrDefault(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
        public IActionResult Create()
        { 
            GroupViewModel groupViewModel = new GroupViewModel();
            groupViewModel.GroupList = new SelectList(groupRepository.GetAll, "Id", "Name");
            
            return View(groupViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee Employee)
        {            
            if (ModelState.IsValid)
            {
                employeeRepository.Add(Employee);
                employeeRepository.Commit();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = employeeRepository.GetAll.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Name", employee.GroupId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,GroupId,Name,DateOfBirth,Sex,Tel,CMND,Email,Address")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    employeeRepository.Update(employee);
                    employeeRepository.Commit();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["GroupId"] = new SelectList(_context.Groups, "Id", "Id", employee.GroupId);
            return View(employee);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee =  employeeRepository.GetAll.FirstOrDefault(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var employee = employeeRepository.GetAll.FirstOrDefault(e => e.Id == id);
            employeeRepository.Delete(employee);
            employeeRepository.Commit();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return employeeRepository.GetAll.Any(e => e.Id == id);
        }
    }
}
