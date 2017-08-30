using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car5.Infrastructure;
using Car5.Infrastructure.Models;
using Microsoft.Practices.Unity;

namespace Car5.BootStraper
{
    public class RenderCarCommands:IRenderCarCommands
    {
        private IUnityContainer Container;

        public List<ICarOperation> _availableOperations = new List<ICarOperation>();
        public List<ICarOperation> AvailableOperations
        {
            get
            {
                return _availableOperations;
            }
        }

        public RenderCarCommands(IUnityContainer container)
        {
            Container=container;
            _availableOperations = container.ResolveAll<ICarOperation>().ToList();
   
        }

        public void Execute(ICar car)
        {
            ICarOperation op = GetOperation(car.Command.ToString());
            
            op.DoOperation(car);
        }

       
        private ICarOperation GetOperation(string opName)
        {
            if (Container.IsRegistered<ICarOperation>(opName))
            {
                ICarOperation op = Container.Resolve<ICarOperation>(opName);
                return op;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
       
    }
}
