using DbzGraphQl.IoC;
using DbzGraphQl.Types;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DbzGraphQl.Api
{
    public class Bootstrapper
    {
        public System.Web.Http.Dependencies.IDependencyResolver Resolver()
        {
            var container = BuildContainer();
            var resolver = new SimpleContainerDependencyResolver(container);
            return resolver;
        }

        private ISimpleContainer BuildContainer()
        {
            var container = new SimpleContainer();
            container.Singleton<IDocumentExecuter>(new DocumentExecuter());
            container.Singleton<IDocumentWriter>(new DocumentWriter(true));

            container.Singleton(new DbzData());
            container.Register<DbzQuery>();
            container.Register<SaiyajinType>();
            container.Register<EarthmanType>();
            container.Register<CharacterInterface>();
            container.Singleton(new DbzSchema(type => (GraphType) container.Get(type)));

            return container;
        }
    }
}