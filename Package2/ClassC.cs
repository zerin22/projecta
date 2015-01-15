using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassC : IInterfaceC
    {
        internal void Method1()
        {
            
        }

        void IInterfaceC.Method1()
        {
            Method1();
        }
    }
}
