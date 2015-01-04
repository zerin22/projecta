using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassL
    {
        private IInterfaceP _ip;

        public ClassL(IInterfaceP ip)
        {
            _ip = ip;
        }

        public void Method1()
        {
            _ip.Method10();
        }
    }
}
