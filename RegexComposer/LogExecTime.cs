using System;
using System.Diagnostics;

namespace RegexComposer
{
    internal class LogExecTime
    {
        private readonly string _name;
        private readonly Stopwatch _watch;

        public LogExecTime(string Name)
        {
            _name = Name;
            _watch = new Stopwatch();
        }

        public LogExecTime Start()
        {
            _watch.Start();
            return this;
        }

        public LogExecTime Retart()
        {
            _watch.Start();
            return this;
        }

        public void Stop()
        {
            _watch.Stop();
            Console.WriteLine(string.Format("{0}: {1}ms", _name, _watch.ElapsedMilliseconds));
        }
    }
}