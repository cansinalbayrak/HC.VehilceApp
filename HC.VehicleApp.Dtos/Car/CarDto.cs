using HC.VehicleApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehicleApp.Dtos.Car
{
    public class CarDto
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public WheelType Wheel { get; set; }
        public bool HeadLightOn { get; set; }
    }
}
