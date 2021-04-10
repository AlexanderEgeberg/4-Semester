using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace GameFramework
{
    public class conf
    {
        public static Game ReadConfiguration()
        {
            XmlDocument configDoc = new XmlDocument();
            configDoc.Load(@"C:\Users\alexa\Documents\GitHub\4 Semester\C#\2dgame\game.conf");

            XmlNode widthNode = configDoc.DocumentElement.SelectSingleNode("Width");
            XmlNode heightNode = configDoc.DocumentElement.SelectSingleNode("Height");
            if (widthNode != null && heightNode != null)
            {
                string gameWidthStr = widthNode.InnerText.Trim();
                string gameHeightStr = heightNode.InnerText.Trim();
                int gameWidth = Convert.ToInt32(gameWidthStr);
                int gameHeight = Convert.ToInt32(gameHeightStr);

                return new Game(gameWidth, gameHeight);
            }

            //Default if nothing to read
            return new Game(20, 20);
        }
    }
}
