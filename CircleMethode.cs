using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Circle
{
    class CircleMethode
    {
        // attributs privés par convention, leur nom commence par '_'
        private double _rayon;
        public double rayon
        {
            get
            {
                return _rayon;
            }
            set
            {
                _rayon = value;
            }
        }

        public double CalculAire()
        {
            double surface = Math.PI * _rayon * _rayon;
            return surface;
        }
        public double CalculPerimetre()
        {
            double perimetre = 2 * Math.PI * _rayon;
            return perimetre;
        }
        public string AfficheInfo()
        {
           string phrase = "Le cercle de Rayon" + _rayon + "a un perimetre de" + CalculPerimetre() + "et une aire de" + CalculAire();
            return phrase;
        }

    }



}
