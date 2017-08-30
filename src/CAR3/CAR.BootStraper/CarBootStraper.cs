using Car3.Infrastructure;
using Car3.Infrastructure;
using Car3.InputeParser;
using Car3.InputOutputService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.BootStraper
{
    public class CarBootStraper:ICarBootStraper
    {
        IInputService inputService;
        IOutputService outputService;
        IInputParserService inputParse;
        ICar car;
        IRenderCarCommands renderCarCommands;

        public CarBootStraper()
        {
            inputService = new ConsoleInputService();
            outputService = new MsgOutputService();
            inputParse = new FirstInputeParser();
            car = new Car();
            renderCarCommands = new RenderCarCommands();
        }
        public  void Run()
        {
            car.Name=inputService.ReadCar(outputService);
            while (true)
            {
                car.Command = inputParse.CommandParser(inputService.ReadCommand(outputService));
                renderCarCommands.Execute(car,this.outputService);
                outputService.Clear();
            }
        }

    }
}
