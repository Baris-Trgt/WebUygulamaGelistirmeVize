using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirmeVize.Controllers
{
    public class StokController : Controller
    {
        //Durum Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde stogun altında Durum olarak olusturuldu.
        //Cunku = StokController altinda bu sayfayi olusturdugum icin .
        public IActionResult Durum()
        {
            return View(Models.StokVeri.Stoklar);
            //StokVeri classı icerisinde Stoklar listesi icerisinde olan veriyi vericektir
            //Web sayfası icerisine listeledim 
        }

        //StokEkle Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde stogun altında StokEkle olarak olusturuldu.
        //Cunku = StokController altinda bu sayfayi olusturdugum icin .
        public IActionResult StokEkle()
        {
            return View();
        }

        // Sayfa uzerindeki bir veriyi sayfaya kaydetmek icin kullandik
        // Sayfa icinde buton ile ilgli Post islemi yapilinca calisir
        [HttpPost]
        public IActionResult StokEkle(Models.Stok ekleStok)//veri kismi ve method kismi
        {
            Models.StokVeri.Stoklar.Add(ekleStok);//Dondurdugumuz liste icine  ekleStok kaydettik.
            return RedirectToAction("Durum");// olusturdugum veriyi Durum sayfasina gonderir . Veriyi gercekte ekleyip ekleyemedigimizi gormek adina yaptik
        }

        //StokGuncelle Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde stogun altında StokGuncelle olarak olusturuldu.
        public IActionResult StokGuncelle(int id)//parametre degeri girdim
        {
            var guncelle = Models.StokVeri.Stoklar.FirstOrDefault(d => d.Id == id);
            //liste uzerinde herhangi bir Id ile kayıta konumlandim (Stoklar icerisinde ozelliklere ulastim)
            return View(guncelle);// Buldugu kaydı bize dondurecek
        }

        // Sayfa uzerindeki bir veriyi sayfada guncellemek icin kullandik
        // Sayfa icinde buton ile ilgli Post islemi yapilinca calisir
        [HttpPost]
        public IActionResult StokGuncelle(Models.Stok stok)//Geriye tum kayitlari donecegi icin bu parametreyi girdik
        {
            var guncelleIlk = Models.StokVeri.Stoklar.FirstOrDefault(d => d.Id == stok.Id);//Orijinal kayıtımız
            var guncelle = Models.StokVeri.Stoklar.FirstOrDefault(d => d.Id == stok.Id);//Degistirilecek olan kayit
            guncelle.Urun_Adi = stok.Urun_Adi;// kayda konumlandıktan sonra ilgli alani parametredeki alana esitledim 
            guncelle.Urun_Fiyat = stok.Urun_Fiyat;
            guncelle.Marka = stok.Marka;
            guncelle.Stok_Durumu = stok.Stok_Durumu;

            Models.StokVeri.Stoklar.Remove(guncelleIlk);//Orijinal kaydimizi sildik.liste icerisinden
            Models.StokVeri.Stoklar.Add(guncelle); // Degisiklik yaptigimiz kaydi ekledik(yeni kayit gibi).Gene ayni liste icerisine
            return RedirectToAction("Durum");
            // olusturdugum veriyi Durum sayfasina gonderir . Veriyi gercekte ekleyip(güncelleyip) ekleyemedigimizi(güncellemedigini) gormek adina yaptik
        }

        //StokDetay adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde stogun altında StokDetay olarak olusturuldu.
        public IActionResult StokDetay(int id)//Parametre degeri girdim
        {
            var detay = Models.StokVeri.Stoklar.FirstOrDefault(d => d.Id == id);
            // Liste uzerinde herhangi bir Id ile kayıta konumlandim.(Stoklar icerisinde ozelliklere ulastim)
            return View(detay);// Buldugu kaydı bize dondurecek
        }


        //StokSil Adinda bir method olusturdum.Buradan yarattıgım sayfa  Views icerisinde stogun altında StokSil olarak olusturuldu.
        public IActionResult StokSil(int id)//Parametre degeri girdim
        {
            var sil = Models.StokVeri.Stoklar.FirstOrDefault(d => d.Id == id);
            // Liste uzerinde herhangi bir Id ile kayıta konumlandim.(Stoklar icerisinde ozelliklere ulastim)
            return View(sil);// Buldugu kaydı bize dondurecek
        }


        // Sayfa uzerindeki bir veriyi sayfada Silmek icin kullandik
        // Sayfa icinde buton ile ilgli Post islemi yapilinca calisir
        [HttpPost]
        public IActionResult StokSil(Models.Stok stok)//Geriye tum kayitlari donecegi icin bu parametreyi girdik
        {
            var sil = Models.StokVeri.Stoklar.FirstOrDefault(d => d.Id == stok.Id);
            // Liste uzerinde herhangi bir Id ile kayıta konumlandim.(Stoklar icerisinde ozelliklere ulastim)
            Models.StokVeri.Stoklar.Remove(sil);// parametre olarak gelen ilgili kaydi sildim
            return RedirectToAction("Durum");
            // olusturdugum veriyi Durum sayfasina gonderir . Veriyi gercekte silip silmedigimizi gormek adina yaptik

        }

    }
}
