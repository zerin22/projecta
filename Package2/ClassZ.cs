using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassZ
    {
        IInterfaceJ j;
        IInterfaceQ q;
        public ClassZ(IInterfaceJ newJ, IInterfaceQ newQ)
        {
            j = newJ;
            q = newQ;
        }
        public void Method2()
        {
        
            j.Method1();
            q.Method3();
        }
    }
}
