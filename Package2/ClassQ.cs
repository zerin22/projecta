using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassQ : IInterfaceQ
    {
        IInterfaceJ j;
        public  ClassQ(IInterfaceJ newJ)
        {
            j = newJ;
        }
        public void Method3()
        {
           
            j.Method1();
        }
    }
}
