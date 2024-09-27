namespace DimensionExample
{
    using System;

    class DimendClass
    {
        public void dimendFunc()
        {
            int maxPets = 3;  // Example: 3 pets
            string[,] ourAnimals = new string[maxPets, 6];

            // Filling the array with data
            ourAnimals[0, 0] = "Charlie";  // Pet 1 name
            ourAnimals[0, 1] = "Dog";      // Pet 1 species
            ourAnimals[0, 2] = "3";        // Pet 1 age
            ourAnimals[0, 3] = "Golden Retriever"; // Pet 1 breed
            ourAnimals[0, 4] = "Male";     // Pet 1 gender
            ourAnimals[0, 5] = "Healthy";  // Pet 1 health status

            ourAnimals[1, 0] = "Bella";    // Pet 2 name
            ourAnimals[1, 1] = "Cat";      // Pet 2 species
            ourAnimals[1, 2] = "5";        // Pet 2 age
            ourAnimals[1, 3] = "Siamese";  // Pet 2 breed
            ourAnimals[1, 4] = "Female";   // Pet 2 gender
            ourAnimals[1, 5] = "Needs Vaccination"; // Pet 2 health status

            ourAnimals[2, 0] = "Max";      // Pet 3 name
            ourAnimals[2, 1] = "Bird";     // Pet 3 species
            ourAnimals[2, 2] = "2";        // Pet 3 age
            ourAnimals[2, 3] = "Parrot";   // Pet 3 breed
            ourAnimals[2, 4] = "Male";     // Pet 3 gender
            ourAnimals[2, 5] = "Healthy";  // Pet 3 health status

            // Displaying the array in the console
            Console.WriteLine("Our Animals:");
            for (int i = 0; i < maxPets; i++)  // Loop over rows (pets)
            {
                Console.Write("Pet " + (i + 1) + ": ");
                for (int j = 0; j < 6; j++)  // Loop over columns (attributes)
                {
                    Console.Write(ourAnimals[i, j] + " ");
                }
                Console.WriteLine();  // Newline after each pet
            }
        }
    }
    class Flipper
    {
        public void flipFunc()
        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");
        }
    }
    class Permision
    {
        public void permFun()
        {
            string permission = "Admin|Manager";
            int level = 53;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
    class Block
    {
        public void blockFunc()
        {
            bool flag = true;
            if (flag)
            {
                int value = 10;
                Console.WriteLine($"Inside the code block: {value}");
            }
        }
        public void blockFunc1()
        {
            bool flag = true;
            int? value = null;

            if (flag)
            {
                Console.WriteLine($"Inside the code block : {value}");
            }

            value = 10;
            Console.WriteLine($"Outside the code block: {value}");
        }
        public void blockFunc2()
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                Console.WriteLine($"Inside the code block flag: {value}");
            }

            value = 10;
            Console.WriteLine($"Outside the code block flag: {value}");
        }
        public void blockFunc3()
        {
            // Code sample 2
            int value;

            if (true)
            {

                value = 10;
                Console.WriteLine($"Inside the code block NO flag: {value}");
            }

            Console.WriteLine($"Outside the code block NO flag: {value}");
        }
        public void blockFunc4()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            bool found = false;
            int total = 0;

            foreach (int number in numbers)
            {
                total += number;

                if (number == 42)
                {
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("Set contains 42");
            }

            Console.WriteLine($"Total: {total}");
        }

    }
}
