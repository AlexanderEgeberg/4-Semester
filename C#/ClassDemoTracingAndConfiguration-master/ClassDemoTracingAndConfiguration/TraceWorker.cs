using System.Diagnostics;
using System.IO;

namespace ClassDemoTracingAndConfiguration
{
    public class TraceWorker
    {
        private TraceSource ts = new TraceSource("Peters Demo");
        public TraceWorker()
        {
            ts.Switch = new SourceSwitch("Peter","All");

            TraceListener consoleLog = new ConsoleTraceListener();
            ts.Listeners.Add(consoleLog);

            TraceListener fileLog = new TextWriterTraceListener( new StreamWriter("TraceDemo.txt"));
            ts.Listeners.Add(fileLog);
            //fileLog.Filter = new EventTypeFilter(SourceLevels.Error);

            TraceListener eventLog = new EventLogTraceListener("Application");
            //ts.Listeners.Add(eventLog);
            eventLog.Filter = new EventTypeFilter(SourceLevels.Error);
        }

        public void Start()
        {
            ts.TraceEvent(TraceEventType.Information, 333, "dette er information");
            ts.TraceEvent(TraceEventType.Warning, 333, "dette er warning");
            ts.TraceEvent(TraceEventType.Error, 333, "dette er error");
            ts.TraceEvent(TraceEventType.Critical, 333, "dette er critical");
            

            ts.Close();
        }
    }
}