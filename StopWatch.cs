using System;

namespace StopWatchConsoleAPP
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isStarted = false;

        public TimeSpan Duration
        {
            get { return _startTime - _stopTime; }
        }

        public void Start()
        {
            if (!_isStarted)
            {
                _startTime = DateTime.Now;
                _isStarted = true;
            }
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
            _isStarted = false;
        }

    }
}
