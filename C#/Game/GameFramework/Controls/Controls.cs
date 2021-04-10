using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GameFramework
{

    public class Controls : IControls
    {
        public InputKey ReadNextEvent(List<IKey> keys)
        {
            var ok = true;
            while (ok)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                char c = info.KeyChar;
                foreach (var key in keys)
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
