using System;
using System.Reflection.Metadata;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator
{
    class Decorator1:IComponent
    {
        // reference to the object to decorate / wrap 


        public int Hp { get; set; }
        private IComponent _component;
        
        public Decorator1(IComponent component, int hp)
        {
            _component = component;
            Hp = hp + component.Hp;
        }


        public string DoSomething(string str)
        {
            return " blabla " + _component.DoSomething(str);
        }
    }
}
