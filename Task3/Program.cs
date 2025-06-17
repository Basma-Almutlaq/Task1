class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();

        Manager manager = new Manager
        {
            Id = 1,
            Name = "Aisha",
            Department = "HR",
            TeamSize = 5,
            Bonus = 1200.50
        };

        Developer dev = new Developer
        {
            Id = 2,
            Name = "Ahmed",
            Department = "IT",
            ProgrammingLanguage = "C#"
        };

        employees.Add(manager);
        employees.Add(dev);

        foreach (Employee emp in employees)
        {
            emp.GetDetails(); 
        }
    }
}

