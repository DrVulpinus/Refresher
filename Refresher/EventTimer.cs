using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Refresher
{
    public partial class EventTimer : Timer
    {
        public MasterEvent timedEvent { get; set; }
        public EventTimer(MasterEvent _timedEvent)
        {
            timedEvent = _timedEvent;
            Interval = timedEvent.interval;
            AutoReset = true;
            Enabled = true;
        }
        
    }
}
