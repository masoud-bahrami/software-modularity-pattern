using Car3.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.InputeParser
{
    public class FirstInputeParser:IInputParserService
    {
        public CarCommands CommandParser(int commandId)
        {
            return (CarCommands)commandId;
        }
    }
}
