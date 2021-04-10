using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator
{
    interface IComponent
    {
        public int Hp { get; set; }
        String DoSomething(String str);
    }
}
