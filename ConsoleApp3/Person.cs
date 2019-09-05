using System;
using System.Collections.Generic;
using System.Text;
 

namespace OOP
{
    public class Person
    {
        protected int age;

        public void setAge(int n)
        {
            age = n;
        }
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }

    class Teacher : Person
    {
        private string Subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }

    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old.", age);
        }
    }
    class StudentAndTeacherTest
    {
        static void Main()
        {
            //bool debug = false;

            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.setAge(20);
            student.Greet();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.setAge(30);
            teacher.Greet();
            teacher.Explain();

            //if (debug)
            //    Console.ReadLine();
        }
    }
}
