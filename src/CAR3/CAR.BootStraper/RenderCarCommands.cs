using Car3.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.BootStraper
{
    public class RenderCarCommands:IRenderCarCommands
    {
        public void Execute(ICar car,IOutputService outService)
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
        void AddGas(ICar car, IOutputService outService)
        {
            outService.WriteMessage(string.Format("Add Gas into {0}.........", car.Name));
        }

        void Stopping(ICar car, IOutputService outService)
        {
            outService.WriteMessage(string.Format("the {0} now is stoped<><><><>", car.Name));
        }

        void Moving(ICar car, IOutputService outService)
        {
            outService.WriteMessage(string.Format("The {0} is moving>>>>>>>>>>", car.Name));
        }

        void TurnOnTheLights(ICar car, IOutputService outService)
        {
            outService.WriteMessage(string.Format("Turn On The Lights of {0}> > > > >", car.Name));
        }

        void TurnOfTheLights(ICar car, IOutputService outService)
        {
            outService.WriteMessage(string.Format("Turn Of The Lights of {0}< < < < <", car.Name));
        }
    }
}
