﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    class CNC : IMachine
    {
        public bool Start()
        {

            Console.WriteLine("CNC Machine has started.");
            return true;
        }
        public bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
