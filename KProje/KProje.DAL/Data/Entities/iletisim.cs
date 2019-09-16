using KProje.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KProje.DAL.Data.Entities
{
    public class iletisim : Entity<int>
    {
        public string mail { get; set; }
        public string yorum { get; set; }
    }
}
