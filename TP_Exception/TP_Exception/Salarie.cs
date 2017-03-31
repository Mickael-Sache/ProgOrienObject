using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exception
{
    public class Salarie : Personne
    {
        /// <summary>
        /// Classe définissant un Salarie
        /// </summary>

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Attributs         *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        private static int _nbreSalarie = 0;
        private int _matricule;
        private int _categorie;
        private int _service;
        private double _salaire;

        //private string message_sal = "Le salaire doit être positif";
        //private string message_cat = "Seul les catégories 1 <Cadre>, 2 <Technicien>, 3 <Employé> sont autorisés.";

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

        /// <summary>
        /// Définit une Catégorie de Salarié
        /// <remarks>Contient une exception personnalisés si la catégorie n'est pas respecté</remarks>
        /// </summary>
        public int Cat
        {
            get
            {
                return this._categorie;
            }
            set
            {
                if (Cat != 1 || Cat != 2 || Cat != 3)
                {
                    CategorieException ce = new CategorieException(this);
                    throw ce;
                }
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

        /// <summary>
        /// Définit le Salaire d'un Salarié
        /// <remarks>Contient une exception personnalisés si le salaire est négatif</remarks>
        /// </summary>
        public double Sal
        {
            get
            {
                return _salaire;
            }

            set
            {
                if (value < 0)
                {
                    SalaireException se = new SalaireException(this);
                    throw se;
                }
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
            Console.WriteLine("");
        }

        /// <summary>
        /// Méthode qui renvoie un string par-rapport a des attributs donnés
        /// </summary>
        /// <returns></returns>
        /// 
        //public new string ToString()
        //{
        //    return "Erreur";
        //}

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

            /*Condition dans constructeur : Salaire doit être positif et Catégorie comprises entre 1 & 3*/
            //if (Sal < 0)
            //{
            //    SalaireException se = new SalaireException(this);
            //    throw se;
            //}
            //else if (Cat != 1 || Cat != 2 || Cat != 3)
            //{
            //    CategorieException se = new CategorieException(this);
            //    throw se;
            //}
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
