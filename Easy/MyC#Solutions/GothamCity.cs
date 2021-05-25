using System;

class Program {
    static void Main(string[] args) {
        int criminals = Int32.Parse(Console.ReadLine());
        if (criminals < 5)
        	Console.WriteLine("I got this!");
        else if (criminals < 10)
        	Console.WriteLine("Help me Batman");
        else
        	Console.WriteLine("Good Luck out there!");
    }
}