using System;

class Program {
    static void Main(string[] args) {
        string text = Console.ReadLine();
        foreach (var letter in text){
            if ("/:.;,?*+=%!)(-_€$*'&#@^¨<>`".Contains(letter))
                text = text.Replace(letter.ToString(), "");
        }
        Console.WriteLine(text);
    }
}
