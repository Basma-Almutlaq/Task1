using System;

public class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Contact(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }

    public void PrintContact()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine();
    }
}
