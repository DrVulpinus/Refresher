using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public class KeysEvent : MasterEvent
    {
        public String keys { get; set; }
        
        public KeySender keySender;
        public KeysEvent()
        {

        }
        public KeysEvent(String _keys, long _interval)
        {
            keys = _keys;
            interval = _interval;
            keySender = new KeySender();
        }
        public KeysEvent(String _keys, long _interval, Process _targetProcess)
        {            
            keys = _keys;
            interval = _interval;
            targetProcess = _targetProcess;
            keySender = new KeySender();
        }

        public override void executeEvent()
        {
            keySender.sendKeys(keys);
        }
       
        
    }
}
