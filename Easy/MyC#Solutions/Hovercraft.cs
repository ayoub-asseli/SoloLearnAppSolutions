using System;

class Program {
    static void Main(string[] args) {
    	var building_cost = 2000000;
    	var selling_cost = 3000000;
    	var insurance_cost = 1000000; 

    	int sales = Int32.Parse(Console.ReadLine());
    	if ( (building_cost*10 + insurance_cost) < sales*selling_cost )
    		Console.WriteLine("Profit");
    	else if ( (building_cost*10 + insurance_cost) > sales*selling_cost )
    		Console.WriteLine("Loss");
    	else
    		Console.WriteLine("Broke Even");
    }
}