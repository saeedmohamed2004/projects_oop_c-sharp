using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor___Observer_pattern
{
    internal class TempArgs : EventArgs
    {
        public int Tempruture { get; set; }

        public TempArgs(int temp) 
        {
            Tempruture = temp;
        }

    }
}
