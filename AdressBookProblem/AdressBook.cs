using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookProblem
{
    public class AdressBook
    {
        public static void CreateContact()
        {

            ContactDetails contactDetails = new ContactDetails();

            Console.WriteLine("Enter Uniquename: ");
            contactDetails.Uniquename = Console.ReadLine();

            Console.WriteLine("Enter Firstname: ");
            contactDetails.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Lastname: ");
            contactDetails.LastName = Console.ReadLine();

            Console.WriteLine("Enter your address: ");
            contactDetails.Address = Console.ReadLine();

            Console.WriteLine("Enter your email-id: ");
            contactDetails.Email = Console.ReadLine();

            Console.WriteLine("Enter your MobileNumber number:");
            contactDetails.MobileNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter your city: ");
            contactDetails.City = Console.ReadLine();

            Console.WriteLine(" Enter your state: ");
            contactDetails.State = Console.ReadLine();

            Console.WriteLine(" Enter ypur zipcode: ");
            contactDetails.zipcode = Convert.ToInt32(Console.ReadLine());

            Program.Person.Add(contactDetails.Uniquename, contactDetails);

        }
        public static ContactDetails GetByFirstName(string firstName)
        {
            
            foreach (var item in Program.Person)
            {
                if (item.Value.FirstName == firstName)
                {
                    return item.Value;
                }
            }
            return null;

        }


        public static void EditByFirstName()
        {
            Console.WriteLine("Enter First Name To Edit: ");
            string firstName = Console.ReadLine();
            var contact = GetByFirstName(firstName);
            Console.WriteLine("Select Which Detail you want to Edit : \n1. First Name \n2. Last Name \n3. Mobile Number \n4. Email ID \n5. Address \n6. City \n7. State \n8. Zip Code \n9. Uniquname");
            int editDetail = Convert.ToInt32(Console.ReadLine());
            switch (editDetail)
            {
                case 1:
                    Console.Write("Enter First Name to Update : ");
                    string fName = Console.ReadLine();
                    contact.FirstName = fName;
                    break;
                case 2:
                    Console.Write("Enter Last Name to Update : ");
                    string lastName = Console.ReadLine();
                    contact.LastName = lastName;
                    break;
                case 3:
                    Console.Write("Enter Mobile Number to Update : ");
                    long mobNumber = Convert.ToInt64(Console.ReadLine());
                    contact.MobileNumber = mobNumber;
                    break;
                case 4:
                    Console.Write("Enter Email ID to Update : ");
                    string email = Console.ReadLine();
                    contact.Email = email;
                    break;
                case 5:
                    Console.Write("Enter Address to Update : ");
                    string address = Console.ReadLine();
                    contact.Address = address;
                    break;
                case 6:
                    Console.Write("Enter City to Update : ");
                    string city = Console.ReadLine();
                    contact.City = city;
                    break;
                
                case 7:
                    Console.Write("Enter State to Update : ");
                    string state = Console.ReadLine();
                    contact.State = state;
                    break;
                case 8:
                    Console.Write("Enter Zipcode to Update : ");
                    int zipcode = Convert.ToInt32(Console.ReadLine());
                    contact.zipcode = zipcode;
                    break;
                case 9:
                    Console.Write("Enter Uniquename to Update : ");
                    string uniquname = Console.ReadLine();
                    contact.Uniquename = uniquname;
                    break;
            }
            
        }
        public static void DisplayContactDetails()
        {
            foreach (var item in Program.Person)
            {
                Console.WriteLine("Unique Name is : " + item.Value.Uniquename);
                Console.WriteLine("First Name is : " + item.Value.FirstName);
                Console.WriteLine("Last Name is : " + item.Value.LastName);
                Console.WriteLine("Mobile Number is : " + item.Value.MobileNumber);
                Console.WriteLine("Email ID is : " + item.Value.Email);
                Console.WriteLine("Address is : " + item.Value.Address);
                Console.WriteLine("City is : " + item.Value.City);
                Console.WriteLine("State is : " + item.Value.State);
                Console.WriteLine("Zip Code is : " + item.Value.zipcode);
                Console.WriteLine();
            }
        }
        public static void DeleteByUniqueName()
        {
            Console.WriteLine("Enter Unique Name To Delete: ");
            string UniqueName = Console.ReadLine();
            Program.Person.Remove(UniqueName);
        }
    }
}
