namespace ClassDemoOfDiffDesignPatterns.pattern.CreationalPattern.abstractFactory
{
    interface IFactory
    {
        IDemoObject GetClass(FactoryType typeOfClass);
    }
}
