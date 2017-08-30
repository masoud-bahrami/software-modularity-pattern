using Car4.Infrastructure;
using Car4.Infrastructure.Models;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car4
{
    class Program
    {
        public static IUnityContainer Container { get; set; }
        static void Main(string[] args)
        {
            InitializeUnityContainer();
            
            ICarBootStraper bootstraper = Container.Resolve<ICarBootStraper>();

            bootstraper.Run();
        }
        private static void InitializeUnityContainer()
        {
            var container = new UnityContainer();

            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("Unity");

            section.Configure(container, "container");

            Container = container;
        }
    }
}
