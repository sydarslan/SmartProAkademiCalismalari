using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1410
{
    class Program
    {
        static void Main(string[] args)
        {
            //int yas = 0;
            //string isim = "";
            //Console.WriteLine("Adınız :");
            //isim = Console.ReadLine();
            //Console.WriteLine("Yaşınız :");
            //yas = Convert.ToInt16(Console.ReadLine());
            //if (yas < 18)
            //{
            //    Console.WriteLine(isim + " Yaşınız : " + yas.ToString());
            //    Console.Write("Çocuk Reyonu sağda ...");


            //}
            //else
            //{
            //    if (yas > 18 && yas < 40)
            //    {
            //        Console.WriteLine(isim + " Yaşınız : " + yas);
            //        Console.Write("Genç Reyonu Solda ...");
            //    }
            //    else
            //    {
            //        if (yas > 40 && yas < 90)
            //        {
            //            Console.WriteLine(isim + " Yaşınız : " + yas.ToString());
            //            Console.Write("Yetişkin Reyonu İleride ...");
            //        }
            //        else
            //        {
            //            if (yas > 90)
            //            {
            //                Console.WriteLine(isim + " Yaşınız : " + yas.ToString());
            //                Console.Write("Sizin Reyonu Karacaahmet şubemizde ...");
            //            }
            //            else
            //            {
            //                Console.WriteLine(isim + " Yaşınız : " + yas.ToString());
            //                Console.Write("Size reyon kalmadı ...");
            //            }
            //        }
            //    }
            //}

            // İf ve switch**********************************************************************************************
            //Console.WriteLine("********************");
            //Console.WriteLine("*                  *");
            //Console.WriteLine("*   1- Merhaba     *");
            //Console.WriteLine("*   2- Nasılsın    *");
            //Console.WriteLine("*   3- Neredesin   *");
            //Console.WriteLine("*   4- Hoşcakal    *");
            //Console.WriteLine("*   Seçim Yapınız !*");
            //Console.WriteLine("*                  *");
            //Console.WriteLine("********************");
            //int Secim = Convert.ToInt16(Console.ReadLine());
            //if (Secim == 1)
            //{
            //    Console.WriteLine("Seçilen : " + Secim + "-Merhaba");
            //}
            //else
            //{
            //    if (Secim == 2)
            //    {
            //        Console.WriteLine("Seçilen : " + Secim + "-Nasılsın");
            //    }
            //    else
            //    {
            //        if (Secim == 3)
            //        {
            //            Console.WriteLine("Seçilen : " + Secim + "-Neredesin");
            //        }
            //        else
            //        {
            //            if (Secim == 4)
            //            {
            //                Console.WriteLine("Seçilen : " + Secim + "-Hoşcakal");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Seçilen : " + Secim + "-Saçma ........ !");
            //            }
            //        }
            //    }
            //}
            //switch (Secim)
            //{
            //    case 1:
            //        Console.WriteLine("Seçilen : " + Secim + "-Merhaba");
            //       break;
            //    case 2:

            //        Console.WriteLine("Seçilen : " + Secim + "-Nasılsın");
            //        break;
            //    case 3:
            //        Console.WriteLine("Seçilen : " + Secim + "-Neredesin");
            //        break;
            //    case 4:
            //        Console.WriteLine("Seçilen : " + Secim + "-Hoşcakal");
            //        break;

            //    default:
            //        Console.WriteLine("Seçilen : " + Secim + "-Saçma ........ !");
            //        break;
            //}
            try
            {
                Console.WriteLine("Başlangıc Sayısını Gir");
                int Baslama = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Bitiş Sayısını Gir");
                int Bitis = Convert.ToInt16(Console.ReadLine());
                if (Baslama > Bitis)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Baslama Değeri bitiş " +
                        "Değerinden büyük olamaz");
                    
                }
                else
                {
                    int Sonuc = 0;
                    for (int i = Baslama; i < Bitis; i++)
                    {
                        Console.WriteLine("Sonuç = " +
                                           Sonuc.ToString() +
                                           "+" + i + "= ");
                        Sonuc = Sonuc + i;
                        Console.Write(" " + Sonuc);
                        Console.WriteLine();
                    }
                    Console.WriteLine(Sonuc);
                }


                
            }
            catch (Exception)
            {
                Console.WriteLine("Girilen Sayı Değerlerinde Hata Var !");
                
            }
           
            Console.ReadKey();


        }
    }
}
