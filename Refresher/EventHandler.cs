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
        
        public void addNewEvent(MasterEvent newEvent)
        {
            EventTimer newTimer = new EventTimer(newEvent);
            newTimer.Elapsed += new System.Timers.ElapsedEventHandler(eventElapsed);
            newTimer.Stop();
            events.Add(newTimer);
        }
        public void removeEvent(MasterEvent removeEvent)
        {
            EventTimer removeTimer = findEventTimer(removeEvent);
            if (removeTimer != null)
            {
                events.Remove(removeTimer);
            }
        }

        public EventTimer findEventTimer(MasterEvent timedEvent)
        {
            foreach (EventTimer eventTimer in events)
            {
                if (eventTimer.timedEvent == timedEvent)
                {
                    return eventTimer;
                }
            }
            return null;
        }

        public void startEvent(MasterEvent eventToStart)
        {
            
            EventTimer timerToStart = findEventTimer(eventToStart);
            Console.WriteLine("Starting");
            if (timerToStart != null)
            {
                
                timerToStart.Start();
                Console.WriteLine("Started");
            }
        }
        public void stopEvent(MasterEvent eventToStop)
        {
            EventTimer timerToStop = findEventTimer(eventToStop);
            Console.WriteLine("Stopping");
            if (timerToStop != null)
            {
                
                timerToStop.Stop();
                Console.WriteLine("Stopped");
            }
        }



        private void eventElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            EventTimer elapsedTimer = (EventTimer)sender;
            MasterEvent thisEvent = elapsedTimer.timedEvent;
            if (thisEvent.targetProcess != null)
            {
                ws.switchToTarget(thisEvent.targetProcess);
            }
            thisEvent.executeEvent();
            if (thisEvent.targetProcess != null)
            {
                ws.returnToOrigin();
            }
        }


    }
}
