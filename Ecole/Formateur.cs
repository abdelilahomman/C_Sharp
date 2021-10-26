using System;
using System.Collections;
using System.Linq;
using System.Text;
 
namespace GestionModules
{
    class Personne
    {
        private string nom;
        private ArrayList prenom;
        private DateTime DateNaissance;
 
        // Question 8
        public Personne(string _nom, ArrayList _prenom, DateTime DN) {
            this.nom = _nom;
            this.prenom = _prenom;
            this.DateNaissance = DN;
        }
 
        // Question 7
        public string getNom() {
            return nom;
        }
        public ArrayList getPrenom() {
            return prenom;
        }
        public DateTime getDN() {
            return DateNaissance;
        }
 
        public void setNom(string _nom)
        {
            this.nom=_nom;
        }
        public void getPrenom(ArrayList _prenom)
        {
            this.prenom=_prenom;
        }
        public void getDN(DateTime DN)
        {
            DateNaissance = DN;
        }
 
 
        // Question 9
        public bool Equals(Personne p)
        {
            return ((this.nom == p.nom) && (this.prenom==p.prenom));
        }
 
        // Question 10
        public override string ToString()
        {
            // Méthode 1
            string prenoms="";
            foreach (string pn in prenom)
            {
                prenoms = prenoms + " " + pn;
            }
 
            // Moéthode 2
            // string prenoms = string.Join(" ", prenom.ToArray());
 
            return "Le pesonne :" + nom + " " + prenoms + ", sa date de naissance est : " + DateNaissance;
        }
    }
    class Formateur : Personne
    {
        private string matricule;
        private ArrayList Listmodules;
  
        // Question 12
        public Formateur(string _nom, ArrayList _prenom, DateTime DN, string _matricule, ArrayList _modules):base(_nom,_prenom,DN)
        {
            matricule = _matricule;
            Listmodules = _modules;
        }
 
        // Question 11
        public string getMatricule()
        {
            return matricule;
        }
        public ArrayList getListmodules()
        {
            return Listmodules;
        }
        public void setMatricule(string _matricule)
        {
            this.matricule = _matricule;
        }
        public void setModules(ArrayList _modules)
        {
            this.Listmodules = _modules;
        }
 
        // Question 13
        public bool Equals(Formateur f)
        {
            return ((base.getNom() == f.getNom()) && (base.getPrenom() == f.getPrenom()) && (this.matricule == f.matricule));
        }
 
        // Question 15
        public void ajouterModule(Module m) 
        {
            if (this.verifierModule(m) == false)
            {
                this.Listmodules.Add(m);
                Console.WriteLine("Le module a été ajouté avec succès au formateur");
            }
            else {
                Console.WriteLine("l'ajouter n'a pas été effectué car ce module est déjà pris en charge par le formateur");
            }
        }
 
        // Question 14
        public bool verifierModule(Module m) 
        {
            int j = 0;
            foreach (Module mod in Listmodules)
            {
                if (mod.Equals(m)) {
                    j++;
                }
            }
            if (j == 0) {
                //Console.WriteLine("Ce module n'est pas pris en charge par le formateur");
                return false;
            }
            else{
                //Console.WriteLine("Ce module est pris en charge par le formateur");
                return true;
            }
        }
 
        // Question 16
        public void supprimerModule(Module m) {
            if (this.verifierModule(m) == true)
            {
                Listmodules.Remove(m);
                Console.WriteLine("la suppression a été effectué avec succès");
            }
            else {
                Console.WriteLine("la suppression n'a pas été effectué car le module n'est pas pris en charge par le formateur");
            }
        }
 
 
        // Question 17
        public int totalMH() {
            int total = 0;
            foreach (Module m in Listmodules) {
                total = total + m.getMO();
            }
            return total;
        }
 
        // Question 18 : 
 
        //public ArrayList listeModules()
        //{
        //    return this.Listmodules;
        //}
 
        // Question 19-a :
        public ArrayList listeModules(int seuil)
        {
            ArrayList l = new ArrayList();
            foreach (Module m in Listmodules)
            {
                if (m.getMO() > seuil) {
                    l.Add(m);
                }
            }
            return l;
        }
 
        // Question 19-b :
        public string listeModules()
        {
            string str ="";
            foreach (Module m in Listmodules)
            {
                str = str + "\n " + m.getDM();
            }
            return str;
        }
    }
}