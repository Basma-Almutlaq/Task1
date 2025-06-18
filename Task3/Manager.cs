public class Manager : Employee
{
    public int TeamSize { get; set; }
    public double Bonus { get; set; }

    public override void GetDetails()
    {
        base.GetDetails();
        Console.WriteLine($"Team Size: {TeamSize}, Bonus: {Bonus}\n");
    }
}