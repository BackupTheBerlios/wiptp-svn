using System;
using System.Collections.Generic;
using System.Text;

namespace TerminplanungTechnischerPrototyp.Calculation
{
    class Time
    {
        private byte _hour;
        private byte _minute;

        public byte Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }
        public byte Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }

        public Time(byte hour, byte minute)
        {
            _hour = hour;
            _minute = minute;
        }
    }
}
