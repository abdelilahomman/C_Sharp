using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EL_BAHI_HASSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Devloper D1 = new Devloper(1,"abdelilah", "Ommane", "abdelilahoman@hotmail.com", "0777366604", 10000, "c# Devlore");
            Console.WriteLine(D1.ToString());
            Console.WriteLine("--------------------------\nManager\n------------------------------");
            Manager m1 = new Manager(12,"Abderzzak", "said", "abderaza@hotmail.com", "066xxxxx68",30000, "Manager informatique Departement");
            Console.WriteLine(m1.ToString());
        }
    }
}
