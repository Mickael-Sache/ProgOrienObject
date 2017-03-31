using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exception
{
    class SalaireException : SalarieException
    {
        public SalaireException(Salarie Sal) : base(Sal.ToString())
        {

        }

        public override string ToString()
        {
            return "Le salaire doit être positif ..";
        }
    }
}
