using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    class EventHandler
    {
        private List<EventTimer> events = new List<EventTimer>();
        private WindowSwitcher ws = new WindowSwitcher();
        public void addNewEvent(KeysEvent newEvent)
        {
            EventTimer newTimer = new EventTimer(newEvent);
            newTimer.Elapsed += new System.Timers.ElapsedEventHandler(eventElapsed);
            newTimer.Stop();
        }
        public void removeEvent(KeysEvent removeEvent)
        {
            
            foreach (EventTimer eventTimer in events)
            {
                if (eventTimer.timedEvent == removeEvent)
                {
                    events.Remove(eventTimer);
                    break;
                }
            }
           
        }

        private void eventElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            EventTimer elapsedTimer = (EventTimer)sender;
            KeysEvent thisEvent = elapsedTimer.timedEvent;
            
        }


    }
}
