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
                bool premierJ = true; //pour savoir qui joue en premier
                string joueur1 = ""; // joueur 1
                string joueur2 = ""; // joueur 2
                string pseudo1 = ""; // pseudo du premier joueur
                string pseudo2 = ""; // pseudo du deuxième joueur
                const int tailleG = 10; // taille de la grille
                char[,] grille = new char[tailleG, tailleG]; // La grille
                char[,] grilleJ1;
                char[,] grilleJ2;


                Console.WriteLine("Bonjour à vous et bienvenu dans le jeu bataille naval");
                Console.WriteLine("Quel sera le pseudo du premier joueur ?");
                pseudo1 = Console.ReadLine();
                Console.WriteLine("Quel sera le pseudo du deuxième joueur ?");
                pseudo2 = Console.ReadLine();

                Console.WriteLine(pseudo1 + " placez vos bateaux");
                outil.iniGrille(grille);
                outil.AfficherGrille(grille);
                outil.placeBateaux(grille);
                outil.AfficherGrille(grille);

                Console.WriteLine(pseudo2 + " placez vos bateaux");
                outil.iniGrille(grille);
                outil.AfficherGrille(grille);
                outil.placeBateaux(grille);
                outil.AfficherGrille(grille);
                premierJ = true;
                do
                {
                    if (premierJ == true)
                    {
                    }
                    else
                    {
                    }
                } while (joueur1 == "perdant" && joueur2 == "gagnant" || joueur2 == "perdant" && joueur1 == "gagnant");


                Console.WriteLine("Voulez-vous recommencer");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");

        }
    }
}