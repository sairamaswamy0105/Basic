using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.Script.Seril

namespace MinimumTimeDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] timeStamp = {"01:00","02:00","23:59" };
            int[] minutes = new int[timeStamp.Length];
            int i = 0;
            foreach (string stamp in timeStamp)
            {
                int.TryParse(stamp.Substring(0, 2), out int m1); 
                int.TryParse(stamp.Substring(3, 2), out int m2);
                minutes[i++] = m1*60+m2;
            }
            Array.Sort(minutes);
            int mini = int.MaxValue;
            for (i = 1; i < minutes.Length; i++)
            {
                mini = Math.Min(mini,Math.Abs(minutes[i - 1] - minutes[i]));
            }
            Console.WriteLine(mini);
        }
    }
}
