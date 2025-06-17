using System;

class Program
{
    static void Main(string[] args)
    {
        ContactManager contactManager = new ContactManager();
        int choice;

        do
        {
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. List Contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out choice);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter phone: ");
                    string phone = Console.ReadLine();

                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();

                    contactManager.AddContact(name, phone, email);
                    break;

                case 2:
                    contactManager.ListAllContacts();
                    break;

                case 3:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid number. Try again.");
                    break;
            }

        } while (choice != 3);
    }
}
