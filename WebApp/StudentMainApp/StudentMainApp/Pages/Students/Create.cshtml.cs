using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentCore;
using StudentData;

namespace StudentMainApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly IStudentData studentData;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]
        public Student student { set; get; }
        public IEnumerable<SelectListItem> Sports { set; get; }

        public CreateModel(IStudentData studentData, IHtmlHelper htmlHelper)
        {
            this.studentData = studentData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet()
        {
            Sports = htmlHelper.GetEnumSelectList<Sport>();
            return Page();
        }
        public IActionResult OnPost()
        {
            Sports = htmlHelper.GetEnumSelectList<Sport>();
            studentData.Create(student);
            studentData.Commit();
            return RedirectToPage("./Detail", new { studentId = student.Id});
        }
    }
}