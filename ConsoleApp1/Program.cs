using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class AdressBook
    {
        public string FirstName;
        public string LastName;
        public string City;
        public int age;
       


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System");
            AdressBook ContactDetails1 = new AdressBook() { FirstName = "Vishal", LastName = "Girase", City = "pune", age = 26 };
            AdressBook ContactDetails2 = new AdressBook() { FirstName = "Rajesh", LastName = "Rajput", City = "Mumbai", age =18  };
            AdressBook ContactDetails3 = new AdressBook() { FirstName = "Vidhi", LastName = "Shah", City = "surat", age = 21 };
            AdressBook ContactDetails4 = new AdressBook() { FirstName = "Shridi", LastName = "Sing", City = "surat", age = 20 };

            List<AdressBook> Contact = new List<AdressBook>();
            Contact.Add(ContactDetails1);
            Contact.Add(ContactDetails2);
            Contact.Add(ContactDetails3);
            Contact.Add(ContactDetails4);


            foreach (AdressBook item in Contact)
            {
                Console.WriteLine($"\n First Name : {item.FirstName}\n Last Name: {item.LastName}\n City : {item.City}\n Age : {item.age}\n \n");

            }
           


        }
    }
}
