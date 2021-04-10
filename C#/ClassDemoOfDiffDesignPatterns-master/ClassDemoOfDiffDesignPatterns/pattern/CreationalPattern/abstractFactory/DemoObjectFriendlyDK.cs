using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    class DemoObjectFriendlyDK : IDemoObject
    {
        public void Print(string name)
        {
            Console.WriteLine($"Hej {name}");
        }
    }
}
