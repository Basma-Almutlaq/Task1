public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public virtual void GetDetails()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}");
    }
}