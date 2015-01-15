using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassT : IInterfaceT
    {
        private IInterfaceE _ie;
        private IInterfaceX _x;

        public ClassT(IInterfaceE ie,IInterfaceX x)
        {
            _ie = ie;
            _x = x;
        }

        public void Method2()
        {
            
            _x.Method1();

            _ie.Method5();
        }
    }
}
