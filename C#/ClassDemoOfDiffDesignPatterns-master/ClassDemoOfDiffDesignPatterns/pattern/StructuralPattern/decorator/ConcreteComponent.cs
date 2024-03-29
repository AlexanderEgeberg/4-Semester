﻿using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.decorator
{
    class ConcreteComponent : IComponent
    {
        public int Hp { get; set; }

        public ConcreteComponent(int hp)
        {
            Hp = hp;
        }
        public String DoSomething(string str)
        {
            // do nothing else but return the string

            return str;
        }
    }
}
