using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;

namespace ASteller.Data
{
    public class HeadLights
    {
        public HeadLights()
        {
            this.State = EnumHeadLightState.Off;
        }
        public EnumHeadLightState State { get; set; }
    }
}
