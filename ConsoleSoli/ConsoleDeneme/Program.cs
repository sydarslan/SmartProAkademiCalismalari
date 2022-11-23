using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            var ogrList = new List<Ogrenci>();
            var notList = new List<SinavNotu>();
            menuOlustur(ogrList, notList);
            Console.ReadKey();
            // Console.ReadLine();
        }
        private static void menuOlustur(List<Ogrenci> ogrList, List<SinavNotu> notList)
        {
            Console.WriteLine("**********  Menü  **************");
            Console.WriteLine("*      1- Ögrenci Girişi           *");
            Console.WriteLine("*      2- Sınav Girişi             *");
            Console.WriteLine("*      3- Öğrenci Listesi          *");
            Console.WriteLine("*      4- Öğrenci Sınav Listesi    *");
            Console.WriteLine("*      5- Sınav Notu Değiştirme    *");
            Console.WriteLine("*      6-Çıkış                     *");
            Console.WriteLine("*      Lütfen Seçim Yapınız        *");
            int Secim = Convert.ToInt16(Console.ReadLine());
            switch (Secim)
            {
                case 1:
                    //öğrenci girişi
                    OgrenciKayit(ogrList, notList);
                    break;
                case 2:
                    //sınav girişi
                    Console.WriteLine("Sınav Notu Eklemek istediğiniz Tc numarasını Giriniz:");
                    string girilentc = Console.ReadLine();
                   // bool ogrBulundu = false;
                    for (int i = 0; i < ogrList.Count; i++)
                    {
                        if (ogrList[i].Tc == girilentc)
                        {
                           // ogrBulundu = true;
                            SinavNotuEkle(notList, ogrList, girilentc);
                        }
                        else
                        {
                          //  ogrBulundu = false;
                            Console.WriteLine("Girilen Tc için kayıt bulunmadı");
                        }
                    }
                    //if (!ogrBulundu)
                    //{
                    //    Console.WriteLine("Girilen Tc için kayıt bulunmadı");
                    //}
                    break;
                case 3:
                    //öğrenci listesi
                    ListeGoster(ogrList, notList);
                    break;
                case 4:
                    ListeGoster(ogrList, notList);

                    break;
                case 5:
                    SinavNotuDegistirme(ogrList, notList);
                    break;
                case 6:
                    System.Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("Menüden bir seçim yapınız ........ !");
                    break;
            }
        }
        class Ogrenci
        {
            public string Adi;
            public string Soyadi;
            public string Tc;
        }
        class SinavNotu
        {
            public string Tc;
            public string Vize;
            public string Final;
        }
        private static void OgrenciKayit(List<Ogrenci> ogrList,
                                         List<SinavNotu> notList)
        { 
            Console.WriteLine("Adınızı Girin:");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı Girin:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Tc No  Girin:");
            string tc = Convert.ToString(Console.ReadLine());
            ogrList.Add(new Ogrenci { Adi = ad, Soyadi = soyad, Tc = tc });
            OgrGöster(ogrList, notList);
            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            string Devam = Console.ReadLine();
            if (Devam == "E" || Devam == "e")
            {
                menuOlustur(ogrList, notList);
            }
            else
            {
                // Çıkış
            } 
        }
        private static void OgrGöster(List<Ogrenci> ogrList, List<SinavNotu> notList)
        {
            bool ogrBulundu = false;

            foreach (var item in ogrList)
            {
                ogrBulundu = true;
                Console.WriteLine("Adı:{0},Soyadı:{1}, Tc:{2}", item.Adi, item.Soyadi, item.Tc);
            }
            if (!ogrBulundu)
            {
                Console.WriteLine("Gösterilecek kayıt bulunmadı");
            }
            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            string Devam = Console.ReadLine();
            if (Devam == "E" || Devam == "e")
            {
                menuOlustur(ogrList, notList);
            }
            else
            {
                //
            }
        }
        private static void SinavNotuEkle(List<SinavNotu> notList, List<Ogrenci> ogrList, string GTc)
        {

               // string girilentc = GTc;
                Console.WriteLine("Vize Notunu Girin:");
                string vize = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Final Notunu Girin:");
                string final = Console.ReadLine();
                notList.Add(new SinavNotu { Tc = GTc, Vize = vize, Final = final });
          

            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            string Devam = Console.ReadLine();
            if (Devam == "E" || Devam == "e")
            {
                menuOlustur(ogrList, notList);
            }
        }

        private static void ListeGoster(List<Ogrenci> ogrList, List<SinavNotu> notList)
        {
            bool NotVarYok = false;
            foreach (var item in ogrList)
            {
                if (ogrList.Count > 0)
                {
                    foreach (var items in notList)
                    {
                        if (notList.Count > 0)
                        {
                           
                            if (items.Tc == item.Tc)
                            {
                                NotVarYok = true;
                                Console.WriteLine("Adı:{0},Soyadı:{1}, Tc:{2}, Vize:{3}, Final:{4} ", item.Adi, item.Soyadi, item.Tc, items.Vize, items.Final);
                            }
                            else
                            {
                                NotVarYok = false;
                                Console.WriteLine("Adı:{0},Soyadı:{1}, Tc:{2}, Vize:{3}, Final:{4} ", item.Adi, item.Soyadi, item.Tc, 0, 0);
                            }
                           
                        }
                         
                       
                    }
                    if (NotVarYok == false)
                    {
                        Console.WriteLine("Listelenecek Sınav Bulunamadı");
                        Console.WriteLine("Adı:{0},Soyadı:{1}, Tc:{2}, Vize:{3}, Final:{4} ", item.Adi, item.Soyadi, item.Tc, 0, 0);
                    }
                   

                }
                else
                {
                  //  Console.WriteLine("Adı:{0},Soyadı:{1}, Tc:{2}, Vize:{3}, Final:{4} ", item.Adi, item.Soyadi, item.Tc, 0, 0);
                }
               

            }
            Console.WriteLine("Devam etmek istiyor musunuz ? (E/H)");
            string Devam = Console.ReadLine();
            if (Devam == "E" || Devam == "e")
            {
                menuOlustur(ogrList, notList);
            }
        }
        private static void SinavNotuDegistirme(List<Ogrenci> ogrList, List<SinavNotu> notList)
        {
            if (ogrList.Count > 0)
            {
                ListeGoster(ogrList, notList);
                Console.WriteLine("Değiştireceğiniz Sınav Notunı Seçiniz");
                string Dtc = Console.ReadLine();
                Console.WriteLine("Vize Notunu Girin:");
                string Yvize = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Final Notunu Girin:");
                string Yfinal = Console.ReadLine();
                for (int i = 0; i < notList.Count; i++)
                {
                    if (notList[i].Tc == Dtc)
                    {
                        notList.Remove(notList[i]);
                    }
                }
                notList.Add(new SinavNotu { Tc = Dtc, Vize = Yvize, Final = Yfinal });

            }
            else
            {
                Console.WriteLine("Değiştirilecek Kayıt Bulunamadı");
                menuOlustur(ogrList, notList);
            }
           

        }



    }
}
