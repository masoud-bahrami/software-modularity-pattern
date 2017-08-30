using Car5.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.BootStraper
{
    public class Stopping : ICarOperation
    {
        public Infrastructure.Models.CarCommands OperationName
        {
            get { return Infrastructure.Models.CarCommands.Stopping; }
        }

        public void DoOperation(ICar car)
        {
            Console.WriteLine(string.Format("The {0} is Stopping>>>>>>>>>>", car.Name));
        }
    }
}
