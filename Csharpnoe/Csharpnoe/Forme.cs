using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpnoe
{
    // Définition d'une classe abstraite 'Forme' qui servira de base pour d'autres formes géométriques
    public abstract class Forme
    {
        // Un champ public de type 'Point' représentant le point d'ancrage de la forme
        public Point point;

        // Constructeur de la classe abstraite 'Forme' qui prend un objet 'Point' en paramètre
        // Ce constructeur permet d'initialiser le champ 'point' avec la valeur passée lors de la création de l'objet
        public Forme(Point point)
        {
            // 'this.point' fait référence au champ de la classe, tandis que 'point' est le paramètre passé
            this.point = point;
        }

        // Méthode abstraite pour calculer le périmètre de la forme
        // Les classes dérivées (comme Cercle ou Rectangle) devront fournir leur propre implémentation de cette méthode
        abstract public double Perimetre();

        // Méthode abstraite pour calculer l'aire de la forme
        // Doit être implémentée par les classes qui héritent de 'Forme'
        abstract public double Aire();
    }
}
