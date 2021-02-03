using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dzewo_rekurencja
{

    public partial class Form1 : Form
    {
        public class wek2d
        {
            public double x, y;
        }
        Graphics graf;

        int pokolenia=3;
        public Form1()
        {
            InitializeComponent();
            graf = panel1.CreateGraphics();
        }

        private void galaz(wek2d poczatek, wek2d koniec,int pokolenie)
        {
            if (pokolenie > 0)
            {
                graf.DrawLine(Pens.Black, (float)poczatek.x, (float)poczatek.y, (float)koniec.x, (float)koniec.y);
                double dx = koniec.x - poczatek.x;
                double dy = koniec.y - poczatek.y;
                double kat = Math.Atan2(dy, dx);
                double dlugosc = Math.Sqrt(dy * dy + dx * dx);
                double nowykat = kat + trackBar1.Value* 0.017;
                double nowadlugosc = dlugosc * trackBar4.Value / 100.0;
                wek2d nowykoniec = new wek2d();

                nowykoniec.x = koniec.x + nowadlugosc * Math.Cos(nowykat);
                nowykoniec.y = koniec.y + nowadlugosc * Math.Sin(nowykat);
                galaz(koniec, nowykoniec, pokolenie - 1);

                nowykat = kat + trackBar2.Value* 0.017;
                nowykoniec.x = koniec.x + nowadlugosc * Math.Cos(nowykat);
                nowykoniec.y = koniec.y + nowadlugosc * Math.Sin(nowykat);
                galaz(koniec, nowykoniec, pokolenie - 1);

                nowykat = kat + trackBar3.Value* 0.017;
                nowykoniec.x = koniec.x + nowadlugosc * Math.Cos(nowykat);
                nowykoniec.y = koniec.y + nowadlugosc * Math.Sin(nowykat);
                galaz(koniec, nowykoniec, pokolenie - 1);




            }
        }

        private void rysuj()
        {
            graf.Clear(Color.White);
            wek2d pocz = new wek2d();
            wek2d kon = new wek2d();
            pocz.x = panel1.Width / 2;
            pocz.y = panel1.Height;
            kon.x = pocz.x;
            kon.y = pocz.y - 20;
            galaz(pocz, kon, pokolenia);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            rysuj();
           
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            pokolenia = trackBar5.Value;
        }
    }
}
