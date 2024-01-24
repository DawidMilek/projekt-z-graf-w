using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_z_grafów
{
    public partial class Form1 : Form
    {
        private const int r = 10;
        private Graphics g;
        private Pen pWierzcholek;
        private Pen pWierzcholekAktywny;
        private Pen pKrawedz;
        private Wierzchlek MouseDownWierzcholek;

        private List<Wierzchlek> wierzcholki = new List<Wierzchlek>();

        Wyszukiwania s = new Wyszukiwania();

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(500, 500);

            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            pWierzcholek = new Pen(Color.Orange);
            pWierzcholek.Width = 3;
            pWierzcholekAktywny = new Pen(Color.Red);
            pWierzcholekAktywny.Width = 3;

            pKrawedz = new Pen(Color.Blue);
            pKrawedz.Width = 10;
            pKrawedz.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MouseDownWierzcholek = null;
                foreach (Wierzchlek w in wierzcholki)
                {
                    if (w.Odleglosc(e.Location) < r)
                    {
                        MouseDownWierzcholek = w;
                    }
                }
                odrysujGraf();
            }
        }

        private void odrysujGraf()
        {
            D_lista_wierzcholkow.Items.Clear();

            g.Clear(Color.White);
            foreach (Wierzchlek w in wierzcholki)
            {
                D_lista_wierzcholkow.Items.Add(w.Id);
                g.DrawEllipse(pWierzcholek, w.Polozenie.X - r, w.Polozenie.Y - r, 2 * r, 2 * r);
                g.DrawString(w.Id.ToString(),
                             new System.Drawing.Font("Microsoft Sans Serif", r),
                             new SolidBrush(Color.Red),
                             w.Polozenie.X + r,
                             w.Polozenie.Y + r);
                if (w == MouseDownWierzcholek)
                {
                    g.DrawEllipse(pWierzcholekAktywny, w.Polozenie.X - r, w.Polozenie.Y - r, 2 * r, 2 * r);
                }
                foreach (Wierzchlek wn in w.Nastpniki)
                {
                    g.DrawLine(pKrawedz, w.Polozenie, wn.Polozenie);
                }
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseDownWierzcholek != null)
            {
                foreach (Wierzchlek w in wierzcholki)
                {
                    if (w.Odleglosc(e.Location) < r)
                    {
                        MouseDownWierzcholek.Nastpniki.Add(w);
                    }
                }
                MouseDownWierzcholek = null;
                odrysujGraf();
            }
            else if (e.Button == MouseButtons.Middle)
            {
                Wierzchlek nowyWierzcholek = new Wierzchlek(e.Location);
                wierzcholki.Add(nowyWierzcholek);
                D_lista_wierzcholkow.Items.Add(nowyWierzcholek.Id);
                odrysujGraf();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && MouseDownWierzcholek != null)
            {
                odrysujGraf();
                g.DrawLine(pKrawedz, MouseDownWierzcholek.Polozenie, e.Location);
                pictureBox1.Refresh();
            }

        }

        private void D_start_Click(object sender, EventArgs e)
        {
            if (int.TryParse(D_text.Text, out int startId))
            {
                Wierzchlek startWierzcholek = wierzcholki.FirstOrDefault(w => w.Id == startId);

                if (!D_wszerz.Checked && !D_w_glab.Checked)
                {
                    MessageBox.Show("Wybierz Wyszukiwanie!");
                    return;
                }

                if (D_wszerz.Checked)
                {
                    List<int> wynikiWszerz = s.WyszukiwanieWszerz(startWierzcholek);
                    AktualizujWyniki(wynikiWszerz);
                }

                if (D_w_glab.Checked)
                {
                    List<int> wynikiWGlab = s.WyszukiwanieWGlab(startWierzcholek);
                    AktualizujWyniki(wynikiWGlab);
                }
            }
            else
            {
                MessageBox.Show("Wypełnij formularz");
            }
        }

        private void AktualizujWyniki(List<int> wyniki)
        {
            D_wyniki.Items.Clear();

            foreach (int wynik in wyniki)
            {
                D_wyniki.Items.Add(wynik);
            }
        }

        private void D_resetuj_Click(object sender, EventArgs e)
        {
            wierzcholki.Clear();
            D_lista_wierzcholkow.Items.Clear();
            D_wyniki.Items.Clear();

            g.Clear(Color.White);
            pictureBox1.Refresh();
        }
    }
}
