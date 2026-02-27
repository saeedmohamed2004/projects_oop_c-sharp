using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor___Observer_pattern
{
    internal class Sensors
    {
        //event
        public event EventHandler<TempArgs> sensorchanged;
        private int CurrentTemp { get; set; }

        public void ChangeTempruture(int newTemp)
        {
            CurrentTemp = newTemp;

            sensorchanged.Invoke(this, new TempArgs(newTemp));
        }

    }
}
