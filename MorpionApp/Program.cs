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
            jeu.affichePlateau();
            jeu.tourJoueur();
        }        
    }
}
