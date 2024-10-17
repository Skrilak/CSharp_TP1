using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnoe
{
    // Déclaration de la classe principale Programme
    class programme
    {
        // Méthode Main : point d'entrée du programme
        static void Main(string[] args)
        {
            // Création d'un point avec des coordonnées x = 3 et y = 4
            Point p = new Point(3, 4);
            Console.WriteLine("Point : " + p.ToString());  // Affichage des informations sur le point

            // Création d'un cercle avec le point 'p' comme centre et un rayon de 5
            Cercle c = new Cercle(p, 5);
            Console.WriteLine(c.ToString());  // Affichage des informations sur le cercle
            Console.WriteLine("Périmètre du cercle : " + c.Perimetre());  // Affichage du périmètre du cercle
            Console.WriteLine("Aire du cercle : " + c.Aire());  // Affichage de l'aire du cercle

            // Création d'un rectangle avec le point 'p' comme coin supérieur gauche, une largeur de 8 et une hauteur de 6
            Rectangle r = new Rectangle(p, 8, 6);
            Console.WriteLine(r.ToString());  // Affichage des informations sur le rectangle
            Console.WriteLine("Périmètre du rectangle : " + r.Perimetre());  // Affichage du périmètre du rectangle
            Console.WriteLine("Aire du rectangle : " + r.Aire());  // Affichage de l'aire du rectangle
        }
    }
}