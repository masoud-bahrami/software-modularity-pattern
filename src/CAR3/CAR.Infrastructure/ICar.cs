using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.Infrastructure
{
    public interface ICar
    {
        string Name { get; set; }
        string Fuelype { get; set; }
        CarCommands Command { get; set; }
    }
}
