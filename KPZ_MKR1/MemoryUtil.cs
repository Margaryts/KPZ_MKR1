using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class MemoryUtil
    {
        public static long MeasureMemoryUsage(Action action)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long before = Process.GetCurrentProcess().PrivateMemorySize64;

            action.Invoke();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            long after = Process.GetCurrentProcess().PrivateMemorySize64;

            return after - before;
        }
    }
}
