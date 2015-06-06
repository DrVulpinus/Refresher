using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    class KeysEvent
    {
        public String keys { get; set; }
        public Process targetProcess { get; set; }
        public long interval { get; set; }
        public KeysEvent()
        {

        }
        public KeysEvent(String _keys, long _interval)
        {
            keys = _keys;
            interval = _interval;
        }
        public KeysEvent(String _keys, long _interval, Process _targetProcess)
        {
            keys = _keys;
            interval = _interval;
            targetProcess = _targetProcess;
        }
       
        
    }
}
