using System;

class Program {
    static void Main(string[] args) {
    	char[] sentence = Console.ReadLine().ToCharArray();
        string translation = "";
        for (int i = sentence.Length - 1; i >= 0; i--){
            translation += sentence[i];
        }
        Console.WriteLine(translation);
    }
}