namespace _5T25_Limet_BatailleNaval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "non";
            do
            {
                mesOutils outil = new mesOutils();

                //Variable
                string pseudo1 = ""; // pseudo du premier joueur
                string pseudo2 = ""; // pseudo du deuxième joueur
                const int tailleG = 10; // taille de la grille
                char[,] grille = new char[tailleG, tailleG]; // La grille
                int scoreJ1 = 0;
                int scoreJ2 = 0;
                char[,] grilleJ1 = (outil.iniGrille(grille));
                char[,] grilleJ2 = (outil.iniGrille(grille));
                char [,] grilleMJ1 = (outil.iniGrille(grille));
                char[,] grilleMJ2 = (outil.iniGrille(grille));
                string terminer = "oui";
                bool tourJ1 = true;


                Console.WriteLine("Bonjour à vous et bienvenu dans le jeu bataille naval");
                Console.WriteLine("Quel sera le pseudo du premier joueur ?");
                pseudo1 = Console.ReadLine();
                Console.WriteLine("Quel sera le pseudo du deuxième joueur ?");
                pseudo2 = Console.ReadLine();

                do
                {
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("///////////////////////////////////////////");
                    Console.WriteLine(pseudo1 + " placez vos bateaux");
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    outil.AfficherGrille(grilleJ1);
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    outil.placeBateaux1(grille, ref grilleJ1, ref grilleJ2, tourJ1);
                    outil.AfficherGrille(grilleJ1);
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine(pseudo1 + " avez-vous terminer ?");
                    terminer = Console.ReadLine();
                } while (terminer != "oui");

                do
                {
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("///////////////////////////////////////////");
                    outil.iniGrille(grille);
                    Console.WriteLine(pseudo2 + " placez vos bateaux");
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    outil.AfficherGrille(grille);
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    outil.placeBateaux1(grille, ref grilleJ1, ref grilleJ2, tourJ1);
                    outil.AfficherGrille(grilleJ2);
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                    Console.WriteLine(pseudo2 + " avez-vous terminer ?");
                    terminer = Console.ReadLine();
                } while (terminer != "oui");
                do
                {
                    do
                    {
                        outil.AfficherGrille(grilleJ1);
                        outil.AfficherGrille(grilleJ2);
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine("///////////////////////////////////////////");
                        Console.WriteLine(pseudo1 + " Ou voulez-vous visez");
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        grilleMJ1 = (outil.iniGrille(grille));
                        outil.AfficherGrille(grilleMJ1);
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        outil.CoordonneesDesMissiles(grille, grilleJ1, grilleJ2, ref grilleMJ1, ref grilleMJ2, ref tourJ1);
                        outil.AfficherGrille(grilleMJ1);
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine("///////////////////////////////////////////");
                        Console.WriteLine("Avez-vous terminer ?");
                        terminer = Console.ReadLine();
                    } while (terminer != "oui");
                    do
                    {
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine("///////////////////////////////////////////");
                        Console.WriteLine(pseudo2 + " Ou voulez-vous visez");
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        grilleMJ2 = (outil.iniGrille(grille));
                        outil.AfficherGrille(grilleMJ2);
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        outil.CoordonneesDesMissiles(grille, grilleJ1, grilleJ2, ref grilleMJ1, ref grilleMJ2, ref tourJ1);
                        outil.AfficherGrille(grilleMJ2);
                        Console.WriteLine("////////////////////////////////////////////////////////////////////////////");
                        Console.WriteLine("///////////////////////////////////////////");
                        Console.WriteLine("Avez-vous terminer ?");
                        terminer = Console.ReadLine();
                    } while (terminer != "oui");
                } while (scoreJ1 != 14 && scoreJ2 != 14);
                Console.WriteLine("Voulez-vous recommencer");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");

        }
    }
}