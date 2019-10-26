using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentCore;
using StudentData;

namespace StudentMainApp.Pages.Students
{
    public class DetailModel : PageModel
    {
        private readonly IStudentData studentData;

        public DetailModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }

        public Student student { get; private set; }

        public IActionResult OnGet(int studentId)
        {
            student = studentData.GetStudentById(studentId);
            if(student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}