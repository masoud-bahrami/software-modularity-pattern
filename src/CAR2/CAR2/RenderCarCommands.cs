using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    public class RenderCarCommands
    {
        public void Execute(Car car,ConsoleOutputService outService)
        {
            switch (car.Command)
            {
                case CarCommands.AddGAS:
                    AddGas(car, outService);
                    break;
                case CarCommands.Moving:
                    Moving(car, outService);
                    break;
                case CarCommands.Stopping:
                    Stopping(car, outService);
                    break;
                case CarCommands.TurnOfTheLights:
                    TurnOfTheLights(car, outService);
                    break;
                case CarCommands.TurnOnTheLights:
                    TurnOnTheLights(car, outService);
                    break;
            }
        }
        void AddGas(Car car,ConsoleOutputService outService)
        {
            outService.WriteMessage(string.Format("Add Gas into {0}.........", car.Name));
        }

        void Stopping(Car car, ConsoleOutputService outService)
        {
            outService.WriteMessage(string.Format("the {0} now is stoped<><><><>", car.Name));
        }

        void Moving(Car car, ConsoleOutputService outService)
        {
            outService.WriteMessage(string.Format("The {0} is moving>>>>>>>>>>", car.Name));
        }

        void TurnOnTheLights(Car car, ConsoleOutputService outService)
        {
            outService.WriteMessage(string.Format("Turn On The Lights of {0}> > > > >", car.Name));
        }

        void TurnOfTheLights(Car car, ConsoleOutputService outService)
        {
            outService.WriteMessage(string.Format("Turn Of The Lights of {0}< < < < <", car.Name));
        }

    }
}
