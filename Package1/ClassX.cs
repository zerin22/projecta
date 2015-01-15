using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassX : IInterfaceX
    {
        IInterfaceR r;
        public ClassX(IInterfaceR newR)
        {
          r = newR;
        }

        public void Method1()
        {

            r.Method1();
        }
    }
}
