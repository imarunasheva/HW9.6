using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW9._6._2
{
    class MyException : Exception
    {
        public MyException(string message) : base(message) { }
    }
}
