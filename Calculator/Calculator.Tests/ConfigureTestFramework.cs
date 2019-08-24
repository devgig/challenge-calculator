using Autofac;
using Calculator.BootStrap;
using Calculator.Engine;
using System.Reflection;
using Xunit;
using Xunit.Abstractions;
using Xunit.Ioc.Autofac;
using Xunit.Sdk;

[assembly: TestFramework("Calculator.Tests.ConfigureTestFramework", "Calculator.Tests")]

namespace Calculator.Tests
{
    public class ConfigureTestFramework : AutofacTestFramework
    {
        private const string TestSuffixConvention = "Tests";
        public ConfigureTestFramework(IMessageSink diagnosticMessageSink) : base(diagnosticMessageSink)
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
               .Where(t => t.Name.EndsWith(TestSuffixConvention));

            builder.Register(context => new TestOutputHelper())
                .AsSelf()
                .As<ITestOutputHelper>()
                .InstancePerLifetimeScope();


            var bootstrap = new CalculatorBootStrapper();
            Container = bootstrap.Configure(builder);

           
        }
    }
}
