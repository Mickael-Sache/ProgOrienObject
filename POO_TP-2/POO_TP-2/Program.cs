using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Salarie unSalarie = new Salarie();
            unSalarie.Nom = "Mike";
            unSalarie.Sal = 2000;

            unSalarie.CalculerSalaire();


        }
    }
}
