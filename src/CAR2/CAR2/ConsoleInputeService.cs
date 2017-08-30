using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    public class ConsoleInputeService
    {
        public int ReadCommand(ConsoleOutputService outService)
        {
            outService.WriteMessage("---------------------------Welcome----------------------------------------");
            outService.WriteMessage("Please Choose Op:\t0:AddGas\t1:Moving\t2:Stoping\t3:TurnOnTheLights\t4:TurnOfTheLights");
            return int.Parse(Console.ReadLine());
        }
        
        public string ReadCar(ConsoleOutputService outService)
        {
            
            outService.WriteMessage("Please entere the your's car name.......");
            var carName = Console.ReadLine();
            return carName;
        }
    }
}
