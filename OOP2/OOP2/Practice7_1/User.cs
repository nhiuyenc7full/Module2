using System;
using System.Collections.Generic;
using System.Text;

namespace Practice7_1
{
    public class User :IUserPro
    {
        private int iD;
        private string name;
        private string password;
        private static int idCount = 1;
        private List<int?> phoneList;
        
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public List<int?> PhoneList { get => phoneList; set => phoneList = value; }

        //public int? this[int index] { get => this[index]; set => this[index] = value; }

        public User()
        {
            PhoneList = new List<int?>();
            ID = ID + idCount;
            idCount++;
        }
        public User(string name, string password)
        {
            PhoneList = new List<int?>();
            Name = name;
            Password = password;
            ID = ID + idCount;
            idCount++;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name};\tPassword: {Password};\tID: {ID}");
        }
    }
}
