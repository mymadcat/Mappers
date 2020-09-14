using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ConsoleApp2
{
    public class ServiceFactory
    {
        private readonly IContainer _container;

        public ServiceFactory(IContainer container) => _container = container;

        public IPersonService GetPersonService() => _container.Resolve<IPersonService>();
    }
}
