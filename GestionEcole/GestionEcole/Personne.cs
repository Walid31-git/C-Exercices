using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole
{
    internal class Personne
    {
        protected string nom;
        protected string prenom;
        protected int age;

        protected string Nom { get => nom; set => nom = value; }
        protected string Prenom { get => prenom; set => prenom = value; }
        protected int Age { get => age; set => age = value; }

        // Constructeur sans paramètres (à ajouter)
        public Personne() { }

        // Constructeur avec paramètres
        public Personne(string nom, string prenom, int age)
        {
            this.prenom = prenom;
            this.age = age;
            this.nom = nom;
        }

        public virtual void Afficher()
        {
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"Prénom : {prenom}");
            Console.WriteLine($"Âge : {age}");
        }

        public void Vieillir()
        {
            age++;
        }
    }
}
