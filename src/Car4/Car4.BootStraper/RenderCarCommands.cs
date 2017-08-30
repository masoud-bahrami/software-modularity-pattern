using Car4.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car4.Infrastructure.Models;

namespace Car4.BootStraper
{
    public class RenderCarCommands:IRenderCarCommands
    {
        public void Execute(ICar car)
        {
            switch (car.Command)
            {
                case CarCommands.AddGAS:
                    AddGas(car);
                    break;
                case CarCommands.Moving:
                    Moving(car);
                    break;
                case CarCommands.Stopping:
                    Stopping(car);
                    break;
                case CarCommands.TurnOfTheLights:
                    TurnOfTheLights(car);
                    break;
                case CarCommands.TurnOnTheLights:
                    TurnOnTheLights(car);
                    break;
            }
        }
        void AddGas(ICar car)
        {
            Console.WriteLine(string.Format("Add Gas into {0}.........", car.Name));
        }

        void Stopping(ICar car)
        {
            Console.WriteLine(string.Format("the {0} now is stoped<><><><>", car.Name));
        }

        void Moving(ICar car)
        {
            Console.WriteLine(string.Format("The {0} is moving>>>>>>>>>>", car.Name));
        }

        void TurnOnTheLights(ICar car)
        {
            Console.WriteLine(string.Format("Turn On The Lights of {0}> > > > >", car.Name));
        }

        void TurnOfTheLights(ICar car)
        {
            Console.WriteLine(string.Format("Turn Of The Lights of {0}< < < < <", car.Name));
        }
    }
}
