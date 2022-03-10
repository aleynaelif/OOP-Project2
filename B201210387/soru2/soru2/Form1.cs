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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void  Form1_Load(object sender, EventArgs e)
        {
            Matrix.matrix1 = Matrix.RandomMatrix(Matrix.matrix1);
            Matrix.matrix2 = Matrix.RandomMatrix(Matrix.matrix2);
            // matrixleri random dolduruyor

            Matrix.left = matrix(Matrix.matrix1, Matrix.size, Matrix.left)+ 100;
            Matrix.left = Matrix.left + matrix(Matrix.matrix2, Matrix.size, Matrix.left);
            //matrix içeriğini button olarak bastırıyor   

        }


        private int matrix(int[,] matrix, int matrixSize, int location)
        {
            int i, j;

            Button[,] buttons = new Button[matrixSize, matrixSize];
            int top = 0;
            int left = 0;
            int newSize = 20;

            //her elemanı button olarak  bastıran metot

            for (i = 0; i < matrixSize; i++)
            {
                for (j = 0; j < matrixSize; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 100;
                    buttons[i, j].Height = 100;
                    buttons[i, j].Left = left + location;
                    buttons[i, j].Top = top;
                    left += 100;
                    buttons[i, j].Font = new Font(buttons[i, j].Font.FontFamily, newSize);
                    buttons[i, j].Text = matrix[i, j].ToString();
                    this.Controls.Add(buttons[i, j]);

                }
                left = 0;
                top += 100;
            }
            return matrixSize * 100;
        }

      
        private void yazdirma_Click(object sender, EventArgs e)
        {
            //yapamadım
        }

        private void toplama_Click(object sender, EventArgs e)
        {
            //toplama yapıp bastırıyor
            Matrix.matrix3 = Matrix.toplama();
            Matrix.left1 = Matrix.left + matrix(Matrix.matrix3, Matrix.size, Matrix.left + 100);
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            //çarpma yapıp bastırıyor
            Matrix.matrix3 = Matrix.carpma();
            Matrix.left1 = Matrix.left + matrix(Matrix.matrix3, Matrix.size, Matrix.left +100 );
        }

        private void okuma_Click(object sender, EventArgs e)
        {
            //yapamadım
        }

        private void ters_Click(object sender, EventArgs e)
        {
            //yapamadım
        }

        private void iz_Click(object sender, EventArgs e)
        {
            //izleri bulup ayrı ayrı bastırıyor

            //ilk matrixin izi
            int iz1 = Matrix.iz(Matrix.matrix1);
            int newSize = 20;

            Button button = new Button();
            button.Left = Matrix.left + 100;
            button.Width = 100;
            button.Height = 100;
            button.Font = new Font(button.Font.FontFamily, newSize);
            button.Text = iz1.ToString();
            this.Controls.Add(button);

            //ilk matrixin labelı
            Label namelabel = new Label();
            namelabel.Location = new Point(Matrix.size * 100 * 2 + 200, 100);
            namelabel.Text = "iz 1";
            this.Controls.Add(namelabel);
            namelabel.AutoSize = true;

            //ikinci matrixin izi 
            int iz2 = Matrix.iz(Matrix.matrix2);

            Button button1 = new Button();
            button1.Left = Matrix.left + 300;
            button1.Width = 100;
            button1.Height = 100;
            button1.Font = new Font(button1.Font.FontFamily, newSize);
            button1.Text = iz2.ToString();
            this.Controls.Add(button1);

            //ikinci matrixin labelı
            Label namelabel1 = new Label();
            namelabel1.Location = new Point(Matrix.size * 100 * 2 + 400, 100);
            namelabel1.Text = "iz 2";
            this.Controls.Add(namelabel1);
            namelabel1.AutoSize = true;

        }

        private void transpoze_Click(object sender, EventArgs e)
        {
            //transpoze hesaplayıp buttonlarla ekrana basıyor 
            Matrix.matrix3 = Matrix.transpoze(Matrix.matrix1);
            Matrix.left1 = Matrix.left + matrix(Matrix.matrix3, Matrix.size, Matrix.left+100);

            //ilk matrix için label
            Label namelabel = new Label();
            namelabel.Location = new Point(Matrix.left+100, Matrix.left/2);
            namelabel.Text = "transpoze 1";
            this.Controls.Add(namelabel);
            namelabel.AutoSize = true;

            Matrix.matrix3 = Matrix.transpoze(Matrix.matrix2);
            Matrix.left1 = Matrix.left1 + matrix(Matrix.matrix3, Matrix.size, Matrix.left1+200);

            //ikinci matrix için label
            Label namelabel1 = new Label();
            namelabel1.Location = new Point(Matrix.left1-100, Matrix.left1 / 4+50 );
            namelabel1.Text = "transpoze 2";
            this.Controls.Add(namelabel1);
            namelabel1.AutoSize = true;
        }

        
    }
}
