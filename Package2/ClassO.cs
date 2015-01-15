using Package1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package2
{
    public class ClassO 
    {
        IInterfaceT t;
        public ClassO(IInterfaceT newT)
        {
            t = newT;
        }
        public void Method2()
        {
           
            t.Method2();
			
			//test comment
			
        }
    }
}
