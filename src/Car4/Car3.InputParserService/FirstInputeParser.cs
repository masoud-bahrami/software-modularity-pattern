using Car4.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car4.Infrastructure.Models;

namespace Car4.InputParserService
{
    public class FirstInputeParser : IInputParserService
    {
        public CarCommands CommandParser(int commandId)
        {
            return (CarCommands)commandId;
        }
    }
}
