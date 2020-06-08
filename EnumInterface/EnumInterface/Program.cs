using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumInterface
{
    class Program
    {
        #region Enum
        public enum Weekdays { Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
        public enum ErrorList:byte { NotFound=254,ServerError};
        #endregion
        static void Main(string[] args)
        {
            #region Enum
            //var number = 7;
            //switch (number)
            //{
            //    case (int)Weekdays.Sunday:
            //        Console.WriteLine("Hefte sonudur");
            //        break;
            //    case (int)Weekdays.Saturday:
            //        Console.WriteLine("Senbe gunudur");
            //        break;
            //    default:
            //        Console.WriteLine("Hefte icidir");
            //        break;
            //}

            //foreach (var item in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine((int)item);
            //}
            #endregion
        }
    }

    #region Interface
    interface IRun
    {
        void Run();
        //int Test(int x);
    }

    interface IEatable
    {
        void Eat();
    }

    class Person : IRun, IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Eat as Human");
        }

        public void Run()
        {
            Console.WriteLine("Run as Human");
        }
    }

    class Animal : IRun
    {
        public void Run()
        {
            Console.WriteLine("Run as Animal");
        }
    }
    #endregion

}
