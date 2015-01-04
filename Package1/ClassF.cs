using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    class ClassF
    {
        private ClassA _a;

        public ClassF()
        {
            _a = new ClassA();
        }

        public void Method1()
        {
            _a.Method2();
            _a.Method3();
        }

        public void Method2()
        {
            _a.Method3();
        }

        public void Method3()
        {
            _a.Method1();
        }
    }
}
