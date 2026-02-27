namespace Temperature_Sensor___Observer_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Sensors sensors = new Sensors();
            Display display = new Display();
            Alarm alarm = new Alarm(20);

            sensors.sensorchanged += display.ShowTemp;             //
            sensors.sensorchanged += alarm.FireAlarm;             //

            while (true) 
            {
                Console.WriteLine("Welcome to the tempruture system");

                Console.WriteLine("1- set the tempruture ");
                Console.WriteLine("2- set the Alarm Value (default 20) ");
                Console.WriteLine("3- Exit");

                var result =Console.ReadLine();

                switch (result) 
                {
                        case "1":
                        Console.WriteLine("Please enter the tempeture in degrees ");

                        var temp = Convert.ToInt32(Console.ReadLine());
                        sensors.ChangeTempruture(temp);
                        break;
                        case "2":
                        Console.WriteLine("Please enter the tempeture value for the alarm ");
                       
                        var Alarmvalue = Convert.ToInt32(Console.ReadLine());
                        alarm.SetAlarmValue(Alarmvalue);


                        break;
                        case "3":
                        Environment.Exit(0);
                        break;
                        default:
                        Console.WriteLine("invalid input , try again");
                        break;
                }

            }

        }
    }
}
