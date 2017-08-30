//namespace Car1
//{
//    using System;
//    using System.Linq;

//    class Program1
//    {
//        delegate void RenderCarsCommands(string car);

//        static RenderCarsCommands[] Commands = { AddGAS, Moving, Stopping, TurnOnTheLights, TurnOfTheLights };

//        static void Main(string[] args)
//        {
//            var car = ChoiceCar();
//            Console.Clear();
//            while (true)
//            {
//                RenderCarsCommands op = ChoseOperation();
//                op(car);
//                Console.ReadKey();
                
//                Console.Clear();
//            }
//        }
//        static RenderCarsCommands ChoseOperation()
//        {
//            Console.WriteLine("-------------------------------------Welcome------------------------------");
//            Console.Write("Please choice op:\t0:AddGAS\t1:Moving\t2:Stopping\t3:TurnOnTheLights\t4:TurnOnTheLights : ");
//            int input=int.Parse(Console.ReadLine());
//            RenderCarsCommands RenderCarsCommands=Commands[input];
//            return RenderCarsCommands;
//        }
//        static string ChoiceCar()
//        {
//            Console.Write("Please enter the your's car name.......... ");
//            return Console.ReadLine();
//        }

//        static void AddGAS(string car)
//        {
//            Console.WriteLine(string.Format("the {0} where in the GAS Station and addning Fuel", car));
//        }
//        static void Stopping(string car)
//        {
//            Console.WriteLine(string.Format("the {0} now is stoped<><><><>", car));
//        }

//        static void Moving(string car)
//        {
//            Console.WriteLine(string.Format("The {0} is moving>>>>>>>>>>", car));
//        }

//        static void TurnOnTheLights(string car)
//        {
//            Console.WriteLine(string.Format("Turn On The Lights of {0}> > > > >", car));
//        }

//        static void TurnOfTheLights(string car)
//        {
//            Console.WriteLine(string.Format("Turn Of The Lights of {0}< < < < <", car));
//        }
//    }
//}
