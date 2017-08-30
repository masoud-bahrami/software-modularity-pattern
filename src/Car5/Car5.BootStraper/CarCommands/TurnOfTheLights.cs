using Car5.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.BootStraper
{
    public class TurnOfTheLights : ICarOperation
    {
        public Infrastructure.Models.CarCommands OperationName
        {
            get { return Infrastructure.Models.CarCommands.TurnOnTheLights; }
        }

        public void DoOperation(ICar car)
        {
            Console.WriteLine(string.Format("Turn Of The Lights of {0}< < < < <", car.Name));
        }
    }
}
