using Car3.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.InputOutputService
{
    public class ConsoleOutputService:IOutputService
    {

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void Clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
