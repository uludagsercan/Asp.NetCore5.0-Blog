using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Abstract;

namespace BusinessLayer.DependencyResolvers
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {


            builder.RegisterType<WriterManager>().As<IWriterService>().SingleInstance();
            builder.RegisterType<EfWriterDal>().As<IWriterDal>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
