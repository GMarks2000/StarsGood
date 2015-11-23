using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarsGood
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        void StarField(int stars)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            Random rand = new Random();
            formGraphics.Clear(Color.Black);

            int x;
            int y;
            int w;

            int r;
            int g;
            int b;

            int starCounter = 0;

            while (starCounter < stars)
            {
                x = rand.Next(0, 1501);
                y = rand.Next(0, 921);
                w = rand.Next(1, 8);
                r = rand.Next(50, 256);
                g = rand.Next(50, 256);
                b = rand.Next(50, 256);

                drawBrush.Color = Color.FromArgb(r, g, b);
                formGraphics.FillEllipse(drawBrush, x, y, w, w);

                starCounter++;
            }
            drawBrush.Dispose();

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            StarField(1001);
        }
    }
}
