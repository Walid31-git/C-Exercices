using GestionEcole.GestionEcole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole
{
    internal class Ecole
    {
        List<Eleve> eleves = new List<Eleve>();
        List<Professeur> professeurs = new List<Professeur>();
        string nom, adresse;
        decimal budjet;

        public string Nom { get => nom; set => nom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public decimal Budjet { get => budjet; set => budjet = value; }
        public Ecole() {}

        public Ecole(string nom, string adresse, decimal budjet)
        {
            this.nom = nom;
            this.adresse = adresse;
            this.budjet = budjet;
        }

        public void AjouterProfesseur(Professeur prof)
        {
            professeurs.Add(prof);
        }
        public void AjouterEleve(Eleve eleve)
        {
            eleves.Add(eleve);
        }
        public void Afficher()
        {
            Console.WriteLine($"Nom: {nom}");
            Console.WriteLine($"Adresse: {adresse}");
            Console.WriteLine($"Budget: {budjet}");

            Console.WriteLine("Liste Eleves");
            foreach (Eleve eleve in eleves)
            {
                eleve.Afficher();
            }

            Console.WriteLine("Liste Professeurs");
            foreach (Professeur professeur in professeurs)
            {
                professeur.Afficher();
            }
        }
    }
}
        
