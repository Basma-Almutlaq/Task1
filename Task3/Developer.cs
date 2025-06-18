public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public override void GetDetails()
    {
        base.GetDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}\n");
    }
}