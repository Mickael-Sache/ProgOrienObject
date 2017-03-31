using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie unSalarie = new Salarie();
            unSalarie.nom = "Mike";
            unSalarie.salaire = 2000;

            unSalarie.CalculerSalaire();



        }

    }
}
