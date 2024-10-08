namespace ExampleOne
{
    class ReturnExample
    {
        public void returnFunc()
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            double total = 0;
            double minimumSpend = 30.00;

            double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
            double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }

            total -= TotalMeetsMinimum() ? 5.00 : 0.00;

            Console.WriteLine($"Total: ${FormatDecimal(total)}");

            double GetDiscountedPrice(int itemIndex)
            {
                return items[itemIndex] * (1 - discounts[itemIndex]);
            }

            bool TotalMeetsMinimum()
            {
                return total >= minimumSpend;
            }

            string FormatDecimal(double input)
            {
                return input.ToString().Substring(0, 5);
            }
        }
    }
    class arrayExample
    {
        public void arrayFunc()
        {
            int target = 30;
            int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
            int[,] result = TwoCoins(coins, target);

            if (result.Length == 0)
            {
                Console.WriteLine("No two coins make change");
            }
            else
            {
                Console.WriteLine("Change found at positions:");
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    if (result[i, 0] == -1)
                    {
                        break;
                    }
                    Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
                }
            }

            int[,] TwoCoins(int[] coins, int target)
            {
                int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
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
                return (count == 0) ? new int[0, 0] : result;
            }
        }
    }
    class Dice
    {
        public void diceFunc()
        {
            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay())
            {
                PlayGame();
            }

            bool ShouldPlay()
            {
                string response = Console.ReadLine();
                return response.ToLower().Equals("y");
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = GetTarget();
                    var roll = RollDice();

                    Console.WriteLine($"Roll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(roll, target));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }

            int GetTarget()
            {
                return random.Next(1, 6);
            }

            int RollDice()
            {
                return random.Next(1, 7);
            }

            string WinOrLose(int roll, int target)
            {
                if (roll > target)
                {
                    return "You win!";
                }
                return "You lose!";
            }
        }
    }
}