using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentCore;
using StudentData;

namespace StudentMainApp.Pages.Students
{
    public class ListModel : PageModel
    {
        private readonly IStudentData studentData;

        public ListModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }

        public IEnumerable<Student> Students { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchKeyWord { get; set; }
        public Student student { get; set; }

        public void OnGet()
        {
            Students = studentData.GetStudentByName(SearchKeyWord);
        }
        public IActionResult OnPostDelete(int studentId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (studentId > 0)
            {
                studentData.Delete(studentId);
            }
            studentData.Commit();
            return RedirectToPage("List");
        }
    }
}