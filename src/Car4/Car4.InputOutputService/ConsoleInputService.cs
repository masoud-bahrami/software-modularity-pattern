
using Car4.Infrastructure;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4.InputOutputService
{
    public class ConsoleInputService:IInputService
    {
        IOutputService outService;
        
        [InjectionConstructor]
        public ConsoleInputService(IOutputService outService)
        {
            this.outService = outService;
        }

        public int ReadCommand()
        {
            this.outService.WriteMessage("---------------------------Welcome----------------------------------------");
            this.outService.WriteMessage("Please Choose Op:\t0:AddGas\t1:Moving\t2:Stoping\t3:TurnOnTheLights\t4:TurnOfTheLights");
            return int.Parse(Console.ReadLine());
        }

        public string ReadCar()
        {
            this.outService.WriteMessage("Please entere the your's car name.......");
            var carName = Console.ReadLine();
            return carName;
        }
    }
}
