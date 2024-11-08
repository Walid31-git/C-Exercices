using GestionEcole.GestionEcole;

namespace GestionEcole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            




            Eleve eleve1 = new Eleve("Balthazar", "Russell", 22);
            eleve1.AjouterMoyenne(19);
            eleve1.AjouterMoyenne(12);
           

            Professeur professeur1 = new Professeur("Douglass", "Banabe", 45, 1200);
            

            Ecole ecole = new Ecole("La classe de balto", "102 rue Benin", 100000);
            
            ecole.AjouterProfesseur(professeur1);
            ecole.AjouterEleve(eleve1);
            ecole.Afficher();


        }
    }
}
