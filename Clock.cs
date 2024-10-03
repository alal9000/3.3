using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Clock
    {
        // fields
        private Counter _seconds;
        private Counter _minutes;
        private Counter _hours;

        // constructor
        public Clock(string name)
        {
            Seconds = new Counter(name + " seconds");
            Minutes = new Counter(name + " minutes");
            Hours = new Counter(name + " hours");
        }

        // properties
        public Counter Seconds { get => _seconds; set => _seconds = value; }
        public Counter Minutes { get => _minutes; set => _minutes = value; }
        public Counter Hours { get => _hours; set => _hours = value; }

        // methods
        public void Tick()
        {
            Seconds.Increment();

            if (Seconds.Ticks == 60)
            {
                Seconds.Reset();
                Minutes.Increment();
            }

            if (Minutes.Ticks == 60)
            {
                Minutes.Reset();
                Hours.Increment();
            }

            if (Hours.Ticks == 24)
            {
                this.Reset();
            }
        }

        public void Reset()
        {
            Seconds.Reset();
            Minutes.Reset();
            Hours.Reset();
        }

        public string GetCurrentTime()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", 
                Hours.Ticks, 
                Minutes.Ticks, 
                Seconds.Ticks
            );          
        }


    }
}
