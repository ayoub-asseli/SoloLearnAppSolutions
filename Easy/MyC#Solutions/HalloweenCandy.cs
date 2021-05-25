using System;

class Program {
    static void Main(string[] args) {
    	float candies = float.Parse(Console.ReadLine());
    	Console.WriteLine(Math.Ceiling((2/candies)*100));
    }
}