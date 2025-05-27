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
                char[,] grilleJ1;
                char[,] grilleJ2;
                int scoreJ1 = 0;
                int scoreJ2 = 0;
                char[,] grilleMJ1;
                char[,] grilleMJ2;
                string terminer = "oui";
                bool tourJ1 = true;


                Console.WriteLine("Bonjour à vous et bienvenu dans le jeu bataille naval");
                Console.WriteLine("Quel sera le pseudo du premier joueur ?");
                pseudo1 = Console.ReadLine();
                Console.WriteLine("Quel sera le pseudo du deuxième joueur ?");
                pseudo2 = Console.ReadLine();

                do
                {
                    Console.WriteLine(pseudo1 + " placez vos bateaux");
                    outil.iniGrille(grille);
                    outil.AfficherGrille(grille);
                    grilleJ1 = (outil.placeBateaux(grille));
                    outil.AfficherGrille(grilleJ1);
                    Console.WriteLine(pseudo1 + "avez-vous terminer ?");
                    terminer = Console.ReadLine();
                } while (terminer != "oui");

                do
                {
                    Console.WriteLine(pseudo2 + " placez vos bateaux");
                    outil.iniGrille(grille);
                    outil.AfficherGrille(grille);
                    grilleJ2 = (outil.placeBateaux(grille));
                    outil.AfficherGrille(grilleJ2);
                    Console.WriteLine(pseudo2 + "avez-vous terminer ?");
                    terminer = Console.ReadLine();
                } while (terminer != "oui");

                do
                {
                    do
                    {
                        Console.WriteLine(pseudo1 + " Ou voulez-vous visez");
                        outil.iniGrille(grille);
                        outil.AfficherGrille(grille);
                        outil.CoordonneesDesMissiles(grille, grilleJ1, grilleJ2, out grilleMJ1, out grilleMJ2, ref tourJ1, ref scoreJ1, ref scoreJ2);
                        outil.AfficherGrille(grilleMJ1);
                    } while (terminer != "oui");
                    do
                    {
                        Console.WriteLine(pseudo2 + " Ou voulez-vous visez");
                        outil.iniGrille(grille);
                        outil.AfficherGrille(grille);
                        outil.CoordonneesDesMissiles(grille, grilleJ1, grilleJ2, out grilleMJ1, out grilleMJ2, ref tourJ1, ref scoreJ1, ref scoreJ2);
                        outil.AfficherGrille(grilleMJ2);
                    } while (terminer != "oui");
                } while (scoreJ1 == 14 || scoreJ2 == 14);

                Console.WriteLine("Voulez-vous recommencer");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");

        }
    }
}