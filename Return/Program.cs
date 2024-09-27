using ExampleOne;
public class Program
{
    public static void Main(string[] args)
    {
        ReturnExample returnExample = new ReturnExample();
        returnExample.returnFunc();

        // Call UsdToVnd
        double usd = 23.73;
        int vnd = UsdToVnd(usd);
        int result = UsdToVnd(20);
        double vndBack = VndToUsd(20);
        Console.WriteLine($"20 USD to VND: {result}");
        Console.WriteLine($"20 USD to VND: {vndBack}");
        Console.WriteLine($"${usd} USD = ${vnd} VND");
        Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
        UsdToBtc(12);
        string input = "snake";
        Console.WriteLine(input);
        Console.WriteLine(ReverseWord(input));
        Console.WriteLine(ReverseWord("folly"));
        string inputs = "there are snakes at the zoo";

        Console.WriteLine(inputs);
        Console.WriteLine(ReverseSentence(inputs));

        Console.WriteLine("Is it a palindrome?");
        foreach (string word in words)
        {
            Console.WriteLine($"{word}: {IsPalindrome(word)}");
        }
        int target = 60;
        int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5, 60, 6 };
        int[] resultx = TwoCoins(coins, target);
        if (resultx.Length == 0)
        {
            Console.WriteLine("No two coins make change");
        }
        else
        {
            Console.WriteLine($"Change found at positions {resultx[0]} and {resultx[1]}");
        }
        Dice dice  = new Dice();
        dice.diceFunc();
    }

    // Make UsdToVnd static
    static int UsdToVnd(double usd)
    {
        int rate = 23500;
        return (int)(rate * usd);
    }
    static void UsdToBtc(double usd)
    {
        int rate = 23500;
        int usdbtc = (int)(rate * usd);
        System.Console.WriteLine(usdbtc + "  from no return");
    }
    static double VndToUsd(int vnd)
    {
        double rate = 23500;
        return vnd / rate;
    }
    static string ReverseWord(string word)
    {
        string result = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            // System.Console.WriteLine(i);
            // System.Console.WriteLine(word[i]);
            result += word[i];
        }
        return result;
    }
    static string ReverseSentence(string input)
    {
        // string result = "";
        // string[] words = input.Split(" ");

        // foreach(string word in words) 
        // {
        //     result += ReverseWord(word) + " ";
        // }

        // return result;
        string result = "";
        string[] words = input.Split(" ");
        System.Console.WriteLine(string.Join(" , ", words) + " from split");

        foreach (string word in words)
        {
            result += Program.ReverseWord(word) + " ";
        }

        return result.Trim();
    }
    static string[] words = { "racecar", "talented", "deified", "tent", "tenet" };


    static bool IsPalindrome(string word)
    {
        int start = 0;
        int end = word.Length - 1;
        System.Console.WriteLine(start);
        System.Console.WriteLine(end);

        while (start < end)
        {
            if (word[start] != word[end])
            {
                return false;
            }
            start++;
            end--;
        }

        return true;
    }
    static int[] TwoCoins(int[] coins, int target)
    {
        for (int curr = 0; curr < coins.Length; curr++)
        {
            for (int next = curr + 1; next < coins.Length; next++)
            {
                if (coins[curr] + coins[next] == target)
                {
                    return new int[] { curr, next };
                }

            }
        }

        return new int[0];
    }

    static int[,] zTwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
}
