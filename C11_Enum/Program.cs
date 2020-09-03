using System;
using System.ComponentModel;

namespace C11_Enum
{
    public enum Level
    {
        Low,
        Normal,
        High,
    }
    class Program
    {

        enum Status
        {
            Pending,
            Production,
            Transporting,
            Delivered,
        }
        static void Main(string[] args)
        {
            var temperature = 32;
            var _tempLevel = Level.Normal;


            switch(temperature)
            {
                case var t when t < 10:
                    _tempLevel = Level.Low;
                    Console.WriteLine("Temp is too low!");
                    break;

                case var t when t < 30:
                    _tempLevel = Level.High;
                    Console.WriteLine("Temp is too high!");
                    break;

                default:
                    _tempLevel = Level.Normal;
                    Console.WriteLine("Temp is really good atm");
                    break;
            }

            switch (_tempLevel)
            {
                case Level.Low:
                    Console.WriteLine("temp is too low");
                    break;

                case Level.Normal:
                    Console.WriteLine("Temp is normal");
                    break;
                case Level.High:
                    Console.WriteLine("Temp is too high!");
                    break;
                default:
                    break;
            }

            var status = Status.Transporting;

            switch (status)
            {
                case Status.Pending:
                    Console.WriteLine("Electronic register information has been recieved");
                    break;
                case Status.Production:
                    Console.WriteLine("Your order(s) is now in production");
                    break;
                case Status.Transporting:
                    Console.WriteLine("Your order(s) is on it's way");
                    break;
                case Status.Delivered:
                    Console.WriteLine("Your order(s) has been delivered");
                    break;
                default:
                    Console.WriteLine("Please place your order(s)!");
                    break;
            }

        }
    }
}
