using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        var numbers = new Dictionary<string, string>(){
                {"0", "zero"},
                {"1", "one"},
                {"2", "two"},
                {"3", "three"},
                {"4", "four"},
                {"5", "five"},
                {"6", "six"},
                {"7", "seven"},
                {"8", "eight"},
                {"9", "nine"},
                {"10", "ten"}
            };
        string[] words = Console.ReadLine().Split(" ");
        foreach (var word in words) {
            if (numbers.ContainsKey(word)){
                int index = Array.IndexOf(words, word);
                words[index] = numbers[word];
            }
        }
        Console.WriteLine(String.Join(" ", words));
    }
}