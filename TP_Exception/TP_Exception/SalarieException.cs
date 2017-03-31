using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Exception
{
    public class SalarieException : Exception
    {
        /// <summary>
        /// Constructeur de base
        /// </summary>
        public SalarieException()
        {

        }

        /// <summary>
        /// Constructeur Globale d'exceptions personnalisées
        /// </summary>
        /// <param name="message"></param>
        public SalarieException(string message) : base(message)
        {

        }

    }

    
}
