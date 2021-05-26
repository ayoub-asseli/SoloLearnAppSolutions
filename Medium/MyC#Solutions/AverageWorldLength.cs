using System;

class Program {
    public static bool IsAllLetters(string s){
    foreach (char c in s) {
        if (!Char.IsLetter(c))
            return false;
    }
    return true;
    }
    static void Main(string[] args) {
    	string[] words = Console.ReadLine().Split(" ");
        float s = 0;
        int i = 0;
        foreach (string word in words){
        	if (IsAllLetters(word)){
        		s += word.Length;
        		i += 1;
        	}
        	else {
        		s += word.Length - 1;
        		i += 1;
        	}
        }
        Console.WriteLine(Math.Ceiling(s/i));
    }
}