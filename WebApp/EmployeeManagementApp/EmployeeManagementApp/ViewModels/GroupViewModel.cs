using EmployeeManagementApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.ViewModels
{
    public class GroupViewModel
    {
        //public Group Group { get; set; }
        public Employee Employee { get; set; }
        public SelectList GroupList { get; set; }
        //public IEnumerable<Group> Groups { get; set; }
    }
}
