using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var kisiler = new List<Kisi>();
            menuOlustur(kisiler);

            Console.ReadKey();
        }

        private static void menuOlustur(List<Kisi> kisiler)
        {
            Console.WriteLine("**********  Menü  **************");
            Console.WriteLine("*      1- Yeni Kayıt           *");
            Console.WriteLine("*      2- Kayıt Sil            *");
            Console.WriteLine("*      3- Listeyi Göster       *");
            Console.WriteLine("*      4- Çıkış                *");
            Console.WriteLine("**********  Menü  **************");
            Console.WriteLine("*****  Lütfen Seçim Yapınız ****");
            int Secim = Convert.ToInt16(Console.ReadLine());
            switch (Secim)
            {
                case 1:
                    KisiKayit(kisiler);
                    break;
                case 2:

                    Console.WriteLine("Silmek istediğiniz Tc numarasını Giriniz:");
                    string SilinecekTc = Console.ReadLine();
                    KayitSil(SilinecekTc, kisiler);

                    break;
                case 3:
                    KisileriGoster(kisiler);
                    break;
                case 4:
                    System.Environment.Exit(-1);

                    break;

                default:
                    Console.WriteLine("Menüden bir seçim yapınız ........ !");
                    menuOlustur(kisiler);
                    break;
            }
        }
        public class Kisi
        {
            public string Adi;
            public string Soyadi;
            public string Tc;

        }
        public static void KisiKayit(List<Kisi> kisiler )
        {

            for(int i=0; i < 2; i++)
            {
                Console.WriteLine("Adınızı Girin:");
                string ad = Console.ReadLine();
                Console.WriteLine("Soyadınızı Girin:");
                string soyad = Console.ReadLine();
                Console.WriteLine("Tc No  Girin:");
                string tc =Convert.ToString(Console.ReadLine());
                kisiler.Add(new Kisi { Adi = ad, Soyadi = soyad, Tc = tc });
            }
            KisileriGoster(kisiler);
        }
        public static void KisileriGoster(List<Kisi> kisiler)
        {
            bool KisiBulundu = false;
           
            foreach (var item in kisiler)
            {
                KisiBulundu = true;
                Console.WriteLine("Adı:{0},Soyadı:{1}, Tc:{2}", item.Adi, item.Soyadi, item.Tc);
            }
            if (!KisiBulundu)
            {
                Console.WriteLine("Gösterilecek kayıt bulunmadı");
            }
            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            string Devam = Console.ReadLine();
            if (Devam == "E" || Devam == "e")
            {
                menuOlustur(kisiler);
            }

        }
        public static void KayitSil(string silinecekTc, List<Kisi> kisiler)
        {
            bool KayitBulundu = false;
            for (int i = 0; i < kisiler.Count; i++)
            {
               if (kisiler[i].Tc==silinecekTc)
                {
                    KayitBulundu = true;
                    kisiler.Remove(kisiler[i]);
                }
                else
                {
                    KayitBulundu = false;
                }

            }
            if (!KayitBulundu)
            {
                Console.WriteLine(silinecekTc + " numaralı TC Bulunamadı");
            }
            KisileriGoster(kisiler);
        }
        
    }
}
 