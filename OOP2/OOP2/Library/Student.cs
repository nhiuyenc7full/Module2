using System;
using System.Collections.Generic;
using System.Text;
using BorrowBook;

namespace Library
{
    public class Student
    {
        private int studentID = 0;
        private string studentName;
        private int age;
        private string gender;
        private string city;
        private static int idCount = 1;
        private List<Book> listBook = new List<Book>();

        public int StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string City { get => city; set => city = value; }
        public List<Book> ListBook { get => listBook; }

        StudentRepository studentRepo = new StudentRepository();
        public Student()
        {
            List<Book> listBook = ListBook;
            StudentID = StudentID + idCount;
            idCount++;
        }

        public void CreateStudentInfo()
        {
            Console.Write("Enter name student: ");
            StudentName = Console.ReadLine();
            Console.Write("Enter age student: ");
            Age = studentRepo.EnterAge();
            Console.Write("Enter gender student (male/female): ");
            Gender = studentRepo.EnterGender();
            Console.Write("Enter city student: ");
            City = studentRepo.EnterCity();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student information: \n ******************************************");
            Console.WriteLine($"ID: {StudentID};\nName: {StudentName};\nAge: {Age};\nGender: {Gender};\nCity: {City}.\n");
        }

    }
}
