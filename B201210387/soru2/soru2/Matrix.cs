/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**			   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					  2020-2021 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2. ÖDEV SORU 2
**				ÖĞRENCİ ADI............: ALEYNA ELİF ÖZKAN
**				ÖĞRENCİ NUMARASI.......: B201210387
**              DERSİN ALINDIĞI GRUP...: 1-C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru2
{
    static class Matrix
    {
         // buttonlar teker teker kapatıp açıldığında  çalışıyor 
         // aynı anda hepsi çalışmıyor
         
        static Random rnd = new Random();
        internal static int size = rnd.Next(2, 5);
        //boyutu random belirliyor

        //3 tane matrix oluşturuyor
        internal static int[,] matrix1 = new int[size, size];
        internal static int[,] matrix2 = new int[size, size];
        internal static int[,] matrix3 = new int[size, size];

        //location için helper değişken
        internal static int left = 0;
        internal static int left1 = 0;

        internal static int [,] RandomMatrix(int[,] matrix)
        {
            //matrixleri random doldurup geri döndürüyor
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rnd.Next(1, 25);
                }
            }
            return matrix;

        }

        internal static int[,] toplama()
        {
            //toplama yapıp matrixi geri döndürüyor
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix3[i, j] = Matrix.matrix1[i, j] + Matrix.matrix2[i, j];
                }
            }
            return matrix3;

        }

        internal static int[,] carpma()
        {
            //çarpma yapıp matrixi geri döndürüyor
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix3[i, j] = 0;
                    for (int k = 0; k < size; k++)
                    {
                        matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return matrix3;

        }


        internal static int[,] transpoze(int [,] matrix)
        {
            //transpoze hesaplayıp matrixi geri döndürüyor
            for (int i = 0; i < size; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    matrix3[i,k] =matrix[k, i];
                }
            }

            return matrix3;

        }

        internal static int iz(int[,] matrix)
        {
            //izi hesaplayıp matrixi geri döndürüyor
            int res = 0;

            for (int i = 0; i < size; i++)
                res += matrix[i, i];

            return res;
        }

    }
}
