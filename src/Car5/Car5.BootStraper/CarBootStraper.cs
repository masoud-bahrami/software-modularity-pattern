using Car5.Infrastructure;
using Car5.Infrastructure.Models;
using Car5.InputOutputService;
using Car5.InputParserService;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.BootStraper
{
    public class CarBootStraper:ICarBootStraper
    {
        IInputService inputService;
        IOutputService outPutService;
        IOutputService defaultOutPutService;
        IInputParserService inputParser;
        ICar car;
        IRenderCarCommands renderCarCommands;
        IUnityContainer Container = null;
        //public CalculatorBootStraper(IUnityContainer container,IOutputService outputService )
        [InjectionConstructor]
        public CarBootStraper(IUnityContainer container)
        {
            this.Container = container;
            List<IOutputService> outputServices = container.ResolveAll<IOutputService>().ToList();
            if (container.IsRegistered<IOutputService>())
                defaultOutPutService = container.Resolve<IOutputService>();
            else
                defaultOutPutService = new ConsoleOutputService();
            SetOutputService(outputServices, defaultOutPutService);

            if (container.IsRegistered<IInputService>())
                inputService = container.Resolve<IInputService>();
            else
                inputService = new ConsoleInputService(outPutService);

            if (container.IsRegistered<IOutputService>())
                outPutService = container.Resolve<IOutputService>();
            else
                outPutService = new ConsoleOutputService();


            if (container.IsRegistered<IInputParserService>())
                inputParser = container.Resolve<IInputParserService>();
            else
                inputParser = new FirstInputeParser();


            if (container.IsRegistered<ICar>())
                car = container.Resolve<ICar>();
            else
                car = new Car();

            if (container.IsRegistered<IRenderCarCommands>())
                renderCarCommands = container.Resolve<IRenderCarCommands>();
            else
                renderCarCommands = new RenderCarCommands(Container);
        }
        public  void Run()
        {
            car.Name=inputService.ReadCar();
            while (true)
            {
                car.Command = ChooseOperation(renderCarCommands, outPutService, inputService);
                renderCarCommands.Execute(car);
                outPutService.Clear();
            }
        }

        public void SetOutputService(List<IOutputService> availableServices, IOutputService defaultOutputService)
        {
            List<string> outputServiceNames = new List<string>();
            defaultOutputService.WriteMessage("Please Select Output Service Provider");
            int i = 0;
            foreach (IOutputService service in availableServices)
            {
                defaultOutputService.WriteMessage(string.Format("{0}:{1}", i, service.ServiceName));
                outputServiceNames.Add(service.ServiceName);
                i++;
            }
            int selection = int.Parse(Console.ReadLine());
            Container.RegisterInstance<IOutputService>(availableServices[selection]);
        }

        public Car5.Infrastructure.Models.CarCommands ChooseOperation(IRenderCarCommands renderCarCommands, IOutputService outputService, IInputService inputService)
        {
            int i = 0;

            foreach (ICarOperation op in renderCarCommands.AvailableOperations)
            {
                outputService.WriteMessage(string.Format("{0}:{1}", i, op.OperationName));
                i++;
            }
            int selection = int.Parse(Console.ReadLine());
            return renderCarCommands.AvailableOperations[selection].OperationName;
        }
    }
}
