﻿using C13_Interfaces_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace C13_Interfaces_2.Models
{
    class Product : IShoppingItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool OrderCompleted { get; private set; }

        public bool Ordercompleted { get; }

        public void ShippingItem()
        {
            if (!OrderCompleted) //if(OrderCompleted == false)
            {
                Console.WriteLine($"Varan { Name } har skickats iväg.");
                OrderCompleted = true;
            }
        }
    }
}
