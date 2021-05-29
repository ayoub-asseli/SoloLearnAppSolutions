using System;

class Program {
    static void Main(string[] args) {
        string text = Console.ReadLine();
        foreach (var letter in text){
            if ("/:.;,?*+=%!)(-_€$*'&#@^¨<>`".Contains(letter))
                text = text.Replace(e, "");
        }
        Console.WriteLine(text);
    }
}