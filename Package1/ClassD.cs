using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassD
    {
        private ClassA _a;

        public ClassD(ClassA a)
        {
            _a = a;
        }

        public void Method1()
        {
            _a.Method3();
        }
    }
}
