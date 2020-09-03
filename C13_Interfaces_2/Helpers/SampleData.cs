using C13_Interfaces_2.Interfaces;
using C13_Interfaces_2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace C13_Interfaces_2.Helpers
{
    class SampleData
    {
        public static List<IShoppingItem> CartSampleItems()
        {

            var output = new List<IShoppingItem>();

            output.Add(new Product { Id = "1007573", Name = "Apple Airpods (2019)", Description = "Airpods med laddningsetui" });
            output.Add(new Product { Id = "1003000", Name = "SodaStream titan/silver", Description = "Sodastream med kolsyrepatron och fyra extra grejer" });
            output.Add(new Product { Id = "1250022", Name = "Ear Cleaner", Description = "Rensar dina Airpods" });

            output.Add(new License { Id = "50403030", Name = "Windows-nyckel", Description = "Licensnyckel till Windows" , NumberOfLicenses = 5 });

            return output;

        }
    }
}
