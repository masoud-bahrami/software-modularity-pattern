using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car4.Infrastructure;

namespace Car4.Infrastructure
{
    public interface IRenderCarCommands
    {
        void Execute(ICar car);
    }
}
