using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GameFramework
{
    public class conf
    {
        public static List<int> ReadConfiguration()
        {
            List<int> test = new List<int>();
            test.Add(20);
            test.Add(20);

            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(@"C:\Users\alexa\Documents\GitHub\4 Semester\C#\Game\config.conf");

            XmlNode widthNode = configDoc.DocumentElement.SelectSingleNode("Width");
            XmlNode heightNode = configDoc.DocumentElement.SelectSingleNode("Height");
            if (widthNode != null && heightNode != null)
            {
                test.Clear();
                string gameWidthStr = widthNode.InnerText.Trim();
                string gameHeightStr = heightNode.InnerText.Trim();
                test.Add(Convert.ToInt32(gameWidthStr));
                test.Add(Convert.ToInt32(gameHeightStr));

                return test;
            }

            //Default if nothing to read
            return test;
        }
    }
}
