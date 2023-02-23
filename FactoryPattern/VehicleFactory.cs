using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string numTires)
        {
            switch (numTires)
            {
                case "1":
                    return new Unicycle();
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
