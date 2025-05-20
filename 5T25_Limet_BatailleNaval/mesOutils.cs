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
        public void iniGrille(char[,] grille)
        {
            char eau = '*'; // symbole de l'eau
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
        public void placeBateaux(char[,] grille)
        {
            char bateau = 'B'; // symbole des bateux
            int i = 0;
            int taille = 5; 
            int iLigneU;
            int iColonneU;
            string horyzontal = "oui";
            for (int continuer = 0; continuer < 4; continuer++)
            {
                Console.WriteLine("voulez-vous mettre votre bateaux à l'horyzontal ?");
                horyzontal = Console.ReadLine();
                Console.WriteLine("Donné moi une colonne");
                iLigneU = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Donné moi une ligne");
                iColonneU = Convert.ToInt32(Console.ReadLine());
                if (horyzontal == "oui")
                {
                    if (taille + i < grille.GetLength(0))
                    {
                        for (int place = 0; place < taille; place++)
                        {
                            grille[iLigneU + place, iColonneU] = bateau;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ceci n'est pas possible");
                    }
                }
                else
                {
                    if ( taille + i < grille.GetLength(1))
                    {
                        for (int place = 0; place < taille; place++)
                        {
                            grille[iLigneU, iColonneU + place] = bateau;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ceci n'est pas possible");
                    }
                }
                taille = taille - 1;
            }
        }
        public void coordonnéesDesMissiles(char [,] grille)
        {
            int iLigne;
            int iColonne;
            string ligneU;
            int ligne;
            string colonneU;
            int colonne;
            do
            {
                Console.WriteLine("donner moi une ligne");
                ligneU = Console.ReadLine();
                while (!int.TryParse(ligneU, out ligne))
                {
                    Console.WriteLine("Cela n'est pas un entier");
                    Console.WriteLine("donner moi une ligne");
                    ligneU = Console.ReadLine();
                }
            } while (ligne < 0 || ligne > 9);

            do
            {
                Console.WriteLine("Donne moi une colonne");
                colonneU = Console.ReadLine();
                while (!int.TryParse (colonneU, out colonne))
                {
                    Console.WriteLine("Cela n'est pas un entier");
                    Console.WriteLine("Donne moi une colonne");
                    colonneU = Console.ReadLine();
                }
            } while(colonne < 0 || colonne > 9);
            int[,] missile = new int[ligne, colonne];
            for (iLigne = 0; iLigne < grille.GetLength(0); iLigne++)
            {
                for (iColonne = 0;iColonne < grille.GetLength(1); iColonne++)
                {
                }
            }
            

        }
    }
}