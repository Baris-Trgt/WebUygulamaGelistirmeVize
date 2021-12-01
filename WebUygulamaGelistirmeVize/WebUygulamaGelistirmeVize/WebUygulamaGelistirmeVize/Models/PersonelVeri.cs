using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirmeVize.Models
{
    public class PersonelVeri
    //Models'ın altinda PersonelVeri adinda bir class olusturdum.
    //PersonelVeri classı Personel classından olusan bir liste vermesi icin PersonelVeri classını olusturdum.
    //PersonelVeri classı Personel classı icerigini barırındır.
    {
        public static List<Personel> Personeller = new List<Personel>()
        // List tanimlandigi tipte (Personel)  n tane veri tutar
        // Datanin degistirilmemesi ve miras alınmamasi icin static tipini kullandım
        // Personeller isimli bir liste olusturdum ve liste icini doldurdum
        {
            new Personel()
            {
                Id = 89745,
                Ad = "Metin",
                Soyad = "Turk",
                Dogum_Tarih ="01-05-1989",
                Kimlik_No = "89614525897",
                Departman_Tipi = "DEPO SORUMLUSU",
                Giris_Yil = "19-03-2010",
                Sozlesme_Bitis_Tarih = "19-03-2012"
            },
            new Personel()
            {
                Id = 88923,
                Ad = "Alper",
                Soyad = "Kurt",
                Dogum_Tarih = "12-09-1992",
                Kimlik_No = "17123596807",
                Departman_Tipi = "DEPO SORUMLUSU",
                Giris_Yil = "10-09-2015",
                Sozlesme_Bitis_Tarih = "10-09-2017"
            },
            new Personel()
            {
                Id = 99999,
                Ad = "Cenk",
                Soyad = "Yilmaz",
                Dogum_Tarih = "08-01-1980",
                Kimlik_No = "78402601702",
                Departman_Tipi = "MAGAZA MUDURU",
                Giris_Yil = "01-05-2017",
                Sozlesme_Bitis_Tarih = "01-05-2022"
            },
            new Personel()
            {
                Id = 75998,
                Ad = "Fırat",
                Soyad = "Tekin",
                Dogum_Tarih = "21-03-1989",
                Kimlik_No = "30057411078",
                Departman_Tipi = "TEKNIK SERVIS",
                Giris_Yil = "09-03-2010",
                Sozlesme_Bitis_Tarih = "09-03-2023"
            },
            new Personel()
            {
                Id = 74569,
                Ad = "Oguz",
                Soyad = "Ulusoy",
                Dogum_Tarih = "20-03-1988",
                Kimlik_No = "24102580366",
                Departman_Tipi = "TEKNIK SERVIS",
                Giris_Yil = "27-05-2009",
                Sozlesme_Bitis_Tarih = "27-05-2022"
            },
            new Personel()
            {
                Id = 96325,
                Ad = "Melisa",
                Soyad = "Yanık",
                Dogum_Tarih = "12-09-1999",
                Kimlik_No = "50725630225",
                Departman_Tipi = "KASA SORUMLUSU",
                Giris_Yil = "14-10-2020",
                Sozlesme_Bitis_Tarih = "14-10-2022"
            },
            new Personel()
            {
                Id = 95147,
                Ad = "Caner",
                Soyad = "Sonmez",
                Dogum_Tarih = "11-11-1997",
                Kimlik_No = "90662134952",
                Departman_Tipi = "KASA SORUMLUSU",
                Giris_Yil = "25-11-2021",
                Sozlesme_Bitis_Tarih = "25-11-2023"
            },
            new Personel()
            {
                Id = 84621,
                Ad = "Ece",
                Soyad = "Tekkan",
                Dogum_Tarih = "12-09-1994",
                Kimlik_No = "55470102698",
                Departman_Tipi = "SATIS SORUMLUSU",
                Giris_Yil = "29-04-2021",
                Sozlesme_Bitis_Tarih = "29-04-2023"
            },
            new Personel()
            {
                Id = 99741,
                Ad = "Cenk",
                Soyad = "Gönen",
                Dogum_Tarih = "06-05-2000",
                Kimlik_No = "19614525897",
                Departman_Tipi = "SATIS SORUMLUSU",
                Giris_Yil = "11-11-2021",
                Sozlesme_Bitis_Tarih = "11-11-2023"

            }

        };
    }
}
