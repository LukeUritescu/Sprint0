using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{


    class ToyPlane : Airplane
    { 
        
       
        private bool IsWoundUp;

        public string GetWindUpString()
        {
            if (IsWoundUp)
                return "ToyPlane is wound up";
            else
                return "ToyPlane not wound up";
        }

        public override void StartEngine()
        {
            if (IsWoundUp)
                Console.WriteLine(this + " is wound up. Engine started");
            else
                Console.WriteLine(this + " is not wound up, engine can not be started.");
        }

        public override string TakeOff()
        {
            if (Engine.IsStarted)
                return this + " is taking off.";
            else
                return this + " engine isn't started can not take off.";
        }

        public ToyPlane() : base()
        {
            MaxAltitude = 50;
        }
        protected void UnWind()
        {
            IsWoundUp = false;
        }
        protected void WindUp()
        {
            IsWoundUp = true;
        }
    }
}
