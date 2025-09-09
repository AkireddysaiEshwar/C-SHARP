using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace methods
{
    public class TimeUtility
    {
        public static void printTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());
    }
}