using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP_2
{
    /// <summary>
    /// Classe définissant un Salarie
    /// </summary>
    public class Salarie
    {
        private int matricule;
        private int categorie;
        private int service;
        private string nom;
        private double salaire;

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Acccesseurs       *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        public int Mat
        {
            get
            {
                return this.matricule;
            }
            set
            {
                this.matricule = value;
            }
        }

        public int Cat
        {
            get
            {
                return this.categorie;
            }
            set
            {
                this.categorie = value;
            }
        }

        public int Serv
        {
            get
            {
                return this.service;
            }
            set
            {
                this.service = value;
            }
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public double Sal
        {
            get
            {
                return this.salaire;
            }
            set
            {
                this.salaire = value;
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
            Console.WriteLine("Le salaire de " + nom + " est de " + salaire + " euros.");
        }


        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Constructeurs     *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        /// <summary>
        /// Constructeur de la classe Salarie
        /// </summary>
        public Salarie()
        {

        }
    }
}
