namespace Ball_and_cups;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gæt om bolden ligger under 1,2 eller 3");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("#1     ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write("#2     ");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("#3");
        Console.ResetColor();
        Console.ReadLine();

        Random random = new Random();
        int cup = random.Next(1, 4);
        // 1 til 6


        string ball; 

        if (cup == 1)
        {
            Console.WriteLine("Bolden ligger under nr 1");
        }

        else
        if (cup== 2)
        {
            Console.WriteLine("Bolden ligger under nr 2");
        }
        else
        if (cup == 3)
        {
            Console.WriteLine("Bolden ligger under nr 3");
        }
        


    }
}

