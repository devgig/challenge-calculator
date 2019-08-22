using Autofac;
using Calculator.Engine;

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
            builder.RegisterType<CalculationProvider>().As<ICalculationProvider>();
            builder.RegisterType<InputParser>().As<IInputParser>();

            return builder.Build();
        }
    }
}
