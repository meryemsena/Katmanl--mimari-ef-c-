using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KProje.DAL.Model
{
    public interface IEntityKey<T> 
    {
        T ID { get; set; }
    }
}
