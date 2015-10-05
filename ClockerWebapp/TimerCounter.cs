using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SinalRtest3
{
    public class TimerCounter : Hub
    {

        private static int _connected=0; //To be changed to some database, sql/firebase
        private static long _time = 0;
        private static bool pressed = false;
        private static double test = 0;
        public TimerCounter()
        {
            //Connected();
        }
        
        //Called after a connection is established.
        public void Connected()
        {
            //_connected++;
            Clients.All.updateConnected(++_connected);
            Clients.All.time(test);
        }

        
        public override System.Threading.Tasks.Task OnDisconnected(bool stopCalled)
        {

            this.Clients.All.updateConnected(--_connected);
            return base.OnDisconnected(stopCalled);
        }

        //Add timer stuff here later
        public void Time()
        {
            DateTime time = DateTime.Now;
           
            if (!pressed)
            {

                _time = time.Ticks;
                pressed = true;
                Clients.All.time("started: " + 0);
            }
            else{
                long deltaTime = time.Ticks - _time;
                pressed = false;
                deltaTime = deltaTime/10000;
                test = deltaTime/1000.0;
                Clients.All.time("stopped: " + test);
            }
            
            

        }
    }
}