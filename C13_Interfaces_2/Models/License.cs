using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class License : IShoppingItem, ILicense
    {
        
        public string Name { get; set; }
        public int NumberOfLicenses { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }

        public bool Ordercompleted { get; private set; }

        public void ShippingItem() //funktion
        {

            Console.WriteLine($"Licensen för { Name } har skickats till e-postadressen" );

        }
    }
}
