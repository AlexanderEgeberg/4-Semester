namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.adaptor
{
    class Adaptor2:IAdaptor
    {
        private DemoAdaptee2 adap = new DemoAdaptee2();

        // the common method - here mapped into Upper-method
        public string Request(string str)
        {
            return adap.Upper(str);
        }
    }
}
