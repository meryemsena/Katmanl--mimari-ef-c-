﻿using KProje.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KProje.DAL.Data.Entities
{
    public class bilim : Entity<int>
    {
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string resim { get; set; }
    }
}