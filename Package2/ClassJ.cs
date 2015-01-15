using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassJ : IInterfaceJ
    {
        IInterfaceK k;
        public ClassJ(IInterfaceK newK)
        {
            k = newK;

        }
        public void Method1()
        {
           
            k.Method1();
        }
    }
}
