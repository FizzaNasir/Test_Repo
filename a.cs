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
            Console.WriteLine("You didn't enter a name. Goodbye!");
            Console.WriteLine("Bye");
        }
        else
        {
            Console.WriteLine("You didn't enter a name. Goodbye!");
        }
        
        else{
            Console.WriteLine("bye");
            Console.WriteLine("bye2");
        }
    }
}
