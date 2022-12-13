using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.DrawRectangle(Pens.Black, 0, 0, pictureBox1.Width - 1, pictureBox1.Height - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        public void ejercicio1(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2;

            vi1 = 0;
            r1 = pictureBox1.Width / n;
            vi2 = 0;
            my = pictureBox1.Height / 2;
            r2 = my / n;

            y1 = pictureBox1.Height / 2;
            x2 = pictureBox1.Width;

            g.DrawLine(Pens.Blue, 0, my, pictureBox1.Width, my);


            for (int i = 1; i <= n; i++)
            {

                x1 = vi1 + (i - 1) * r1;
                y2 = vi2 + (i - 1) * r2;

                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

            }


        }

        public void ejercicio1_1(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2;

            vi1 = 0;
            r1 = pictureBox1.Width / n;
            my = pictureBox1.Height / 2;
            vi2 = my;
            r2 = my / n;

            y1 = pictureBox1.Height;

            x2 = pictureBox1.Width;

            g.DrawLine(Pens.Blue, 0, my, pictureBox1.Width, my);
            for (int i = 1; i <= n; i++)
            {

                x1 = vi1 + (i - 1) * r1;
                y2 = vi2 + (i - 1) * r2;

                g.DrawLine(Pens.Blue, x1, y1, x2, y2);
            }


        }


        //PREGUNTA 1


        public void ejercicioE1(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2,mx;

            vi1 = 0;
            my = pictureBox1.Height / 2;

            r1 = my / n;

            mx = pictureBox1.Width / 2;

            vi2 = mx;

            r2 = mx / n;

            x1 = 0;

            y2 = my;

            g.DrawLine(Pens.Blue, mx,0,mx, pictureBox1.Height);
            g.DrawLine(Pens.Blue, 0, my, pictureBox1.Width,my);



            for (int i = 1; i <= n; i++)
            {

                y1 = vi1 + (i - 1) * r1;

                x2 = vi2 + (i - 1) * (-r2);


                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

            }


        }

        public void ejercicioE1_1(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2, mx;

            vi1 = 0;
            my = pictureBox1.Height / 2;

            r1 = my / n;

            mx = pictureBox1.Width / 2;

            vi2 = mx;

            r2 = mx / n;

            x1 = pictureBox1.Width;

            y2 = my;

            g.DrawLine(Pens.Blue, mx, 0, mx, pictureBox1.Height);
            g.DrawLine(Pens.Blue, 0, my, pictureBox1.Width, my);



            for (int i = 1; i <= n; i++)
            {

                y1 = vi1 + (i - 1) * r1;

                x2 = vi2 + (i - 1) * (r2);


                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

            }


        }

        private void eJERCICIO1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ejercicio1(int.Parse(textBox1.Text));
            //ejercicio1_1(int.Parse(textBox1.Text));
            ejercicioE1(int.Parse(textBox1.Text));
            ejercicioE1_1(int.Parse(textBox1.Text));
        }


        //PREGUNTA 2



        public void ejercicioE2(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2, mx, mmy, mmx;
            Random r = new Random(); //objeto random

            mx = pictureBox1.Width / 2;
            my = pictureBox1.Height / 2;

            mmy = my / 2; 
             mmx= mx/2;

            x1 = mmx;
            y1 = mmy;

            g.DrawLine(Pens.Red, 0, mmy, pictureBox1.Width, mmy);
            g.DrawLine(Pens.Blue, mx, 0, mx, pictureBox1.Height);
            g.DrawLine(Pens.Blue, 0, my, pictureBox1.Width, my);

            for (int i = 1; i <= n; i++)
            {

                x2 = r.Next(0, (int)mx);
                y2 = r.Next((int)mmy, (int)my);


                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

            }


        }

        public void ejercicioE2_2(int n)
        {
            float x1, y1, x2, y2;
            float vi1, r1, vi2, my, r2, mx, mmy, mmx;
            Random r = new Random(); //objeto random

            mx = pictureBox1.Width / 2;
            my = pictureBox1.Height / 2;

            mmy = my / 2;
            mmx = mx / 2;

            x1 = mx+mmx;
            y1 = mmy;

           

            for (int i = 1; i <= n; i++)
            {

                x2 = r.Next((int)mx, (int)pictureBox1.Width);
                y2 = r.Next(0, (int)mmy);


                g.DrawLine(Pens.Blue, x1, y1, x2, y2);

            }


        }


        private void pREGUNAT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejercicioE2(int.Parse(textBox1.Text));
            ejercicioE2_2(int.Parse(textBox1.Text));
        }
    }
}
