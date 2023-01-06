using System.ComponentModel;
using SimpleInjector;

namespace InversionOfControlDemoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the IoC container
            var container = new SimpleInjector.Container();

            // Register the dependencies
            container.Register<IHelloService, HelloService>();
            
            // Resolve the controller and run it
            HelloController controller = container.Resolve<HelloController>();
            controller.Run();
        }
    }

    public interface IHelloService
    {
        void SayHello();
    }

    public class HelloService : IHelloService
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }

    public class HelloController
    {
        private readonly IHelloService _helloService;

        public HelloController(IHelloService helloService)
        {
            _helloService = helloService;
        }

        public void Run()
        {
            _helloService.SayHello();
        }
    }
}