/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					  2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2. ÖDEV SORU 1
**				ÖĞRENCİ ADI............: ALEYNA ELİF ÖZKAN
**				ÖĞRENCİ NUMARASI.......: B201210387
**              DERSİN ALINDIĞI GRUP...: 1-C
****************************************************************************/

using System;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            //test dosyası

            int arayaGir = 5;
            int degerAl1 = 2, degerAl2 = 5;
            char diziyeAyir = 'n';
            char degerIndis = 'a';

            BenimString Obj1 = new BenimString();

            string STR1 = "aleyna";
            string STR2 = "elif";

            Console.Write("String'in eleman sayısı: {0}\n\n", Obj1.ElemanSayisi(STR1));

            Console.WriteLine("String'leri birleştir: " + Obj1.Birlestir(STR1, STR2));
            Console.WriteLine("");

            Console.Write("String'in {0}. karakterden sonra araya gir: ",arayaGir);

            Obj1.ArayaGir(STR1, STR2, arayaGir);
            Console.WriteLine("");

            Console.WriteLine("String'i alfabetik sırala: " + Obj1.SiralaAZ(STR1));
            Console.WriteLine("");

            Console.WriteLine("String'i ters çevir: " + Obj1.TersCevir(STR1));
            Console.WriteLine("");

            Console.WriteLine("String'i alfabenin tersine göre sırala: " + Obj1.SiralaZA(STR1));
            Console.WriteLine("");

            Console.WriteLine("String'i karakter arrayine çevir: ");
            Obj1.CharDiziyeDonustur(STR1);
            Console.WriteLine("");

            Console.Write("{0}. ve {1}. karakterler arasını geri döndür: ", degerAl1,degerAl2);
            Console.WriteLine(Obj1.DegerAl(STR1,degerAl1,degerAl2));
            Console.WriteLine("");

            Console.WriteLine("String'i {0} karakterine  göre dizilere ayır: ",diziyeAyir); 
            Obj1.DiziyeAyir(STR1,diziyeAyir);
            Console.WriteLine("");

            Console.WriteLine("String'inde {0} karakterinin görüldüğü karakter sayıları: ", degerIndis);
            Obj1.DegerIndis(STR1,degerIndis);
            
        }
    }
}
