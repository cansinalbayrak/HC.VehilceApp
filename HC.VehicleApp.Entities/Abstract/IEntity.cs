using HC.VehicleApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehicleApp.Entities.Abstract
{
    public interface IEntity
    {
        Guid Id { get; set; }
        Status Status { get; set; }
    }
}
