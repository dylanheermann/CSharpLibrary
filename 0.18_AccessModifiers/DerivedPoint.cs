using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_AccessModifiers
{
    class DerivedPoint : Point
    {
        public int DerivedPointMethod()
        {
            return this.X;
        }
    }
}
