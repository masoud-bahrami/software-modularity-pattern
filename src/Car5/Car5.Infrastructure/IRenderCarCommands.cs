using System;
using System.Collections.Generic;
using System.Linq;

namespace Car5.Infrastructure
{
    public interface IRenderCarCommands
    {
        List<ICarOperation> AvailableOperations
        {
            get;
        }
        void Execute(ICar car);
    }
}
