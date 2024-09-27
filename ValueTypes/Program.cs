// See https://aka.ms/new-console-template for more information

class Program
{
    public static void Main(string[] args)
    {
        optionalGmail();

    }
    public static void optionalGmail()
    {
        string[,] corporate =
    {
        {"Robert", "Bavin"}, {"Simon", "Bright"},
        {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
        {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

        string[,] external =
        {
        {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
        {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

        string externalDomain = "hayworth.com";

        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
        }

        void DisplayEmail(string first, string last, string domain = "contoso.com")
        {
            string email = first.Substring(0, 2) + last;
            email = email.ToLower();
            Console.WriteLine($"{email}@{domain}");
        }
    }
    public static void valueType()
    {
        Console.WriteLine("Hello, World!");
        int a = 3;
        int b = 4;
        int c = 0;
        int d = 0;

        Multiply(a, b, c);
        Console.WriteLine($"global statement : {a} x {b} = {c}");

        void Multiply(int a, int b, int c)
        {
            c = a * b;
            d++;
            Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
        }
        Console.WriteLine($"global statement : {a} x {b} = {c}");
        System.Console.WriteLine(d);

    }
    public static void optionalParam()
    {
        string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
        string[] rsvps = new string[10];
        int count = 0;

        // void RSVP(string name, int partySize, string allergies, bool inviteOnly)
        void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
        {
            // if (inviteOnly)
            // {
            //     // search guestList before adding rsvp
            // }
            if (inviteOnly)
            {
                bool found = false;
                foreach (string guest in guestList)
                {
                    if (guest.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Sorry, {name} is not on the guest list");
                    return;
                }
            }

            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }

        void ShowRSVPs()
        {
            Console.WriteLine("\nTotal RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }
        RSVP("Rebecca", 1, "none", true);
        RSVP("Nadia", 2, "Nuts", true);
        RSVP("Linh", 2, "none", false);
        RSVP("Tony", 1, "Jackfruit", true);
        RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
        RSVP("Noor", 4, "none", false);
        RSVP("Jonte", 2, "Stone fruit", false);
        RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
        ShowRSVPs();
    }
    public static void stringTyp()
    {
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(false);
        Console.WriteLine($"End: {status}");

        void SetHealth(bool isHealthy)
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }
    }
    public static void stringType()
    {
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(status, false);
        Console.WriteLine($"End: {status}");

        void SetHealth(string status, bool isHealthy)
        {
            status = (isHealthy ? "Healthy" : "Unhealthy");
            Console.WriteLine($"Middle: {status}");
        }
    }
    public static void referenceType()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        PrintArray(array);
        Clear(array);
        PrintArray(array);

        void PrintArray(int[] array)
        {
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        void Clear(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
    }
}
