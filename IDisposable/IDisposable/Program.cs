using Classes;
using System;

namespace IDisposable
{
    class Program
    {
        static void Main()
        {
            using (Sample s = new Sample())
            {
                s.PerformAction();
            } // Dispose is called automatically here

            //another way to use IDisposable
            Sample s2 = new Sample();
            using (s2)
            {
                s2.PerformAction();
            } // Dispose is called automatically here

        }
    }
}