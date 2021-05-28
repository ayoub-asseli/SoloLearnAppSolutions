using System;

class Program {
    static void Main(string[] args) {
        string[] words = Console.ReadLine().Split(" ");
        string new_res = "";
        foreach (var word in words){
        	new_res += word.Substring(1) + word[0] + "ay ";
        }
        Console.WriteLine(new_res);
    }
}