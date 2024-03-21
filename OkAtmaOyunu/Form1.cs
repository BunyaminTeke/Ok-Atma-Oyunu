namespace OkAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.BackgroundImage = Resource1.arkplan1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            pb_arrow.BackgroundImageLayout = ImageLayout.Stretch;
            pb_arrow.BackColor = Color.Transparent;
            pb_arrow.BackgroundImage = Resource1.arrow;
            pb_arrow.Parent = this;
            timer1.Start();
            denemeSayisi = 0;

        }

        bool asagimi = true;
        int sayi = 0;
        byte denemeSayisi;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pb_arrow.Top < 10)
            {
                asagimi = true;

            }
            else if (pb_arrow.Bottom > this.Height - 50)
            {
                asagimi = false;
            }

            if (asagimi)
            {
                pb_arrow.Location = new Point(pb_arrow.Location.X, pb_arrow.Location.Y + 8);

                sayi = new Random().Next(1, 7);
                timer1.Interval = sayi * 10;
            }
            else
            {
                pb_arrow.Location = new Point(pb_arrow.Location.X, pb_arrow.Location.Y - 8);
                sayi = new Random().Next(1, 7);
                timer1.Interval = sayi * 10;
            }

        }

        int yatayDeger;
        int puan;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                denemeSayisi++;
                yatayDeger = pb_arrow.Bottom - pb_arrow.Height / 2;

                if ((yatayDeger > lbl_onalt.Top) || yatayDeger < lbl_onust.Bottom)
                {
                    puan += 10;
                    OkHareketeGecir();

                }
                else if ((yatayDeger < lbl_onalt.Top && yatayDeger > lbl_otuzalt.Bottom) || yatayDeger > lbl_onust.Bottom && yatayDeger < lbl_otuzust.Top)
                {
                    puan += 20;
                    OkHareketeGecir();

                }
                else if ((yatayDeger < lbl_yirmialt.Top && yatayDeger > lbl_kirkalt.Bottom) || yatayDeger > lbl_yirmiust.Bottom && yatayDeger < lbl_kirkust.Top)
                {
                    puan += 30;
                    OkHareketeGecir();

                }
                else if ((yatayDeger < lbl_otuzalt.Top && yatayDeger > lbl_ellialt.Bottom) || yatayDeger > lbl_otuzust.Bottom && yatayDeger < lbl_elliust.Top)
                {
                    puan += 40;
                    OkHareketeGecir();

                }
                else if ((yatayDeger < lbl_kirkalt.Top && yatayDeger > lbl_altmisalt.Bottom) || yatayDeger > lbl_kirkust.Bottom && yatayDeger < lbl_altmisust.Top)
                {
                    puan += 50;
                    OkHareketeGecir();

                }
                else if ((yatayDeger < lbl_ellialt.Top && yatayDeger > lbl_yuz.Bottom) || yatayDeger > lbl_elliust.Bottom && yatayDeger < lbl_yuz.Top)
                {
                    puan += 60;
                    OkHareketeGecir();

                }
                else
                {
                    puan += 100;
                    OkHareketeGecir();

                }
            }
        }
        private void OkHareketeGecir()
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pb_arrow.Location = new Point(pb_arrow.Location.X + 10, pb_arrow.Location.Y);

            if (pb_arrow.Right >= 870)
            {
                timer2.Stop();
                pb_arrow.Location = new Point(12, new Random().Next(50, 640));
                this.Text = puan.ToString();
                timer1.Start();
                label1.Text = puan.ToString();
                if (denemeSayisi == 3)
                {
                    timer1.Stop();
                    timer2.Stop();
                    MessageBox.Show(puan +"  Tebrikler");
                }
            }
        }
    }
}
