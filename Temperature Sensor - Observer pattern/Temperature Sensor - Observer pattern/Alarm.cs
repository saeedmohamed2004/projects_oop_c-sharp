using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor___Observer_pattern
{
    internal class Alarm
    {
      private   int AlarmValue { get; set; }//Threshold

        public Alarm(int alarmtemp)//default 
        {
            AlarmValue=alarmtemp;
        }

        public void SetAlarmValue(int newalarmValue)
        {
            AlarmValue=newalarmValue;
        }

        public void FireAlarm(object? obj ,TempArgs tempArgs )
        {
            if (tempArgs.Tempruture>AlarmValue)
            {
                Console.WriteLine($"Take care , the temp value {tempArgs.Tempruture} is greaterthan {AlarmValue}");
            }

        }
    }
}
