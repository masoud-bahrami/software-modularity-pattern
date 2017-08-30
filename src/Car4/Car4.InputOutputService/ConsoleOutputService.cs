
using Car4.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4.InputOutputService
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

        public string ServiceName
        {
            get { return "Console"; }
        }
    }
}
