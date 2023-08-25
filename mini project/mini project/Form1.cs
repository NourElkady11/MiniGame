using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    class scorel
    {
        public char Letter;
        public int x, y;
        public int W;
        public Color clr;
    }
    class tayara
    {
        public int x;
        public int y;
        public Bitmap img;
        public List<Bitmap> lt = new List<Bitmap>();
        public int flagimg;

    }
    class sawarekh
    {
        public int x;
        public int y;
        public Bitmap img;
        public List<Bitmap> ls = new List<Bitmap>();
        public int flagsarokh;
    }
    class sahab
    {
        public int x;
        public int y;
        public Bitmap img;


    }
    class nar
    {
        public int x;
        public int y;
        public Bitmap img;

    }
    class coins
    {
        public int x;
        public int y;
        public Bitmap img;
        public List<Bitmap> lc = new List<Bitmap>();
        public int flagcoin;

    }
    class amaken
    {
        public int x;
        public int y;
    }
    class score
    {
        public int x;
        public int y;
        public List<Bitmap> ls = new List<Bitmap>();
        public int flagscore;
    }
    class win
    {
        public int x;
        public int y;
        public Bitmap img;

    }
    class loser
    {
        public int x;
        public int y;
        public Bitmap img;
    }
    public partial class Form1 : Form
    {

        Bitmap pic;
        Bitmap wallpaper = new Bitmap("walp.jpg");
        Bitmap win = new Bitmap("Winner.jpg");
        Bitmap lose = new Bitmap("Game over.jpg");
        List<scorel> score = new List<scorel>();
        List<loser> l = new List<loser>();
        List<tayara> t = new List<tayara>();
        List<sahab> s = new List<sahab>();
        List<sawarekh> m = new List<sawarekh>();
        List<nar> n = new List<nar>();
        List<coins> c = new List<coins>();
        List<amaken> a = new List<amaken>();
        List<score> ss = new List<score>();
        List<win> w = new List<win>();
        Timer tt = new Timer();


        int q = 0;
        int ct = -1;
        int i, k;
        int cttimer = 20;
        int isel;
        int xyboost = 6;
        int first = 0;
        int ctc = 0;
        int ctg = 0;
        int ctscore = 0;
        int xysboost = 14;
        int flagwin = 0;
        int flaglose = 0;


        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            this.Load += Form1_Load;
            this.Paint += Form1_Paint;
            tt.Tick += Tt_Tick;
            this.KeyDown += Form1_KeyDown;
            this.MouseMove += Form1_MouseMove;
            tt.Interval = 100;
            tt.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + "," + e.Y;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.Up && t[0].y + 30 > 0)
                {
                    t[0].flagimg = 0;
                    t[0].y -= xyboost;
                }
                if (e.KeyCode == Keys.Down && t[0].y + 130 <= this.ClientSize.Height)
                {
                    t[0].flagimg = 2;
                    t[0].y += xyboost;
                }
                if (e.KeyCode == Keys.Right && t[0].x + 120 <= this.ClientSize.Width)
                {
                    t[0].flagimg = 1;
                    t[0].x += xyboost;
                }
                if (e.KeyCode == Keys.Left && t[0].x - 30 >= 0)
                {
                    t[0].flagimg = 3;
                    t[0].x -= xyboost;
                }
            
           


        }

        private void Tt_Tick(object sender, EventArgs e)
        {
            if (cttimer % 10 == 0)
            {
                gatwala();
                for (i = 0; i < c.Count; i++)
                {
                    gatfelcoinwala();
                }

                isel = check();
                createsawarekh();

            }
            if (cttimer % 70 == 0)
            {

                ctg++;
                if (first == 0)
                {
                    createcoins();

                }
                if (first > 0 && c.Count > 0)
                {
                    Removecoin();
                    ctc++;

                }
                if (first > 0)
                {
                    createcoins();
                    ctc++;
                }
                first++;

            }
            if (isel == 1)
            {
                m[ct].flagsarokh = 2;

            }
            if (isel == 2)
            {
                m[ct].flagsarokh = 1;

            }
            if (isel == 3)
            {
                m[ct].flagsarokh = 0;

            }
            //if (isel == 4)
            //{


            //}


            haraksawarekhshmal();
            haraksawarekhymen();
            haraksawarekhfo();
















            cttimer++;
            drawdub(this.CreateGraphics());
        }
        void Removecoin()
        {
            c.RemoveAt(0);
            a.RemoveAt(0);

        }
        void createscore()
        {

            score pnn = new score();
            pnn.x = 0;
            pnn.y = 0;

            pnn.flagscore = 0;
            for (i = 0; i < 11; i++)
            {
                Bitmap img = new Bitmap(i + ".jpg");
                //img.MakeTransparent(img.GetPixel(0, 0));
                pnn.ls.Add(img);
            }
            ss.Add(pnn);
        }

        int check()
        {
            Random r = new Random();
            int z = r.Next(0, 4);
            return z;
        }
        void createsawarekh()
        {
            sawarekh pnn = new sawarekh();
            if (isel == 1)
            {

                Random ry = new Random();
                pnn.y = ry.Next(50, this.ClientSize.Height - 50);
                pnn.x = this.ClientSize.Width;


            }
            if (isel == 2)
            {

                Random ry = new Random();
                pnn.y = ry.Next(50, this.ClientSize.Height - 50);
                pnn.x = 0;

            }
            if (isel == 3)
            {
                pnn.y = this.ClientSize.Height;
                Random ry = new Random();
                pnn.x = ry.Next(50, this.ClientSize.Height - 50);
            }
            for (k = 5; k < 8; k++)
            {
                Bitmap img = new Bitmap(k + ".png");
                img.MakeTransparent(img.GetPixel(0, 0));
                pnn.ls.Add(img);
            }
            m.Add(pnn);
            ct++;

        }


        void createcoins()
        {
            coins pnn = new coins();
            Random rr = new Random();
            pnn.x = rr.Next(100, this.ClientSize.Width - 100);
            pnn.y = rr.Next(200, this.ClientSize.Height - 200);
            pnn.flagcoin = 0;
            amaken pnn2 = new amaken();
            pnn2.x = pnn.x;
            pnn2.y = pnn.y;
            a.Add(pnn2);
            for (i = 1; i < 5; i++)
            {
                Bitmap img = new Bitmap("c" + i + ".png");
                // img.MakeTransparent(img.GetPixel(0, 0));
                pnn.lc.Add(img);

            }
            c.Add(pnn);
            q++;
            if (q == 3)
            {
                q = 0;
            }




        }


        void createnar()
        {
            nar pnn = new nar();
            pnn.x = t[0].x;
            pnn.y = t[0].y;
            pnn.img = new Bitmap("nar.png");
            pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            n.Add(pnn);
        }



        void haraksawarekhymen()
        {
            for (i = 0; i < m.Count; i++)
            {
                if (m[i].flagsarokh == 1)
                {

                    m[i].x += xysboost;
                }
            }

        }
        void haraksawarekhshmal()
        {
            for (i = 0; i < m.Count; i++)
            {
                if (m[i].flagsarokh == 2)
                {
                    m[i].x -= xysboost;
                }

            }

        }
        void haraksawarekhfo()
        {
            for (i = 0; i < m.Count; i++)
            {
                if (m[i].flagsarokh == 0)
                {
                    m[i].y -= xysboost;
                }
            }
        }
        //void haraksawarekhtht()
        //{
        //    for (i = 0; i < m.Count; i++)
        //    {
        //        if (m[i].flagsarokh == 2)
        //        {
        //            m[i].y += 12;
        //        }
        //    }
        //}

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawdub(e.Graphics);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pic = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            createactors();
            createscore();
        }
        int xsahab = 100;
        int ysahab = 100;
        int fsahab = 0;

        void createactors()
        {

            for (i = 0; i < 4; i++)
            {
                sahab pnn = new sahab();
                pnn.x = xsahab;
                pnn.y = ysahab;
                pnn.img = new Bitmap("sa7ab.jpg");
                pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
                if (fsahab % 2 == 0)
                {
                    ysahab += 50;
                }
                else
                {
                    ysahab -= 50;
                }
                xsahab += 300;
                fsahab++;
                s.Add(pnn);

            }
            for (i = 0; i < 1; i++)
            {

                tayara pnn = new tayara();
                pnn.x = 500;
                pnn.y = 200;
                for (k = 1; k < 5; k++)
                {
                    Bitmap img = new Bitmap(k + ".png");
                   img.MakeTransparent(img.GetPixel(0, 0));
                    pnn.lt.Add(img);

                }
                t.Add(pnn);


            }


        }

        void gatfelcoinwala()
        {
            if (t.Count == 1)
            {
                if (t[0].flagimg == 0)
                {
                    if (t[0].y + 30 <= c[0].y + 60 && t[0].x + 30 >= c[0].x - 20 && t[0].x + 30 < c[0].x + 70 && t[0].y + 30 > c[0].y)
                    {

                        c.RemoveAt(0);
                        a.RemoveAt(0);
                        xyboost += 4;
                        ctscore++;
                        xysboost += 2;
                        ss[0].flagscore++;
                        if (ss[0].flagscore == 10)
                        {
                            flagwin = 1;
                        }
                    }

                }
                if (t[0].flagimg == 1)
                {
                    if (t[0].x + 170 >= c[0].x && t[0].y + 50 > c[0].y - 20 && t[0].y + 50 < c[0].y + 60 && t[0].x < c[0].x)
                    {

                        c.RemoveAt(0);
                        a.RemoveAt(0);
                        xyboost += 4;
                        ctscore++;
                        xysboost += 2;
                        ss[0].flagscore++;
                        if (ss[0].flagscore == 10)
                        {
                            flagwin = 1;
                        }
                    }

                }
                if (t[0].flagimg == 2)
                {
                    if (t[0].y + 110 >= c[0].y && t[0].x + 50 >= c[0].x - 20 && t[0].x + 50 < c[0].x + 60 && t[0].y < c[0].y)
                    {

                        c.RemoveAt(0);
                        a.RemoveAt(0);
                        xyboost += 4;
                        ctscore++;
                        xysboost += 2;
                        ss[0].flagscore++;
                        if (ss[0].flagscore == 10)
                        {
                            flagwin = 1;
                        }

                    }

                }
                if (t[0].flagimg == 3)
                {
                    if (t[0].y + 50 >= c[0].y - 20 && t[0].y + 30 < c[0].y + 60 && t[0].x + 30 <= c[0].x + 70 && t[0].x + 30 > c[0].x)
                    {

                        c.RemoveAt(0);
                        a.RemoveAt(0);
                        xyboost += 4;
                        ctscore++;
                        xysboost += 2;
                        ss[0].flagscore++;
                        if (ss[0].flagscore == 10)
                        {
                            flagwin = 1;
                        }

                    }

                }
            }






        }
        void gatwala()
        {
            for (i = 0; i < m.Count; i++)
            {
                /////////////////   saro5 ely t7t    //////////////////////////////////////////////
                if (m[i].flagsarokh == 0 && t[0].flagimg == 0 || m[i].flagsarokh == 0 && t[0].flagimg == 2 && m[i].y > 0)
                {
                    if (m[i].y <= t[0].y + 130 && m[i].x >= t[0].x && m[i].x <= t[0].x + 100 && m[i].y > t[0].y)
                    {
                        createnar();
                        tt.Stop();
                        MessageBox.Show("BOOOOOOM");
                        flaglose = 1;
                        t.RemoveAt(0);
                        break;

                    }
                }
                if (m[i].flagsarokh == 0 && t[0].flagimg == 1 || m[i].flagsarokh == 0 && t[0].flagimg == 3 && m[i].y > 0)
                {
                    if (m[i].y <= t[0].y + 120 && m[i].x >= t[0].x && m[i].x <= t[0].x + 100 && m[i].y > t[0].y)
                    {
                        createnar();
                        tt.Stop();
                        MessageBox.Show("BOOOOMM");
                        flaglose = 1;
                        t.RemoveAt(0);
                        break;


                    }
                }

                ///////////////////////////////////////////saro5 ely foo2////////////////////////////////
                //if (m[i].flagsarokh == 2 && t[0].flagimg == 0 || m[i].flagsarokh == 2 && t[0].flagimg == 2 && m[i].y < this.ClientSize.Height)
                //{
                //    if (m[i].y + 90 >= t[0].y + 15 && m[i].x >= t[0].x && m[i].x <= t[0].x + 100 && m[i].y < t[0].y)
                //    {
                //        createnar();
                //        tt.Stop();

                //        MessageBox.Show("fo2");
                //        t.RemoveAt(0);
                //        break;

                //    }
                //}
                //if (m[i].flagsarokh == 2 && t[0].flagimg == 1 || m[i].flagsarokh == 2 && t[0].flagimg == 3 && m[i].y < this.ClientSize.Height)
                //{
                //    if (m[i].y + 90 >= t[0].y + 18 && m[i].x >= t[0].x && m[i].x <= t[0].x + 100 && m[i].y < t[0].y)
                //    {
                //        createnar();
                //        tt.Stop();

                //        MessageBox.Show("fo2");
                //        t.RemoveAt(0);
                //        break;

                //    }
                //}
                ///////////////////////////////////////////saro5 4mal//////////////////////////////////
                if (m[i].flagsarokh == 1 && t[0].flagimg == 0 || m[i].flagsarokh == 1 && t[0].flagimg == 2 && m[i].x < this.ClientSize.Width)
                {
                    if (m[i].x + m[i].ls[1].Width >= t[0].x && m[i].y+10 >= t[0].y + 10 && m[i].y+10 <= t[0].y + 100 && m[i].x < t[0].x + t[0].lt[0].Width)
                    {
                        createnar();
                        tt.Stop();
                        MessageBox.Show("BOOMOMMM");
                        flaglose = 1;
                        t.RemoveAt(0);
                        break;

                    }
                }
                if (m[i].flagsarokh == 1 && t[0].flagimg == 1 || m[i].flagsarokh == 1 && t[0].flagimg == 3 && m[i].x < this.ClientSize.Width)
                {
                    if (m[i].x + m[i].ls[1].Width - 25 >= t[0].x - 15 && m[i].y + 35 >= t[0].y + 25 && m[i].y + 35 <= t[0].y + t[0].lt[1].Height - 30 && m[i].x < t[0].x + t[0].lt[1].Width)
                    {
                        createnar();
                        tt.Stop();
                        MessageBox.Show("BOOOOMM");
                        flaglose = 1;
                        t.RemoveAt(0);
                        break;

                    }
                }
                /////////////////////////////////////////saro5 ymeen //////////////////////////////////
                if (m[i].flagsarokh == 2 && t[0].flagimg == 0 || m[i].flagsarokh == 2 && t[0].flagimg == 2 && m[i].x > 0)
                {
                    if (m[i].x <= t[0].x + 130 && m[i].y+5 >= t[0].y && m[i].y+5 <= t[0].y + 100 && m[i].x > t[0].x)
                    {
                        createnar();
                        tt.Stop();
                        MessageBox.Show("BOOOMMM");
                        flaglose = 1;
                        t.RemoveAt(0);
                        break;

                    }
                }
                if (m[i].flagsarokh == 2 && t[0].flagimg == 1 || m[i].flagsarokh == 2 && t[0].flagimg == 3 && m[i].x > 0)
                {
                    if (m[i].x <= t[0].x + 125 && m[i].y >= t[0].y && m[i].y <= t[0].y + 130 && m[i].x > t[0].x)
                    {
                        createnar();
                        tt.Stop();
                        MessageBox.Show("BOOOMM");
                        flaglose = 1;
                        t.RemoveAt(0);
                        break;

                    }
                }



            }
        }

        void drawdub(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(pic);
            drawscene(g2);
            g.DrawImage(pic, 0, 0);
        }
        void drawscene(Graphics g2)
        {
            g2.Clear(Color.DeepSkyBlue);
            g2.DrawImage(wallpaper, 0, 0, this.Width, this.Height);

            //for (i = 0; i < s.Count; i++)
            //{
            //    g2.DrawImage(s[i].img, s[i].x, s[i].y);
            //}
            for (i = 0; i < t.Count; i++)
            {
                int s = t[0].flagimg;
                g2.DrawImage(t[i].lt[s], t[i].x, t[i].y);

            }
            for (i = 0; i < m.Count; i++)
            {
                int w = m[i].flagsarokh;
                g2.DrawImage(m[i].ls[w], m[i].x, m[i].y);
            }
            for (i = 0; i < n.Count; i++)
            {
                g2.DrawImage(n[i].img, n[i].x, n[i].y);
            }
            for (i = 0; i < c.Count; i++)
            {
                int u = c[i].flagcoin;
                g2.DrawImage(c[i].lc[u], c[i].x, c[i].y);
            }
            for (i = 0; i < ss.Count; i++)
            {
                int p = ss[i].flagscore;

                g2.DrawImage(ss[i].ls[p], ss[i].x, ss[i].y);
            }
            if (flagwin == 1)
            {
                g2.DrawImage(win, 0, 0, this.Width, this.Height);
                tt.Stop();

            }
            if (flaglose == 1)
            {
                g2.DrawImage(lose, 0, 0, this.Width, this.Height);
            }








        }
    }
}
