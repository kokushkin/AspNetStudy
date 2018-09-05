using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAspNet45.Modules;
using TestAspNet45.Modules.Repository;
using TestAspNet45.Presenters;

namespace TestAspNet45.App_Start
{
    public static class DIConfiguration
    {
        public static void SetupDI(IKernel kernel)
        {
            kernel.Bind<IPresenter<GuestResponse>>().To<RSVPPresenter>();
            kernel.Bind<IRepository>().To<MemoryRepository>().InSingletonScope();
        }
    }
}