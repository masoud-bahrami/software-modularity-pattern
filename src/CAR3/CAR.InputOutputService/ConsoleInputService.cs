using Car3.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.InputOutputService
{
    public class ConsoleInputService:IInputService
    {
        public int ReadCommand(IOutputService outService)
        {
            outService.WriteMessage("---------------------------Welcome----------------------------------------");
            outService.WriteMessage("Please Choose Op:\t0:AddGas\t1:Moving\t2:Stoping\t3:TurnOnTheLights\t4:TurnOfTheLights");
            return int.Parse(Console.ReadLine());
        }

        public string ReadCar(IOutputService outService)
        {
            outService.WriteMessage("Please entere the your's car name.......");
            var carName = Console.ReadLine();
            return carName;
        }
    }
}
