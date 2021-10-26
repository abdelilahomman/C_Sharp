using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace EL_BAHI_HASSAN
{
    class Program
    {
        static void Main(string[] args)
        {
            //generale class
            Article article = new Article("bic", "1", 1.5);
            Article article2 = new Article("bic", "1", 1.5);
            Article article3 = new Article("Maped", "1", 2);
            Console.WriteLine(article.ToString());
            Console.WriteLine(article3.ToString());


            //Stylo class
            Console.WriteLine(article.Equals(article3));
            Stylo s1 = new Stylo("Stylo", "1", 2.00, "Bleu");
            Stylo s2 = new Stylo("Stylo", "1", 2.00, "Red");
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.ToString());


            //Ramet class
            Ramette ram1 = new Ramette("Maped", "1", 20, "A4");
            Ramette ram2 = new Ramette("Maped", "1", 20, "A4");
            Console.WriteLine(ram1.Equals(ram2));
            Console.WriteLine(ram1.ToString());
        }
    }
}
