using Autofac;
using Calculator.Engine;
using Calculator.Engine.Results;
using System;
using System.Linq;
using System.Reflection;

namespace Calculator.BootStrap
{
    public class CalculatorBootStrapper
    {
           
        public IContainer Configure(ContainerBuilder builder)
        {
            builder.RegisterType<CalculationProvider>().As<ICalculationProvider>();
            builder.RegisterType<InputParser>().As<IInputParser>();

            builder.RegisterAssemblyTypes(Assembly.GetAssembly(typeof(ICalculationStrategy)))
                   .Where(t => typeof(ICalculationStrategy).IsAssignableFrom(t))
                   .AsSelf();

            builder.Register<Func<CalculationType, ICalculationStrategy>>(c =>
            {

                var types = c.ComponentRegistry.Registrations
                 .Where(r => typeof(ICalculationStrategy).IsAssignableFrom(r.Activator.LimitType))
                 .Select(r => r.Activator.LimitType);

                ICalculationStrategy[] lst = types.Select(t => c.Resolve(t) as ICalculationStrategy).ToArray();

                return (someEnum) =>
                {
                    return lst.FirstOrDefault(x => x.CanProcess(someEnum));
                };
            });


            return builder.Build();
        }
    }
}
