using System;
using HumanGeneration;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static int counter = 0;
    public static void Main(string[] args)
    {
        System.Console.WriteLine(1234);
        // ErrorExample();
        // ZeroExample();
        // OperatorExample();
        // conditionExample();
        // LoginExampe();
        // SwitchExampe();
        // TenaryExample();
        // LoopExample();
        // LoopWhileExample();
        // breakContinue();
        // callBox();
        // finalizer(true);
        // ArrayFunc();
        // forLoopFunc();
        // dimemnsionArray();
        // jaggedArray();
        // arrayListExample();
        ListExample();



    }
    public static void ListExample() {
        List<string> friends = new List<string>{"frank","joe","michael","maria","carlos","angelina"};
        var partyFriends = GetPartyFriends(friends,3);
        foreach (var name in partyFriends)
        {
            System.Console.WriteLine(name);
        }
     }
     public static List<string> GetPartyFriends(List<string> list,int count){
        var partyFriends = new List<string>();
        while(partyFriends.Count < count){
            var currentFriends = GetPartyFriend(list);
            partyFriends.Add(currentFriends);
            list.Remove(currentFriends);
        }
        return partyFriends;
     }
     public static string GetPartyFriend(List<string> list){
        string shortestName = list[0];
        for(var i = 0;i < list.Count;i++){
            if(list[i].Length > shortestName.Length){

            shortestName=list[i];
            }
        }
        return shortestName;
     }
    public static void arrayListExample()
    {
        ArrayList myList = new ArrayList();
        System.Console.WriteLine(123);
        myList.Add(12);
        myList.Add(11);
        myList.Add(13);
        myList.Add(14);
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);
        myList.Add("hello");
        myList.Add("is");
        myList.Add(" world");
        myList.Add("chall");
        myList.Remove(12);
        System.Console.WriteLine("the list of arraylist {0} ",myList.Count);
        double sum = 0;
        foreach (object obj in myList)
        {
            if (obj is int)
            {
                sum += Convert.ToDouble(obj);
            }else if(obj is double){
                sum += (double)obj;
            }else if(obj is string){
                System.Console.WriteLine(obj);
            }
        }
        System.Console.WriteLine("from the sun {0}",sum);
    }
    public static void jaggedArray()
    {
        System.Console.WriteLine(12);
        int[][] jaggedArray = new int[][]{
            new int[]{1, 2, 3,},
            new int[]{4, 5, 6,},
        };
        System.Console.WriteLine("from jagged array {0}", jaggedArray[0][1]);
        // int[][] jagArray =new int[][];
        // jagArray[0] = new int[3];
        // jagArray[1] = new int[3];
        // jagArray[2] = new int[3];

        // jagArray[0] = new int[]{1, 2, 3,};
        // jagArray[1] = new int[]{1, 2, 3,};
        // jagArray[2] = new int[]{1, 2, 3,};

    }
    public static void dimemnsionArray()
    {
        System.Console.WriteLine(123);
        int[,] myDimend = new int[3, 5]{
            {1,2,3,4,6},
            {56,6,7,8,70},
            {9,10,11,12,80}
        };
        //! r,c
        //! int data type
        //! [,] 2d array
        //! 3 rows
        //! 4 colums 
        // myDimend=
        System.Console.WriteLine(myDimend[0, 0]);
        System.Console.WriteLine(myDimend[0, 1]);
        System.Console.WriteLine(myDimend[0, 2]);
        System.Console.WriteLine(myDimend[0, 3]);
        //? ! 2d array
        string[,] matrix;
        //? ! 3d array
        int[,,] threeD;
        // two dimension
        int[,] array2d = new[,]{
            {1,2,3,5,6},
            {4,5,6,2,4},
            {7,8,9,4,5},
            {7,8,9,4,5},
            {7,8,9,4,5},
            {7,8,9,4,5},
        };

        System.Console.WriteLine("control of row {0}", array2d[2, 2]);
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            for (int j = 0; j < array2d.GetLength(1); j++)
            {
                System.Console.WriteLine(array2d[i, j] + " from 2d using for loop");
            }
        }
        foreach (int item in array2d)
        {
            System.Console.WriteLine(item + "using for each");
        }
        System.Console.WriteLine("to get the dimension of the array " + array2d.Rank);

        string[,,] array3d = new[, ,]
        {
            {
                {"000","001"},
                {"010","011"},
                {"hi there","what up"},
            },
            {
                {"100","101"},
                {"110","111"},
                {"another entry","last entry"},
            },
        };

        System.Console.WriteLine("3d center {0}", array3d[0, 0, 0]);
        System.Console.WriteLine("3d center {0}", array3d[0, 2, 0]);

    }
    public static void forLoopFunc()
    {
        int[] nums = new int[10];
        for (int i = 0; i < 10; i++)
        {
            nums[i] = i + 10;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            System.Console.WriteLine("elemet at position {0} : {1}", i, nums[i]);
        }
        foreach (int k in nums)
        {
            counter++;
            System.Console.WriteLine("elemet in index {0} and position = {1}", k, counter);
        }

        string[] friends = { "michael", "folly", "babs", "age", "kale" };
        foreach (string friend in friends)
        {
            System.Console.WriteLine("hi,there {0}", friend);
        }
    }
    public static void ArrayFunc()
    {
        System.Console.WriteLine("hello array is here");
        int[] grade = new int[] { 1, 2, 3, 4, 5 };
        int[] age = new int[] { 1, 2, 3, 4, 5 };

        System.Console.WriteLine(string.Join(",", grade));
        System.Console.WriteLine(string.Join(",", age));
        System.Console.WriteLine("enter founder name");
        string foundName = Console.ReadLine();
        // string na= string.Parse(foundName);
        string[] founder = new string[5];
        founder[0] = "folly";
        founder[1] = "babs";
        founder[2] = "akin";
        founder[3] = "mahmud";
        founder[4] = foundName;
        System.Console.WriteLine(founder[0]);
        System.Console.WriteLine(founder[4]);
        System.Console.WriteLine(string.Join(",", founder));
        System.Console.WriteLine(founder.Length);
        System.Console.WriteLine(grade.Length);
    }
    public static void finalizer(bool isFriend)
    {
        Members members = new Members();
        members.introducing(isFriend);
    }
    public static void callBox()
    {
        //? instance
        Human folly = new Human("babsb", "folly", 1, "blue");
        // folly.firstName ="babsb";
        // folly.lasttName ="folly";
        // folly.numOfPeople =5;
        folly.IntroduceMyself();
        //? new instance
        Human micheal = new Human("michael", "ayoola", 10, "red");
        // micheal.firstName ="michael";
        // micheal.lasttName ="ayoola";
        micheal.IntroduceMyself();
        Human seun = new Human("seun", "ayoola", "red");
        seun.IntroduceMyself();
        Human akeem = new Human("akeem", "ayoola");
        akeem.IntroduceMyself();

        Box box = new Box(3, 4, 6);
        // box.length=3;
        box.Height = 29;
        // box.height=29;
        box.width = 10;
        box.AreaOfCircle = 10;
        box.setLength(7);
        box.displayInfo();
        System.Console.WriteLine("box length is " + box.GetLength());
        System.Console.WriteLine("box volume is " + box.getVolume());
        System.Console.WriteLine("box volume is " + box.Volume);
        System.Console.WriteLine("box area if circle  is " + box.AreaOfCircle);

    }
    public static void breakContinue()
    {
        for (counter = 0; counter < 10; counter++)
        {
            Console.WriteLine(counter);
            if (counter == 3)
            {
                System.Console.WriteLine("we are at 3");
                break;
            }
        }
        for (counter = 0; counter < 10; counter++)
        {
            Console.WriteLine(counter);
            if (counter == 3)
            {
                System.Console.WriteLine("we skip 3");
                continue;
            }
            if (counter % 2 == 0)
            {
                System.Console.WriteLine("we jump");
                continue;
            }
            System.Console.WriteLine(counter);
        }
    }
    public static void LoopWhileExample()
    {

        while (counter < 10)
        {
            System.Console.WriteLine("while loop " + counter);
            counter++;
        }
        string enterText = "";
        while (enterText.Equals(""))
        {
            System.Console.WriteLine("please press enter to increase amount by one");
            enterText = Console.ReadLine();
            counter++;
            System.Console.WriteLine("current peoplee counte {0}", counter);
        }
    }
    public static void LoopExample()
    {
        /*
         for loop 
         do while do first then go
         while loop check then go
         foreach loop run through array or list
        */

        for (counter = 0; counter < 50; counter += 5)
        {
            System.Console.WriteLine("this is for loop " + counter);
        }
        for (counter = 1; counter > 20; counter++)
        {
            System.Console.WriteLine(" this os oldd " + counter);
        }
        for (counter = 20; counter > 2; counter--)
        {
            System.Console.WriteLine(" this os oldd " + counter);
        }
        //! do whule loop
        do
        {
            System.Console.WriteLine(counter);
            counter++;
        } while (counter < 5);

        int lengthOfText = 0;
        string wholeText = "";
        do
        {
            System.Console.WriteLine("please enter a number");
            string nameOfFriend = Console.ReadLine();
            int currentText = nameOfFriend.Length;
            lengthOfText += currentText;
            wholeText += nameOfFriend;
            System.Console.WriteLine(wholeText);
        } while (lengthOfText < 20);
        System.Console.WriteLine("thanks that enough");

    }
    public static void TenaryExample()
    {
        int temp = -5;
        string stateOfMater;
        stateOfMater = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";
        System.Console.WriteLine(stateOfMater);

    }
    public static void SwitchExampe()
    {
        int age = 25;
        switch (age)
        {
            case 15:
                System.Console.WriteLine("too youf");
                break;
            case 25:
                System.Console.WriteLine("goo to go");
                break;
            default:
                System.Console.WriteLine("how old are you");
                break;
        }
    }
    public static void LoginExampe()
    {
        bool isAdmin = false;
        bool isRegister = true;
        string username = "";
        System.Console.WriteLine("please enter usename");
        username = Console.ReadLine();
        if (isRegister && username != "" && username.Equals("Admin"))
        {
            System.Console.WriteLine("hi there ,Admin");
        }
        else
        {
            System.Console.WriteLine("hi thre ,register" + username);

        }
        if (isAdmin || isRegister)
        {
            System.Console.WriteLine("you are register");
        }
        //! 
        //  if(isRegister){
        //     System.Console.WriteLine("hi thre ,register");
        //     if(username != ""){
        //         System.Console.WriteLine("hi there,"+ username);
        //         if(username.Equals("Admin")){
        //             System.Console.WriteLine("hi there ,Admin");
        //         }
        //     }
        //  }

    }
    public static void conditionExample()
    {
        System.Console.WriteLine("what the temp todat");
        string condition = Console.ReadLine();

        //    int temp = int.Parse(condition);
        int temp;
        bool success = int.TryParse(condition, out temp);

        if (temp < 10)
        {
            System.Console.WriteLine("teke the coat" + temp + "@");
        }
        else if (temp > 10)
        {
            System.Console.WriteLine("is more more ");
        }
        else
        {
            System.Console.WriteLine($"its {temp}");
        }
    }
    public static void OperatorExample()
    {
        int num1 = 8;
        int num2 = 10;
        int num3;
        //! unary
        num3 = -num1;
        System.Console.WriteLine("num1={0} ", num1);
        System.Console.WriteLine("num2={0} {1} ", num2, num1);
        System.Console.WriteLine("num2={0}", num3);
        bool isSunny = true;
        System.Console.WriteLine("is it sunny {0}  {1} 1", !isSunny, num1++);
        System.Console.WriteLine("is it sunny {0} in {1} 2", !isSunny, num1);
        System.Console.WriteLine("is it sunny {0} in {1} 3", !isSunny, ++num1);
        System.Console.WriteLine("num1 {0} and num2 {1}", num1, num2);
        int result = num1 + num2;
        System.Console.WriteLine(result + " from result");
        bool isLower;
        isLower = num1 > num2;
        bool isEqual;
        isEqual = num1 == num2;
        bool notIsEqual;
        notIsEqual = num1 != num2;
        System.Console.WriteLine("result of num1 >< {0}", isLower);
        System.Console.WriteLine("result of num1 >< {0}", isEqual);
        System.Console.WriteLine("result of num1 >< {0}", notIsEqual);
        //! condition && AND
        bool isLowerAndSunnny;
        isLowerAndSunnny = isLower && isSunny;
        System.Console.WriteLine(" is lower and sunny " + isLowerAndSunnny);
        //! ||
        bool orIsLower;
        orIsLower = isLower && isSunny;
        System.Console.WriteLine(" is lower and sunny " + orIsLower);

    }
    public static void ZeroExample()
    {
        int num1 = 10;
        int num2 = 20;
        try
        {

            System.Console.WriteLine(num2 / num1);
        }
        catch (DivideByZeroException)
        {
            System.Console.WriteLine("cant divide by zero");
        }
    }
    public static void ErrorExample()
    {
        float prodA = 12f;
        float prodB = 2.4f;
        float prodC = 2.5f;
        float sum = (prodA + prodB + prodC);
        int sunTotal = (int)(prodA + prodB + prodC);
        Console.WriteLine(sunTotal);
        Console.WriteLine(sum);

        // Using explicit cast
        Console.WriteLine((int)sum); // Truncates the decimal part

        // Using Convert.ToInt32()
        Console.WriteLine(Convert.ToInt32(sum)); // Rounds to the nearest integer

        // Reading inputs and converting them to integers
        Console.WriteLine("Enter first number:");
        string num1 = Console.ReadLine();
        Console.WriteLine("Enter second number :");
        string num2 = Console.ReadLine();

        try
        {
            int num1Int = int.Parse(num1);  // Converting string to int
            int num2Int = int.Parse(num2);  // Converting string to int

            int sumRead = num1Int * num2Int;  // Multiplying the two integers
            Console.WriteLine(sumRead);
        }
        catch (FormatException e)
        {
            System.Console.WriteLine("format eexception " + e.Message);
            throw;
        }
        catch (OverflowException)
        {
            System.Console.WriteLine("some wrong yhappens te number to");
        }
        catch (ArgumentNullException)
        {
            System.Console.WriteLine("the argument is null");
        }
        finally
        {
            System.Console.WriteLine("you are final");
        }

    }
}
