using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox.CSharp.BigONotation.Util
{
    public class Watchdog : IDisposable
    {
        private Stopwatch StopWatch;

        public Watchdog()
        {
            StopWatch = new Stopwatch();
            StopWatch.Start();
        }
        public void Dispose()
        {
            StopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"----- Elapsed time: {StopWatch.Elapsed}");
            Console.WriteLine($"---------------------------------------------------");
            Console.WriteLine();
            StopWatch.Restart();
        }
    }
}
