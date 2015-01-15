using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using Package1;
using Package2;
using Package3;

namespace ProjectA
{
    public class ModuleBinding : NinjectModule
    {
        public override void Load()
        {
            Bind<IInterfaceSomething>().To<ClassM>();
            Bind<IInterfaceA>().To<ClassA>();
            Bind<IInterfaceK>().To<ClassK>();
            Bind<IInterfaceT>().To<ClassT>();
            Bind<IInterfaceX>().To<ClassX>();
            Bind<IInterfaceC>().To<ClassC>();
            Bind<IInterfaceE>().To<ClassE>();
            Bind<IInterfaceJ>().To<ClassJ>();
            Bind<IInterfaceP>().To<ClassP>();
            Bind<IInterfaceQ>().To<ClassQ>();
            Bind<IInterfaceR>().To<ClassR>();
            Bind<IInterfaceS>().To<ClassS>();
            Bind<IInterfaceY>().To<ClassY>();

           

        }
    }
}
