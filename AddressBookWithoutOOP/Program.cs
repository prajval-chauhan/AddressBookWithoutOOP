using System;

namespace AddressBookWithoutOOP
{
    class Program
    {

        static void Main(string[] args)
        {
            AddressBook call = new AddressBook();
            Console.WriteLine("Welcome to the Address Book Program\n------------------------------------ \n");
            for (; ; )
            {
                Console.WriteLine("1. Add a new contact \n2. Display all the contacts\n3. Exit \nenter your choice...");
                int input = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                switch (input)
                {
                    case 1:
                        call.AddContact();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        call.DisplayRecord();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                if (input == 3)
                    break;
            }
        }
    }
}

