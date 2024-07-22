using HC.VehicleApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehicleApp.Entities.Abstract
{
    public abstract class Vehicle:BaseEntity
    {
        public Color Color { get; set; }
    }
}
