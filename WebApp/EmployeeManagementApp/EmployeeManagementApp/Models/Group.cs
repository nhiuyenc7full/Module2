using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        [Display(Name="Chọn nhóm nhân viên")]
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
