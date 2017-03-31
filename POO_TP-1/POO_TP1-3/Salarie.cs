using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP1_3
{
    public class Salarie
    {

        public int matricule;
        public int categorie;
        public int service;
        public string nom;
        public double salaire;

        /// <summary>
        /// Méthode pour calculer le salaire avec un "nom" et un "salaire"
        /// </summary>
        public void CalculerSalaire()
        {
            Console.WriteLine("Le salaire de " + nom + " est de " + salaire + " euros.");
        }

        /// <summary>
        /// Constructeur vide de la classe Salarié
        /// </summary>
        public Salarie()
        {

        }
    }
}
