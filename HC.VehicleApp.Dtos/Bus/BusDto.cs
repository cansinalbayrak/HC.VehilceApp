using HC.VehicleApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehicleApp.Dtos.Bus
{
    public class BusDto
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
    }
}
