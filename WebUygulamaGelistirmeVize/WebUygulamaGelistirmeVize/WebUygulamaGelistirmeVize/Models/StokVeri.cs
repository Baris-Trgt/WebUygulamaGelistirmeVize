using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirmeVize.Models
{
    public class StokVeri //Laptop ile ilgili Stok Verilerimi Girdim 
    //Models'ın altinda StokVeri adinda bir class olusturdum.
    //StokVeri classı Stok classından olusan bir liste vermesi icin StokVeri classını olusturdum.
    //StokVeri classı Stok classı icerigini barırındır.
    {
        public static List<Stok> Stoklar = new List<Stok>()
        // List tanimlandigi tipte (Stok)  n tane veri tutar
        // Datanin degistirilmemesi ve miras alınmamasi icin static tipini kullandım
        // Stoklar isimli bir liste olusturdum ve liste icini doldurdum
        {
            new Stok()
            {
                Id = 1599,
                Urun_Adi = "ASUS CELERON",
                Urun_Fiyat = "3.999",
                Marka = "ASUS",
                Stok_Durumu = "3"
            },
             new Stok()
             {
                Id = 1633,
                Urun_Adi = "MACBOOK PRO",
                Urun_Fiyat = "22.699",
                Marka = "APPLE",
                Stok_Durumu = "6"
             },
             new Stok()
             {
                Id = 7833,
                Urun_Adi = "DYNABOOK BY TOSHIBA",
                Urun_Fiyat = "6.219",
                Marka = "TOSHIBA",
                Stok_Durumu = "5"
             },
              new Stok()
             {
                Id = 6612,
                Urun_Adi = "HP G55",
                Urun_Fiyat = "6.699",
                Marka = "HP",
                Stok_Durumu = "Tükendi"
             },
              new Stok()
             {
                Id = 3092,
                Urun_Adi = "DELL VOSTRO",
                Urun_Fiyat = "18.018",
                Marka = "DELL",
                Stok_Durumu = "3"
             },
              new Stok()
             {
                Id = 4120,
                Urun_Adi = "HONOR MAGIC BOOK",
                Urun_Fiyat = "6.499",
                Marka = "HONOR",
                Stok_Durumu = "11"
             },
             new Stok()
             {
                Id = 5569,
                Urun_Adi = "HP ENVY X360",
                Urun_Fiyat = "19.482",
                Marka = "HP",
                Stok_Durumu = "1"
             },
              new Stok()
              {
                Id = 1594,
                Urun_Adi = "HUAWEI MATEBOOK",
                Urun_Fiyat = "9.499",
                Marka = "HUAWEI",
                Stok_Durumu = "2"
              },
              new Stok()
              {
                Id = 1690,
                Urun_Adi = "MACBOOK AIR",
                Urun_Fiyat = "15.599",
                Marka = "APPLE",
                Stok_Durumu = "1"
              },
              new Stok()
              {
                Id = 1024,
                Urun_Adi = "LENOVO IDEAPAD",
                Urun_Fiyat = "9.999",
                Marka = "LENOVO",
                Stok_Durumu = "Tükendi"
              },
              new Stok()
              {
                Id = 3214,
                Urun_Adi = "HP PAVILION",
                Urun_Fiyat = "11.799",
                Marka = "HP",
                Stok_Durumu = "1"
              },
              new Stok()
              {
                Id = 4001,
                Urun_Adi = "DELL VOSTRO",
                Urun_Fiyat = "9.899",
                Marka = "DELL",
                Stok_Durumu = "7"
              },
              new Stok()
              {
                Id = 7901,
                Urun_Adi = "I-LIFE ZED AIR",
                Urun_Fiyat = "2.949",
                Marka = "I-LIFE",
                Stok_Durumu = "Tükendi"
              },
               new Stok()
              {
                Id = 3901,
                Urun_Adi = "MSI PRESTIGE",
                Urun_Fiyat = "12.739",
                Marka = "MSI",
                Stok_Durumu = "4"
              },
              new Stok()
              {
                Id = 2501,
                Urun_Adi = "ACER ASPIRE",
                Urun_Fiyat = "3.599",
                Marka = "ACER",
                Stok_Durumu = "8"
              },
              new Stok()
              {
                Id = 2001,
                Urun_Adi = "ASUS ZENBOOK",
                Urun_Fiyat = "4.399",
                Marka = "ASUS",
                Stok_Durumu = "1"
              }

        };

    }
}
