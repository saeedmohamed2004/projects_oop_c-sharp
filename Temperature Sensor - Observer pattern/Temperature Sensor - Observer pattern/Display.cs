using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor___Observer_pattern
{
    internal class Display
    {
        public void ShowTemp(object? obj,TempArgs args )
        {
            Console.WriteLine($"The Tempruture now set to {args.Tempruture} from display");
        }
    }
}
