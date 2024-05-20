namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Hello, World!");
        Console.Write("Enter your name:");
        var name = Console.ReadLine(); //press enter to finish
        Console.WriteLine($"Name: {name}");
        
        Console.Write("Enter any character to know its ASCII value:");
        var ch = Console.Read(); //press enter to finish
        Console.WriteLine($"ASCII value: {ch}");
        Console.ReadKey();

        Console.Write("Press any key on keyboard:");
        var key = Console.ReadKey(); // it does not require to press the enter key 
        Console.WriteLine();
        Console.WriteLine($"You pressed: {key.Key}");
        */
        
        Console.Write("Hei, hva heter du? ");
        var navn = Console.ReadLine();
        Console.WriteLine($"Velkommen {navn}!");
    }
}