namespace Csharpnoe
{
    public class Point
    {
        // Champs privés pour l'encapsulation (meilleure pratique)
        private int _x;
        private int _y;

        // Propriétés publiques pour permettre un contrôle d'accès sécurisé aux champs
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        // Constructeur par défaut accessible publiquement
        public Point() { }

        // Constructeur avec paramètres
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Surcharge de la méthode Equals
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Point)) return false;
            Point point = (Point)obj;
            return _x == point.X && _y == point.Y;
        }

        // Surcharge de la méthode ToString pour une représentation textuelle
        public override string ToString()
        {
            return $"({_x},{_y})";
        }

        // Implémentation de GetHashCode pour cohérence avec Equals
        public override int GetHashCode()
        {
            return _x.GetHashCode() ^ _y.GetHashCode();
        }
    }
}