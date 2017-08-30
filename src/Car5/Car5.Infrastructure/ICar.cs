using System;
using System.Collections.Generic;
using System.Linq;
using Car5.Infrastructure.Models;

namespace Car5.Infrastructure
{
    public interface ICar
    {
        string Name { get; set; }
        string Fuelype { get; set; }
        CarCommands Command { get; set; }
    }
}
