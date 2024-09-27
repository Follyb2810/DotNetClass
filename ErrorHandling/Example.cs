namespace ErrorExample
{
    public class ErrorExampleOne
    {
        public void errorFun()
        {
            string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

            try
            {
                Workflow1(userEnteredValues);
                Console.WriteLine("'Workflow1' completed successfully.");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(ex.Message);
            }

            static void Workflow1(string[][] userEnteredValues)
            {
                foreach (string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        Process1(userEntries);
                        Console.WriteLine("'Process1' completed successfully.");
                        Console.WriteLine();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("'Process1' encountered an issue, process aborted.");
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                    }
                }
            }

            static void Process1(String[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true)
                    {
                        if (valueEntered != 0)
                        {
                            checked
                            {
                                int calculatedValue = 4 / valueEntered;
                            }
                        }
                        else
                        {
                            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
                        }
                    }
                    else
                    {
                        throw new FormatException("Invalid data. User input values must be valid integers.");
                    }
                }
            }
        }
        public void errorFunc3()
        {
            // Console.Write("Enter the lower bound: ");
            // int lowerBound = int.Parse(Console.ReadLine());

            // Console.Write("Enter the upper bound: ");
            // int upperBound = int.Parse(Console.ReadLine());

            // decimal averageValue = 0;

            // // Calculate the sum of the even numbers between the bounds
            // averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

            // // Display the value returned by AverageOfEvenNumbers in the console
            // Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

            // // Wait for user input
            // Console.ReadLine();

            // static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
            // {
            //     int sum = 0;
            //     int count = 0;
            //     decimal average = 0;

            //     for (int i = lowerBound; i <= upperBound; i++)
            //     {
            //         if (i % 2 == 0)
            //         {
            //             sum += i;
            //             count++;
            //         }
            //     }

            //     average = (decimal)sum / count;

            //     return average;
            // }
            // try
            // {
            //     OperatingProcedure1();
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            //     Console.WriteLine("Exiting application.");
            // }

            // static void OperatingProcedure1()
            // {
            //     string[][] userEnteredValues = new string[][]
            //     {
            //         new string[] { "1", "two", "3"},
            //         new string[] { "0", "1", "2"}
            //     };

            //     foreach(string[] userEntries in userEnteredValues)
            //     {
            //         try
            //         {
            //             BusinessProcess1(userEntries);
            //         }
            //         catch (Exception ex)
            //         {
            //             if (ex.StackTrace.Contains("BusinessProcess1"))
            //             {
            //                 if (ex is FormatException)
            //                 {
            //                     Console.WriteLine(ex.Message);
            //                     Console.WriteLine("Corrective action taken in OperatingProcedure1");
            //                 }
            //                 else if (ex is DivideByZeroException)
            //                 {
            //                     Console.WriteLine(ex.Message);
            //                     Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

            //                     // re-throw the original exception
            //                     throw;
            //                 }
            //                 else
            //                 {
            //                     // create a new exception object that wraps the original exception
            //                     throw new ApplicationException("An error occurred - ", ex);
            //                 }
            //             }
            //         }

            //     }
            // }

            // static void BusinessProcess1(string[] userEntries)
            // {
            //     int valueEntered;

            //     foreach (string userValue in userEntries)
            //     {
            //         try
            //         {
            //             valueEntered = int.Parse(userValue);

            //             checked
            //             {
            //                 int calculatedValue = 4 / valueEntered;
            //             }
            //         }
            //         catch (FormatException)
            //         {
            //             FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            //             throw invalidFormatException;
            //         }
            //         catch (DivideByZeroException)
            //         {
            //             DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            //             throw unexpectedDivideByZeroException;

            //         }
            //     }
            // }
        }
        public void errorFunc2()
        {
            // // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            string[][] userEnteredValues = new string[][]
            {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
            };

            foreach (string[] userEntries in userEnteredValues)
            {
                try
                {
                    BusinessProcess1(userEntries);
                }
                catch (Exception ex)
                {
                    if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        public void errorFunc1()
        {
            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        // completes required calculations based on userValue
                        // ...
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                }
            }
            try
            {
                OperatingProcedure1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exiting application.");
            }

            static void OperatingProcedure1()
            {
                string[][] userEnteredValues = new string[][]
                {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
                };

                foreach (string[] userEntries in userEnteredValues)
                {
                    try
                    {
                        BusinessProcess1(userEntries);
                    }
                    catch (Exception ex)
                    {
                        if (ex.StackTrace.Contains("BusinessProcess1"))
                        {
                            if (ex is FormatException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Corrective action taken in OperatingProcedure1");
                            }
                            else if (ex is DivideByZeroException)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                                // re-throw the original exception
                                throw;
                            }
                            else
                            {
                                // create a new exception object that wraps the original exception
                                throw new ApplicationException("An error occurred - ", ex);
                            }
                        }
                    }

                }
            }

            static void BusinessProcess1(string[] userEntries)
            {
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    try
                    {
                        valueEntered = int.Parse(userValue);

                        checked
                        {
                            int calculatedValue = 4 / valueEntered;
                        }
                    }
                    catch (FormatException)
                    {
                        FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
                        throw invalidFormatException;
                    }
                    catch (DivideByZeroException)
                    {
                        DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
                        throw unexpectedDivideByZeroException;

                    }
                }
            }
        }
        public void errorFunc()
        {
            string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

            string overallStatusMessage = "";

            overallStatusMessage = Workflow1(userEnteredValues);

            if (overallStatusMessage == "operating procedure complete")
            {
                Console.WriteLine("'Workflow1' completed successfully.");
            }
            else
            {
                Console.WriteLine("An error occurred during 'Workflow1'.");
                Console.WriteLine(overallStatusMessage);
            }

            static string Workflow1(string[][] userEnteredValues)
            {
                string operationStatusMessage = "good";
                string processStatusMessage = "";

                foreach (string[] userEntries in userEnteredValues)
                {
                    processStatusMessage = Process1(userEntries);

                    if (processStatusMessage == "process complete")
                    {
                        Console.WriteLine("'Process1' completed successfully.");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("'Process1' encountered an issue, process aborted.");
                        Console.WriteLine(processStatusMessage);
                        Console.WriteLine();
                        operationStatusMessage = processStatusMessage;
                    }
                }

                if (operationStatusMessage == "good")
                {
                    operationStatusMessage = "operating procedure complete";
                }

                return operationStatusMessage;
            }

            static string Process1(String[] userEntries)
            {
                string processStatus = "clean";
                string returnMessage = "";
                int valueEntered;

                foreach (string userValue in userEntries)
                {
                    bool integerFormat = int.TryParse(userValue, out valueEntered);

                    if (integerFormat == true)
                    {
                        if (valueEntered != 0)
                        {
                            checked
                            {
                                int calculatedValue = 4 / valueEntered;
                            }
                        }
                        else
                        {
                            returnMessage = "Invalid data. User input values must be non-zero values.";
                            processStatus = "error";
                        }
                    }
                    else
                    {
                        returnMessage = "Invalid data. User input values must be valid integers.";
                        processStatus = "error";
                    }
                }

                if (processStatus == "clean")
                {
                    returnMessage = "process complete";
                }

                return returnMessage;
            }

        }
    }
}