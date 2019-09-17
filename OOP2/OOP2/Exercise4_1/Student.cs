using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4_1
{
    class Student : IStudent
    {
        private string _fullName;
        private DateTime _dateofBirth;
        private int _iD = 1000;
        private string _native;
        private string _class;
        private int _phoneNo;
        private string _mobile;
        private static int number = 0;
        public string FullName{ get => _fullName; set => _fullName = value; }
        public DateTime DateofBirth { get => _dateofBirth; set => _dateofBirth = value; }
        public int ID { get => _iD; set => _iD = value; }
        public string Native { get => _native; set => _native = value; }
        public string Class { get => _class; set => _class = value; }
        public int PhoneNo { get => _phoneNo; set => _phoneNo = value; }
        public string Mobile { get => _mobile; set => _mobile = value; }

        public Student()
        {
            ID = ID + number;
            number++;
        }

        public Student(string fullName, DateTime dateofBirth, string native, string _class, int phoneNo, string mobile)
        {
            FullName = fullName;
            DateofBirth = dateofBirth;
            Native = native;
            Class = _class;
            PhoneNo = phoneNo;
            Mobile = mobile;
            ID = ID + number;
            number++;
        }

        public void Display()
        {
            Console.WriteLine($"Full name: {FullName};\n" +
                $"ID: {ID};\n" +
                $"Date of birth: {DateofBirth};\n" +
                $"Native: {Native};\n" +
                $"Class: {Class};\n" +
                $"Phone number: {PhoneNo};\n" +
                $"Mobile: {Mobile}.\n");
        }
    }
}
