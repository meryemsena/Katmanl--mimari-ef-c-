using KProje.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KProje.DAL.Data.Entities
{
     public class haberler : Entity<int>
    {
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string resim { get; set; }
        public string yanbaslik { get; set; }
    }
}
