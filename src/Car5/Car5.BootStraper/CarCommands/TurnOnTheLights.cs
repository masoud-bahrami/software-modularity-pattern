using Car5.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.BootStraper
{
    public class TurnOnTheLights : ICarOperation
    {
        public Infrastructure.Models.CarCommands OperationName
        {
            get { return Infrastructure.Models.CarCommands.TurnOfTheLights; }
        }

        public void DoOperation(ICar car)
        {
            Console.WriteLine(string.Format("Turn On The Lights of {0}> > > > >", car.Name));
        }
    }
}
