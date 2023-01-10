using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookProblem
{
    public class AdressBook
    {
       

        public static void CreateContact()
        {
            ContactDetails contactDetails = new ContactDetails();
            Console.WriteLine("Enter firstname: ");
            contactDetails.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Lastname: ");
            contactDetails.LastName = Console.ReadLine();

            Console.WriteLine("Enter your address: ");
            contactDetails.Address = Console.ReadLine();

            Console.WriteLine("Enter your email-id: ");
            contactDetails.Email = Console.ReadLine();

            Console.WriteLine("Enter your MobileNumber number:");
            contactDetails.MobileNumber = Convert.ToInt64( Console.ReadLine());

            Console.WriteLine("Enter your city: ");
            contactDetails.City = Console.ReadLine();

            Console.WriteLine(" Enter your state: ");
            contactDetails.State = Console.ReadLine();

            Console.WriteLine(" Enter ypur zipcode: ");
            contactDetails.zipcode = Convert.ToInt32(Console.ReadLine());

           Program.Person.Add(contactDetails);

        }
    }
}
