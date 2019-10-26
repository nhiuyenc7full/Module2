using System;
using System.Collections.Generic;
using System.Text;
using StudentCore;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentData
{
    public class SqlStudentData : IStudentData
    {
        private readonly StudentContext DbContext;

        public SqlStudentData(StudentContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public int Commit()
        {
            try
            {
                return DbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                return 0;
            }
        }

        public Student Create(Student newStudent)
        {
            DbContext.Add(newStudent);
            return newStudent;
        }

        public Student Delete(int studentId)
        {
            var student = GetStudentById(studentId);
            DbContext.Students.Remove(student);
            return student;
        }

        public Student Edit(Student updateStudent)
        {
            var student = DbContext.Students.Attach(updateStudent);
            student.State = EntityState.Modified;
            return updateStudent;
        }

        public Student GetStudentById(int studentId)
        {
            return DbContext.Students.Find(studentId);
        }

        public IEnumerable<Student> GetStudentByName(string name)
        {
            var result = from s in DbContext.Students
                         where string.IsNullOrEmpty(name) || s.Name.StartsWith(name)
                         select s;
            return result;
        }
    }
}
