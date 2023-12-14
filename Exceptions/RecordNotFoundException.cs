using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string messaage) : base(messaage)
        {




        }


    }
}
