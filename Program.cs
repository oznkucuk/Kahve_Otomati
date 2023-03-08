using System;
using System.Threading;

namespace kahve_otomati_uygulamasi
{
    class Program
    {                                                 // 45 dakikada yapamadım :(
        static void Main(string[] args)
        {
            Console.WriteLine("*-*-* Kahve Otomatı *-*-*");

            int suhazne = 300;
            int suthazne = 200;
            int kahvehazne = 100;
            int toplampara = 0;
            int paraustu;

            Console.WriteLine("(1) Expresso");
            Console.WriteLine("(2) Latte");
            Console.WriteLine("(3) Capicino");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Lütfen para girişi yapınız..");
            Console.Write("5 TL :");
            int bestl = Convert.ToInt32(Console.ReadLine());
            Console.Write("10 TL :");
            int ontl = Convert.ToInt32(Console.ReadLine());
            int gp = ((bestl * 5) + (ontl * 10));
            int girenpara = gp;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");
            Console.WriteLine("Toplam bakiyeniz: " + girenpara);
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*");


            bool devam = true;
            while (devam)
            {
                Console.WriteLine("(1) Expresso");
                Console.WriteLine("(2) Latte");
                Console.WriteLine("(3) Capicino");
                Console.WriteLine("--------------------------");
                Console.WriteLine("(r) Raporlama");
                Console.WriteLine("(x) Çıkış");
                string giris;
                Console.WriteLine("Kahvenizi seçiniz**");
                giris = Console.ReadLine();

                if (giris == "1")//expresso
                {
                    if (girenpara >= 15)
                    {
                        if (suhazne >= 50 && kahvehazne >= 20)
                        {
                            Console.WriteLine("kahveniz hazırlanıyor");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            suhazne -= 50;
                            kahvehazne -= 20;
                            paraustu = girenpara - 15;
                            Console.WriteLine("Para üstü : " + paraustu);
                            toplampara += 15;
                            girenpara = paraustu;
                            Console.WriteLine("kahvenizi alabilirsiniz..");
                            Console.WriteLine("yeni işlem için bir tuşa basınız");
                            Console.ReadKey();
                            devam = true;
                        }
                        else
                        {
                            Console.WriteLine("Yeterli malzeme yok..");
                            devam = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz yetersiz.. İşlem sonlandırılıyor");
                        Thread.Sleep(3000);
                        devam = false;
                    }
                    Console.Clear();
                }
                else if (giris == "2")//latte
                {
                    if (girenpara >= 25)
                    {
                        if (suhazne >= 200 && kahvehazne >= 25 && suthazne >= 150)
                        {
                            Console.WriteLine("Kahveniz hazırlanıyor");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            suhazne -= 200;
                            kahvehazne -= 25;
                            suthazne -= 150;
                            toplampara += 25;
                            paraustu = girenpara - 25;
                            girenpara = paraustu;
                            Console.WriteLine("Para üstü : " + paraustu);
                            Console.WriteLine("Kahvenizi alabilirsiniz..");
                            Console.WriteLine("yeni işlem için bir tuşa basınız");
                            Console.ReadKey();
                        }
                        else
                        {
                            devam = false;
                            Console.WriteLine("Yeterli malzeme yok..");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz yetersiz.. İşlem sonlandırılıyor");
                        Thread.Sleep(3000);
                        devam = false;
                    }
                    Console.Clear();
                }
                else if (giris == "3")//capicino
                {
                    if (girenpara >= 30)
                    {
                        if (suhazne >= 250 && kahvehazne >= 25 && suthazne >= 100)
                        {
                            Console.WriteLine("kahveniz hazırlanıyor");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            suhazne -= 250;
                            kahvehazne -= 25;
                            suthazne -= 100;
                            toplampara += 30;
                            paraustu = girenpara - 30;
                            girenpara = paraustu;
                            Console.WriteLine("Para üstü : " + paraustu);
                            Console.WriteLine("kahvenizi alabilirsiniz..");
                            Console.WriteLine("yeni işlem için bir tuşa basınız");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bakiyeniz yetersiz.. İşlem sonlandırılıyor");
                        Thread.Sleep(3000);
                        devam = false;
                    }
                    Console.Clear();
                }
                else if (giris == "x")
                {
                    Console.WriteLine("çıkış yapılıyor..");
                    devam = false;
                }
                else if (giris == "r")
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("malzeme bilgisi ");
                    Console.WriteLine("Kalan süt: " + suthazne);
                    Console.WriteLine("Kalan Su:  " + suhazne);
                    Console.WriteLine("Kalan Kahve: " + kahvehazne);
                    Console.WriteLine("Toplam Kazanç: " + toplampara);
                    Console.WriteLine("********************");
                    Console.WriteLine("Ana menü için bir tuşa basınız.!");
                    Console.ReadKey();
                }
                else
                {
                    devam = false;
                    Console.WriteLine("bakiyeniz yetersiz..?");
                }
                Console.Clear();
            }

        }
    }
}
