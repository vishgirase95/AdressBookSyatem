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

            string YesOrNO = "Y";
            while (YesOrNO == "Y")
            {
                AddInput();
                PrintOutPut();


                Console.WriteLine("Do You want to  Edit Contact, Please type Y or N ?");
                YesOrNO = Console.ReadLine().ToUpper();
                if (YesOrNO == "N")


                    break;
                Console.WriteLine("\n \n Please Enter the Name You want to edit");
                string NameToRemove = Console.ReadLine();
                Contact.Remove(NameToRemove);

                Console.WriteLine($"\n ****************************Please Enter the New details now********************\n \n");

              





            };




        }
    }
}
