using System;

class Program {
    static void Main(string[] args) {
    	string url = Console.ReadLine();
    	try {
    		Console.WriteLine(url.Split("=")[1]);
    	} catch {
    		string[] stel = url.Split("/");
    		Console.WriteLine(stel[stel.Length - 1]);
    	}
    }
}