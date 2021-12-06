﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCD_OOPInterfaceOrnek3
{
    class KrediKartiOdeme : Odeme, IOdeme
    {
        public string  KartSahibiAd { get; set; }
        public string  KartSahibiSoyad { get; set; }
        public byte SonKullanimAy { get; set; }
        public int SonKullanimYili { get; set; }
        public short  CVV { get; set; }

        private string  _kartNumarasi;

        public string  KartNumarasi
        {
            get 
            { 
                return _kartNumarasi; 
            }
            set 
            {
                char[] dizi = value.ToCharArray();
                bool rakamDegilMi = false;
                foreach (var item in dizi  )
                {
                    if (!char.IsDigit (item)) //digit olmayan varsa
                    {
                        rakamDegilMi = true; //hemen yakala
                        break; //çık
                    }
                }// döngğ bitti

                if (!rakamDegilMi && value .Length ==16)
                {
                    _kartNumarasi = value;
                }
                else
                {
                    throw new FormatException("HATA : Kart numarası 16 haneli değil veya uygun formatta girilmemiştir.");
                   
                }
            }
        }

        
        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("Kredi Kartı ile Ödeme --> 1");
        }


        public void OdemeYap()
        {
            Console.Write("Kart Sahibinin Adı: ");
            KartSahibiAd = Console.ReadLine();
            Console.Write("Kart Sahibinin Adı: ");
            KartSahibiSoyad= Console.ReadLine();
            Console.Write("16 haneli kart numarasını giriniz: ");
            KartNumarasi  = Console.ReadLine();
            Console.Write("Kartınızın son kullanım ay bilgisini 1-12 arasında sayı olarak giriniz: ");
            SonKullanimAy  = Convert.ToByte(Console.ReadLine());
            Console.Write("Kartınızın son kullanım bilgilerinden yıl bilgisini 20XX formatında giriniz: ");
            SonKullanimYili =Convert .ToInt32 ( Console.ReadLine());
            Console.Write("CVV kodunu giriniz: ");
            CVV  = Convert.ToInt16 (Console.ReadLine());

            //Kart numarası boş olmamalı ve diğer özellikler de boş olmamalı encapsulation yap.
            //Bu if 'in içindeki koşulları encapsulation ile gerçekleştiriniz.
            //Biz çok vakit harcamamak için if ile yazıp  geçmek istedik.

            if (KartSahibiAd .Length >0 && KartSahibiSoyad.Length >0 && SonKullanimAy >0 && SonKullanimAy<13 && SonKullanimYili >=DateTime .Now .Year )
            {
                Console.Clear();
                Console.WriteLine($"Sayın {KartSahibiAd} {KartSahibiSoyad} {odenecekTutar} TL ödeniyor.Lütfen Bekleyiniz...");
                Random rnd = new Random();
                int bekleme = rnd.Next(3000, 5000);
                Thread.Sleep(bekleme);
                Console.WriteLine("Ödeme Alındı..");
            }


        }
    }
}
