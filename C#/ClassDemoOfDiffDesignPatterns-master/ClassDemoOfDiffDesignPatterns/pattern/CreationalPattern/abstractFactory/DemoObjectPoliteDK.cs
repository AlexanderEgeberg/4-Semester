using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class DemoObjectPoliteDK : IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Kære {name}");
        }
    }
}
