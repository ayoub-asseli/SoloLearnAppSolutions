using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
    	char[] message_encoded = Console.ReadLine().ToCharArray();
    	List<string> message_decoded = new List<string>();
    	foreach (var elem in message_encoded){
    		if (!"0123456789/:.;,?*+=%!)(-_€$*'&#@^¨<>`".Contains(elem.ToString()))
    			message_decoded.Add(elem.ToString());
    	}
    	message_decoded.Reverse();
    	Console.WriteLine(string.Join("", message_decoded));
    }
}