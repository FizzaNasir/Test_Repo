using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! What's your name?");
        string name = Console.ReadLine();

        if (!string.IsNullOrEmpty(name))
        {
            Console.WriteLine($"Nice to meet you, {name}!");
        }
        else if(true){
            Console.WriteLine("Hi");
        }
        else
        {
            Console.WriteLine("You didn't enter a name. Goodbye!");
        }
    }
}
