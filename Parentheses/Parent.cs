namespace ParentExample
{
    class Parent
    {
        public void parentFunc10()
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>50800</span></div>";

            string quantity = "";
            string output = "";

            // Your work here

            // Extract the "quantity"
            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
            int quantityEnd = input.IndexOf(closeSpan);
            int quantityLength = quantityEnd - quantityStart;
            quantity = input.Substring(quantityStart, quantityLength);
            quantity = $"Quantity: {quantity}";

            // Set output to input, replacing the trademark symbol with the registered trademark symbol
            const string tradeSymbol = "&trade;";
            const string regSymbol = "&reg;";
            output = input.Replace(tradeSymbol, regSymbol);

            // Remove the opening <div> tag
            const string openDiv = "<div>";
            int divStart = output.IndexOf(openDiv);
            output = output.Remove(divStart, openDiv.Length);

            // Remove the closing </div> tag and add "Output:" to the beginning
            const string closeDiv = "</div>";
            int divCloseStart = output.IndexOf(closeDiv);
            output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
        public void parentFunc9()
        {
            string message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);
        }
        public void parentFunc8()
        {
            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);
        }
        public void parentFunc7()
        {
            string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

            // The IndexOfAny() helper method requires a char array of characters. 
            // You want to look for:

            char[] openSymbols = { '[', '{', '(' };

            // You'll use a slightly different technique for iterating through 
            // the characters in the string. This time, use the closing 
            // position of the previous iteration as the starting index for the 
            //next open symbol. So, you need to initialize the closingPosition 
            // variable to zero:

            int closingPosition = 0;

            while (true)
            {
                int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
                System.Console.WriteLine(openingPosition);

                if (openingPosition == -1) break;

                string currentSymbol = message.Substring(openingPosition, 1);

                // Now  find the matching closing symbol
                char matchingSymbol = ' ';

                switch (currentSymbol)
                {
                    case "[":
                        matchingSymbol = ']';
                        break;
                    case "{":
                        matchingSymbol = '}';
                        break;
                    case "(":
                        matchingSymbol = ')';
                        break;
                }

                // To find the closingPosition, use an overload of the IndexOf method to specify 
                // that the search for the matchingSymbol should start at the openingPosition in the string. 

                openingPosition += 1;
                closingPosition = message.IndexOf(matchingSymbol, openingPosition);

                // Finally, use the techniques you've already learned to display the sub-string:

                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));
            }
        }
        public void parentFunc6()
        {
            string message = "Help (find) the {opening symbols}";
            Console.WriteLine($"Searching THIS Message: {message}");
            char[] openSymbols = { '[', '{', '(' };
            int startPosition = 5;
            int openingPosition = message.IndexOfAny(openSymbols);
            Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

            openingPosition = message.IndexOfAny(openSymbols, startPosition);
            Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
        }
        public void parentFunc5()
        {
            string message = "(What if) there are (more than) one (set of parentheses)?";
            while (true)
            {
                int openingPosition = message.IndexOf('(');
                // System.Console.WriteLine(openingPosition);
                System.Console.WriteLine("hello");
                System.Console.WriteLine(message[openingPosition]);
                if (openingPosition == -1) break;

                openingPosition += 1;
                int closingPosition = message.IndexOf(')');
                int length = closingPosition - openingPosition;
                Console.WriteLine(message.Substring(openingPosition, length));

                // Note the overload of the Substring to return only the remaining 
                // unprocessed message:
                message = message.Substring(closingPosition + 1);
            }
        }
        public void parentFunc4()
        {
            string message = "(What if) I am (only interested) in the last (set of parentheses)?";
            int openingPosition = message.LastIndexOf('(');

            openingPosition += 1;
            int closingPosition = message.LastIndexOf(')');
            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
        public void parentFunc3()
        {
            string message = "hello there!";

            int first_h = message.IndexOf('h');
            int last_h = message.LastIndexOf('h');

            Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
        }
        public void parentFunc2()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            openingPosition += 1;

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
        public void parentFunc1()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);

            int length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
        public void parentFunc()
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            Console.WriteLine(openingPosition);
            Console.WriteLine(closingPosition);
        }
    }
}