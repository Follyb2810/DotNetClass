using MyMathOperation;
class Program{
    public static void Main(string[] args){
        double num1=10.5;
        double num2 = 2.5;
        double addResult = Calculate.Add(num1,num2);
        double SubtractResult = Calculate.Subtract(num1,num2);
        double DivideResult = Calculate.Divide(num1,num2);
        double MultiplyResult = Calculate.Multiply(num1,num2);
        double ResultSquareRoot = Calculate.SquareRoot(num1);

        Console.WriteLine(addResult);
        Console.WriteLine(SubtractResult);
        Console.WriteLine(DivideResult);
        Console.WriteLine(MultiplyResult);
        Console.WriteLine(ResultSquareRoot);
    }
}