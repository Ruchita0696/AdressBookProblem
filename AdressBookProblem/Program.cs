namespace AdressBookProblem
{
    public class Program
    {
        public static List<ContactDetails> Person = new List<ContactDetails>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book \n");

            AdressBook.CreateContact();
            AdressBook.DisplayContactDetails();
            AdressBook.EditByFirstName();
            AdressBook.DisplayContactDetails();
        }
    }
}