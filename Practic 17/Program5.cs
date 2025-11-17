using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_17._5
{
    class Time
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Time(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public static bool operator ==(Time t1, Time t2)
        {
            if (t1 is null && t2 is null)
                return true;
            if (t1 is null || t2 is null)
                return false;
            return t1.hours == t2.hours && t1.minutes == t2.minutes && t1.seconds == t2.seconds;
        }

        public static bool operator !=(Time t1, Time t2)
        {
            return !(t1 == t2);
        }
        public static bool operator >(Time t1, Time t2)
        {
            return t1.ToTotalSeconds() > t2.ToTotalSeconds();
        }

        public static bool operator <(Time t1, Time t2)
        {
            return t1.ToTotalSeconds() < t2.ToTotalSeconds();
        }
        
        public int ToTotalSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }

        public int this[int i]
        {
            get
            {
                if (i == 0) return hours;
                if (i == 1) return minutes;
                if (i == 2) return seconds;
                return -1; //если индекс не 0,1,2
            }
            set
            {
                if (i == 0) hours = value;
                if (i == 1) minutes = value;
                if (i == 2) seconds = value;
            }
        }

        public override string ToString()
        {
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}"; //Дает 05, а не 5
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Time(14, 35, 9);
            Console.WriteLine(t1);
            var t2 = new Time(9, 10, 5);
            Console.WriteLine(t1 > t2);
            Console.WriteLine(t1[1]);
            t1[2] = 59;
            Console.WriteLine(t1);

        }
    }
}
