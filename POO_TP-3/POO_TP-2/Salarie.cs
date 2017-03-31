using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP_3
{
    /// <summary>
    /// Classe définissant un Salarie
    /// </summary>
    public class Salarie
    {
        private static int _nbreSalarie = 0;
        private int _matricule;
        private int _categorie;
        private int _service;
        private string _nom;
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

        public string Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                _nom = value;
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
        public void CalculerSalaire()
        {
            Console.WriteLine("Le salaire de " + _nom + " est de " + _salaire + " euros.");
        }

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *         Constructeurs       *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        /// <summary>
        /// Constructeur de la classe Salarie
        /// <remarks>Ajout de la fonction de compteur pour donner un "nbreSalarie" exact</remarks>
        /// </summary>
        public Salarie()
        {
            ++_nbreSalarie;
        }

        /// <summary>
        /// Constructeur avec plusieurs paramètres et un compteur
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
            _nom = Nom;
            _salaire = Sal;
            ++_nbreSalarie;
        }

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *         Destructeurs        *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/
         /// <summary>
         /// Destructeur de la classe Salarie
         /// </summary>
        ~Salarie()
        {
            _nbreSalarie--;
        }


    }
}
