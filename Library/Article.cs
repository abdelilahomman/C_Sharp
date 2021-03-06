using System;
using System.Collections;
using System.Collections.Generic;

namespace EL_BAHI_HASSAN
{
    class Article
    {
        private string nom;
        private string reference;
        private double prixUnitaire;

        public Article(){}
        public Article(string _nom, string _reference, double _prixUnitaire)
        {
            this.nom = _nom;
            this.reference = _reference;
            this.prixUnitaire = _prixUnitaire;
        }
        public Article(Article _article)
        {
            this.nom = _article.nom;
            this.reference = _article.reference;
            this.prixUnitaire = _article.prixUnitaire;
        }

        public void setNom(string _nom)
        {
            this.nom = _nom;
        }

        public void setRef(string _ref)
        {
            this.reference = _ref;
        }

        public void setPrixUnitaire(double _prixU)
        {
            this.prixUnitaire = _prixU;
        }

        public string getNom()
        {
            return nom;
        }

        public string getReference()
        {
            return reference;
        }

        public double getPrixUnitaire()
        {
            return prixUnitaire;
        }

        public bool Equals(Article a)
        {
            return (this.nom == a.nom);
        }

        public override string ToString()
        {
            return $"article {this.nom}\nreference {this.reference}\nprix {this.prixUnitaire} MAD\n";
        }
    }
}