using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassV 
    {
        IInterfaceC c;
        public ClassV(IInterfaceC newC)
        {
            c = newC;

        }
        public void Method2()
        {
            
            c.Method1();
        }
    }
}
