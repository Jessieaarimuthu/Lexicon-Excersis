using System;

namespace MainMenu
{
    class Mainmenu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have arrived at the main menu, please navigate by entering numbers");
            do
            {
                ShowMainMeny();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "3":
                        splitwords();
                        break;
                    case "2":
                        repeat10times();
                        break;
                    case "1":
                        youthOrPensoiner();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            } while (true);


        }

       

static void ShowMainMeny()
{
    Console.WriteLine("0. Quit");
    Console.WriteLine("1. Cinema");
    Console.WriteLine("2. Repeat10Times");
    Console.WriteLine("3. The ThirdWord");
}

static void youthOrPensoiner()
{
    int price = 0;
    Console.WriteLine("How many going to cinema?");
    int count = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= count; i++)
    {
        Console.WriteLine("Enter Name for person " + i + " :");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Age for person " + i + " :");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age <= 20)
        {
            Console.WriteLine("Youth Price SEK 80");
            price = price + 80;
        }
        else if (age >= 64)
        {
            Console.WriteLine("Pensioner's Price SEK 90");
            price = price + 90;
        }
        else
        {
            Console.WriteLine("Standard Price SEK 120");
            price = price + 120;
        }
    }

    Console.WriteLine($"No of people: {count}");
    Console.WriteLine($"Total Cost: {price}");
    Console.WriteLine();

}

static void repeat10times()
{
    Console.WriteLine("Input a value to repeat 10 times");
    string value = Console.ReadLine();
    for (int i = 1; i <= 10; i++)
        Console.Write($"{i} {value} ");

    Console.WriteLine();
}

static void splitwords()
{
    Console.WriteLine("Write sentence with atleast 3 words:");

    String input = Console.ReadLine();
    var array = input.Split(' ');
    Console.WriteLine($"The third word of sentence is {array[2]}");
    Console.WriteLine();
}
}



   
}

