using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace TP7
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            do
            {
                Console.WriteLine("1- pour ajouter");
                Console.WriteLine("2- pour afficher");
                Console.WriteLine("3- pour modifier");
                Console.WriteLine("4- pour supprimer");
                Console.WriteLine("5- pour rechercher");
                Console.WriteLine("6- pour afficher la gategorie");
                Console.WriteLine("7- pour compter");
                Console.WriteLine("8- pour quitter");
 
                c = int.Parse(Console.ReadLine());
 
                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("donner le nom , le prenom, l'age et le code");
                            String n = Console.ReadLine();
                            String pr = Console.ReadLine();
                            int a = int.Parse(Console.ReadLine());
                            int co = int.Parse(Console.ReadLine());
                            Personne p = new Personne(n, pr, a, co);
                            Personne.ajouter(p);
                            break;
                        }
                    case 2:
                        {
                            Personne.affichage();
                            break;
                        }
 
                    case 3:
                        {
                            Console.WriteLine("entrer le code à modifier");
                            int co = int.Parse(Console.ReadLine());
                            Console.WriteLine("donner le nouveau nom");
                            String n = Console.ReadLine();
                            Personne.modifier_nom(co, n);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("entrer le nom à supprimer");
                            String n = Console.ReadLine();
                            Personne.supprimer(n);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("entrer le code à chercher");
                            int n = int.Parse(Console.ReadLine());
                            Personne.chercher(n); break;
                        }
                    case 6:
                        {
                            Personne.categories();
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("le nombre des personnes est :" + Personne.compter());
                            break;
                        }
 
                }
 
            } while (c != 8); 
 
            Console.ReadLine();
        }
    }
}