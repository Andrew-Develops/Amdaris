namespace DecoratorPatternDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA("added state");
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            Console.WriteLine(d2.Operation());
            Console.WriteLine(d2.AddedBehavior());

            // Wait for user
            Console.ReadKey();
        }
    }


    // The 'Component' abstract class
    public abstract class Component
    {
        public abstract string Operation();
    }

    // The 'ConcreteComponent' class
    public class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }

    // The 'Decorator' abstract class
    public abstract class Decorator : Component
    {
        protected Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override string Operation()
        {
            if (_component != null)
            {
                return _component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    // The 'ConcreteDecoratorA' class
    public class ConcreteDecoratorA : Decorator
    {
        private string _addedState;

        public ConcreteDecoratorA(string addedState)
        {
            _addedState = addedState;
        }

        public override string Operation()
        {
            return string.Format("ConcreteDecoratorA({0})", _addedState) + " " + base.Operation();
        }
    }

    // The 'ConcreteDecoratorB' class
    public class ConcreteDecoratorB : Decorator
    {
        public override string Operation()
        {
            return "ConcreteDecoratorB " + base.Operation();
        }

        public string AddedBehavior()
        {
            return "ConcreteDecoratorB added behavior.";
        }
    }

}