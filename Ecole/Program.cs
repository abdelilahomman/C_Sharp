using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace EL_BAHI_HASSAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Formateur f1 = new Formateur("Saddi", prenom3, DN3,"DD1",modules);
            f1.ajouterModule(m1);
            f1.ajouterModule(m2);
            f1.ajouterModule(m3);
            f1.ajouterModule(m4);
            f1.ajouterModule(m6);
            f1.supprimerModule(m5);
            ArrayList LF= f1.listeModules(90);
             
            Console.WriteLine("Nombre des modules qui sont pris en charge par le formateur :" + f1.getListmodules().Count);
            Console.WriteLine("Nombre des modules après l'application de la seuil : " + LF.Count);
 
            Console.WriteLine("La masse horaire globale prise en charge par un formateur est :" + f1.totalMH());
            Console.WriteLine("La liste de modules qui sont pris en charge par le formateur :" + f1.listeModules());
            Console.ReadLine();
        }
    }
}
