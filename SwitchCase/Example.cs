namespace ExampleSwitch
{
    public class ESwitch
    {
        public void switchFunc()
        {
            int employeeLevel = 200;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                    title = "Junior Associate";
                    break;
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }
        public void switchFunc1()
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }
        public void switchFunc2()
        {
            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");
        }
    }
    public class E2Switch
    {
        public void EswitchFunc1()
        {
            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }

            Console.WriteLine($"Product: {size} {color} {type}");
        }
    }
    public class ForExample
    {
        public void forFunc()
        {
            // Initialize a List instead of a fixed-size array
            List<string> newList = new List<string>();

            string[] names = { "Alex", "Eddie", "David", "Michael" };

            // Loop in reverse order
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]); // Print the current name
                Console.WriteLine(i); // Print the current index

                newList.Add(names[i]); // Add the name to the List

                // Print the current state of the newList
                Console.WriteLine(string.Join(", ", newList));
            }

            // Print the original names array for reference
            Console.WriteLine("Original names: " + string.Join(", ", names));
        }
        public void iter()
        {
            // string[] names = { "Alex", "Eddie", "David", "Michael" };
            // foreach (var name in names)
            // {
            //     // Can't do this:
            //     if (name == "David") name = "Sammy";
            // }
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);
        }
        public void review()
        {
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine($"{i} - FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} - Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine($"{i} - Buzz");
                else
                    Console.WriteLine($"{i}");
            }
        }
    }
}