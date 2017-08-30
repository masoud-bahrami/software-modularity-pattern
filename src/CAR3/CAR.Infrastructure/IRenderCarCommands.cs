using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.Infrastructure
{
    public interface IRenderCarCommands
    {
        void Execute(ICar car,IOutputService outService);
    }
}
