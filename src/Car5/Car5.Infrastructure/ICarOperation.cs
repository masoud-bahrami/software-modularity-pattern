using Car5.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car5.Infrastructure
{
    public interface ICarOperation
    {
        CarCommands OperationName { get; }
        void DoOperation(ICar car);
    }
}
