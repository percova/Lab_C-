using System;

namespace Structural_pattern
{
    //Target
    public class DigitalClocks : IClocks
    {
        private int hours { get; set; }
        private int minutes { get; set; }
        private int seconds { get; set; }
        
        
        public DigitalClocks() {}
        public DigitalClocks(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void GetTime()
        {
            Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
        }

        public void SetTime(int h, int m, int s)
        {
            if ((h <= 23 ) && (h >= 0) && (m <= 59) && (m >= 0) && (s <= 59) && (s >= 0))
            {
                hours = h;
                minutes = m;
                seconds = s;
            }
            
            else
            {
                Console.WriteLine("Wrong parameters of time");
            }
        }
    }
}