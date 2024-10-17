using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnoe
{
    // Définition de la classe 'Rectangle' qui hérite de la classe abstraite 'Forme'
    public class Rectangle : Forme
    {
        // Champs publics représentant les dimensions du rectangle : la longueur et la largeur
        public double Longueur;
        public double Largeur;

        // Constructeur de la classe 'Rectangle' qui prend un objet 'Point' ainsi que la 'longueur' et la 'largeur'
        // Il appelle le constructeur de la classe parente 'Forme' via le mot-clé 'base'
        public Rectangle(Point point, double longueur, double largeur) : base(point)
        {
            // Initialisation des champs Longueur et Largeur avec les valeurs passées en paramètres
            this.Longueur = longueur;
            this.Largeur = largeur;
        }

        // Surcharge de la méthode abstraite 'Perimetre()' définie dans 'Forme'
        // Calcule et renvoie le périmètre du rectangle avec la formule : 2 * (longueur + largeur)
        public override double Perimetre()
        {
            return 2 * (Longueur + Largeur);
        }

        // Surcharge de la méthode abstraite 'Aire()' définie dans 'Forme'
        // Calcule et renvoie l'aire du rectangle avec la formule : longueur * largeur
        public override double Aire()
        {
            return Longueur * Largeur;
        }
    }
}