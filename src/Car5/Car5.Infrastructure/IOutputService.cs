using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.Infrastructure
{
    public interface IOutputService
    {
        void WriteMessage(string message);

        void Clear();
        
        string ServiceName { get; }
    }
}
