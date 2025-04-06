//Nested Switch
/*
namespace Switch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter i value:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter j value:");
        int j = int.Parse(Console.ReadLine());
        switch (i > j)
        {
            case true:
                Console.WriteLine("i is greater than j");
                break;
            case false:
                 switch (j > i)
                 {
                        case true:
                            Console.WriteLine("j is greater than i");
                            break;
                        case false:
                            Console.WriteLine("i is equal to j");
                            break;
                 }//inner switch
                 break;

        }//External switch
        Console.ReadLine();
    }
}


//comparing i and j using if else with in switch.

namespace Switch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter i value:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter j value:");
        int j = int.Parse(Console.ReadLine());
        switch(i>j)
        {
            case true:
                Console.WriteLine("i is greater than j");
                break;
            case false:
                if (j > i)
                    Console.WriteLine("j is greater than i");
                else
                    Console.WriteLine("i is equal to j");
                break;
        }
        Console.ReadLine();
    }
}

//comparing i and j using switch with in if else.

namespace Switch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter i value:");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter j value:");
        int j = int.Parse(Console.ReadLine());
        if (i > j)
            Console.WriteLine("i is greater than j");
        else
            switch(j>i)
            {
                case true:
                    Console.WriteLine("j is greater than i");
                    break;
                case false:
                    Console.WriteLine("i is equal to j");
                    break;
            }
        Console.ReadLine();
    }
}