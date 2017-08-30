using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car2
{
    public class InputeParse
    {
        public CarCommands Parser(int commandId)
        {
            return (CarCommands)commandId;
        }
    }
}
