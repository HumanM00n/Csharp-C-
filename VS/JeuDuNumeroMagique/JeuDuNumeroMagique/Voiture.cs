using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolePOO
{
    internal class Voiture
    {
        public string couleur {get; set; }
        public int NbRoues {get; set; }
        public string motorisation {get; set; }
        private int Position { get; set; }
    
        public bool changerNbRoues(int newRouesNbr)
        {
            NbRoues = newRouesNbr;
            return true;
        }

        public void Avancer(int deplacement)
        {
            Position +=  deplacement;
        }

        public void Reculer(int deplacement)
        {
            Position -= deplacement;
        }
    }
}
