using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SinalRtest3
{
    public class TimerCounter : Hub
    {

        private static int _connected=0; //To be changed to some database, sql/firebase
        private static int _time = 0;
        public TimerCounter()
        {
            //Connected();
        }
        
        //Called after a connection is established.
        public void Connected()
        {
            _connected++;
            Clients.All.updateConnected(_connected);
        }

        //ONDISCONNECT doesn't work atm, but should update the value in the future.
        //public override System.Threading.Tasks.Task OnDisconnected()
        //{

        //    this.Clients.All.updateConnected(--_connected);
        //    return base.OnDisconnected()
        //}

        //Add timer stuff here later
        public void Time()
        {
            _time++;
            Clients.All.time(_time);
        }
    }
}