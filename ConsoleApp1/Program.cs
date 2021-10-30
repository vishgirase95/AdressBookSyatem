using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

    class AdressBook
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public string City { get; set; }


    }

   


    class Program
    {
       public static Dictionary<string, AdressBook> Contact = new Dictionary<string, AdressBook>();

        public static void AddInput()
        {
            Console.WriteLine("Welcome to Address Book System");


            AdressBook ContactDetails1 = new AdressBook();
            Console.WriteLine("Please Enter The First Name : ");
            ContactDetails1.FirstName = Console.ReadLine();
            Console.WriteLine("Please Enter The Last Name : ");
            ContactDetails1.LastName = Console.ReadLine();
            Console.WriteLine("Please Enter The Age : ");
            ContactDetails1.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter The City : ");
            ContactDetails1.City = Console.ReadLine();


            Contact.Add(ContactDetails1.FirstName, ContactDetails1);

        }

        public static void PrintOutPut()
        {
            Console.WriteLine(" \n \n \n Please Check Your Contact Detail");

            foreach (var item in Contact)
            {
                Console.WriteLine($"\n First Name : {item.Value.FirstName} \n Last name : {item.Value.LastName} \n Age : {item.Value.age} \n City : {item.Value.age}");
            }
        }

        static void Main(string[] args)
        {


            //AdressBook ContactDetails2 = new AdressBook() { FirstName = "Rajesh", LastName = "Rajput", City = "Mumbai", age =18  };
            //AdressBook ContactDetails3 = new AdressBook() { FirstName = "Vidhi", LastName = "Shah", City = "surat", age = 21 };
            //AdressBook ContactDetails4 = new AdressBook() { FirstName = "Shridi", LastName = "Sing", City = "surat", age = 20 };


            //Contact.Add(ContactDetails2);
            //Contact.Add(ContactDetails3);

            AddInput();
            PrintOutPut();
           


        }
    }
}
