using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject.Extensions.Conventions;

namespace WebApi.App_Start
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x => x.FromAssembliesMatching("WebApi.*")
                .SelectAllClasses()
                .BindAllInterfaces()
                );
        }
    }
}