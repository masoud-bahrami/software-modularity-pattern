using System;
using System.Collections.Generic;
using System.Linq;
using Car5.Infrastructure.Models;

namespace Car5.Infrastructure
{
    public interface IInputParserService
    {
        CarCommands CommandParser(int commandId);
    }
}
