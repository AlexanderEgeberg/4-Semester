using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace GameFramework
{
    public class TraceWorker
    {

        private TraceSource ts = new TraceSource("Name");

        public TraceWorker()
        {
            ts.Switch = new SourceSwitch("Alex","All");

            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter("TraceDemo.txt"));
            ts.Listeners.Add(fileLog);




        }

        public void Start()
        {
            ts.TraceEvent(TraceEventType.Information,333,"Detter er information");

            ts.Close();
        }
    }
}
