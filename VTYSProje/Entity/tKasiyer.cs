using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VTYSProje.Entity
{
    class tKasiyer
    {
        [Key]
        public int kasiyerId { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSifre { get; set; }
    }
}
