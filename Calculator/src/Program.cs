using Autofac;
using Autofac.Features.Indexed;
using Calculator.BootStrap;
using Calculator.Engine;
using Calculator.Engine.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var container = ConfigureContainer();
            var application = container.Resolve<Application>();

            application.Run(args); 
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>();

            var bootstrap = new CalculatorBootStrapper();
            return bootstrap.Configure(builder);
           
        }
    }
}
