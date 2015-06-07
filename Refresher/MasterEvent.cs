using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresher
{
    public abstract class MasterEvent
    {
        public Process targetProcess { get; set; }
        public long interval { get; set; }

        public abstract void executeEvent();
    }
}
