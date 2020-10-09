using System;
using System.Collections.Generic;

namespace AddressBookWithoutOOP
{
    public class AddressBook
    {
        public static List<AddressBook> Records = new List<AddressBook>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }

        public void AddContact()
        {
            AddressBook contact = new AddressBook();
            Console.WriteLine("Enter the first name: ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the last name: ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter the mobile number ");
            contact.MobileNumber = Console.ReadLine();

            Records.Add(contact);
        }

        public void DisplayContact(AddressBook contact)
        {
            Console.WriteLine("First Name: " + contact.FirstName);
            Console.WriteLine("Last Name: " + contact.LastName);
            Console.WriteLine("Mobile Number: " + contact.MobileNumber);
            Console.WriteLine("************************************");
        }

        public void DisplayRecord()
        {
            if (Records.Count == 0)
            {
                Console.WriteLine("***Address book empty***\n");
                return;
            }
            Console.WriteLine("***List of Contacts***");
            foreach (var contact in Records)
            {
                DisplayContact(contact);
            }
            Console.ReadLine();
        }

    }


}
