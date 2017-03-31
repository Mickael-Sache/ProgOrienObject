using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exception
{
    class CategorieException : SalarieException
    {
        public CategorieException(Salarie Cat) : base (Cat.ToString()) 
        {

        }

        public override string ToString()
        {
            return "Seul les catégories 1 <Cadre> - 2 <Technicien> - 3 <Employé> sont autorisés.";
        }
    }
}
