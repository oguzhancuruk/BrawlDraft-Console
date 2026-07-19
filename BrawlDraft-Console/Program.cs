using System;
using System.Collections.Generic;

namespace BrawlDraft_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int toplamskor = 0;

            List<string> haritalar = new List<string>
            {
                "Savaş topu (Arka Bahçe)",
                "Elmas Kapmaca (Kristal Pasaj)",
                "Hesaplaşma (Fırtınalı Çayır)"
            };

            List<string> rakipler = new List<string>
            {
                "Leon",
                "Edgar",
                "Mortis"
            };

            Console.WriteLine("BRAWL STARS DRAFT SİMÜLATÖRÜNE HOŞGELDİNİZ.");

            string secilenHarita = haritalar[rastgele.Next(haritalar.Count)];
            string secilenRakip = rakipler[rastgele.Next(rakipler.Count)];

            Console.WriteLine($"Seçilen Harita: {secilenHarita}");
            Console.WriteLine($"Rakip Seçimi: RAKİP {secilenRakip.ToUpper()} ALDI!");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Sen hangi karakteri seçeceksin?");
            Console.WriteLine("1 - Shelly");
            Console.WriteLine("2 - Piper");
            Console.WriteLine("3 - Colt");
            Console.Write("Seçiminiz 1-3: ");
            string? secim = Console.ReadLine();

            Console.WriteLine(" \n MAÇ SONUCU");

            if (secim == "1")
            {
                Console.WriteLine("Seçimin: Shelly");
                if (secilenRakip == "Edgar" || secilenRakip == "Mortis")
                {
                    Console.WriteLine($"Harika seçim! Shelly yakın mesafede {secilenRakip} karakterinden daha güçlüdür.)");
                    toplamskor += 100;
                }
                else
                {
                    Console.WriteLine("Ortalama seçim. Leon uzaktan daha iyidir shelly ise yakından.");
                    toplamskor += 50;
                }
            }
            else if (secim == "2")
            {
                Console.WriteLine("Seçimin: Piper");
                if (secilenHarita.Contains("Arka Bahçe"))
                {
                    Console.WriteLine("Müthiş Seçim! Açık haritada Piper çok güçlüdür.");
                    toplamskor += 100;
                }
                else
                {
                    Console.WriteLine("Kötü Seçim. Piper kapalı/duvarlı haritalarda zayıftır.");
                    toplamskor += 20;
                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("Seçimin: Colt");
                Console.WriteLine("Güvenli Seçim. Düzgün nişan alırsan her haritada iş yapar");
                toplamskor += 60;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim yaptın, pas geçildi!");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Draft puanınız: {toplamskor} / 100");

            if (toplamskor >= 100)
            {
                Console.WriteLine("MÜKEMMEL DRAFT! Maçı kesin kazandın.");
            }
            else if (toplamskor >= 50)
            {
                Console.WriteLine("İYİ DRAFT. Kazanma şansın yüksek.");
            }
            else
            {
                Console.WriteLine("KÖTÜ DRAFT. Kazanma ihtimalin düşük.");
            }

            Console.ReadKey();

        }
    }
}