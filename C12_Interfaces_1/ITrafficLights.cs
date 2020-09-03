﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C12_Interfaces_1
{
    interface ITrafficLights
    {
       

        Guid Id { get; set; }
        string Location { get; set; }

        void ChangeLight();
        void WarningLight();

    }
}
