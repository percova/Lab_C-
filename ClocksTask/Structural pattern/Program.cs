using System;

namespace Structural_pattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ClockUser user = new ClockUser();
            DigitalClocks digitalClocks = new DigitalClocks(14, 10, 45);
            AnalogClocks analogClocks = new AnalogClocks();
            
            user.WatchTime(digitalClocks);
            IClocks analogClocksAdaptee = new AnalogToDigitalAdapter(analogClocks);
            user.ChangeTime(analogClocksAdaptee);
            user.WatchTime(analogClocksAdaptee);

            Console.Read();
        }
    }
}