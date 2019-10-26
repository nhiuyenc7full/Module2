using EmployeeManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApp.Repository
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetAll { get; }
    }
}
