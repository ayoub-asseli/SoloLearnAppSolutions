using System;

class Program {
    static void Main(string[] args) {
    	int yards = Int32.Parse(Console.ReadLine());
    	string reaction = "";
    	if (yards > 10)
    		Console.WriteLine("High Five")
    	else if (yards < 1)
    		Console.WriteLine("shh")
    	else
    		for (int i = 0; i < yards; i++ )
    			reaction += "Ra!";
      		Console.WriteLine(reaction);
    }
}