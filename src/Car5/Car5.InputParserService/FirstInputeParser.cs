using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car5.Infrastructure.Models;
using Car5.Infrastructure;

namespace Car5.InputParserService
{
    public class FirstInputeParser : IInputParserService
    {
        public CarCommands CommandParser(int commandId)
        {
            return (CarCommands)commandId;
        }
    }
}
