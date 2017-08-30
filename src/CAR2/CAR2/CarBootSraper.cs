using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    public  class CarBootSraper
    {
        ConsoleInputeService inputService;
        ConsoleOutputService outputService;
        InputeParse inputParse;
        Car car;
        RenderCarCommands renderCarCommands;

        public CarBootSraper()
        {
            inputService = new ConsoleInputeService();
            outputService = new ConsoleOutputService();
            inputParse = new InputeParse();
            car = new Car();
            renderCarCommands = new RenderCarCommands();
        }


        public  void Run()
        {
            car.Name=inputService.ReadCar(outputService);
            while (true)
            {
                car.Command = inputParse.Parser(inputService.ReadCommand(outputService));
                renderCarCommands.Execute(car,this.outputService);
                outputService.Clear();
            }
        }
    }
}
