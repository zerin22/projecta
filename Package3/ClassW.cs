using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package3
{
    public class ClassW
    {
        private IInterfaceSomething _something;
        private IInterfaceY _y;

        public ClassW(IInterfaceSomething something, IInterfaceY newy)
        {
            _something = something;
            _y = newy;
        }

        public int Method2()
        {
            return _y.Method2();
        }

        public void Method3()
        {
            _something.Method7();
            _something.Method8();
        }
    }
}
