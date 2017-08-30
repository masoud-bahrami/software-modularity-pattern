
using Car3.Infrastructure;
using Car4.BootStraper;
using System;
using System.Linq;

namespace CAR3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBootStraper BootStraper = new BootStraper();

            BootStraper.Run();
        }
    }
}
