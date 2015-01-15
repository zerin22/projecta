using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassH 
    {
        IInterfaceG g;
        public ClassH(IInterfaceG newG)
        {
            g = newG;
        }
        public void Method2()
        {
            
            g.Method1();
        }
    }
}
