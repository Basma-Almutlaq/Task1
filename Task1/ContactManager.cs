using System;
using System.Collections.Generic;

public class ContactManager
{
    private List<Contact> contactList;

    public ContactManager()
    {
        contactList = new List<Contact>();
    }

    public void AddContact(string name, string phone, string email)
    {
        Contact contact = new Contact(name, phone, email);
        contactList.Add(contact);
    }

    public void ListAllContacts()
    {
        if (contactList.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            foreach (Contact contact in contactList)
            {
                contact.PrintContact();
            }
        }
    }
}
