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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soru1
{
    class BenimString
    {

        public int ElemanSayisi(string str)
        {
            //stringin uzunluğunu döndürüyor
            int len = 0;

            foreach (char chr in str)
            {
                len += 1;
            }

            return len;
        }

        public string Birlestir(string str1, string str2)
        {
            //iki stringi birleştirip döndürüyor
            str2 = str1 + str2;

            return str2;
        }

        public string DegerAl(string str, int start, int end)
        {
            //başlangıç ve bitiş değerlerine göre string döndürüyor

            int len = ElemanSayisi(str);

            //bitiş değeri stringin uzunluğundan büyükse hata veriyor
            if (end > len) {
                Console.WriteLine("Boyut yanlış!");
                return null;
            }

            //başlangıç değeri sıfırdan küçükse hata veriyor
            if (start < 0)
            {
                Console.WriteLine("Boyut yanlış!");
                return null;
            }

            //değerler doğruysa
            else
            {
                //temp yardımıyla aradaki stringi döndürüyor
                char[] temp = new char[len];

                int j = end - start;
                if (start != 0)
                    start=start - 1;

                for (int i = 0; i <= j; i++)
                {
                    temp[i] = str[start];
                    start++;
                }

                return new string(temp);
            }
        }

        public void ArayaGir(string str1, string str2, int index)
        {
            //ilk str1in verilen karakterinden sonra str2yi ekliyor
            string sub1 = null, sub2 = null;
            int len = 0;

            len = ElemanSayisi(str1);


            if (index <= len && index > -1)
            {
                //önceden yazdığım metotları kullandım
                sub1 = DegerAl(str1,1, index);
                sub2 = DegerAl(str1,index+1,len);

                sub1 = Birlestir(sub1, str2);
                sub1 = Birlestir(sub1, sub2);

                Console.WriteLine(sub1);
            }

            //index kontrolü
            else
                Console.WriteLine("Hata! index yanlış.");

        }
        
        public void DiziyeAyir(string str, char delim)
        {
            //verilen ayırıcı değere göre dizilere ayırıyor ve ayrılmış olan dizileri bastırıyor

            ArrayList arrayList = new ArrayList();
            string helper = null;
            int i = 0;

            while (i < ElemanSayisi(str))
            {
                if (str[i] != delim)
                {
                    if (i + 1 == ElemanSayisi(str) && str[i] != delim)
                    {
                        helper = helper + str[i];
                        arrayList.Add(helper);
                        Console.WriteLine(helper);
                    }
                    helper = helper + str[i];
                    i++;
                    continue;
                }

                arrayList.Add(helper);
                Console.WriteLine(helper);
                helper = null;
                i++;
            }
        }

        public void CharDiziyeDonustur(string str)
        {
            //stringi karakter dizisine dönüştürüp bastırıyor

            int len = 0, i = 0;

            len = ElemanSayisi(str);

            char[] char_arr = new char[len];

            for (i = 0; i < len; i++)
            {
                string cleaned = DegerAl(str, 1, 1).Replace("\0", string.Empty);
                char_arr[i] = char.Parse(cleaned);
                str = DegerAl(str, 2, len);
            }

            for (i = 0; i < len; i++)
            {
                Console.WriteLine(char_arr[i]);
            }
        }

        public void DegerIndis(string str, char c)
        {
            //verilen karaktere eşit olan tüm karakterleri bastırıyor

            int len = ElemanSayisi(str);

            for(int i = 0; i < len; i++)
            {
                if (str[i] == c)
                    Console.WriteLine("{0}. karakter", i+1);
            }
        }

        public string SiralaAZ(string str)
        {
            //temp yardımıyla karakterleri alfabetik olarak sıralıyor

            char temp;
            str = str.ToLower();

            char[] characters = str.ToArray();
            for (int i = 1; i < ElemanSayisi(str); i++)
            {
                for (int j = 0; j < ElemanSayisi(str) - 1; j++)
                {
                    if (characters[j] > characters[j + 1])
                    {
                        temp = characters[j];
                        characters[j] = characters[j + 1];
                        characters[j + 1] = temp;
                    }
                }
            }
            return new string(characters);
        }

        public string TersCevir(string str)
        {
            //stringi ters çeviriyor

            string reversestring = "";
            int len;

            len = ElemanSayisi(str) - 1;
            while (len >= 0)
            {
                reversestring = reversestring +str[len];
                len--;
            }

            return reversestring;
        }

        public string SiralaZA(string str)
        {
            //ters sıralaması için önceden yazdığım iki metodu kullandım
            str = SiralaAZ(str);
            str = TersCevir(str);

            return str;
        }
    }
}
