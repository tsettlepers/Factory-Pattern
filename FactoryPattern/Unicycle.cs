﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Unicycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding my unicycle...");
        }
    }
}
