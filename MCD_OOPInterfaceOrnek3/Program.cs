using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek3
{
    class Program
    {
        static void Main(string[] args)
        {
            KrediKartiOdeme krediKartiIleOdeme = new KrediKartiOdeme();
            KapidaOdeme kapidaOdeme = new KapidaOdeme();
            FastPayOdeme fastPayOdeme = new FastPayOdeme();
            List<KeyValuePair<byte, IOdeme>> OdemeTuruListesi = new List<KeyValuePair<byte, IOdeme>>()
            {
                new KeyValuePair<byte, IOdeme> (1,krediKartiIleOdeme ),
                new KeyValuePair<byte, IOdeme> (2,kapidaOdeme  ),
                new KeyValuePair<byte, IOdeme> (3,fastPayOdeme  )
            };

            foreach (var item in OdemeTuruListesi )
            {
                item.Value.OdemeSekliAyariYap();
            }
            int secim = Convert.ToInt32(Console.ReadLine());
            OdemeTuruListesi[secim - 1].Value.OdemeYap();

            //switch (secim )
            //{
            //    case 1:
            //        krediKartiIleOdeme.OdemeTutariniKullanicidanAl();
            //        krediKartiIleOdeme.OdemeYap();
            //        break;
            //    case 2:
            //        kapidaOdeme.OdemeTutariniKullanicidanAl();
            //        kapidaOdeme .OdemeYap();
            //        break;
            //    case 3:
            //        fastPayOdeme .OdemeTutariniKullanicidanAl();
            //        fastPayOdeme .OdemeYap();
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı seçim!!");
            //        break;

                 
            //}

            Console.ReadKey();
        }
    }
}
