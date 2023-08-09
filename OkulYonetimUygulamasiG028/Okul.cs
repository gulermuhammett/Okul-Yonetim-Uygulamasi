using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasiG028
{
    class Okul
    {

        public List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        public void OgrenciEkle(int no, string ad, string soyad, DateTime dogumtarihi, Ogrenci.CINSIYET cinsiyet, Ogrenci.SUBE sube)
        {
            //Bütün kontroller yapılmış olmalı...

            Ogrenci o = new Ogrenci();
            o.No = no;
            o.Ad = ad;
            o.Soyad = soyad;

            #region Muhammet
            o.DogumTarihi = dogumtarihi;
            o.Cinsiyet = cinsiyet;
            o.Sube = sube;

            #endregion
            //
            //
            this.Ogrenciler.Add(o);
        }

        public void NotEkle(int no, string ders, int not)
        {
            //bu noya sahip bir öğrenci olduğundan ve verilerin doğruluğundan eminiz...
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            DersNotu dn = new DersNotu(ders, not);

            o.Notlar.Add(dn);
        }

        public void AdresEkle(int no, string il, string ilce, string mahalle)
        {
            //bu noya sahip bir öğrenci olduğundan ve verilerin doğruluğundan eminiz...
            Ogrenci o = this.Ogrenciler.Where(a => a.No == no).FirstOrDefault();

            o.Adres.Il = il;
            o.Adres.Ilce = ilce;
            o.Adres.Mahalle = mahalle;

        }

        #region Muhammet
        public List<Ogrenci> TumOgrenciListesiGetir()
        {
            List<Ogrenci> ogrenci = this.Ogrenciler;
            return ogrenci;
        }
        public List<Ogrenci> CinsiyeteGoreOgrenciListesiGetir()
        {
            List<Ogrenci> ogrenci = this.Ogrenciler;
            List<Ogrenci> ogrenciList = new List<Ogrenci>();
            while (true)
            {
                Console.Write("Listelemek istediğiniz cinsiyeti girin (K/E): ");
                string sube = Console.ReadLine();

                switch (sube.ToUpper())
                {
                    case "E":
                        ogrenciList = ogrenci.Where(item => item.Cinsiyet == Ogrenci.CINSIYET.Erkek).ToList();
                        break;
                    case "K":
                        ogrenciList = ogrenci.Where(item => item.Cinsiyet == Ogrenci.CINSIYET.Kiz).ToList();
                        break;

                    default:
                        Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                        continue;
                }
                return ogrenciList;
            }


                

        }

        public List<Ogrenci> SubeyeGoreOgrenciListesiGetir()
        {
            List<Ogrenci> ogrenci = this.Ogrenciler;
            List<Ogrenci> ogrenciList = new List<Ogrenci>();
            while (true)
            {
                Console.Write("Listelemek istediğiniz şubeyi girin (A/B/C): ");
                string sube = Console.ReadLine();

                switch (sube.ToUpper())
                {
                    case "A":
                        ogrenciList = ogrenci.Where(item => item.Sube == Ogrenci.SUBE.A).ToList();
                        break;
                    case "B":
                        ogrenciList = ogrenci.Where(item => item.Sube == Ogrenci.SUBE.B).ToList();
                        break;
                    case "C":
                        ogrenciList = ogrenci.Where(item => item.Sube == Ogrenci.SUBE.C).ToList();
                        break;

                    default:
                        Console.WriteLine("Hatali giris yapildi. Tekrar deneyin");
                        continue;
                }
                return ogrenciList;
            }


       

        }

       
        #endregion

    }
}
