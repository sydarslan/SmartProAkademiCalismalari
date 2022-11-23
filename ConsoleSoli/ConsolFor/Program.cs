using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolFor
{
    class Program
    {
        public int a = 5;

        private static void carpma(double sayi1, double sayi2)
        {
            Console.WriteLine(sayi1 + "*" + sayi2 + "=" + sayi1 * sayi2);


        }
        static void Main(string[] args)
        {
            //    int D1 = -1;
            //    int D2 = -1;
            //    int D3 = -1;
            //    int[] Dizi1 = { 2, 4, 6, 8, 9 };
            //    int[] Dizi2 = { 1, 3, 5, 7, 0 };
            //    for (int i = 0; i < 5; i++)
            //    {
            //        D1 = Dizi1[i];
            //         Console.WriteLine("Dizi 1:" + i + "Elemanı = " + Dizi1[i]);
            //        Console.WriteLine("------------------------");
            //        for (int j = 0; j < 5; j++)
            //        {
            //            D2 = Dizi2[j];
            //            Console.WriteLine("D1: " + D1 + " D2: " +D2 + " D1*D2= " +  D1 * D2);
            //        }
            //        Console.WriteLine("*************************");



            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// While 
            ///
            //int Sayi = 0;

            // Kullanıcı Tarafından 5 Girilene kadar döner 
            //while (Sayi != 5)
            //{
            //    Console.WriteLine("Sayı Giriniz !");
            //    Sayi= Convert.ToInt16(Console.ReadLine()); 
            //}
            //Console.WriteLine("Girilen Sayı = " + Sayi);
            //Console.WriteLine("Kaça Kadar ?");
            //int Sayi = Convert.ToInt16(Console.ReadLine());
            //int i = 0;
            //while (i < Sayi)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} 


            //Random Tut = new Random();
            //int Tutulan = Tut.Next(1 , 50);
            //int Girilen = 0;

            //while (Girilen != Tutulan)
            //{
            //    Console.WriteLine("Bir Sayı Giriniz");
            //    Girilen = Convert.ToInt16(Console.ReadLine());
            //    if (Girilen < Tutulan)
            //    {
            //        Console.WriteLine("Daha Büyük Bir Sayı girin");

            //    }
            //    else if (Girilen > Tutulan)
            //    {
            //        Console.WriteLine("Daha küçük Bir Sayı girin");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Buldunuz");
            //    }
            //}


            //Console.WriteLine("Menu");
            //Console.WriteLine("1- Topla");
            //Console.WriteLine("2- Çarp");
            //Console.WriteLine("3- Böl");
            //Console.WriteLine("İşlem Seçiniz");
            //int Sec = Convert.ToInt16(Console.ReadLine());

            //while ((Sec == 1) || (Sec == 2) || (Sec == 3))
            //{
            //    switch (Sec)
            //    {
            //        case 1:

            //           double Sonuc = topla(Sayi1, Sayi2);
            //           Console.WriteLine(Sayi1+ "+" + Sayi2 + "=" + Sonuc);
            //            Sec = 0;
            //            break;
            //        case 2:
            //            // Sonuç Dönmeyecek ...

            //            carpma(Sayi1, Sayi2);
            //            Sec = 0; 
            //            break;
            //        default:
            //            Console.WriteLine("Menu");
            //            Console.WriteLine("1- Topla");
            //            Console.WriteLine("2- Çarp");
            //            Console.WriteLine("3- Böl");
            //            Console.WriteLine("İşlem Seçiniz");
            //            Sec = Convert.ToInt16(Console.ReadLine());
            //            break;
            //    }
            //}

            MenuOlustur();

            Console.ReadKey();



        }


        private static void MenuOlustur()
        {
            Console.WriteLine("1. Sayıyı Giriniz");
            double Sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2. Sayıyı Giriniz");
            double Sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Menu");
            Console.WriteLine("1- Topla");
            Console.WriteLine("2- Çarp");
            Console.WriteLine("3- Böl");
            Console.WriteLine("İşlem Seçiniz");
            int Sec = Convert.ToInt16(Console.ReadLine());
            secilenislem(Sec, Sayi1, Sayi2);

        }

        private static void secilenislem(int sec, double s1, double s2)
        {


            switch (sec)
            {
                case 1:
                    double Sonuc = topla(s1, s2);
                    Console.WriteLine(s1 + "+" + s2 + "=" + Sonuc);
                    Console.WriteLine("Tekrar Etmek İster misiniz ? (E/H)");
                    string EH = Console.ReadLine();
                    if (EH == "E" || EH == "e")
                    {
                        MenuOlustur();

                    }
                    else
                    {
                        Console.WriteLine("Teşekkürler ...");
                    }

                    break;
                case 2:
                    // Sonuç Dönmeyecek ...

                    carpma(s1, s2);
                    Console.WriteLine("Tekrar Etmek İster misiniz ? (E/H)");
                    EH = Console.ReadLine();
                    if (EH == "E" || EH == "e")
                    {
                        MenuOlustur();

                    }
                    else
                    {
                        Console.WriteLine("Teşekkürler ...");
                    }


                    break;
                default:
                    MenuOlustur();
                    break;
            }
        }

        public static double topla(double s1, double s2)
        {
            double son = s1 + s2;
            return (son);

        }
    }



}
