using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_TP6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Before TP N°6

            //Salarie unSalarie = new Salarie();
            //unSalarie.Nom = "Mike";
            //unSalarie.Sal = 2000;

            //unSalarie.CalculerSalaire();

            ///<summary>
            ///Test avec un constucteur avec paramètres multiples 
            ///</summary>
            //Salarie deSalarie = new Salarie(2, 1, 10, "Jean", 1500);
            //Salarie trSalarie = new Salarie(3, 2, 10, "Pierre", 1650);
            //Salarie quSalarie = new Salarie(4, 2, 10, "Marc", 1200);
            //Salarie cqSalarie = new Salarie(5, 1, 10, "Matthieu", 1800);
            //Salarie siSalarie = new Salarie(6, 3, 10, "Barnabé", 2200);
            //Salarie seSalarie = new Salarie(7, 3, 10, "Luc", 900);
            //Salarie huSalarie = new Salarie(8, 3, 10, "Thomas", 2800);

            //Console.WriteLine("Il y a {0} salariés dans l'entreprise.\n", Salarie.Nombres);

            //trSalarie = null;
            //quSalarie = null;

            ///<summary>
            ///Test de la Méthode ToString()
            /// </summary>
            //Salarie neSalarie = new Salarie() { Nom = "Pierre", Mat = 5 };
            //Console.WriteLine(neSalarie.ToString());
            //Console.WriteLine();

            ///<summary>
            ///Test de la Méthode Equals()
            /// </summary>
            //Console.WriteLine(deSalarie.Equals(trSalarie));
            //Console.WriteLine();

            ///<summary>
            ///Test création d'un Commercial et CalculerSalaire()
            ///</summary>
            //Commercial unCommercial = new Commercial(1, 1, 3, "Robert3", 1500, 10, 10000);
            //unCommercial.Nom = "MikeC";
            //unCommercial.Sal = 2000;

            //unCommercial.CalculerSalaire();

            //Console.WriteLine("\n");

            //Personne diSalarie = new Salarie(1, 1, 3, "Robert", 1500);
            //diSalarie.CalculerSalaire();

            //Personne onSalarie = new Commercial(1, 1, 3, "Robert3", 1500, 10, 10000);

            //onSalarie.CalculerSalaire();

            #endregion

            Salarie s1 = new Salarie(1, "Pablo");
            Salarie s2 = new Salarie(1, "Miguel");
            Salarie s3 = new Salarie(1, "Angel");
            Salarie s4 = new Salarie(1, "Javier");
            Salarie s5 = new Salarie(1, "Enrico");

            //Référence des Salariés dans un tableau //

            Salarie[] tabSalarie = new Salarie[5];
            tabSalarie[0] = s1;
            tabSalarie[1] = s2;
            tabSalarie[2] = s3;
            tabSalarie[3] = s4;
            tabSalarie[4] = s5;

            //Affichage des Salariés conteny dans le tableau "tabSalarie"            

            foreach (Salarie item in tabSalarie)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Référence des Salariés dans une List

            List<Salarie> listSal = new List<Salarie>();
            listSal.Add(s1);
            listSal.Add(s2);
            listSal.Add(s3);
            listSal.Add(s4);
            listSal.Add(s5);

            //Affichage des Salariés de la List "listSal"

            foreach (Salarie item in listSal)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Référence des Salariés dans un Dictionnary --Un doute sur le sorted dictionnary à voir .. --

            SortedDictionary<int, Salarie> dicoSal = new SortedDictionary<int, Salarie>();
            dicoSal.Add(1, s1);
            dicoSal.Add(2, s2);
            dicoSal.Add(3, s3);
            dicoSal.Add(4, s4);
            dicoSal.Add(5, s5);

            //Affichage des élements contenus dans le dictionnaire

            foreach (KeyValuePair<int, Salarie> element in dicoSal)
            {
                int mat = element.Key;
                var sal = element.Value;

                Console.WriteLine("{0}", sal);
            }

            Console.WriteLine();

            //Suppression d'élements dans le dictionnaire

            dicoSal.Remove(4);
            dicoSal.Remove(2);

            foreach (KeyValuePair<int, Salarie> element in dicoSal)
            {
                int mat = element.Key;
                var sal = element.Value;

                Console.WriteLine("{0}", sal);
            }

            Console.WriteLine();

            //Suppression total du dictionnaire

            dicoSal.Clear();

            foreach (KeyValuePair<int, Salarie> element in dicoSal)
            {
                int mat = element.Key;
                var sal = element.Value;

                Console.WriteLine("{0}", sal);
            }
        }
    }
}
