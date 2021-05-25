
using System;

class Program {
    static void Main(string[] args) {
      int pesos = Int32.Parse(Console.ReadLine());
      int dollars = Int32.Parse(Console.ReadLine());
      if (dollars > pesos*0.02) 
      {
        Console.WriteLine("Pesos");
      }
      else 
      {
        Console.WriteLine("Dollars");
      }
    }
}




