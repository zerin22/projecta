using Package3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package1
{
    public class ClassA
    {
        public void Method1()
        {

        }

        public void Method2()
        {
            ClassS s = new ClassS();
            s.Method3();
            s.Method1();
        }

        public void Method3()
        {
            ClassY y = new ClassY();
            y.Method2();
        }
    }
}
