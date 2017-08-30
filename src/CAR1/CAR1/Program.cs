namespace Car1
{
    using System;
    using System.Linq;
    class Program
    {
        enum CarCommands
        {
            AddGAS = 0,
            Moving = 1,
            Stopping = 2,
            TurnOnTheLights = 3,
            TurnOfTheLights = 4
        }
        static void Main(string[] args)
        {
            var car = ChoiceCar();
            Console.Clear();
            while (true)
            {
                var op = ChoseOperation();

                RenderCarCommands(car, op);

                Console.ReadKey();
                Console.Clear();
            }
        }
        static CarCommands ChoseOperation()
        {
            Console.WriteLine("---------------------------Welcome----------------------------------------");
            Console.WriteLine("Please Choose Op:\t0:AddGas\t1:Moving\t2:Stoping\t3:TurnOnTheLights\t4:TurnOfTheLights");
            int input = int.Parse(Console.ReadLine());

            CarCommands op = (CarCommands)input;
            return op;
        }

        static string ChoiceCar()
        {
            Console.Write("Please entere the your's car name.......");
            var car = Console.ReadLine();
            return car;
        }

        private static void RenderCarCommands(string Car, CarCommands op)
        {
            // TODO: Implement this method
            switch (op)
            {
                case CarCommands.AddGAS:
                    AddGas(Car);
                    break;
                case CarCommands.Moving:
                    Moving(Car);
                    break;
                case CarCommands.Stopping:
                    Stopping(Car);
                    break;
                case CarCommands.TurnOfTheLights:
                    TurnOfTheLights(Car);
                    break;
                case CarCommands.TurnOnTheLights:
                    TurnOnTheLights(Car);
                    break;
            }
        }


        static void AddGas(string car)
        {
            Console.WriteLine(string.Format("Add Gas into {0}.........", car));
        }

        static void Stopping(string car)
        {
            Console.WriteLine(string.Format("the {0} now is stoped<><><><>", car));
        }

        static void Moving(string car)
        {
            Console.WriteLine(string.Format("The {0} is moving>>>>>>>>>>", car));
        }

        static void TurnOnTheLights(string car)
        {
            Console.WriteLine(string.Format("Turn On The Lights of {0}> > > > >", car));
        }

        static void TurnOfTheLights(string car)
        {
            Console.WriteLine(string.Format("Turn Of The Lights of {0}< < < < <", car));
        }
    }
}
