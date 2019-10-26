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
    public class EditModel : PageModel
    {
        private readonly IStudentData studentData;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]
        public Student student { get; set; }
        [TempData]
        public string Message { set; get; }
        public IEnumerable<SelectListItem> Sports { get; set; }

        public EditModel(IStudentData studentData, IHtmlHelper htmlHelper)
        {
            this.studentData = studentData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? studentId)
        {
            Sports = htmlHelper.GetEnumSelectList<Sport>();
            if (studentId.HasValue)
            {
                student = studentData.GetStudentById(studentId.Value);
            }
            else
            {
                student = new Student();
            }
            if (student == null)
            {
                return NotFound();
            }
            else return Page();
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                Sports = htmlHelper.GetEnumSelectList<Sport>();
                return Page();
            }
            if(student.Id > 0)
            {
                studentData.Edit(student);
            }
            studentData.Commit();
            Message = "Edit succeed";
            return RedirectToPage("./Detail", new { studentId = student.Id });
        }
    }
}