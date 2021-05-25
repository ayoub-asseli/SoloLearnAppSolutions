using System;

class Program {
    static void Main(string[] args) {
        string[] noises = Console.ReadLine().Split(" ");
        foreach (var noise in noises){
            if (noise == "Grr")
                Console.Write("Lion ");
            else if (noise == "Rawr")
                Console.Write("Tiger ");
            else if (noise == "Ssss")
                Console.Write("Snake ");
            else
                Console.Write("Bird ");
        } 
    }
}