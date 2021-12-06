using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek3
{
    class KapidaOdeme : Odeme, IOdeme
    {
        public string  MusteriAdi { get; set; }
        public string  MusteriSoyadi { get; set; }
        public string  TcNo { get; set; }
        public string  Adres { get; set; }
        public string  KuryeBilgisi { get; set; }

        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("Kapıda Ödeme --> 2");

        }

        public void OdemeYap()
        {
            Console.WriteLine("***** Teslimatı Yapan Kurye Bilgileri *****");
            KuryeBilgisi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Teslim almış olduğunuz ürününüz hasarsız mı? [E/H]");
            
            if (Console .ReadKey ().Key == ConsoleKey.E)
            {
                Console.WriteLine("Teslimat Başarılı...");
            }
            else
            {
                Console.WriteLine("Teslimat Başarısız...");
            }
        }
    }
}
