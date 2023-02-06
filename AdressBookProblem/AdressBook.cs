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
           public static string path = @"D:\6.AddressBook\AdressBookProblem\AdressBookProblem\Details.txt";
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


            var contact = Program.Person.SingleOrDefault(detail => detail.Value.Equals(contactDetails));
            if (contact.Value == null)
            {
                WriteRecordsInFile(path, contactDetails);
                Program.Person.Add(contactDetails.Uniquename, contactDetails);
            }
            else
            {
                Console.WriteLine($"\nThe Contact Name {contactDetails.FirstName} is Already Exists");
            }

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
        public static void SearchContactUsingCityorState()
        {
            Console.WriteLine("\nEnter 1 to Search Contact Using City \n" +
                "Enter 2 to Search Contact Using State");
            int intput = Convert.ToInt32(Console.ReadLine());
            switch (intput)
            {
                case 1:
                    int cityCount = 0;
                    Console.Write("Enter City to Search Contact : ");
                    string city = Console.ReadLine();
                    var contacts = Program.Person.Where(detail => detail.Value.City == city);
                    Console.WriteLine("\n***** Contacts in Address Book *****");
                    if (!contacts.Any())
                    {
                        Console.WriteLine($"Contacts Not Available in Address Book of City {city}\n");
                        return;
                    }
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine("Unique Name is : " + contact.Value.Uniquename);
                        Console.WriteLine("First Name is : " + contact.Value.FirstName);
                        Console.WriteLine("Last Name is : " + contact.Value.LastName);
                        Console.WriteLine("Mobile Number is : " + contact.Value.MobileNumber);
                        Console.WriteLine("Email ID is : " + contact.Value.Email);
                        Console.WriteLine("Address is : " + contact.Value.Address);
                        Console.WriteLine("City is : " + contact.Value.City);
                        Console.WriteLine("State is : " + contact.Value.State);
                        Console.WriteLine("Zip Code is : " + contact.Value.zipcode);
                        Console.WriteLine();
                        cityCount++;

                    }
                    Console.WriteLine($"There are {cityCount} Contact of {city} City");
                    Console.WriteLine();
                    break;

                case 2:
                    int stateCount = 0;
                    Console.Write("Enter State to Search Contact : ");
                    string state = Console.ReadLine();
                    var contactState = Program.Person.Where(detail => detail.Value.State == state);
                    Console.WriteLine("\n*** Contacts in Address Book ***");
                    if (!contactState.Any())
                    {
                        Console.WriteLine($"Contacts Not Available in Address Book of State {state}\n");
                        return;
                    }
                    foreach (var contact in contactState)
                    {
                        Console.WriteLine("Unique Name is : " + contact.Value.Uniquename);
                        Console.WriteLine("First Name is : " + contact.Value.FirstName);
                        Console.WriteLine("Last Name is : " + contact.Value.LastName);
                        Console.WriteLine("Mobile Number is : " + contact.Value.MobileNumber);
                        Console.WriteLine("Email ID is : " + contact.Value.Email);
                        Console.WriteLine("Address is : " + contact.Value.Address);
                        Console.WriteLine("City is : " + contact.Value.City);
                        Console.WriteLine("State is : " + contact.Value.State);
                        Console.WriteLine("Zip Code is : " + contact.Value.zipcode);
                        Console.WriteLine();
                        stateCount++;
                    }
                    Console.WriteLine($"There are {stateCount} Contact of {state} State");
                    Console.WriteLine();
                    break;
            }

        }
        public static void SortByFirstName()
        {
            if (Program.Person.Count > 0)
            {
                var Contact = Program.Person.OrderBy(x => x.Value.FirstName);

                foreach (var personContact in Contact)
                {
                    Console.WriteLine("Unique Name is : " + personContact.Value.Uniquename);
                    Console.WriteLine("First Name is : " + personContact.Value.FirstName);
                    Console.WriteLine("Last Name is : " + personContact.Value.LastName);
                    Console.WriteLine("Mobile Number is : " + personContact.Value.MobileNumber);
                    Console.WriteLine("Email ID is : " + personContact.Value.Email);
                    Console.WriteLine("Address is : " + personContact.Value.Address);
                    Console.WriteLine("City is : " + personContact.Value.City);
                    Console.WriteLine("State is : " + personContact.Value.State);
                    Console.WriteLine("Zip Code is : " + personContact.Value.zipcode);
                    Console.WriteLine();

                    Console.WriteLine("------------------\n");
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }
        public static void SortByCityOrStateOrZip()
        {
            if (Program.Person.Count > 0)
            {
                Console.WriteLine("1-Sort By City /n2-Sort By state /n3-Sort By zip");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:

                        var Contact = Program.Person.OrderBy(x => x.Value.City);

                        foreach (var personContact in Contact)
                        {
                            Console.WriteLine("Unique Name is : " + personContact.Value.Uniquename);
                            Console.WriteLine("First Name is : " + personContact.Value.FirstName);
                            Console.WriteLine("Last Name is : " + personContact.Value.LastName);
                            Console.WriteLine("Mobile Number is : " + personContact.Value.MobileNumber);
                            Console.WriteLine("Email ID is : " + personContact.Value.Email);
                            Console.WriteLine("Address is : " + personContact.Value.Address);
                            Console.WriteLine("City is : " + personContact.Value.City);
                            Console.WriteLine("State is : " + personContact.Value.State);
                            Console.WriteLine("Zip Code is : " + personContact.Value.zipcode);
                            Console.WriteLine();

                            Console.WriteLine("------------------\n");
                        }
                        break;
                    case 2:
                        var Contact1 = Program.Person.OrderBy(x => x.Value.State);

                        foreach (var personContact in Contact1)
                        {
                            Console.WriteLine("Unique Name is : " + personContact.Value.Uniquename);
                            Console.WriteLine("First Name is : " + personContact.Value.FirstName);
                            Console.WriteLine("Last Name is : " + personContact.Value.LastName);
                            Console.WriteLine("Mobile Number is : " + personContact.Value.MobileNumber);
                            Console.WriteLine("Email ID is : " + personContact.Value.Email);
                            Console.WriteLine("Address is : " + personContact.Value.Address);
                            Console.WriteLine("City is : " + personContact.Value.City);
                            Console.WriteLine("State is : " + personContact.Value.State);
                            Console.WriteLine("Zip Code is : " + personContact.Value.zipcode);
                            Console.WriteLine();

                            Console.WriteLine("------------------\n");
                        }
                        break;
                    case 3:
                        var Contact2 = Program.Person.OrderBy(x => x.Value.zipcode);

                        foreach (var personContact in Contact2)
                        {
                            Console.WriteLine("Unique Name is : " + personContact.Value.Uniquename);
                            Console.WriteLine("First Name is : " + personContact.Value.FirstName);
                            Console.WriteLine("Last Name is : " + personContact.Value.LastName);
                            Console.WriteLine("Mobile Number is : " + personContact.Value.MobileNumber);
                            Console.WriteLine("Email ID is : " + personContact.Value.Email);
                            Console.WriteLine("Address is : " + personContact.Value.Address);
                            Console.WriteLine("City is : " + personContact.Value.City);
                            Console.WriteLine("State is : " + personContact.Value.State);
                            Console.WriteLine("Zip Code is : " + personContact.Value.zipcode);
                            Console.WriteLine();

                            Console.WriteLine("------------------\n");
                        }
                        break;

                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }

        }
        public static void WriteRecordsInFile(string path, ContactDetails person)
        {

            if (File.Exists(path))
            {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine("\nFirst Name : " + person.FirstName);
                sw.WriteLine("Last Name : " + person.LastName);
                sw.WriteLine("Address : " + person.Address);
                sw.WriteLine("City : " + person.City);
                sw.WriteLine("State : " + person.State);
                sw.WriteLine("Email : " + person.Email);
                sw.WriteLine("Zip code : " + person.zipcode);
                sw.WriteLine();
                sw.Close();
                Console.WriteLine("\nData added successfully in file");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }
        public static void ReadRecordsFromFile(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }

    }
}


