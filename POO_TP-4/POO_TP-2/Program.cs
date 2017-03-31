using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie unSalarie = new Salarie();
            unSalarie.Nom = "Mike";
            unSalarie.Sal = 2000;

            unSalarie.CalculerSalaire();

            ///<summary>
            ///Test avec un constucteur avec paramètres multiples 
            ///</summary>
            Salarie deSalarie = new Salarie(2, 1, 10, "Jean", 1500);
            Salarie trSalarie = new Salarie(3, 2, 10, "Pierre", 1650);
            Salarie quSalarie = new Salarie(4, 2, 10, "Marc", 1200);
            Salarie cqSalarie = new Salarie(5, 1, 10, "Matthieu", 1800);
            Salarie siSalarie = new Salarie(6, 3, 10, "Barnabé", 2200);
            Salarie seSalarie = new Salarie(7, 3, 10, "Luc", 900);
            Salarie huSalarie = new Salarie(8, 3, 10, "Thomas", 2800);

            Console.WriteLine("Il y a {0} salariés dans l'entreprise.\n", Salarie.Nombres);

            //trSalarie = null;
            //quSalarie = null;

            ///<summary>
            ///Test de la Méthode ToString()
            /// </summary>
            Salarie neSalarie = new Salarie() { Nom = "Pierre", Mat = 5 };
            Console.WriteLine(neSalarie.ToString());
            Console.WriteLine();

            ///<summary>
            ///Test de la Méthode Equals()
            /// </summary>
            Console.WriteLine(deSalarie.Equals(trSalarie));
            Console.WriteLine();

            ///<summary>
            ///Test création d'un Commercial et CalculerSalaire()
            ///</summary>
            Commercial unCommercial = new Commercial(1000, 10);
            unCommercial.Nom = "MikeC";
            unCommercial.Sal = 2000;

            unCommercial.CalculerSalaire();

        }
    }
}
