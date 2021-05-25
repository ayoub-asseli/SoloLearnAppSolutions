using System;

class Program {
    static void Main(string[] args) {
        int points = Int32.ConsoleWriteLine();
        int squirt_gun = Int32.ConsoleWriteLine();
        if (points/12 >= squirt_gun)
            Console.WriteLine("Buy it!");
        else
            Console.WriteLine("Try again");
    }
}