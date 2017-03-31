using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            Personne unePersonne = new Salarie(1, 1, 1, "Jean", 1000);
            unePersonne.CalculerSalaire();


            try
            {
                Salarie s = new Salarie(1, 1, 1, "Jeanne", -100);
                s.Cat = 4;
                //s.Sal = -100;
            }
            catch (SalarieException ex)
            {

                Console.WriteLine(ex);
                //Console.WriteLine(ex.ToString());
            }



        }
    }
}
