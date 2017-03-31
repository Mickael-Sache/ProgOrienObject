using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP6
{
    /// <summary>
    /// Classe définissant un Salarie
    /// </summary>
    public class Salarie : Personne, IComparable<Salarie>
    {
        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Attributs         *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        private static int _nbreSalarie = 0;
        private int _matricule;
        private int _categorie;
        private int _service;
        private double _salaire;

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Acccesseurs       *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        public int Mat
        {
            get
            {
                return this._matricule;
            }
            set
            {
                _matricule = value;
            }
        }

        public int Cat
        {
            get
            {
                return this._categorie;
            }
            set
            {
                _categorie = value;
            }
        }

        public int Serv
        {
            get
            {
                return this._service;
            }
            set
            {
                _service = value;
            }
        }

        public double Sal
        {
            get
            {
                return _salaire;
            }

            set
            {
                _salaire = value;
            }
        }

        /// <summary>
        /// Fournit un compteur de salarié
        /// </summary>
        public static int Nombres
        {
            get
            {
                return _nbreSalarie;
            }
        }

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Méthodes          *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        /// <summary>
        /// Méthode permettant de calculer le Salaire avec un "nom" et un "salaire"
        /// </summary>
        public override void CalculerSalaire()
        {
            Console.WriteLine("Le salaire de " + Nom + " est de " + Sal + " euros.");
        }

        /// <summary>
        /// Méthode qui renvoie un string par-rapport a des attributs donnés
        /// </summary>
        /// <returns></returns>
        //public override string ToString()
        //{
        //    return Nom + ", a pour matricule le n° " + Mat;
        //}

        ///<summary>
        ///Méthode qui renvoie un string (pour TP N°6)
        /// </summary>
        public override string ToString()
        {
            return "Nom : " + Nom + " - Matricule : " + Mat;
        }

        /// <summary>
        /// Méthode qui renvoie un "true" si l'objet spécifié est égale à l'objet actuel sinon "false"
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Salarie s = obj as Salarie;
            if (s == null)
            {
                return false;
            }
            return Nom == s.Nom && Mat == s.Mat;

            //return obj is Salarie && Nom == ((Salarie)obj).Nom && Mat == ((Salarie)obj).Mat;
        }

        /// <summary>
        /// Méthode permettant la substitution avec la méthode Equals
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Méthode CompareTo implémenter dans Salarie
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(Salarie obj)
        {
            return Nom.CompareTo(obj.Nom);
        }



        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *         Constructeurs       *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        /// <summary>
        /// Constructeur de la classe Salarie
        /// <remarks>Ajout de la fonction de compteur pour donner un "Nombres"</remarks>
        /// <paramref name="_nbreSalarie"/>
        /// </summary>
        public Salarie()
        {
            ++_nbreSalarie;
        }

        /// <summary>
        /// Constrcuteur pour TP N°6 avec un Matricule et un Nom
        /// </summary>
        /// <param name="Mat"></param>
        /// <param name="Nom"></param>
        public Salarie(int Mat, string Nom)
        {
            _nom = Nom;
            _matricule = Mat;
        }

        /// <summary>
        /// Constructeur avec plusieurs paramètres
        /// </summary>
        /// <param name="Mat"></param>
        /// <param name="Cat"></param>
        /// <param name="Serv"></param>
        /// <param name="Nom"></param>
        /// <param name="Sal"></param>
        public Salarie(int Mat, int Cat, int Serv, string Nom, double Sal)
        {
            _matricule = Mat;
            _categorie = Cat;
            _service = Serv;
            _salaire = Sal;
            _nom = Nom;
            ++_nbreSalarie;
        }

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *         Destructeurs        *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        /// <summary>
        /// Destructeur de la classe Salarie :
        /// <remarks>Le garbage collector ne semble pas tenir compte de la valeur "null" et détruit tous sur son passage !</remarks>
        /// </summary>
        //~Salarie()
        //{
        //    _nbreSalarie--;
        //    Console.WriteLine("");
        //    Console.WriteLine("Il n'y a plus que {0}", Salarie.Nombres);
        //}

        


    }
}
