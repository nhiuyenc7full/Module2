using StudentCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentData
{
    public interface IStudentData
    {
        IEnumerable<Student> GetStudentByName(string name); 
        Student Create(Student newStudent);
        Student Edit(Student updateStudent);
        Student Delete(int studentId);
        Student GetStudentById(int studentId);
        int Commit();
    }
}
