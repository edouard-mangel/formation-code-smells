using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorpionApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Jeu jeu = new Jeu();

            PuissanceQuatre puissanceQuatre = new PuissanceQuatre();

            Console.WriteLine("Jouer à quel jeu ? Taper [X] pour le morpion et [P] pour le puissance 4.");
            GetKey:
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.X:
                    jeu.BoucleJeu();
                    break;
                case ConsoleKey.P:
                    puissanceQuatre.BoucleJeu();
                    break;
                default:
                    goto GetKey;
            }
        }        
    }
}
