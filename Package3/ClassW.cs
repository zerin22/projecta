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

        public ClassW(IInterfaceSomething something)
        {
            _something = something;
        }

        public int Method2()
        {
            return new ClassY().Method2();
        }

        public void Method3()
        {
            _something.Method7();
            _something.Method8();
        }
    }
}
