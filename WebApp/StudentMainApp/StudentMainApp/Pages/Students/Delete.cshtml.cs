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
    public class DeleteModel : PageModel
    {
        private IStudentData studentData;
        [BindProperty]
        public int studentId { set; get; }
        public Student student { set; get; }
        public DeleteModel(IStudentData studentData)
        {
            this.studentData = studentData;
        }
        //public IActionResult OnGet(int? studentId)
        //{
        //    if (studentId.HasValue)
        //    {
        //        student = studentData.GetStudentById(studentId.Value);
        //    }
        //    else
        //    {
        //        student = new Student();
        //    }
        //    if (student == null)
        //    {
        //        return RedirectToPage("./NotFound");
        //    }
        //    else return Page();
        //}
        public IActionResult OnPost(int studentId)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (student.Id > 0)
            {
                studentData.Delete(studentId);
            }
            studentData.Commit();
            return RedirectToPage("./List");
        }
    }
}