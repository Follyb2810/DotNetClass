using FOREACHDAY;
using StringDay;
public class LoopArray
{
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
        // string[] fraudulentOrderIDs = new string[3];

        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";

        // string[] fraudulentOrderIDs = new string[3];

        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";
        // fraudulentOrderIDs[3] = "D000";

        // string[] fraudulentOrderIDs = new string[3];

        // fraudulentOrderIDs[0] = "A123";
        // fraudulentOrderIDs[1] = "B456";
        // fraudulentOrderIDs[2] = "C789";
        // // fraudulentOrderIDs[3] = "D000";

        // Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        // Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        // Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        string[] fraudulentOrderIDs = new string[3];

        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        // fraudulentOrderIDs[3] = "D000";

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        // string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
        // string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
        FOREACH forEachFunc = new FOREACH();
        forEachFunc.calFunc();
        STRINGTEST stringTest = new STRINGTEST();
        stringTest.stringFunc();
    }
}