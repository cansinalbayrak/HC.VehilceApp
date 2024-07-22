using HC.VehicleApp.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.VehicleApp.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        //toDo
        /*
         * genericrepo 
         * db kullanmayacaksan inmemory?? , uow !!
         * async kullan !!
         * di cont. unutma !!
         * swagger => postman unutma !!
         * auth ekle, baseE değişt??.
         * new prop ekle endpointleri çeşlitledir
         */
    }
}
