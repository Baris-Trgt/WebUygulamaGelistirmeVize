using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirmeVize.Models
{
    public class Stok
    //Models'ın altinda Stok adinda bir class olusturdum . Daha sonra bu class'in icini doldurdum.

    {
        public int Id { get; set; }
        public string Urun_Adi { get; set; }
        public string Urun_Fiyat { get; set; }
        public string Marka { get; set; }
        public string Stok_Durumu { get; set; }
    }
}
