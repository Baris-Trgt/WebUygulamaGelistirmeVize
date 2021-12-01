using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirmeVize.Models
{
    public class Personel 
        //Models'ın altinda Personel adinda bir class olusturdum . Daha sonra bu class'in icini doldurdum. 
    {

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Dogum_Tarih { get; set; }
        public string Kimlik_No { get; set; }
        public string Departman_Tipi { get; set; }
        public string Giris_Yil { get; set; }
        public string Sozlesme_Bitis_Tarih { get; set; }


    }
}
