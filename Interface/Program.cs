using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Animales
    {
        public string _Name;
        public int _Age;

        public Animales(string name, int age)
        {
            _Name = name;
            _Age = age;
        }

        public override string ToString() => $"name | {_Name} age | {_Age}\n -------------------------------";
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animales> Animale= new List<Animales>();

            Animale.Add(new Animales("zakaia", 20));
            Animale.Add(new Animales("Amine chawlid", 30));
            Animale.Add(new Animales("Zouair ait malek", 30));

            foreach(var animale in Animale)
            {
                Console.WriteLine(animale.ToString());
            }
        }
    }
}