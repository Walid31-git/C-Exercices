using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEcole
{
    namespace GestionEcole
    {
        internal class Eleve : Personne
        {
            private List<double> notes = new List<double>();

            // Propriété pour accéder aux notes de l'élève
            public List<double> Notes { get => notes; set => notes = value; }

            // Constructeur sans paramètres
            public Eleve() { }

            // Constructeur avec paramètres
            public Eleve(string nom, string prenom, int age)
                : base(nom, prenom, age) { }


            public override void Afficher()
            {
                base.Afficher();
                Console.Write("Notes: ");
                foreach (var item in notes)
                {
                    Console.Write($"[{item}], ");
                }
                Console.WriteLine();

                Console.WriteLine($"Moyenne generale: {MoyenneGen()}");
            }
            public double MoyenneGen()
            {
                if (notes.Count > 0)
                {
                    return notes.Average();
                }
                return 0;
            }
            public void AjouterMoyenne(double moyenne)
            {
                notes.Add(moyenne);
            }


        }
    }

}
