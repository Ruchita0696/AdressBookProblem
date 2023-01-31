using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookProblem
{
    public class ContactDetails
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long? MobileNumber { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public int? zipcode { get; set; }
        public string? Uniquename { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            ContactDetails details = obj as ContactDetails;

            return details.FirstName == FirstName || details.Uniquename == Uniquename || details.MobileNumber == MobileNumber || details.Email == Email;
        }
    }
}
