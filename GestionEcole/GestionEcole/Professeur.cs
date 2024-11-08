using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole
{
    internal class Professeur : Personne
    {
        private decimal salaire;

        public decimal Salaire { get => salaire; set => salaire = value; }

        public Professeur() { }

        public Professeur(string nom, string prenom, int age, decimal salaire)
            : base(nom, prenom, age)
        { 
            this.salaire = salaire; 
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine($"Salire : {Calculcout()}");   
        }
        public decimal Calculcout()
        {
            return salaire * 12;
        }
    }
}
