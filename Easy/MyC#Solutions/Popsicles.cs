using System;

class Program {
    static void Main(string[] args) {
        float nb_siblings = Int32.Parse(Console.ReadLine());
        float nb_popsicles = Int32.Parse(Console.ReadLine());
        if ( nb_popsicles/nb_siblings == Convert.ToInt32(nb_popsicles/nb_siblings) )
            Console.WriteLine("give away");
        else
            Console.WriteLine("eat them yourself");
    }
}