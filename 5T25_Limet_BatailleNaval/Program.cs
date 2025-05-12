namespace _5T25_Limet_BatailleNaval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recommencer = "non";
            do
            {


                //Variable
                bool premierJ = true; //pour savoir qui joue en premier
                string joueur1 = ""; // joueur 1
                string joueur2 = ""; // joueur 2
                string pseudo1 = ""; // pseudo du premier joueur
                string pseudo2 = ""; // pseudo du deuxième joueur
                const int tailleG = 10; // taille de la grille
                char[,] grille = new char[tailleG, tailleG]; // La grille


                Console.WriteLine("Bonjour à vous et bienvenu dans le jeu bataille naval");
                Console.WriteLine("Quel sera le pseudo du premier joueur ?");
                pseudo1 = Console.ReadLine();
                Console.WriteLine("Quel sera le pseudo du deuxième joueur ?");
                pseudo2 = Console.ReadLine();

                do
                {
                    if (premierJ == true)
                    {
                        Console.WriteLine(pseudo1 + " c'est à votre tour");
                        iniGrille(grille);
                        placeBateux(grille);
                        AfficherGrille(grille);

                        premierJ = false;
                    }
                    else
                    {
                        Console.WriteLine(pseudo2 + " c'est à votre tour");
                        iniGrille(grille);
                        placeBateux(grille);
                        AfficherGrille(grille);
                        premierJ = true;
                    }
                } while (joueur1 == "perdant" && joueur2 == "gagnant" || joueur2 == "perdant" && joueur1 == "gagnant");
                

                Console.WriteLine("Voulez-vous recommencer");
                recommencer = Console.ReadLine();
            } while (recommencer != "non");

        }
        /// <summary>
        /// On remplis la grille avec * qui représente l'eau
        /// </summary>
        /// <param name="grille">Le plateau de jeu</param>
        static void iniGrille(char[,] grille)
        {
            const char eau = '*'; // symbole de l'eau
            for (int iColonne = 0; iColonne < 10; iColonne++)
            {
                for (int iLigne = 0; iLigne < 10; iLigne++)
                {
                    grille[iLigne, iColonne] = eau;
                }
            }
        }
        /// <summary>
        /// Fonction pour afficher la grille
        /// </summary>
        /// <param name="grille">Le plateau de jeu</param>
        static void AfficherGrille(char[,] grille)
        {
            Console.Write("  ");
            for (int iLigne = 0; iLigne < 10; iLigne++)
            {
                Console.Write($"{iLigne} ");
            }
            Console.WriteLine();

            for (int iColonne = 0; iColonne < 10; iColonne++)
            {
                Console.Write($"{iColonne} ");
                for (int iLigne = 0; iLigne < 10; iLigne++)
                {
                    Console.Write($"{grille[iLigne, iColonne]} ");
                }
                Console.WriteLine();
            }
        }

        static void placeBateux(char[,] grille)
        {
            const char bateau = 'B'; // symbole des bateux
            const int cuirasse = 5;
            const int contreTorpilleur = 4;
            const int sousMarin = 3;
            const int bateuSauvetage = 2;
            int iLigne = 0;
            int iColonne = 0;
            string choix = "";
            string horyzontal;
            for (int continuer = 0; continuer < 4; continuer++)
            {
                Console.WriteLine("Choisissez un bateau à placer (cuirassé = 5, contre-torpilleur = 4, sous-marin = 3, bateau de sauvetage = 2)");
                choix = Console.ReadLine();
                if (choix == "cuirassé")
                {
                    for (int i = 0; i < grille.GetLength(0); i++)
                    {
                        Console.WriteLine("voulez-vous mettre votre bateaux à l'horyzontal ?");
                        horyzontal = Console.ReadLine();
                        if (horyzontal == "oui")
                        {
                            if (cuirasse + i < grille.GetLength(0))
                            {
                                grille[cuirasse + i, iColonne] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                        else
                        {
                            if (cuirasse + i < grille.GetLength(1))
                            {
                                grille[iLigne, cuirasse + i] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                    }

                }
                if (choix == "contre-torpilleur")
                {
                    for (int i = 0; i < grille.GetLength(0); i++)
                    {
                        Console.WriteLine("voulez-vous mettre votre bateaux à l'horyzontal ?");
                        horyzontal = Console.ReadLine();
                        if (horyzontal == "oui")
                        {
                            if (contreTorpilleur + i < grille.GetLength(0))
                            {
                                grille[contreTorpilleur + i, iColonne] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                        else
                        {
                            if (contreTorpilleur + i < grille.GetLength(1))
                            {
                                grille[iLigne, contreTorpilleur + i] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                    }
                }
                if (choix == "sous-marin")
                {
                    for (int i = 0; i < grille.GetLength(0); i++)
                    {
                        Console.WriteLine("voulez-vous mettre votre bateaux à l'horyzontal ?");
                        horyzontal = Console.ReadLine();
                        if (horyzontal == "oui")
                        {
                            if (sousMarin + i < grille.GetLength(0))
                            {
                                grille[sousMarin + i, iColonne] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                        else
                        {
                            if (sousMarin + i < grille.GetLength(1))
                            {
                                grille[sousMarin, iColonne + i] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                    }
                }
                if (choix == "bateau de sauvetage")
                {
                    for (int i = 0; i < grille.GetLength(0); i++)
                    {
                        Console.WriteLine("voulez-vous mettre votre bateaux à l'horyzontal ?");
                        horyzontal = Console.ReadLine();
                        if (horyzontal == "oui")
                        {
                            if (bateuSauvetage + i < grille.GetLength(0))
                            {
                                grille[bateuSauvetage + i, iColonne] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                        else
                        {
                            if (bateuSauvetage + i < grille.GetLength(1))
                            {
                                grille[iLigne, bateuSauvetage + i] = bateau;
                            }
                            else
                            {
                                Console.WriteLine("Ceci n'est pas possible");
                            }
                        }
                    }
                }

            }
        }
    }
}
