using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambiente
{
    public partial class Splash : Form
    {
        double pbUnit;
        int pbWidth, pbHeigth, pbComplete;
        Bitmap bmp;
        Graphics gra;
        Timer t = new Timer();
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Opacity = .9;
            pbWidth = pictureBox2.Width;
            pbHeigth = pictureBox2.Height;

            pbUnit = pbWidth / 100.0;
            pbComplete = 0;
            bmp = new Bitmap(pbWidth, pbHeigth);

            t.Interval = 20;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            gra = Graphics.FromImage(bmp);
            gra.Clear(Color.White);
            gra.FillRectangle(Brushes.PaleGreen, new Rectangle(0, 0, (int)(pbComplete * pbUnit), pbHeigth));
            //gra.DrawString("Cargando...     " + pbComplete + " %", new Font("Century Gothic", pbHeigth / 2), Brushes.Black, new Point(pbWidth / 3 - pbHeigth, pbHeigth / 10));
            /*label1.Text = pbComplete + " %";*/
            pictureBox2.Image = bmp;
            pbComplete++;
            if (pbComplete > 100)
            {
                gra.Dispose();
                t.Stop();
                Form1 ins = new Form1();
                ins.Show();
                this.Hide();
            }
        }
    }
}
