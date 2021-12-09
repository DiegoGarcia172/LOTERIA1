using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace LOTERIA1
{
    public partial class Form1 : Form
    {
        const int Cantidad_Cartas = 54;
        const int Cantidad_Sonidos_Cartas = 54;
       
        private PictureBox[] Tabla;
        Random R = new Random();
        int r = 0, c = 0;
        SoundPlayer Win = new SoundPlayer();
        SoundPlayer Start = new SoundPlayer();
        //SoundPlayer carta = new SoundPlayer();
        int a, aux;
        //private PictureBox[] baraja;
        int[] cartas = new int[54];
        //private SoundPlayer[] Sonido;
        SoundPlayer barajear = new SoundPlayer();
       
        SoundPlayer carta = new SoundPlayer();
        public Form1()
        {
            //MessageBox.Show("Primer obten una tabla y despues dale en (Cambiar carta) ", "Reglas");
            InitializeComponent();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            inicializarTabla();
            Start.SoundLocation = @"C:\Users\DIEGO\Downloads\Sonidos\corre y se va con.wav";
            Start.Play();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            int num = R.Next(1, 54);
            pictureBox1.Image = Image.FromFile(@"cartas\" + num + ".jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                carta.SoundLocation = @"baraja\" + num + ".wav";
                carta.Play();
            //for (int i = 0; i < cartas.Length; i++)
            //{
            //    a = R.Next(cartas.Length);
            //    aux = cartas[i];
            //    cartas[i] = cartas[a];
            //    cartas[a] = aux;
            //    carta.SoundLocation = @"baraja\" + cartas[i] + ".wav";
            //    carta.Play();
            //}
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox26.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox25.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox22.Image = Image.FromFile(@"C:\Users\DIEGO\Downloads\ficha.jpg");
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Win.SoundLocation=(@"C:\Users\DIEGO\Downloads\Sonidos\win.wav");
            Win.Play();
            MessageBox.Show("Felicidades por ganar", "Victoria");
            inicializar_reinicio();
            

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void inicializar_reinicio()
        {
            
            Application.Restart();
        }
        private void inicializarTabla()
        {
            
            Tabla = new PictureBox[25];
           
            for (int i = 0; i < cartas.Length; i++)
            {
                cartas[i] = i + 1;
            }
            for (int i = 0; i < cartas.Length; i++)
            {
                a = R.Next(cartas.Length);
                aux = cartas[i];
                cartas[i] = cartas[a];
                cartas[a] = aux;
            }
            for (int i = 0; i < Tabla.Length; i++)
            {
                Tabla[i] = new PictureBox();
                Tabla[i].Location = new System.Drawing.Point(100 + (c * 90), 90 + (r * 170));
                Tabla[i].Name = "picTabla" + i;
                Tabla[i].Size = new System.Drawing.Size(85, 110);
                Tabla[i].TabIndex = 0 + i;
                Tabla[i].SizeMode = PictureBoxSizeMode.StretchImage;
                Tabla[i].TabStop = false;
                Tabla[i].Image = Image.FromFile(@"cartas\" + cartas[i] + ".jpg");
                this.Controls.Add(Tabla[i]);
                c++;
                if (c == 5)
                {
                    r++;
                    c = 0;
                }              
            }

            //private void inicializar_baraja()
            //{
            //    baraja = new PictureBox[54];

            //    for (int i = 0; i < cartas.Length; i++)
            //    {
            //        cartas[i] = i + 1;
            //    }
            //    for (int i = 0; i < cartas.Length; i++)
            //    {
            //        a = R.Next(cartas.Length);
            //        aux = cartas[i];
            //        cartas[i] = cartas[a];
            //        cartas[a] = aux;
            //    }
            //    for (int i = 0; i < barajas.Length; i++)
            //    {
            //        barajas[i] = new PictureBox();
            //        barajas[i].Location = new System.Drawing.Point(850, 50);
            //        barajas[i].Name = "picBaraja" + i;
            //        barajas[i].Size = new System.Drawing.Size(308, 413);
            //        barajas[i].TabIndex = 0 + i;
            //        barajas[i].SizeMode = PictureBoxSizeMode.StretchImage;
            //        barajas[i].TabStop = false;
            //        barajas[i].Image = Image.FromFile(@"cartas\" + (cartas[i]) + ".jpg");
            //        this.Controls.Add(baraja[i]);
            //        c++;
            //        if (c == 5)
            //        {
            //            r++;
            //            c = 0;
            //        }
            //    }
            //}
        }
    }
}



