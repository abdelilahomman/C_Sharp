using System;
using System.Collections;
using System.Collections.Generic;

namespace EL_BAHI_HASSAN
{
    class Ramette : Article
    {
        private string Format;

        public Ramette(string _nom, string _reference, double prixUnitaire, string format) : base(_nom, _reference, prixUnitaire)
        {
            this.Format = format;
        }
        public Ramette() : base(){}

        public bool Equals(Ramette ram)
        {
            return (this.Format == ram.Format);
        }

        public override string ToString()
        {
            return base.ToString() + $"Format {this.Format}";
        }
    }
}