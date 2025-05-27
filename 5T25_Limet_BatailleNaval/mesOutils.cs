using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5T25_Limet_BatailleNaval
{
    public struct mesOutils
    {
        /// <summary>
        /// On remplis la grille avec * qui représente l'eau
        /// </summary>
        /// <param name="grille">Le plateau de jeu</param>
        public char[,] iniGrille(char[,] grille)
        {
            char eau = '*'; // symbole de l'eau
            for (int iColonne = 0; iColonne < 10; iColonne++)
            {
                for (int iLigne = 0; iLigne < 10; iLigne++)
                {
                    grille[iLigne, iColonne] = eau;
                }
            }
            return grille;
        }
        /// <summary>
        /// Fonction pour afficher la grille
        /// </summary>
        /// <param name="grille">Le plateau de jeu</param>
        public char[,] AfficherGrille(char[,] grille)
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
            return grille;
        }
        /// <summary>
        /// Fonction pour placer les bateaux
        /// </summary>
        /// <param name="grille">Le plateau de jeu</param>
        public char[,] placeBateaux(char[,] grille)
        {
            char bateau = 'B'; // symbole des bateux
            int i = 0;
            int taille = 5;
            string ligneU;
            string colonneU;
            int colonne;
            int ligne;
            string horyzontal = "oui";
            for (int continuer = 0; continuer < 1; continuer++)
            {
                Console.WriteLine("voulez-vous mettre votre bateaux à l'horyzontal ?");
                horyzontal = Console.ReadLine();
                do
                {
                    Console.WriteLine("donner moi une colonne");
                    ligneU = Console.ReadLine();
                    while (!int.TryParse(ligneU, out ligne))
                    {
                        Console.WriteLine("Cela n'est pas un entier");
                        Console.WriteLine("donner moi une colonne");
                        ligneU = Console.ReadLine();
                    }
                } while (ligne < 0 || ligne > 9);
                do
                {
                    Console.WriteLine("Donne moi une ligne");
                    colonneU = Console.ReadLine();
                    while (!int.TryParse(colonneU, out colonne))
                    {
                        Console.WriteLine("Cela n'est pas un entier");
                        Console.WriteLine("Donne moi une ligne");
                        colonneU = Console.ReadLine();
                    }
                } while (colonne < 0 || colonne > 9);
                if (horyzontal == "oui")
                {
                    if (taille + i < grille.GetLength(0))
                    {
                        for (int place = 0; place < taille; place++)
                        {
                            grille[ligne + place, colonne] = bateau;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ceci n'est pas possible");
                    }
                }
                else
                {
                    if (taille + i < grille.GetLength(1))
                    {
                        for (int place = 0; place < taille; place++)
                        {
                            grille[ligne, colonne + place] = bateau;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ceci n'est pas possible");
                    }
                }
                taille = taille - 1;
            }
            return grille;
        }

        public void CoordonneesDesMissiles(char [,] grille, char[,] grilleJ1, char[,] grilleJ2, out char[,] grilleMJ1, out char[,] grilleMJ2, ref bool tourJ1, ref int scoreJ1, ref int scoreJ2)
        {
            char bateau = 'B'; // symbole des bateux
            char batTouche = 'O';
            char rien = 'X';
            string ligneU;
            int ligne;
            string colonneU;
            int colonne;
            grilleMJ2 = new char[grille.GetLength(0), grille.GetLength(1)];
            grilleMJ1 = new char[grille.GetLength(0), grilleJ2.GetLength(1)];
            if (tourJ1 == true)
            {
                do
                {
                    Console.WriteLine("donner moi une colone");
                    ligneU = Console.ReadLine();
                    while (!int.TryParse(ligneU, out ligne))
                    {
                        Console.WriteLine("Cela n'est pas un entier");
                        Console.WriteLine("donner moi une colonne");
                        ligneU = Console.ReadLine();
                    }
                } while (ligne < 0 || ligne > 9);

                do
                {
                    Console.WriteLine("Donne moi une ligne");
                    colonneU = Console.ReadLine();
                    while (!int.TryParse(colonneU, out colonne))
                    {
                        Console.WriteLine("Cela n'est pas un entier");
                        Console.WriteLine("Donne moi une ligne");
                        colonneU = Console.ReadLine();
                    }
                } while (colonne < 0 || colonne > 9);
                if (grilleJ1[ligne, colonne] == bateau)
                {
                    grilleMJ1[ligne, colonne] = batTouche;
                    tourJ1 = false;
                    scoreJ1 += 1;
                }
                else
                {
                    grilleMJ1[ligne, colonne] = rien;
                    tourJ1 = false;
                }
            }
            else
            {
                do
                {
                    Console.WriteLine("donner moi une colone");
                    ligneU = Console.ReadLine();
                    while (!int.TryParse(ligneU, out ligne))
                    {
                        Console.WriteLine("Cela n'est pas un entier");
                        Console.WriteLine("donner moi une colonne");
                        ligneU = Console.ReadLine();
                    }
                } while (ligne < 0 || ligne > 9);

                do
                {
                    Console.WriteLine("Donne moi une ligne");
                    colonneU = Console.ReadLine();
                    while (!int.TryParse(colonneU, out colonne))
                    {
                        Console.WriteLine("Cela n'est pas un entier");
                        Console.WriteLine("Donne moi une ligne");
                        colonneU = Console.ReadLine();
                    }
                } while (colonne < 0 || colonne > 9);
                if (grilleJ2[ligne, colonne] == bateau)
                {
                    grilleMJ2[ligne, colonne] = batTouche;
                    tourJ1 = true;
                    scoreJ2 += 1;
                }
                else
                {
                    grilleMJ2[ligne, colonne] = rien;
                    tourJ1 = true;
                }
            }
        }

    }
}