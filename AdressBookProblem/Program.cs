namespace AdressBookProblem
{
    public class Program
    {
        public static List<ContactDetails> Person = new List<ContactDetails>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");
            Console.Write("Enter 'y' to Enter Contact Details : ");
            var input = Console.ReadLine();

            while (input == "y")
            {
                AdressBook.CreateContact();
                Console.Write("Enter 'y' to Enter Contact Details or otherwise Enter any key : ");
                input = Console.ReadLine();
            }
            AdressBook.DisplayContactDetails();
            AdressBook.EditByFirstName();
            AdressBook.DisplayContactDetails();
            AdressBook.DeleteByFirstName();
            AdressBook.DisplayContactDetails();

            AdressBook.DisplayContactDetails();

        }
    }
}