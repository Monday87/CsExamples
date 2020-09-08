using System;

namespace C11_Udemy_3
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3



    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var metoden = ShippingMethod.Express;
            Console.WriteLine((int)metoden);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);


            Console.WriteLine(metoden.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
