using System;
using System.Xml;

namespace ClassDemoTracingAndConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadConfiguration();

            TraceWorker worker = new TraceWorker();
            worker.Start();
        }

        private static void ReadConfiguration()
        {
            XmlDocument configDoc = new XmlDocument(); 
            configDoc.Load(@"M:\uv\2021f-AvanceretCsharp\prog\Data\ServerConfiguration.conf");

            XmlNode portNode = configDoc.DocumentElement.SelectSingleNode("Port"); 
            if (portNode != null) { 
                String portStr = portNode.InnerText.Trim(); 
                int serverPort = Convert.ToInt32(portStr);


                Console.WriteLine("Server port er " + serverPort);
            }

            XmlNode nameNode = configDoc.DocumentElement.SelectSingleNode("Name");
            if (nameNode != null)
            {
                String nameStr = nameNode.InnerText.Trim();
                
            Console.WriteLine("Server name er " + nameStr);
            }
        }
    }
}
