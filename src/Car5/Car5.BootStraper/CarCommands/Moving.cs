using Car5.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.BootStraper
{
    public class Moving : ICarOperation
    {
        public Infrastructure.Models.CarCommands OperationName
        {
            get {return Infrastructure.Models.CarCommands.Moving; }
        }

        public void DoOperation(ICar car)
        {
            Console.WriteLine(string.Format("the {0} now is Moving<><><><>", car.Name));
        }
    }
}
