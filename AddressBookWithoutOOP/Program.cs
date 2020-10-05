using System;
using System.Collections.Generic;

namespace AddressBookWithoutOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Program\n------------------------------------ ");
            for (; ; )
            {
                Console.WriteLine("1. Add a new contact \n2. Display all the contacts\n3. Exit \nenter your choice...");
                int input = Convert.ToInt16(Console.ReadLine());

                switch(input)
                {
                    case 1:
                        Program Call = new Program();
                        Call.AddContact();
                        break;
                    case 2:
                        Program Calll = new Program();
                        Calll.DisplayRecords();
                        break;
                }
                if (input == 3)
                    break;
            }
        }
        public List<ContactDetails> Records = new List<ContactDetails>();

        public void AddContact()
        {
            Console.Clear();
            ContactDetails contact = new ContactDetails();

            Console.WriteLine("Enter the first name: ");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the last name: ");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter the phone number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the Address: ");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter the ZIP code: ");
            contact.ZipCode = Console.ReadLine();

            Console.WriteLine("Enter the State: ");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter the eMail address: ");
            contact.Email = Console.ReadLine();

            Records.Add(contact);
        }

        public void DisplayContact(ContactDetails contact)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("First Name : " + contact.FirstName);
            Console.WriteLine("Last Name : " + contact.LastName);
            Console.WriteLine("Phone Number : " + contact.PhoneNumber);
            Console.WriteLine("Address : " + contact.Address);
            Console.WriteLine("ZIP Code : " + contact.ZipCode);
            Console.WriteLine("State : " + contact.State);
            Console.WriteLine("Email ID : " + contact.Email);
            Console.WriteLine("-----------------------------------");

        }
        public void DisplayRecords()
        {
            if (Records.Count == 0)
            {
                Console.WriteLine("The records are empty");
                return;
            }
            Console.WriteLine("RECORDS: " + "\n----------");
            foreach (var Contact in Records)
            {
                DisplayContact(Contact);
            }
            Console.ReadKey();
        }
    }
    public class ContactDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Email { get; set; }


    }


}

