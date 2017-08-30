using Car5.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car5.Infrastructure
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
