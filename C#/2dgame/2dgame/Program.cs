using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Xml;
using 

namespace _2dgame
{
    class Program
    {
        static void Main(string[] args)
        {


            TraceWorker worker = new TraceWorker();
            worker.Start();
            Console.ReadLine();
            //create game, parameters game size, read from XML file
            Game game = conf.ReadConfiguration();
            //start the game
            game.Start();
        }
    }
}
