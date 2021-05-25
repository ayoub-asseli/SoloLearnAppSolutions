using System;

class Program {
    static void Main(string[] args) {
        int colors = Int32.Parse(Console.ReadLine())*5;
        Console.WriteLine(Math.Round((40.00 + colors)*1.1));
    }
}