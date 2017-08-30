using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4.Infrastructure
{
    public interface IInputService
    {
        int ReadCommand();
        string ReadCar();
    }
}
