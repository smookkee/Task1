using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalc.Exception
{
    public class ShapeException : ArgumentOutOfRangeException
    {
        public ShapeException()
            :base("Value must be greater than zero")
        {}

        public ShapeException(string message)
           : base(message)
        {}
    }
}
