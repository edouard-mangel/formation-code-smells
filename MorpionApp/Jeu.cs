using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorpionApp
{
    public class Jeu
    {
        public static bool quiterJeu = false;
        public static bool tourDuJoueur = true;
        public char[,] grille;

        public Jeu()
        {
            grille = new char[3,3];
        }

        public void BoucleJeu()
        {
            while(!quiterJeu)
            {
                grille = new char[3, 3] 
                {
                    { ' ', ' ', ' '},
                    { ' ', ' ', ' '},
                    { ' ', ' ', ' '},
                };
                while(!quiterJeu)
                {
                    if(tourDuJoueur)
                    {
                        tourJoueur();
                    }
                    else
                    {
                        tourJoueur2();
                    }
                }
                if(!quiterJeu)
                {
                    Console.WriteLine("Appuyer sur [Echap] pour quitter");
                    GetKey:
                    switch(Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                            quiterJeu = true;
                            Console.Clear();
                            break;

                        default:
                            goto GetKey;
                    }
                }

            }
        }

        public void tourJoueur()
        {
            var (row, column) = (0, 0);
            bool moved = false;

            while (!quiterJeu && !moved)
            {
                Console.Clear();
                affichePlateau();
                Console.WriteLine();
                Console.WriteLine("Choisir une case valide est appuyer sur [Entrer]");
                Console.SetCursorPosition(column * 6 + 1, row * 4 + 1);

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Escape:
                        quiterJeu = true;
                        Console.Clear();
                        break;

                    case ConsoleKey.RightArrow:
                        if (column >= 2)
                        {
                            column = 0;
                        }
                        else
                        {
                            column = column + 1;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (column <= 0)
                        {
                            column = 2;
                        }
                        else
                        {
                            column = column - 1;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (row <= 0)
                        {
                            row = 2;
                        }
                        else
                        {
                            row = row - 1;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (row >= 2)
                        {
                            row = 0;
                        }
                        else
                        {
                            row = row + 1;
                        }
                        break;
                }

            }
        }

        public void tourJoueur2()
        {

        }

        public void affichePlateau()
        {
            Console.WriteLine();
            Console.WriteLine($" {grille[0, 0]}   |  {grille[0, 1]}   |  {grille[0, 2]}");
            Console.WriteLine("    |     |");
            Console.WriteLine("----+-----+----");
            Console.WriteLine("    |     |");
            Console.WriteLine($" {grille[1, 0]}   |  {grille[1, 1]}   |  {grille[1, 2]}");
            Console.WriteLine("    |     |");
            Console.WriteLine("----+-----+----");
            Console.WriteLine("    |     |");
            Console.WriteLine($" {grille[2, 0]}   |  {grille[2, 1]}   |  {grille[2, 2]}");
        }
    }
}
