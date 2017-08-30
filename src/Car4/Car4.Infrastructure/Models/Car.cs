using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Car4.Infrastructure;

namespace Car4.Infrastructure.Models
{
    public class Car:ICar
    {
        #region Fields
        string name;
        string fuelype;
        CarCommands command;
        #endregion
        #region Constractors
        #endregion
        #region Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Fuelype
        {
            get
            {
                return this.fuelype;
            }
            set
            {
                this.fuelype = value;
            }
        }

        public CarCommands Command
        {
            get
            {
                return this.command;
            }
            set
            {
                this.command = value;
            }
        }

        #endregion

    }
}
