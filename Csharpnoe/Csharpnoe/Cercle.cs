using System;

namespace Csharpnoe
{
    // Définition de la classe 'Cercle' qui hérite de la classe abstraite 'Forme'
    public class Cercle : Forme
    {
        // Champ public 'Rayon' représentant le rayon du cercle
        public double Rayon;

        // Constructeur de la classe 'Cercle' qui prend un objet 'Point' et un 'rayon' comme paramètres
        // Il appelle le constructeur de la classe parente 'Forme' en utilisant le mot-clé 'base'
        public Cercle(Point point, double rayon) : base(point)
        {
            // Le champ 'Rayon' est initialisé avec la valeur passée en paramètre
            this.Rayon = rayon;
        }

        // Surcharge de la méthode abstraite 'Perimetre()' définie dans 'Forme'
        // Cette méthode retourne le périmètre du cercle, calculé avec la formule 2 * π * Rayon
        public override double Perimetre()
        {
            return 2 * Math.PI * Rayon;
        }

        // Surcharge de la méthode abstraite 'Aire()' définie dans 'Forme'
        // Cette méthode retourne l'aire du cercle, calculée avec la formule π * Rayon^2
        public override double Aire()
        {
            return Math.PI * Rayon * Rayon;
        }
    }
}