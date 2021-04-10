using System;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.adaptor
{
    class Adaptor1:IAdaptor
    {
        private DemoAdaptee1 adap = new DemoAdaptee1();
        


        // the common method - here mapped into KindOfPerson-method of DemoAdaptee1
        public string Request(string str)
        {
            return adap.KindOfPerson(str);
        }
    }
}
