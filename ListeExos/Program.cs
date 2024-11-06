using System;
using System.Collections.Generic;

namespace ListeExos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercice10();
        }
        
        public static void Exercice1()
        {
            Console.WriteLine("Donner une valeur");
            int val = int.Parse(Console.ReadLine());
            if (val == 0)
                Console.WriteLine($"La valeur {val} est egal à 0");
            else if (val > 0)
                Console.WriteLine($"La valeur {val} est supérieur a 0 (positive)");
            else
                Console.WriteLine($"La valeur {val} est inférieur à 0 (negative)");

        }
        public static void Exercice2()
        {
            Console.WriteLine("Bienvenue dans la calculatrice \n Taper un nombre A ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Taper un nombre B");
            int b = int.Parse(Console.ReadLine());
            string op;
            do
            {
                Console.WriteLine("Donner une operation qui vous interesse \n + \n * \n - \n /");
                op = Console.ReadLine();

            } while (op != "+" && op != "*" && op != "-" && op != "/");
            int resulat = 0;
            switch(op)
            {
                case "+":
                    resulat = a + b;
                    break;
                case "-":
                    resulat = a - b;
                    break;
                case "*":
                    resulat = a * b;
                    break;
                case "/":
                    {
                        if (b != 0)
                            resulat = a / b;
                        else
                        {
                            Console.WriteLine("Erreur : Division par zéro.");
                            return;
                        }
                    }
                    break;

            }
            Console.WriteLine($"Voici le resultat {resulat} ");
            Console.ReadKey();

        }
        public static void Exercice3()
        {
            int j;
            for (j = 1; j <= 20; j++)
            {
                Console.WriteLine($"{j}");
            }
            j = 1;
            while(j <= 20)
            {
                Console.WriteLine($"{j}");
                j++;
            } 
        }
        public static void Exercice4()
        {
            Console.WriteLine("tu veux la table que quelle valeur ?");
            int t= int.Parse( Console.ReadLine() );
            int res = 0;
            for(int i = 1; i <= 10; i++)
            {
                res = i * t;
                Console.WriteLine($"{i} x {t} = {res} ");
            }
        }
        public static void Exercice6()
        {
            Console.WriteLine(" Donne moi un nombre A");
            int a = int.Parse(Console.ReadLine());
            int b;
            do
            {
                Console.WriteLine(" Donne moi un nombre B qui doit etre supérieur a A");
                b = int.Parse(Console.ReadLine());
            } while (b < a);
            int res = 0;
            
        for(int i = a; i <= b; i++)
            {
                res = res + i;
               
            }
            Console.WriteLine($"la somme de tout est de : {res}");
        }
        public static void Exercice7()
        {
            List<double> list = new List<double> { 1.0 , 5.5 , 7.4 , 9.4 , 2.8 };
            Console.WriteLine($"La moyenne est de {list.Average()}");
        }
        public static void Exercice8()
        {
            List<string> prenoms = new List<string> {
            "Adam", "Léa", "Yasmine", "Hugo", "Nora", "Ahmed", "Sarah", "Maxime", "Lina", "Karim",
            "Camille", "Sofia", "Julien", "Nadia", "Rayan", "Emma", "Amine", "Chloé", "Mehdi", "Inès",
            "Pierre", "Lucie", "Ali", "Marion", "Samir", "Eva", "Jules", "Laura", "Bilal", "Anaïs",
            "Marc", "Zohra", "Lucas", "Salma", "Dylan", "Manon", "Thomas", "Émilie", "Ibrahim", "Amina",
            "Clara", "Rémi", "Sofiane", "Dounia", "Lilian", "Maya", "Paul", "Lila", "Antoine", "Rim",
            "Alex", "Morgane", "Tarek", "Sabrina", "Louis", "Julie", "Zaki", "Aicha", "Kylian", "Yasmina",
            "Oscar", "Imane", "Théo", "Mélanie", "Samy", "Sara", "Baptiste", "Nour", "Anis", "Sonia",
            "Jacques", "Layla", "Gaspard", "Sana", "Fabien", "Mounia", "Damien", "Ilhem", "Mounir", "Siham",
            "François", "Aurelie", "Pascal", "Karima", "Valentin", "Dina", "Guillaume", "Hafsa", "Romain", "Dalila",
            "Nicolas", "Kenza", "Philippe", "Zina", "Eric", "Khadija", "Jean", "Aya", "Laurent", "Baya",
            "Charles", "Nada", "Sébastien", "Meriem", "David", "Sihame", "Vincent", "Hanane", "Etienne", "Aïda",
            "Cédric", "Djamila", "Quentin", "Imen", "Franck", "Soraya", "Yannick", "Fadoua", "Victor", "Bouchra",
            "Mathieu", "Lamia", "Jonathan", "Hind", "Léo", "Basma", "Sylvain", "Widad", "Martin", "Narimane",
            "Kevin", "Amira", "Gregory", "Samira", "Thierry", "Farida", "Christophe", "Hasna", "Geoffrey", "Ilham",
            "Jordan", "Houda", "Fabrice", "Chaima", "Ludovic", "Rahma", "Clément", "Sihame", "Arnaud", "Yousra",
            "Patrick", "Fouzia", "Benjamin", "Iliana", "Jérôme", "Saida", "Arthur", "Rania", "Olivier", "Faiza",
            "Xavier", "Asma", "Florian", "Souad", "Raphaël", "Dania", "Adrien", "Naima", "Michel", "Loubna",
            "Mohamed", "Hayet", "Rayane", "Fatima", "Stéphane", "Meriem", "Benoit", "Khadidja", "Didier", "Latifa",
            "Éric", "Kaoutar", "Alain", "Ikram", "Dan", "Oumayma", "Séb", "Loubna", "Nadir", "Oumaima",
            "Karim", "Rym", "Saïd", "Ikram", "Zakaria", "Saadia", "Hassan", "Zakia", "Malik", "Ghizlane", "Adeline", "Alain", "Alban", "Albert", "Alexandra", "Alexandre", "Alexis", "Alfred", "Alicia", "Alix",
            "Amandine", "Amélie", "Anaïs", "André", "Anita", "Annabelle", "Anne", "Antoine", "Ariane", "Armand",
            "Arnaud", "Arthur", "Aude", "Aurélien", "Aurélie", "Axel", "Barbara", "Bastien", "Benjamin", "Bernard",
            "Bertrand", "Blandine", "Brice", "Brigitte", "Bruno", "Camille", "Carine", "Carla", "Carole", "Catherine",
            "Cédric", "Céline", "Chantal", "Charles", "Chloé", "Christelle", "Christian", "Christine", "Christophe", "Claire",
            "Clara", "Claude", "Claudia", "Clément", "Clémentine", "Coralie", "Corinne", "Cyril", "Damien", "Daniel",
            "Danielle", "David", "Denis", "Diane", "Didier", "Dimitri", "Dominique", "Dorian", "Édouard", "Éléonore",
            "Élise", "Élodie", "Émilie", "Éric", "Estelle", "Étienne", "Fabien", "Fabrice", "Fanny", "Farid",
            "Fatima", "Faustine", "Félix", "Fernand", "Flavie", "Florence", "Florian", "Francis", "Franck", "François",
            "Frédéric", "Gabriel", "Gaspard", "Géraldine", "Gérard", "Ghislaine", "Gilbert", "Gilles", "Gisèle", "Guillaume",
            "Guy", "Hélène", "Henri", "Hervé", "Hugo", "Ingrid", "Irène", "Isabelle", "Jacqueline", "Jacques",
            "Jade", "Jean", "Jeanne", "Jennifer", "Jeremy", "Jérôme", "Jessica", "Joël", "Johanna", "Jonathan",
            "Joséphine", "Jules", "Julien", "Juliette", "Justine", "Karim", "Karine", "Kévin", "Laurent", "Laurie",
            "Laurine", "Léa", "Léo", "Lionel", "Louis", "Louise", "Lucas", "Lucie", "Ludovic", "Madeleine",
            "Manon", "Marc", "Marcel", "Margaux", "Marguerite", "Maria", "Marianne", "Marie", "Marina", "Marine",
            "Mario", "Martine", "Mathieu", "Mathilde", "Matthieu", "Maurice", "Maxime", "Mehdi", "Mélanie", "Michel",
            "Mickaël", "Mireille", "Monique", "Morgane", "Myriam", "Nadine", "Nathalie", "Nicolas", "Noémie", "Nora",
            "Océane", "Olivia", "Omar", "Pascal", "Patricia", "Patrick", "Paul", "Paulette", "Philippe", "Pierre",
            "Quentin", "Rachel", "Raphaël", "Raymond", "Rémy", "René", "Robert", "Roger", "Roland", "Romain",
            "Rosalie", "Sabine", "Salima", "Samira", "Sandra", "Sarah", "Serge", "Simon", "Sophie", "Stéphane",
            "Sylvain", "Sylvie", "Théo", "Thierry", "Thomas", "Valentin", "Valérie", "Vanessa", "Véronique", "Victor",
            "Vincent", "Viviane", "William", "Xavier", "Yann", "Yannick", "Yasmina", "Yohan", "Yves", "Zoé", "Abdel", "Abdallah", "Abdou", "Abigaël", "Adel", "Adriana", "Agnès", "Aimé", "Aissatou", "Alia",
            "Alina", "Ali", "Aloïs", "Amadou", "Amel", "Amira", "Anas", "Andréa", "Angela", "Anissa",
            "Anna", "Annick", "Anselme", "Antonia", "Anwar", "Arielle", "Arsène", "Assia", "Aurel", "Aurore",
            "Ayoub", "Aziza", "Badis", "Baptiste", "Bassam", "Baya", "Bérangère", "Bernadette", "Bilel", "Bintou",
            "Boris", "Brenda", "Cédrick", "Cécile", "Celeste", "Céline", "Charlie", "Cherif", "Chems", "Chérine",
            "Christian", "Cindy", "Claudine", "Coline", "Constance", "Constant", "Danièle", "Daniela", "Dara", "Dario",
            "Deborah", "Demba", "Denise", "Diane", "Djamel", "Djibril", "Dominique", "Doriane", "Driss", "Eddy",
            "Éléa", "Éliane", "Elijah", "Elisa", "Elsa", "Elvis", "Emeline", "Émilien", "Émmanuelle", "Emy",
            "Erwan", "Esteban", "Esther", "Eugène", "Evan", "Évelyne", "Ewen", "Fabienne", "Fatoumata", "Fayçal",
            "Fayza", "Ferdinand", "Feriel", "Firmin", "Flavio", "Fouad", "Fred", "Gaëlle", "Gaétan", "Gaston",
            "Ghizlane", "Gino", "Gisèle", "Grace", "Grégory", "Habib", "Hadi", "Hafid", "Halim", "Hamid",
            "Hania", "Héloïse", "Hichem", "Hind", "Houda", "Hugo", "Idriss", "Ilias", "Ilona", "Imed",
            "Isaac", "Isabelle", "Isidore", "Issam", "Jacqueline", "Jamil", "Janna", "Jean-Luc", "Jean-Marc", "Jeanne",
            "Jessica", "Jihane", "Jocelyne", "Joëlle", "Joey", "Jordan", "Josephine", "Judith", "Julia", "Julio",
            "Kaïs", "Kamal", "Kamelia", "Karen", "Karim", "Karine", "Kawtar", "Kenzo", "Khadra", "Khaled",
            "Kilian", "Kylian", "Lamia", "Lamine", "Laure", "Lazare", "Léandro", "Léna", "Lenny", "Liana",
            "Lila", "Lilia", "Lise", "Loubna", "Louise", "Ludivine", "Lyes", "Maëlys", "Maïssa", "Malek",
            "Malika", "Malo", "Mamoudou", "Manel", "Manuel", "Margot", "Marina", "Marouane", "Martha", "Mathis",
            "Matisse", "Maya", "Mehdy", "Mélina", "Meryem", "Michael", "Mickaella", "Milan", "Mina", "Moez",
            "Mokhtar", "Monica", "Mourad", "Myriam", "Nada", "Naël", "Nahil", "Najla", "Nawal", "Nawel",
            "Nell", "Nicolas", "Nina", "Nizar", "Noah", "Noha", "Nour", "Océane", "Omar", "Ophélie",
            "Othmane", "Pascaline", "Patrice", "Patty", "Pauline", "Pénélope", "Priscille", "Rachid", "Rania", "Raoul",
            "Raymond", "Rim", "Rita", "Robin", "Roméo", "Rudy", "Sabri", "Saïda", "Samia", "Selim",
            "Sofiane", "Soukaina", "Syrine", "Tahar", "Tania", "Tarek", "Théodore", "Tony", "Valérie", "Victorine",
            "Walid", "Warda", "Yacine", "Yara", "Yasmine", "Yassine", "Younes", "Youcef", "Yvan", "Ziad" };

            Console.WriteLine("Donne moi un prenom Français que je chercherais dans ma base de donnée");
            string prenom = Console.ReadLine();
            int i = -1;
            foreach(string item in prenoms)
            {
                if (item == prenom)
                {
                    Console.WriteLine($"{prenom} est disponible sur notre base de donnée generée par chatGpt");
                    i++;
                }
            }
            if (i == -1) Console.WriteLine("Prenom Indisponible");
        
        }
        public static void Exercice9()
        {
            Console.WriteLine("Donner un mot");
            string mot = Console.ReadLine();
            mot = mot.ToUpper();
            List<string> voyelles = new List<string> { "A", "E", "I", "O", "U", "Y" };
            int i = mot.Length;
            int compteur = 0;
            string memoire = "";
            bool voyelletrue = false;
            for (int j = 0; j < i; j++)
            {
                foreach (string lettre in voyelles)
                {
                    if (mot[j].ToString() == lettre)
                    {
                        compteur++;
                        memoire += lettre + ", ";
                        voyelletrue = true;
                    }
                }                
            }
            if (!voyelletrue)
            {
                Console.WriteLine($"aucune voyelle n'est disponible dans le mot {mot}");
            }
            else
            {
                Console.WriteLine($"Le nombre de voyelles trouvé est de {compteur}");
                Console.WriteLine($"Les voyelles trouvées sont : {memoire}");

            }
        }
        public static void Exercice10()
        {
            Console.WriteLine("Veuiller ecire une date sous forme DD/MM/AAAA");
            string date_Brut = Console.ReadLine();
            string[] date = date_Brut.Replace("-","/").Split('/');
            bool verif = true;
            if (int.TryParse(date[0], out int jour))
            {
                if (jour < 1 || jour > 31)
                {
                    Console.WriteLine("Le jour doit être compris entre 01 et 31.");
                    verif = false;
                }
                
            }
            if (int.TryParse(date[1], out int mois))
            {
                if (mois < 1 || mois > 12)
                {
                    Console.WriteLine("Le mois doit être compris entre 01 et 12.");
                    verif = false;
                }

            }
            if (!verif)
            {
                Console.WriteLine("Date invalide, programme terminé.");
                return;
            }

        }
    }
}

