using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exception
{
    public abstract class Personne
    {
        protected string _nom;

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
        *           Acccesseurs        *
        *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        public virtual string Nom
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

        /*¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*
         *           Méthodes          *
         *¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯*/

        public virtual void CalculerSalaire()
        {
            Console.WriteLine("Pas de salaire");
        }

    }
}
