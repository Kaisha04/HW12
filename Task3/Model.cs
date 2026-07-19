using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Task3
{
    internal class Model
    {

        private Stopwatch stopWatch = new Stopwatch();

        public void Start() => stopWatch.Start();
        public void Stop() => stopWatch.Stop();

        public void Reset() => stopWatch.Reset();


        public TimeSpan GetTime() => stopWatch.Elapsed;
    }
}
