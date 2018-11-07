using System;

namespace Structural_pattern
{
    //Adaptee
    public class AnalogClocks
    {
        private int houreHandDegree { get; set; }
        private int minuteHandDegree { get; set; }
        private int secondHandDegree { get; set; }
        bool firstPartOfTheDay;

        public void GetAnalogTime()
        {
            int hours;
            int minutes;
            int seconds;

            hours = houreHandDegree / (360 / 12);
            minutes = minuteHandDegree / (360 / 60);
            seconds = secondHandDegree / (360 / 60);
            if (firstPartOfTheDay)
            {
                Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
            }
            else if (!firstPartOfTheDay)
            {
                hours += 12;
                Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
            }
        }

        public void SetAnalogTime(int h, int m, int s)
        {
            if ((h <= 23 ) && (h >= 0) && (m <= 59) && (m >= 0) && (s <= 59) && (s >= 0))
            {
                if (h <= 12)
                {
                    firstPartOfTheDay = true;
                    houreHandDegree = h * (360 / 12);
                }
                else if ( h > 12 )
                {
                    firstPartOfTheDay = false;
                    houreHandDegree = (h - 12) * (360 / 12);
                }

                minuteHandDegree = m * (360 / 60);
                secondHandDegree = s * (360 / 60);
            }
            
            else
            {
                Console.WriteLine("Wrong parameters of time");
            }   
        }
    }
}