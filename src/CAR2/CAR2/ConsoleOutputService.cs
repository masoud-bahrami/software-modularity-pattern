namespace Car2
{
    using System;
    using System.Linq;

    public class ConsoleOutputService
    {
        public void WriteMessage(string message)
        {
           // System.Windows.Forms.MessageBox.Show(message);
            Console.WriteLine(message);
        }
        public void Clear()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
