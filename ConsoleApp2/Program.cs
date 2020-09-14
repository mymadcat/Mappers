using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using AutoMapper;
using ConsoleApp2.AutoMaper;

namespace ConsoleApp2
{
    class Program
    {
        private static ServiceFactory _factory;
        static void Main(string[] args)
        {
            //registration and init example
            var builder = new ContainerBuilder();
            builder.RegisterModule(new AutoMapperModule(Assembly.GetExecutingAssembly()));
            builder.RegisterType<PersonService>().As<IPersonService>().InstancePerDependency();
            var container = builder.Build();
            _factory = new ServiceFactory(container);

            //execution example
            var testDto = _factory.GetPersonService().GetDto();
        }
    }
}
