using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameFramework
{

    public class Controls : IControls
    {
        private List<IKey> _keys;

        public Controls(List<IKey> keys)
        {
            _keys = keys;
        }
        public InputKey ReadNextEvent()
        {
            var ok = true;
            while (ok)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                char c = info.KeyChar;
                foreach (var key in _keys)
                {
                    if (key.CheckKey(c))
                    {
                        ok = false;
                        return key.ReturnKey();
                    }
                }
            }
            return InputKey.NONE;
        }
    }
}
