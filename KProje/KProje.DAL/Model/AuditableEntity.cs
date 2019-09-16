using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KProje.DAL.Model
{
    public abstract class AuditableEntity<T> : BaseEntity, IEntityKey<T>, IAuditable
    {
        public T ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
       
    }
}
