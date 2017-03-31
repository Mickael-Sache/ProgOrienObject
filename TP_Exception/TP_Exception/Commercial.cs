﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exception
{
    /// <summary>
    /// Classe définissant un Commercial
    /// </summary>
    public class Commercial : Salarie
    {
        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Attributs         *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        private double _chiffreAffaire;
        private int _commission;

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Acccesseurs       *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        public double ChiffreAffaire
        {
            get
            {
                return this._chiffreAffaire;
            }
            set
            {
                _chiffreAffaire = value;
            }
        }

        public int Comm
        {
            get
            {
                return this._commission;
            }
            set
            {
                _commission = value;
            }
        }

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Méthodes          *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/
         /// <summary>
         /// Méthode définissant un Calcul de Salaire avec ajout du calcul de la commission
         /// </summary>
         /// <param>CA, ChiffreAffaire, Comm</param>
        public override void CalculerSalaire()
        {
            Console.WriteLine("¯¯¯¯¯¯¯¯Commercial¯¯¯¯¯¯¯¯");
            Console.WriteLine();
            base.CalculerSalaire();
            Console.WriteLine("Son chiffre d'affaire est de " + ChiffreAffaire + " euros.");
            double CA = (Comm * ChiffreAffaire) / 100;
            Console.WriteLine("Sa commision est de " + CA);
            Console.WriteLine("Son salaire réel est de " + (CA + Sal));
        }


        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *         Constructeurs       *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/
         /// <summary>
         /// Constructeur Commercial de base
         /// </summary>
        public Commercial()
        {

        }

        /// <summary>
        /// Constructeur Commercial avec paramètres associés qui sont le Chiffre d'affaire et le pourcentage de Commission
        /// </summary>
        /// <remarks>Ne pas oublier de mettre :base avec le constructeur de référence et ajouter les paramètres supplémentaires</remarks>
        /// <param name="ChiffreAffaire"></param>
        /// <param name="Comm"></param>
        public Commercial(int Mat, int Cat, int Serv, string Nom, double Sal, int Comm, double ChiffreAffaire) :base( Mat,  Cat,  Serv,  Nom,  Sal)
        {
            _commission = Comm;
            _chiffreAffaire = ChiffreAffaire;

        }

        


    }
}
