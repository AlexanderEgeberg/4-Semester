using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Channels;
using System.Xml.Schema;
using ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.observer;
using ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.state;
using ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.strategy;
using ClassDemoOfDiffDesignPatterns.pattern.BehavioralPattern.template;
using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory;
using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory;
using ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.singleton;
using ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.adaptor;
using ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.composite;
using ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator;
using ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.facade;
using ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.proxy;
using FactoryType = ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory.FactoryType;
using IComponent = ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator.IComponent;
using IDemoObject = ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.factory.IDemoObject;

namespace ClassDemoOfDiffDesignPatterns
{
    class PatternWorker
    {
        public void Start()
        {

            //DemoSingleton();
           // DemoFactoryMethod();
//            DemoAbstractFactory();


         //   DemoAdaptor();
            //DemoFacade();
            //DemoProxy();
            DemoDecorator();
         //   DemoComposite();


            //DemoObserver();
            ////DemoTemplate();
            //DemoStrategy();
            //DemoState();
            
        }

        private void DemoSingleton()
        {
            /*
            NoteCatalogue c1 = new NoteCatalogue();
            c1.Add("New note");
            Console.WriteLine(c1);

            NoteCatalogue c2 = new NoteCatalogue();
            c2.Add("yet another note");
            Console.WriteLine(c2);
           */

            NoteCatalogue c1 = NoteCatalogue.Instance;
            c1.Add("New note");
            Console.WriteLine(c1);

            NoteCatalogue c2 =  NoteCatalogue.Instance;
            c2.Add("yet another note");
            Console.WriteLine(c2);

        }

        private void DemoFactoryMethod()
        {
            IDemoObject obj = DemoFactory.GetClass(FactoryType.Polite);
            obj.Print("Peter");

            IDemoObject obj2 = DemoFactory.GetClass(FactoryType.Friendly);
            obj2.Print("Peter");

        }

        private void DemoAbstractFactory()
        {
            IFactory factory = AbstractFactory.GetFactory(AbstractFactoryType.Uk);
            pattern.CreationalPattern.abstractFactory.IDemoObject obj = factory.GetClass(pattern.CreationalPattern.abstractFactory.FactoryType.Polite);
            obj.Print("Peter");

            IFactory factory2 = AbstractFactory.GetFactory(AbstractFactoryType.Dk);
            pattern.CreationalPattern.abstractFactory.IDemoObject obj2 = factory2.GetClass(pattern.CreationalPattern.abstractFactory.FactoryType.Friendly);
            obj2.Print("Peter");

        }

        private void DemoAdaptor()
        {
            IAdaptor adap = new Adaptor1();
            string newstr = adap.Request("anders");
            Console.WriteLine(newstr);

            IAdaptor adap2 = new Adaptor2();
            string newstr2 = adap2.Request("anders");
            Console.WriteLine(newstr2);

        }

        private void DemoFacade()
        {
            Facade facade = new Facade();

            facade.InsertNote("Remember to Shop on the way home");
            facade.NewShopItem("Milk");

            Console.WriteLine("My shoping list \n" + string.Join("\n", facade.GetShoppingList()));


        }

        private void DemoProxy()
        {
            IDemoProxy proxy = new RealProxy();

            proxy.InsertString("Peter");
            proxy.InsertString("Anders");
            proxy.InsertString("Vibeke");
            proxy.InsertString("Michael C");

            foreach (string s in proxy.GetAll())
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("    AFTER PROXY ");
            IDemoProxy proxy2 = new ProxyClass("SWC");

            proxy2.InsertString("Peter");
            proxy2.InsertString("Anders");
            
            foreach (string s in proxy2.GetAll())
            {
                Console.WriteLine(s);
            }

        }

        private void DemoDecorator()
        {
            // Concrete
            IComponent component = new ConcreteComponent(5);
            Console.WriteLine(component.DoSomething("peter"));

            IComponent comp2 = new Decorator1(component,5);

            Console.WriteLine(comp2.Hp);
            Console.WriteLine(comp2.DoSomething("peter"));

            IComponent comp3 = new Decorator1(comp2,6);
            Console.WriteLine(comp3.DoSomething("peter"));

        }


        private void DemoComposite()
        {
            // some leafs 
            LeafBox b1 = new LeafBox(100);

            Composite comp1 = new Composite();
            comp1.Add(b1);
            comp1.Add(new LeafBox(50));

            Composite comp2 = new Composite();
            comp2.Add(b1);
            comp2.Add(comp1);

            Console.WriteLine(comp2.TotalWeight());


        }

        private void DemoObserver()
        {
            // I am observer
            ObservableObject obj = new ObservableObject(3, "text");
            obj.Text = "Peter"; // nothing happen


            // attach to be observer
            obj.PropertyChanged += (s, args) =>
            {
                Console.WriteLine($"Anonym metode :the changed property is {args.PropertyName}");
                Console.WriteLine($"New values is \n{s}");
            };

            // alternative
            obj.PropertyChanged += Update;

            obj.Text = "Anders";

            obj.PropertyChanged -= Update;

            obj.Text = "Vibeke";


        }

        /*
         * Help to Observer
         */
        protected void Update(object obj, PropertyChangedEventArgs args)
        {
            Console.WriteLine($" Egentlig metode : the changed property is {args.PropertyName}");
            Console.WriteLine($"New values is \n{obj}");
        }



        private void DemoTemplate()
        {
            List<String> data = new List<string>()
            {
                "Peter",
                "Anders",
                "Vibeke",
                "Michael C"
            };

            AbstractTemplateClass temp = new MySubTemplate();
            temp.InsertTemplateMethod(data);

            Console.WriteLine(temp);

        }

        private void DemoStrategy()
        {
            List<String> data = new List<string>()
            {
                "Peter",
                "Anders",
                "Vibeke",
                "Michael C"
            };

            ContextClass context = new ContextClass();
            context.InsertStrategyMethod(data, new ConcreteStrategy());
            Console.WriteLine(context);


            ContextClassMoreCSharpLike context2 = new ContextClassMoreCSharpLike();
            context2.StrategyMethod = (s) => { return s.Substring(1); };
            context2.InsertStrategyMethod(data);
            Console.WriteLine(context2);

        }

        private void DemoState()
        {
            // low tax
            IState calc = new DemoStateLow();
            int price = calc.HandleCalculate(10000);
            Console.WriteLine($"Price with low tax is {price}");

            // high tax
            calc = new DemoStateHigh();
            price = calc.HandleCalculate(10000);
            Console.WriteLine($"Price with high tax is {price}");
        }
    }
}