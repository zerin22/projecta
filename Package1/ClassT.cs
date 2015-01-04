using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassT
    {
        private IInterfaceE _ie;

        public ClassT(IInterfaceE ie)
        {
            _ie = ie;
        }

        public void Method2()
        {
            ClassX x = new ClassX();
            x.Method1();

            _ie.Method5();
        }
    }
}
