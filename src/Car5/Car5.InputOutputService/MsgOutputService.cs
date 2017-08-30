
using Car5.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.InputOutputService
{
    public class MsgOutputService:IOutputService
    {
        public void WriteMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        public void Clear()
        {
            
        }

        public string ServiceName
        {
            get { return "Windows"; }
        }
    }
}
