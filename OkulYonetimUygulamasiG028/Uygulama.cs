using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasiG028
{
    class Uygulama
    {
        public Okul Okul = new Okul();

        public void Calistir()
        {
            SahteVeriGir();
            MenuYazdir();
            while (true)
            {
               
                string secim = SecimAl();
                Console.WriteLine();
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("1-Bütün Ögrencileri Listele ".PadRight(100, '-'));

                        Console.WriteLine();
                        OgrencileriListele(Okul.TumOgrenciListesiGetir());                      
                       
                        break;
                    case "2":
                        Console.WriteLine("2-Subeye Göre Ögrencileri Listele ".PadRight(100, '-'));
                        OgrencileriListele(Okul.CinsiyeteGoreOgrenciListesiGetir()); 
                        break;
                    case "3":
                        Console.WriteLine("3-Cinsiyete Göre Öğrencileri Listele ".PadRight(100, '-'));
                        OgrencileriListele(Okul.SubeyeGoreOgrenciListesiGetir());
                        break;
                    case "4":
                        Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele ".PadRight(100, '-'));
                        break;
                    case "5":
                        Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele ".PadRight(100, '-'));
                        break;
                    case "6":
                        Console.WriteLine("6 - Öğrencinin tüm notlarını listele ".PadRight(100, '-'));
                        break;
                    case "7":
                        Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele ".PadRight(100, '-'));
                        break;
                    case "8":
                        Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele ".PadRight(100, '-'));
                        break;
                    case "9":
                        Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele ".PadRight(100, '-'));
                        break;
                    case "10":
                        Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele ".PadRight(100, '-'));
                        break;
                    case "11":
                        Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele ".PadRight(100, '-'));
                        break;
                    case "12":
                        Console.WriteLine("12 - Öğrencinin not ortalamasını gör ".PadRight(100, '-'));
                        break;
                    case "13":
                        Console.WriteLine("13 - Şubenin not ortalamasını gör ".PadRight(100, '-'));
                        break;
                    case "14":
                        Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör ".PadRight(100, '-'));
                        break;
                    case "15":
                        Console.WriteLine("15 - Öğrenci ekle ".PadRight(100, '-'));
                        break;
                    case "16":

                        Console.WriteLine("16 - Öğrenci güncelle ".PadRight(100, '-'));
                        break;
                    case "17":
                        Console.WriteLine("17 - Öğrenci sil ".PadRight(100, '-'));

                        break;
                    case "18":
                        Console.WriteLine("18 - Öğrencinin adresini gir ".PadRight(100, '-'));

                        break;
                    case "19":

                        Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir ".PadRight(100, '-'));
                        break;
                    case "20":
                        Console.WriteLine("20 - Öğrencinin notunu gir ".PadRight(100, '-'));
                        break;
                    case "LİSTE":
                        MenuYazdir();
                        break;
                    case "ÇIKIŞ":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Hatalı islem gerçeklestirildi. Tekrar deneyin.");
                        break;


                }

            }
           


        }

      

        public void NotGir()
        {

            Console.WriteLine("20-Not Gir -----------------------------------------------");

            Console.Write("Öğrencinin Numarası: ");
            int no = int.Parse(Console.ReadLine());
            //sayı al methodu...

            Console.WriteLine("Not eklemek istediğiniz ders: ");
            //yazı al...
            string ders = Console.ReadLine();
            Console.WriteLine("Eklemek istediğiniz not adedi...");
            int adet = int.Parse(Console.ReadLine());

            for (int i = 1; i <= adet; i++)
            {
                Console.Write(i + ". Notu Girin: ");
                int not = int.Parse(Console.ReadLine());

                Okul.NotEkle(no, ders, not);
            }

        }

        public void SahteVeriGir()
        {

            Okul.OgrenciEkle(1, "Elif", "Selçuk", new DateTime(2009, 7, 9), Ogrenci.CINSIYET.Kiz, Ogrenci.SUBE.C);
            Okul.OgrenciEkle(2, "Yunus", "Emre", new DateTime(1975, 8, 27), Ogrenci.CINSIYET.Erkek, Ogrenci.SUBE.A);
            Okul.OgrenciEkle(3, "Ayşe", "Fatma", new DateTime(2008, 4, 4), Ogrenci.CINSIYET.Kiz, Ogrenci.SUBE.B);
            #region Muhammet
            Okul.OgrenciEkle(4, "Betül", "Yılmaz", new DateTime(1991, 8, 5), Ogrenci.CINSIYET.Kiz, Ogrenci.SUBE.A);
            Okul.OgrenciEkle(5, "Hakan", "Çelik", new DateTime(2000, 7, 19), Ogrenci.CINSIYET.Erkek, Ogrenci.SUBE.C);
            Okul.OgrenciEkle(6, "Keram", "Akay", new DateTime(2005, 9, 25), Ogrenci.CINSIYET.Erkek, Ogrenci.SUBE.B);
            Okul.OgrenciEkle(7, "Hatice", "Çınar", new DateTime(2004, 10, 9), Ogrenci.CINSIYET.Kiz, Ogrenci.SUBE.B);
            Okul.OgrenciEkle(8, "Selim", "İleri", new DateTime(2009, 5, 9), Ogrenci.CINSIYET.Erkek, Ogrenci.SUBE.A);
            Okul.OgrenciEkle(9, "Selin", "Kamış", new DateTime(1991, 5, 2), Ogrenci.CINSIYET.Kiz, Ogrenci.SUBE.C);
            Okul.OgrenciEkle(10, "Sinan", "Avcı", new DateTime(2003, 3, 14), Ogrenci.CINSIYET.Erkek, Ogrenci.SUBE.B);
            Okul.OgrenciEkle(11, "Deniz", "Çoban", new DateTime(2009, 6, 22), Ogrenci.CINSIYET.Erkek, Ogrenci.SUBE.C);
            Okul.OgrenciEkle(12, "Selda", "Kavak", new DateTime(2009, 7, 9), Ogrenci.CINSIYET.Kiz, Ogrenci.SUBE.C);

            Okul.NotEkle(1, "Matematik", 90);
            Okul.NotEkle(1, "Turkce", 50);

            Okul.NotEkle(3, "Fizik", 85);
            Okul.NotEkle(3, "Fizik", 45);

            #endregion
        }
        #region Muhammet
       public void MenuYazdir()

        {

            Console.WriteLine("------  Okul Yönetim Uygulamasi  -----             ");
            Console.WriteLine("");
            Console.WriteLine("1 - Bütün öğrencileri listele                      ");
            Console.WriteLine("2 - Şubeye göre öğrencileri listele                ");
            Console.WriteLine("3 - Cinsiyetine göre öğrencileri listele           ");
            Console.WriteLine("4 - Şu tarihten sonra doğan öğrencileri listele    ");
            Console.WriteLine("5 - İllere göre sıralayarak öğrencileri listele    ");
            Console.WriteLine("6 - Öğrencinin tüm notlarını listele               ");
            Console.WriteLine("7 - Öğrencinin okuduğu kitapları listele           ");
            Console.WriteLine("8 - Okuldaki en yüksek notlu 5 öğrenciyi listele   ");
            Console.WriteLine("9 - Okuldaki en düşük notlu 3 öğrenciyi listele    ");
            Console.WriteLine("10 - Şubedeki en yüksek notlu 5 öğrenciyi listele  ");
            Console.WriteLine("11 - Şubedeki en düşük notlu 3 öğrenciyi listele   ");
            Console.WriteLine("12 - Öğrencinin not ortalamasını gör               ");
            Console.WriteLine("13 - Şubenin not ortalamasını gör                  ");
            Console.WriteLine("14 - Öğrencinin okuduğu son kitabı gör             ");
            Console.WriteLine("15 - Öğrenci ekle                                  ");
            Console.WriteLine("16 - Öğrenci güncelle                              ");
            Console.WriteLine("17 - Öğrenci sil                                   ");
            Console.WriteLine("18 - Öğrencinin adresini gir                       ");
            Console.WriteLine("19 - Öğrencinin okuduğu kitabı gir                 ");
            Console.WriteLine("20 - Öğrencinin notunu gir                         ");

            Console.WriteLine("");
            Console.WriteLine("Çıkış yapmak için 'çıkış' yazıp 'enter' a basın.");
         
        }

        public string SecimAl()
        {
            Console.WriteLine();
            Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            return Console.ReadLine().ToUpper();
        }

        public void OgrencileriListele(List<Ogrenci> liste)
        {
            if (liste.Count > 0)
            {              
                Console.WriteLine("Sube".PadRight(14) + "No".PadRight(12) + "Adı".PadRight(6) + "Soyadı".PadRight(20)
                    + "Not Ort.".PadRight(20) + "Okuduğu Kitap Say.".PadLeft(10));
                Console.WriteLine("".PadRight(100, '-'));
                foreach (Ogrenci item in liste)
                {

                    Console.WriteLine(item.Sube.ToString().PadRight(14) + item.No.ToString().PadRight(12)
                        + item.Ad.PadRight(6) + item.Soyad.PadRight(20) + item.Ortalama.ToString().PadRight(20)
                        + item.Kitaplar.Count);

                }
                  Console.WriteLine();
                Console.WriteLine("Menüyü tekrar listelemek için 'liste', çıkıs yapmak için 'çıkıs' yazın.");
            }
        }

        #endregion

    }
}
