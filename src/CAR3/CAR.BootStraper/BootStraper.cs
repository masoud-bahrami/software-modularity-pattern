using Car3.BootStraper;
using Car3.Infrastructure;
using Car3.InputeParser;
using Car3.InputOutputService;
using Car4.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4.BootStraper
{
    public class BootStraper:ICarBootStraper
    {
        IInputService inputService;
        IOutputService outputService;
        IInputParserService inputParse;
        ICar car;
        IRenderCarCommands renderCarCommands;

        public BootStraper()
        {
            inputService = new ConsoleInputService();
            outputService = new ConsoleOutputService();
            inputParse = new FirstInputeParser();
            car = new Car1();
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
