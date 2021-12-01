using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirmeVize.Controllers
{
    public class PersonelController : Controller
    {
        //Listele Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde personelin altında Listele olarak olusturuldu.
        //Cunku = PersonelController altinda bu sayfayi olusturdugum icin .
        public IActionResult Listele()
        {
            return View(Models.PersonelVeri.Personeller);
            //PersonelVeri classı icerisinde Personeller listesi icerisinde olan veriyi vericektir
            //Web sayfası icerisine listeledim 
        }

        //EKle Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde personelin altında Ekle olarak olusturuldu.
        //Cunku = PersonelController altinda bu sayfayi olusturdugum icin .
        public IActionResult Ekle()
        {
            return View();
        }

        // Sayfa uzerindeki bir veriyi sayfaya kaydetmek icin kullandik
        // Sayfa icinde buton ile ilgli Post islemi yapilinca calisir
        [HttpPost]
        public IActionResult Ekle(Models.Personel yeniPersonel)//veri kismi ve method kismi
        {
            Models.PersonelVeri.Personeller.Add(yeniPersonel);//Dondurdugumuz liste icine  yeniPersonel kaydettik.
            return RedirectToAction("Listele"); // olusturdugum veriyi Listele sayfasina gonderir . Veriyi gercekte ekleyip ekleyemedigimizi gormek adina yaptik
        }


        //Guncelle Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde personelin altında Guncelle olarak olusturuldu.
        public IActionResult Guncelle(int id)//parametre degeri girdim
        {
            var guncelle = Models.PersonelVeri.Personeller.FirstOrDefault(b => b.Id == id);
            //Liste uzerinde herhangi bir Id ile kayıta konumlandim (Personeller icerisinde ozelliklere ulastim)
            return View(guncelle); // Buldugu kaydı bize dondurecek
        }


        // Sayfa uzerindeki bir veriyi sayfada guncellemek icin kullandik
        // Sayfa icinde buton ile ilgli Post islemi yapilinca calisir
        [HttpPost]
        public IActionResult Guncelle(Models.Personel personel)//Geriye tum kayitlari donecegi icin bu parametreyi girdik
        {

            var guncelleOrj = Models.PersonelVeri.Personeller.FirstOrDefault(b => b.Id == personel.Id);//Orijinal kayıtımız

            var guncelle = Models.PersonelVeri.Personeller.FirstOrDefault(b => b.Id == personel.Id);//Degistirilecek olan kayit
            // ilgili kaydı bulması icin kullandik (Personeller icerisinde ozelliklere ulastim)
            guncelle.Ad = personel.Ad; // kayda konumlandıktan sonra ilgli alani parametredeki alana esitledim 
            guncelle.Soyad = personel.Soyad;
            guncelle.Dogum_Tarih = personel.Dogum_Tarih;
            guncelle.Kimlik_No = personel.Kimlik_No;
            guncelle.Departman_Tipi = personel.Departman_Tipi;
            guncelle.Giris_Yil = personel.Giris_Yil;
            guncelle.Sozlesme_Bitis_Tarih = personel.Sozlesme_Bitis_Tarih;

            Models.PersonelVeri.Personeller.Remove(guncelleOrj); //Orijinal kaydimizi sildik.Liste icerisinden
            Models.PersonelVeri.Personeller.Add(guncelle); // Degisiklik yaptigimiz kaydi ekledik(yeni kayit gibi).Gene ayni liste icerisine

            return RedirectToAction("Listele"); 
            // olusturdugum veriyi Listele sayfasina gonderir . Veriyi gercekte ekleyip(güncelleyip) ekleyemedigimizi(güncellemedigini) gormek adina yaptik
        }


        //Detaylar Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde personelin altında Detaylar olarak olusturuldu.
        public IActionResult Detaylar(int id)//Parametre degeri girdim
        {
            var detay = Models.PersonelVeri.Personeller.FirstOrDefault(b => b.Id == id); 
            // Liste uzerinde herhangi bir Id ile kayıta konumlandim.(Personeller icerisinde ozelliklere ulastim)
            return View(detay); // Buldugu kaydı bize dondurecek

        }

        //Sil Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde personelin altında Sil olarak olusturuldu.
        public IActionResult Sil(int id)//Parametre degeri girdim
        {
            var sil = Models.PersonelVeri.Personeller.FirstOrDefault(b => b.Id == id);
            // Liste uzerinde herhangi bir Id ile kayıta konumlandim.(Personeller icerisinde ozelliklere ulastim)
            return View(sil); // Buldugu kaydı bize dondurecek
        }

        // Sayfa uzerindeki bir veriyi sayfada Silmek icin kullandik
        // Sayfa icinde buton ile ilgli Post islemi yapilinca calisir
        [HttpPost]
        public IActionResult Sil(Models.Personel personel)//Geriye tum kayitlari donecegi icin bu parametreyi girdik
        {
            var sil = Models.PersonelVeri.Personeller.FirstOrDefault(b => b.Id == personel.Id);
            // Liste uzerinde herhangi bir Id ile kayıta konumlandim.(Personeller icerisinde ozelliklere ulastim)
            Models.PersonelVeri.Personeller.Remove(sil);// parametre olarak gelen ilgili kaydi sildim
            return RedirectToAction("Listele"); // olusturdugum veriyi Listele sayfasina gonderir . Veriyi gercekte silip silmedigimizi gormek adina yaptik
        }


    }
}
