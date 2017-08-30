using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car3.Infrastructure
{
    public interface IInputService
    {
        int ReadCommand(IOutputService outService);
        string ReadCar(IOutputService outService);
    }
}
