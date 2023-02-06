using System.IO;
using System;
using System.Reflection;

namespace AdressBookProblem
{
    public class Program
    {
        public static Dictionary<string, ContactDetails> Person = new Dictionary<string, ContactDetails>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");
            AdressBook.ReadRecordsFromFile(AdressBook.path);
            Console.Write("Enter 'y' to Enter Contact Details : ");
            var input = Console.ReadLine();

            while (input == "y")
            {
                AdressBook.CreateContact();
                Console.Write("Enter 'y' to Enter Contact Details or otherwise Enter any key : ");
                input = Console.ReadLine();
            }
            AdressBook.ReadRecordsFromFile(AdressBook.path);
            AdressBook.EditByFirstName();
            AdressBook.DisplayContactDetails();
            AdressBook.DeleteByUniqueName();
            AdressBook.DisplayContactDetails();
            AdressBook.SearchContactUsingCityorState();
            AdressBook.SortByFirstName();
            AdressBook.SortByCityOrStateOrZip();


        }
    }
}