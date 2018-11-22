using System;
using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using BLL.ServiceImplementation;
using DAL.Fake;
using DAL.Interface.Interfaces;
using DAL.Repositories;
using Ninject.Modules;
using Ninject;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IAccountService>().To<AccoutServices>();
            //kernel.Bind<IRepository>().To<FakeRepository>();
            kernel.Bind<IFileWorker>().To<FileWorker>().WithConstructorArgument("C:/Users/Shumilin/Documents/Visual Studio 2017/Projects/NET.W.2018.Shumilin.8/file2.txt");
            //kernel.Bind<IAccountNumberCreateService>().To<AccountNumberCreator>().InSingletonScope();
            //kernel.Bind<IApplicationSettings>().To<ApplicationSettings>();
        }
    }
}
