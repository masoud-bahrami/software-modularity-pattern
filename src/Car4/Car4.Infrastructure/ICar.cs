using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car4.Infrastructure;
using Car4.Infrastructure.Models;

namespace Car4.Infrastructure
{
    public interface ICar
    {
        string Name { get; set; }
        string Fuelype { get; set; }
        CarCommands Command { get; set; }
    }
}
