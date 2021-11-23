using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademir_N052_MetotOrnegi
{
    class Program
    {
        static int fiyat=0;
        static void Main(string[] args)
        {
        //Bu uygulama örneğimizden toplam 4 adet metot kullanmaktayız. 
        //Bu kullandığımız metotların adları ise sırası ile; yiyecek, içecek, tatlılar ve hesap işlemlerini yerine getiren metotlardır.
        //Uygulamamızı kullanan kullanıcılar uygulamayı açtıklarında karşılarına menü seçenekleri çıkıyor.
        //Bu seçeneklerin seçimine ve toplam hesap bilgilerine göre metotlarımız devreye girip hesaplıyor. 
        //Sonucu da ekrana yazdırıyor. 
        
            Console.WriteLine("***MENU****");
            Console.WriteLine("1-Yiyecekler");
            Console.WriteLine("2-İcecekler");
            Console.WriteLine("3-Tatlılar");
            int secim = Convert.ToInt32(Console.ReadLine());
        baslangıc:
            switch (secim)
            {

                case 1:
            
                yiyicekler();
                Console.WriteLine("İçecek ister misiniz ? E/H");
                string secim1= Console.ReadLine();
                    if (secim1.ToUpper() == "E")
                    {
                        secim = 2;
                        goto baslangıc;
                    }
                    else
                    {
                       Console.WriteLine("Tatlı ister misiniz ? E/H");
                       string secim2 = Console.ReadLine();
                        if (secim2.ToUpper() == "E")
                        {
                            secim = 3;
                            goto baslangıc;

                        }


                    }
                    break;

                case 2:

                    icecek();
                    Console.WriteLine("Tatlı ister misiniz ? E/H");
                    string secim3 = Console.ReadLine();
                    if (secim3.ToUpper() == "E")
                    {
                        secim = 3;
                        goto baslangıc;
                    }
                   
                    break;

                case 3:

                    tatlılar();
                    break;

            
            }
           
            hesapOde();
            Console.ReadLine();
        }
        static void yiyicekler()
        {
            Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            Console.WriteLine("1 - Et yemeği");
            Console.WriteLine("2 - Mantı");
            Console.WriteLine("3 - Tavuk");
            
            int secim=Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Et yemeğiniz hazırlanıyor");
                fiyat += 30;
            }
            else if (secim == 2)
            {
                Console.WriteLine("Mantınız hazırlanıyor");
                fiyat += 25;
            }
            else
            {
                Console.WriteLine("Tavugunuz hazırlanıyor");
                fiyat += 25;
            }
           
        }
        static void icecek()
        {
            Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
            Console.WriteLine("1 - Ayran");
            Console.WriteLine("2 - Kola");
            Console.WriteLine("3 - Limonata");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Ayranınız hazırlanıyor");
                fiyat += 5;
            }
            else if (secim == 2)
            {
                Console.WriteLine("Kolanız  hazırlanıyor");
                fiyat += 7;
            }
            else
            {
                Console.WriteLine("Limonatanız hazırlanıyor");
                fiyat += 7;
            }
            
        }
        static void tatlılar()
        {
            Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç");
            Console.WriteLine("2 - Kazandibi");
            Console.WriteLine("3 - Tavuk Göğsü");
            
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Console.WriteLine("Sütlacınız hazırlanıyor");
                fiyat += 15;
            }
            else if (secim == 2)
            {
                Console.WriteLine("Kazandibiniz hazırlanıyor");
                fiyat += 17;
            }
            else
            {
                Console.WriteLine("Tavuk gögsünüz  hazırlanıyor");
                fiyat += 16;
            }
            
        }
        static void hesapOde()
        {
            
            Console.WriteLine("Hesabınız: "+fiyat);
        }
    }
}
