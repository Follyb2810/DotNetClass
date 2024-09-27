using Example2;
class Program
{
    public static void Main(string[] args)
    {
        int? age = null;
        if (age.HasValue)
        {
            Console.WriteLine("Age: " + age.Value);
        }
        else
        {
            Console.WriteLine("Age is not specified.");
        }
        string? name = null;  // Nullable reference type
        if (name != null)
        {
            Console.WriteLine(name.Length + " hello nill");  // Safe, as name is not null
        }
        ExampleThree exampleThree = new ExampleThree();
        exampleThree.Score();
        exampleThree.Score1();
        exampleThree.BranchCode();

    }
}