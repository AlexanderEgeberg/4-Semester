using System.Collections.Generic;

namespace ClassDemoOfDiffDesignPatterns.pattern.StructuralPattern.proxy
{
    class ProxyClass:IDemoProxy
    {
        private IDemoProxy _real;
        private string _courseName;

        public ProxyClass(string courseName)
        {
            _real = new RealProxy();
            _courseName = courseName;
        }


        public void InsertString(string str)
        {
            _real.InsertString($"{str} teach in {_courseName}");
        }

        public List<string> GetAll()
        {
            return _real.GetAll();
        }
    }
}
