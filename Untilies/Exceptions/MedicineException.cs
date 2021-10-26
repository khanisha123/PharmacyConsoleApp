using System;
using System.Collections.Generic;
using System.Text;

namespace Untilies.Exceptions
{
    public class MedicineException : Exception
    {
        public MedicineException(string message) : base(message) 
        {

        }
    }
}
