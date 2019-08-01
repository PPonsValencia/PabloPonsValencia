using Application.Interfaces;
using Application.Services;
using Autofac;
using Domain.Interfaces;
using Domain.Services;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transversal.Logger;

namespace WebService
{
    public static class DependencyInjector
    {
        private static IContainer _container;

        static DependencyInjector()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<RebelTrack>().As<IRebelTrack>();
            builder.RegisterType<LoggerLog4Net>().As<ILogger>();
            builder.RegisterType<RebelSightingRepositoryFile>().As<IRebelSightingRepository>();
            builder.RegisterType<FilterRebels>().As<IFilterRebels>();
            _container = builder.Build();
        }

        public static T DependencyInjectorResolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}