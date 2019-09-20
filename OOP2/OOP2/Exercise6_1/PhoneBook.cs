using System;
using System.Collections;
using System.Text;

namespace Exercise6_1
{
    public class PhoneBook : IPhoneBook
    {
        private SortedList listPhoneBook = new SortedList();

        public string Name { get; set; }
        public int Phone { get; set; }
        public SortedList ListPhoneBook { get => listPhoneBook; }

        public PhoneBook()
        {
            Name = "Uyen";
            Phone = 123456;

        }
        public PhoneBook(string name,  int phone)
        {
            Name = name;
            Phone = phone;
        }
        public void InsertPhone(string name, int phone)
        {
            if (ListPhoneBook.ContainsKey(name))
            {
                ListPhoneBook[name] = phone;
            }
            else
            {
                ListPhoneBook.Add(name, phone);
            }
            Console.WriteLine("\t\tInsert succeeded...");
        }
        public void RemovePhone(string name)
        {
            if (ListPhoneBook.ContainsKey(name))
            {
                ListPhoneBook.Remove(name);
                Console.WriteLine("\t\tRemove succeeded...");
            }
            else Console.WriteLine("Not found.");
            Console.WriteLine("\t\tRemove finish...");
        }
        public void UpdatePhone(string name, int newphone)
        {
            if (ListPhoneBook.ContainsKey(name))
            {
                ListPhoneBook[name] = newphone;
                Console.WriteLine("\t\tUpdate succeeded...");
            }
            else
            {
                Console.WriteLine("\t\tNot found.");
            }
        }
        public void SearchPhone(string name)
        {
            if (ListPhoneBook.ContainsKey(name))
            {
                Console.WriteLine("Phone: {0}", ListPhoneBook[name].ToString());
            }
            else Console.WriteLine("Not found.");
            Console.WriteLine("Search phone finished...");
        }
        public void Sort()
        {
            if (ListPhoneBook.Count == 0)
            {
                Console.WriteLine("\t\tNo phonebook to sort...");
            }
            foreach (var item in ListPhoneBook.Keys)
            {
                Console.WriteLine(item.ToString() + "\t: " + ListPhoneBook[item]);
            }
        }

    }
}
