using HC.VehicleApp.Entities.Abstract;
using HC.VehicleApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehicleApp.Entities.Concrete
{
    public class Car:Vehicle
    {
        public WheelType Wheel { get; set; }
        public bool HeadLightOn { get; set; }
    }
}
