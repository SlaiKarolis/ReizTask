using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizTask
{
    public class Clock
    {
        public void Angle()
        {
            Console.WriteLine("Please enter an hour");
            int hour = Convert.ToInt32(Console.ReadLine());
            if (hour < 0 || hour > 24)
            {
                Console.WriteLine("Incorrect hour's format, please try again");
                return;
            }

            Console.WriteLine("Please enter a minute");
            int minute = Convert.ToInt32(Console.ReadLine());
            if (minute < 0 || minute > 60)
            {
                Console.WriteLine("Incorrect minutes was choosen, please try again");
                return;
            }

            if (hour == 12)
            {
                hour = 0;
            }
            if (minute == 60)
            {
                minute = 0;
                hour += 1;
            }
            if (hour > 12)
            {
                hour = hour - 12;
            }

            double hourAngle = (hour * 60 + minute) * 0.5;
            double minuteAngle = 6 * minute;

            double angle = Math.Abs(hourAngle - minuteAngle);

            angle = Math.Min(360 - angle, angle);
            Console.WriteLine($"The angle between hours arrow and minutes arrow is: {angle} degree");
        }

    }
}
