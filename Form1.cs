using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public class cadvimg
    {
        public Rectangle rsrc;
        public Rectangle rdst;
        public Bitmap img;
        public int dir;
        public int dir2;

    }

    public class cimg
    {
        public int x, y;

        public Bitmap img;


    }

    public partial class Form1 : Form
    {
        Bitmap off;
        Timer tt = new Timer();


        List<cadvimg> background = new List<cadvimg>();
        List<cimg> redball = new List<cimg>();
        List<cadvimg> stars = new List<cadvimg>();
        List<cadvimg> enemy = new List<cadvimg>();
        List<cadvimg> boxes = new List<cadvimg>();
        List<cadvimg> snon = new List<cadvimg>();
        List<cadvimg> slm = new List<cadvimg>();
        List<cadvimg> stone = new List<cadvimg>();
        List<cadvimg> seatwo = new List<cadvimg>();
        List<cadvimg> bus = new List<cadvimg>();
        List<cadvimg> win = new List<cadvimg>();
        List<cadvimg> land = new List<cadvimg>();
        List<cadvimg> enemy2 = new List<cadvimg>();
        List<cadvimg> tomato = new List<cadvimg>();
        List<cadvimg> score = new List<cadvimg>();
        List<cadvimg> loser = new List<cadvimg>();
        List<cadvimg> winnn = new List<cadvimg>();
        List<cadvimg> cloud = new List<cadvimg>();
      

        int flagbusupmotion = -1;

        int lossseflag = 4;

        int flagframe1=0;
        int flagframe12 = 0;
        int ct = 0;

        int starsscount=0;
        int starsi = 15;

        int counttomato = 0;

        int flagselslm = -1;

        int flagslm = -1;
        int busflag = -1;

        int seal = 2300;
        int sear = 2200;
        int countc = 0;

        int flagdown = 0;
        int enemyl2 = 3400;
        int enemys2 = 2300;

        int enemyl = 490;
        int enemys = 400;
        int loserf = 0;
        int flagenemy = 0;
        public Form1()
        {
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Paint += Form1_Paint;
            KeyDown += Form1_KeyDown;


            tt.Interval = 200;
            tt.Tick += Tt_Tick;
            tt.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode==Keys.W)
            {

                cadvimg pnn4 = new cadvimg();
                pnn4.img = new Bitmap("tomato.bmp");
                pnn4.img.MakeTransparent(pnn4.img.GetPixel(0,0));
                pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
                pnn4.rdst = new Rectangle(redball[0].x + redball[0].img.Width, 520, 30, 30);
                tomato.Add(pnn4);
                


            }



            if (e.KeyCode==Keys.Space && redball[0].x +400 > seatwo[0].rdst.X + seatwo[0].img.Width)
            {
                flagdown = 1;
                redball[0].x = seatwo[0].rdst.X + seatwo[0].img.Width + 10;
                redball[0].y = 515;
            }
            if (e.KeyCode == Keys.Space && redball[0].x  < seatwo[0].rdst.X + seatwo[0].img.Width)
            {
               
                redball[0].y = 515;
                lossseflag = 1;
                loserf = 3;


                MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // drawdubb(CreateGraphics());
            }
            if (e.KeyCode== Keys.Right)
            {
                flagbusupmotion = 0;
                if (redball[0].x+redball[0].img.Width<= 1200 &&flagselslm==-1)
                {
                    redball[0].x += 2;
                    background[0].rdst.X -= 8;
                   
                    for(int i=0;i<boxes.Count;i++)
                    {
                       
                      boxes[i].rdst.X -= 8;
                        

                    }
                    for (int i = 0; i < enemy.Count; i++)
                    {
                        enemy[i].rdst.X -= 8;
                        enemyl -= 8;
                        enemys -= 8;
                       
                    }
                    for (int i = 0; i < stars.Count; i++)
                    {
                        stars[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < snon.Count; i++)
                    {
                        snon[i].rdst.X -= 8;

                    }
              
                    for (int i = 0; i < slm.Count; i++)
                    {
                        slm[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < seatwo.Count; i++)
                    {
                        seatwo[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < land.Count; i++)
                    {
                        land[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < stone.Count; i++)
                    {
                        stone[i].rdst.X -= 8;

                    }
                   
                    for (int i = 0; i < bus.Count; i++)
                    {
                        bus[i].rdst.X -= 8;
                        seal -= 8;
                        sear += 8;


                    }
                    for (int i = 0; i < win.Count; i++)
                    {
                        win[i].rdst.X -= 8;

                    }
                    flagframe1++;
                    

                        
                    

                }
                else
                {
                    flagbusupmotion = -1;
                }

                if (flagframe1 == 1)
                {
                    redball[0].img = new Bitmap("2.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe1 == 2)
                {
                    redball[0].img = new Bitmap("3.bmp");
                    // hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe1 == 3)
                {
                    redball[0].img = new Bitmap("4.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe1 == 4)
                {
                    redball[0].img = new Bitmap("5.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe1 == 5)
                {
                    redball[0].img = new Bitmap("6.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe1 == 6)
                {
                    redball[0].img = new Bitmap("1.bmp");
                    // hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));
                    flagframe1 = 0;
                }

            }
            /*if(e.KeyCode==Keys.Left)
            {
                if (redball[0].x-5>=0)
                {
                    redball[0].x -= 5;
                    flagframe12++;


                }
                if (flagframe12 == 1)
                {
                    redball[0].img = new Bitmap("5.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe12 == 2)
                {
                    redball[0].img = new Bitmap("4.bmp");
                    // hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe12 == 3)
                {
                    redball[0].img = new Bitmap("3.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe12 == 4)
                {
                    redball[0].img = new Bitmap("2.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe12 == 5)
                {
                    redball[0].img = new Bitmap("1.bmp");
                    //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

                }
                if (flagframe12 == 6)
                {
                    redball[0].img = new Bitmap("6.bmp");
                    // hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));
                    flagframe12 = 0;
                }

            }*/
            if(e.KeyCode==Keys.Up && redball[0].y==515)
            {
                redball[0].y -= 100;

            }


            if(e.KeyCode==Keys.A)
            {
                if (redball[0].y==515)
                {
                    redball[0].x += 170;
                    redball[0].y -= 200;


                    background[0].rdst.X -= 5;

                    for (int i = 0; i < boxes.Count; i++)
                    {

                        boxes[i].rdst.X -= 170;


                    }
                  
                    for (int i = 0; i < enemy.Count; i++)
                    {
                        enemy[i].rdst.X -= 170;
                        enemyl -= 170;
                        enemys -= 170;
                        enemyl2 -= 170;
                        enemys2 -= 170;

                    }
                    for (int i = 0; i < stars.Count; i++)
                    {
                        stars[i].rdst.X -= 170;

                    }
                    for (int i = 0; i < snon.Count; i++)
                    {
                        snon[i].rdst.X -= 170;

                    }

                    for (int i = 0; i < slm.Count; i++)
                    {
                        slm[i].rdst.X -= 170;

                    }
                    for (int i = 0; i < seatwo.Count; i++)
                    {
                        seatwo[i].rdst.X -= 170;

                        seal -= 170;
                        sear -= 170;

                    }
                    for (int i = 0; i < land.Count; i++)
                    {
                        land[i].rdst.X -= 170;

                    }
                    for (int i = 0; i < stone.Count; i++)
                    {
                        stone[i].rdst.X -= 170;

                    }
                    for (int i = 0; i < bus.Count; i++)
                    {
                        bus[i].rdst.X -= 170;

                    }
                    for (int i = 0; i < win.Count; i++)
                    {
                        win[i].rdst.X -= 170;

                    }
                }

            }

           /* if (e.KeyCode == Keys.D)
            {
                if (redball[0].y == 515)
                {
                    redball[0].x -= 250;
                    redball[0].y -= 200;
                }

            }*/




            drawdubb(CreateGraphics());

        }


        private void Tt_Tick(object sender, EventArgs e)
        {
            if(loserf==0)
            {
                ct++;
                if (ct % 2 == 0)
                {     
                   // gravityslm();
                    gravity();
                }

                if (ct % 20 == 0)
                {
                    createcloud();
                }
                //animate();
                keydownslm();
                checkwin();
                collecting();
                
                animatecloud();
                animatebus();
                animatetomato();
                usebus();
                killenemy();
                checkenemy();
                animateenemy();
                checksnon();
                dieenemy();
                seadie();

                

            }
            drawdubb(CreateGraphics());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawdubb(CreateGraphics());
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            createRedball();
            createbackground();
            createenemy();
            createstars();
            //createbox();
            
            createsnon();
            winner();
            createslm();
            createseatwo();
            //createstone();
            createbus();
            loserr();
            createwin();
            //createland();
            off = new Bitmap(ClientSize.Width, ClientSize.Height);
            
           
            drawdubb(CreateGraphics());
        }
        void drawdubb(Graphics g)
        {
            Graphics g2 = Graphics.FromImage(off);
            drawscene(g2);
            g.DrawImage(off, 0, 0);
        }

        void checksnon()
        {
            for(int i=0;i<snon.Count;i++)
            {
                if (redball[0].y + redball[0].img.Height > snon[i].rdst.Y && redball[0].x + redball[0].img.Width >= snon[i].rdst.X && /*redball[0].x >= snon[i].rdst.X && */redball[0].x + redball[0].img.Width <= snon[i].rdst.X + snon[i].img.Width)
                {


                    // redball.Clear();
                    lossseflag = 1;
                    loserf = 3;
                    

                    MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // drawdubb(CreateGraphics());
                    break;
                   // MessageBox.Show("loser");
                    

                }
                //drawdubb(CreateGraphics());
            }
        }
        void checkenemy()
        {
           for(int i=0;i<enemy.Count;i++)
            {
                if (redball[0].x + redball[0].img.Width > enemy[i].rdst.X &&redball[0].x < enemy[i].rdst.X + enemy[i].img.Width)
                {

                    if (redball[0].y ==515)
                    {
                        //redball.Clear();
                        lossseflag = 1;
                        loserf = 3;
                        MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //drawdubb(CreateGraphics());
                        break;
                    }
                }
            }
        }
        //
        void animatecloud()
        {
            for(int i=0;i<cloud.Count;i++)
            {
                cloud[i].rdst.Y += 5;
            }
        }

        
        void dieenemy()
        {
            for(int i=0;i<=enemy.Count;i++)
            {
              /*  if (  redball[0].x < enemy[i].rdst.X + enemy[i].img.Width)
                {
                    enemy.RemoveAt(i);
                    i--;
                   
                    break;
                }*/
            }
        }

        void keydownslm()
        {
            if (redball[0].x +redball[0].img.Width-50 >= slm[0].rdst.X && slm[0].rdst.X + slm[0].img.Width > redball[0].x)
            {
                flagselslm = 0;
            }
            else
            {
                flagselslm = -1;
            }
        }

        void animatetomato()
        {
            for(int i=0;i<tomato.Count;i++)
            {
               if(counttomato<=200)
                {
                    tomato[i].rdst.X += 10;
                    counttomato += 10;

                }
               if(counttomato>200)
                {
                    tomato.RemoveAt(i);
                    counttomato = 0;
                }
                
            }
           



        }

        void killenemy()
        { 
            for(int i=0;i<tomato.Count;i++)
            {
               for(int e=0;e<enemy.Count;e++)
                {
                    if (tomato[i].rdst.X + tomato[i].img.Width > enemy[e].rdst.X && tomato[i].rdst.X < enemy[e].rdst.X + enemy[e].img.Width && enemy[e].rdst.Y == 515)
                    {
                       
                        enemy.RemoveAt(e);
                        tomato.RemoveAt(i);
                        i--;
                        e--;
                        

                    }
                }
            }
        }
        void gravityslm()
        {
            if (redball[0].x + redball[0].img.Width > slm[0].rdst.X && redball[0].x +redball[0].img.Width< slm[0].rdst.X + slm[0].img.Width )
            {
                flagslm = 0;

            }
            else
            {
                flagslm = -1;
            }

        }
        //win
        void checkwin()
        {
            if (redball[0].x >= win[0].rdst.X)
            {
                lossseflag = 2;
                loserf = 3;
               
                MessageBox.Show("Winner!", "Winner Winner Chicken dinner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
        }

        void drawscene(Graphics g)
        {
            g.Clear(Color.Black);

           
            for (int i = 0; i < background.Count; i++)
            {
                cadvimg ptv = background[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc,GraphicsUnit.Pixel);
            }

            for (int i = 0; i < cloud.Count; i++)
            {
                cadvimg ptv = cloud[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }

         



            for (int i = 0; i < enemy.Count; i++)
            {
                cadvimg ptv = enemy[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }

           


            for (int i = 0; i < stars.Count; i++)
            {
                cadvimg ptv = stars[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < boxes.Count; i++)
            {
                cadvimg ptv = boxes[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < score.Count; i++)
            {
                cadvimg ptv = score[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < tomato.Count; i++)
            {
                cadvimg ptv = tomato[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }
            for (int i = 0; i < snon.Count; i++)
            {
                cadvimg ptv = snon[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }
            for (int i = 0; i < win.Count; i++)
            {
                cadvimg ptv = win[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }
            for (int i = 0; i < bus.Count; i++)
            {
                cadvimg ptv = bus[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }

            for (int i = 0; i < slm.Count; i++)
            {
                cadvimg ptv = slm[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }
           

            for (int i = 0; i < stone.Count; i++)
            {
                cadvimg ptv = stone[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }
            for (int i = 0; i < land.Count; i++)
            {
                cadvimg ptv = land[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }
            for (int i = 0; i < seatwo.Count; i++)
            {
                cadvimg ptv = seatwo[i];
                g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
            }
            
            for (int i = 0; i < redball.Count; i++)
            {
                cimg ptv = redball[i];
                g.DrawImage(ptv.img, ptv.x, ptv.y);
            }
            if (lossseflag == 1)
            {
                for (int i = 0; i < loser.Count; i++)
                {
                    cadvimg ptv = loser[i];
                    g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
                }
            }
            if (lossseflag == 2)
            {
                for (int i = 0; i < winnn.Count; i++)
                {
                    cadvimg ptv = winnn[i];
                    g.DrawImage(ptv.img, ptv.rdst, ptv.rsrc, GraphicsUnit.Pixel);
                }
            }

        }

        //seadie
        void seadie()
        {
            if (redball[0].x > seatwo[0].rdst.X)
            {
                if (redball[0].x + redball[0].img.Width < seatwo[0].img.Width + seatwo[0].rdst.X)
                {
                    
                    if (redball[0].y+redball[0].img.Height >= 550)
                    {
                        lossseflag = 1;
                        loserf = 3;
                        
                        MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //drawdubb(CreateGraphics());
                    }
                }
            }
        }


        //collecting stars
        void collecting()
        {
            for(int i=0;i<stars.Count;i++)
            {
                if (redball[0].x + redball[0].img.Width >= stars[i].rdst.X&& redball[0].x < stars[i].rdst.X + stars[i].img.Width)
                {
                    if (redball[0].y <= stars[i].rdst.Y)
                    {
                        stars.RemoveAt(i);
                        starsscount+=50;
                        i--;
                        //
                        cadvimg pnn4 = new cadvimg();
                        pnn4.img = new Bitmap("stars.bmp");
                        pnn4.img.MakeTransparent(pnn4.img.GetPixel(0,0));
                        pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
                        pnn4.rdst = new Rectangle(starsi+starsscount, 100, 50, 50);
                        score.Add(pnn4);

                    }
                }
            }
        }

        //animate
        void animatebus()
        {
          if(busflag!=-1)
            {
               if(countc <=600)
                {
                    bus[0].rdst.X += 5 * bus[0].dir;
                    countc += 5;
                    background[0].rsrc.X += 1;

                    //
                    for (int i = 0; i < boxes.Count; i++)
                    {

                        boxes[i].rdst.X -= 8;


                    }
                    for (int i = 0; i < enemy.Count; i++)
                    {
                        enemy[i].rdst.X -= 8;
                        enemyl -= 8;
                        enemys -= 8;
                        enemyl2 -= 8;
                        enemys2 -= 8;

                    }
                    for (int i = 0; i < stars.Count; i++)
                    {
                        stars[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < snon.Count; i++)
                    {
                        snon[i].rdst.X -= 8;

                    }

                    for (int i = 0; i < slm.Count; i++)
                    {
                        slm[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < seatwo.Count; i++)
                    {
                        seatwo[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < land.Count; i++)
                    {
                        land[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < stone.Count; i++)
                    {
                        stone[i].rdst.X -= 8;

                    }
                    for (int i = 0; i < bus.Count; i++)
                    {
                        bus[i].rdst.X -= 8;
                        seal -= 8;
                        sear += 8;


                    }
                    for (int i = 0; i < win.Count; i++)
                    {
                        win[i].rdst.X -= 8;

                    }
                }


                /*if (bus[0].rdst.X + bus[0].img.Width>= seal)
                {
                    bus[0].dir *= -1;

                }
                if (bus[0].rdst.X <= sear)
                {

                    bus[0].dir *= -1;

                }*/

            }
        }
       
        void animate()
        {

            if ((redball[0].x + 5 + redball[0].img.Width) <= 1300)
            {
                redball[0].x += 5;
                
               background[0].rsrc.X += 1;
                

                flagframe1++;
            }
           

            if (flagframe1 == 1)
            {
                redball[0].img = new Bitmap("2.bmp");
              //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));
                
            }
            if (flagframe1 == 2)
            {
                redball[0].img = new Bitmap("3.bmp");
               // hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));
                
            }
            if (flagframe1 == 3)
            {
                redball[0].img = new Bitmap("4.bmp");
              //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));

            }
            if (flagframe1 == 4)
            {
                redball[0].img = new Bitmap("5.bmp");
              //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));
                
            }
            if (flagframe1 == 5)
            {
                redball[0].img = new Bitmap("6.bmp");
              //  hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));
                
            }
            if (flagframe1 == 6)
            {
                redball[0].img = new Bitmap("1.bmp");
               // hero[0].img.MakeTransparent(hero[0].img.GetPixel(0, 0));
                flagframe1 = 0;
            }




        }

        void animateenemy()
        {
            for(int i=0;i<enemy.Count;i++)
            {
                enemy[i].rdst.X += 10 * enemy[i].dir;
                enemy[i].rdst.Y -= 10 * enemy[i].dir2;
                if (flagenemy == 1)
                {
                    enemy[i].img = new Bitmap("emyr.bmp");
                    //enemy[0].img.MakeTransparent(enemy[0].img.GetPixel(0, 0));

                }
                if (flagenemy == 2)
                {
                    enemy[i].img = new Bitmap("emyl.bmp");
                    // enemy[0].img.MakeTransparent(enemy[0].img.GetPixel(0, 0));
                    flagenemy = 0;
                }
                if(i==0)
                {
                    if (enemy[i].rdst.X > enemyl)
                    {
                        enemy[i].dir *= -1;
                        flagenemy = 2;
                    }
                    if (enemy[i].rdst.X < enemys)
                    {

                        enemy[i].dir *= -1;
                        flagenemy = 1;
                    }
                }
                if (i == 1)
                {
                    if (enemy[i].rdst.X > enemyl2)
                    {
                        enemy[i].dir *= -1;
                        flagenemy = 2;
                    }
                    if (enemy[i].rdst.X < enemys2)
                    {

                        enemy[i].dir *= -1;
                        flagenemy = 1;
                    }
                }

                if (enemy[i].rdst.Y < 500)
                {
                    enemy[i].dir2 *= -1;

                }
                if (enemy[i].rdst.Y >= 515)
                {

                    enemy[i].dir2 *= -1;

                }
            }


        }
        //usebus
        void usebus()
        {
            if (redball[0].x + redball[0].img.Height > bus[0].rdst.X && redball[0].x < bus[0].rdst.X + bus[0].img.Width)
            {
               if(flagdown==0/*&&flagbusupmotion==-1*/)
               {
                    redball[0].x = bus[0].rdst.X;
                    redball[0].y = bus[0].rdst.Y - redball[0].img.Height + 60;
                    busflag = 0;

               }
               

            }
            else
            {
                busflag = -1;
              
                
            }
        }


        //gravity
        void gravity()
        {
            if (redball[0].y + redball[0].img.Height < 515 && flagslm == -1)
            {
                redball[0].y += 100;
            }


            if (flagslm == 0 &&redball[0].y+ redball[0].img.Height < slm[0].rdst.Y +50)
            {
                
                 redball[0].y += 80;
                 
            }

        }

        //create

        void createbackground()
        {
            cadvimg pnn = new cadvimg();
            pnn.img = new Bitmap("rr.bmp");
            pnn.rsrc = new Rectangle(0, 0, pnn.img.Width, pnn.img.Height);
            pnn.rdst = new Rectangle(0, 0, ClientSize.Width*3, ClientSize.Height);
            background.Add(pnn);

        }

        void createRedball()
        {
            cimg pnn = new cimg();
            pnn.img = new Bitmap("1.bmp");
            pnn.x = 0;
            pnn.y = 515;
            redball.Add(pnn);
        }

        void createenemy()
        {
            cadvimg pnn = new cadvimg();
            pnn.img = new Bitmap("emyr.bmp");
           // pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn.rsrc = new Rectangle(0, 0, pnn.img.Width, pnn.img.Height);
            pnn.rdst = new Rectangle(400, 515, pnn.img.Width, pnn.img.Height);
            pnn.dir = 1;
            pnn.dir2 = 1;
            enemy.Add(pnn);


          /*  cadvimg pnn2 = new cadvimg();
            pnn2.img = new Bitmap("emyr.bmp");
            // pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
            pnn2.rsrc = new Rectangle(0, 0, pnn2.img.Width, pnn2.img.Height);
            pnn2.rdst = new Rectangle(3300, 515, pnn2.img.Width, pnn2.img.Height);
            pnn2.dir = 1;
            pnn2.dir2 = 1;
            enemy.Add(pnn2);*/
        }
      

        void createstars()
        {
            cadvimg pnn = new cadvimg();
            pnn.img = new Bitmap("stars.bmp");
            pnn.rsrc = new Rectangle(0, 0, pnn.img.Width, pnn.img.Height);
            pnn.rdst = new Rectangle(430, 515, pnn.img.Width, pnn.img.Height);
            stars.Add(pnn);

            cadvimg pnn2 = new cadvimg();
            pnn2.img = new Bitmap("stars.bmp");
            pnn2.rsrc = new Rectangle(0, 0, pnn2.img.Width, pnn2.img.Height);
            pnn2.rdst = new Rectangle(800, 515, pnn2.img.Width, pnn2.img.Height);
            stars.Add(pnn2);

            cadvimg pnn3 = new cadvimg();
            pnn3.img = new Bitmap("stars.bmp");
            pnn3.rsrc = new Rectangle(0, 0, pnn3.img.Width, pnn3.img.Height);
            pnn3.rdst = new Rectangle(1200, 515, pnn3.img.Width, pnn3.img.Height);
            stars.Add(pnn3);

            cadvimg pnn4 = new cadvimg();
            pnn4.img = new Bitmap("stars.bmp");
            pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn4.rdst = new Rectangle(1200, 515, pnn4.img.Width, pnn4.img.Height);
            stars.Add(pnn4);

            //

            cadvimg pnn5 = new cadvimg();
            pnn5.img = new Bitmap("stars.bmp");
            pnn5.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn5.rdst = new Rectangle(100, 415, pnn4.img.Width, pnn4.img.Height);
            stars.Add(pnn5);
            cadvimg pnn6 = new cadvimg();
            pnn6.img = new Bitmap("stars.bmp");
            pnn6.rsrc = new Rectangle(0, 0, pnn6.img.Width, pnn6.img.Height);
            pnn6.rdst = new Rectangle(1500,515, pnn6.img.Width, pnn6.img.Height);
            stars.Add(pnn6);
            cadvimg pnn7 = new cadvimg();
            pnn7.img = new Bitmap("stars.bmp");
            pnn7.rsrc = new Rectangle(0, 0, pnn7.img.Width, pnn7.img.Height);
            pnn7.rdst = new Rectangle(2000, 515, pnn7.img.Width, pnn7.img.Height);
            stars.Add(pnn7);
            //
            cadvimg pnn10 = new cadvimg();
            pnn10.img = new Bitmap("stars.bmp");
            pnn6.rsrc = new Rectangle(0, 0, pnn10.img.Width, pnn10.img.Height);
            pnn10.rdst = new Rectangle(3300, 515, pnn10.img.Width, pnn10.img.Height);
            stars.Add(pnn10);
            cadvimg pnn11 = new cadvimg();
            pnn11.img = new Bitmap("stars.bmp");
            pnn11.rsrc = new Rectangle(0, 0, pnn11.img.Width, pnn11.img.Height);
            pnn11.rdst = new Rectangle(3350, 515, pnn11.img.Width, pnn11.img.Height);
            stars.Add(pnn11);
            cadvimg pnn12 = new cadvimg();
            pnn12.img = new Bitmap("stars.bmp");
            pnn12.rsrc = new Rectangle(0, 0, pnn12.img.Width, pnn12.img.Height);
            pnn12.rdst = new Rectangle(3400, 515, pnn12.img.Width, pnn12.img.Height);
            stars.Add(pnn12);
            //
            cadvimg pnn13 = new cadvimg();
            pnn13.img = new Bitmap("stars.bmp");
            pnn13.rsrc = new Rectangle(0, 0, pnn13.img.Width, pnn13.img.Height);
            pnn13.rdst = new Rectangle(3450, 515, pnn13.img.Width, pnn13.img.Height);
            stars.Add(pnn13);
            cadvimg pnn14 = new cadvimg();
            pnn14.img = new Bitmap("stars.bmp");
            pnn14.rsrc = new Rectangle(0, 0, pnn14.img.Width, pnn14.img.Height);
            pnn14.rdst = new Rectangle(3500, 515, pnn14.img.Width, pnn14.img.Height);
            stars.Add(pnn14);
            cadvimg pnn15 = new cadvimg();
            pnn15.img = new Bitmap("stars.bmp");
            pnn15.rsrc = new Rectangle(0, 0, pnn15.img.Width, pnn15.img.Height);
            pnn15.rdst = new Rectangle(3550, 515, pnn15.img.Width, pnn15.img.Height);
            stars.Add(pnn15);
            //
            cadvimg pnn16 = new cadvimg();
            pnn16.img = new Bitmap("stars.bmp");
            pnn16.rsrc = new Rectangle(0, 0, pnn16.img.Width, pnn16.img.Height);
            pnn16.rdst = new Rectangle(3600, 515, pnn16.img.Width, pnn16.img.Height);
            stars.Add(pnn16);
            cadvimg pnn17 = new cadvimg();
            pnn17.img = new Bitmap("stars.bmp");
            pnn17.rsrc = new Rectangle(0, 0, pnn17.img.Width, pnn17.img.Height);
            pnn17.rdst = new Rectangle(3650, 515, pnn17.img.Width, pnn17.img.Height);
            stars.Add(pnn17);
            cadvimg pnn18 = new cadvimg();
            pnn18.img = new Bitmap("stars.bmp");
            pnn18.rsrc = new Rectangle(0, 0, pnn18.img.Width, pnn18.img.Height);
            pnn18.rdst = new Rectangle(3700, 515, pnn18.img.Width, pnn18.img.Height);
            stars.Add(pnn18);
        }


      

        void createsnon()
        {
            cadvimg pnn = new cadvimg();
            pnn.img = new Bitmap("snon.bmp");
            pnn.rsrc = new Rectangle(0, 0, pnn.img.Width, pnn.img.Height);
            pnn.rdst = new Rectangle(950, 550, 150, pnn.img.Height);
            pnn.img.MakeTransparent(pnn.img.GetPixel(0,0));
            snon.Add(pnn);

            cadvimg pnn2 = new cadvimg();
            pnn2.img = new Bitmap("snon.bmp");
            pnn2.rsrc = new Rectangle(0, 0, pnn2.img.Width, pnn2.img.Height);
            pnn2.rdst = new Rectangle(1350, 550, 150, pnn2.img.Height);
            pnn2.img.MakeTransparent(pnn2.img.GetPixel(0, 0));
            snon.Add(pnn2);

            cadvimg pnn3 = new cadvimg();
            pnn3.img = new Bitmap("snon.bmp");
            pnn3.rsrc = new Rectangle(0, 0, pnn3.img.Width, pnn3.img.Height);
            pnn3.rdst = new Rectangle(1700, 550, 150, pnn3.img.Height);
            pnn3.img.MakeTransparent(pnn3.img.GetPixel(0, 0));
            snon.Add(pnn3);

            
          
        }

        

        void createstone()
        {
            cadvimg pnn4 = new cadvimg();
            pnn4.img = new Bitmap("stone.bmp");
            pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn4.rdst = new Rectangle(seatwo[0].rdst.X+100 + 250 + seatwo[0].img.Width, 490, 100, 100);
            stone.Add(pnn4);
        }
        void createbox()
        {
            cadvimg pnn = new cadvimg();
            pnn.img = new Bitmap("box.bmp");
            pnn.rsrc = new Rectangle(0, 0, pnn.img.Width, pnn.img.Height);
            pnn.rdst = new Rectangle(3350, 515, enemy[0].img.Width, enemy[0].img.Height);
            //pnn.rdst = new Rectangle(background[0].rdst.X, 515, enemy[0].img.Width, enemy[0].img.Height);
            boxes.Add(pnn);
        }
        void createseatwo()
        {
            cadvimg pnn4 = new cadvimg();
            pnn4.img = new Bitmap("stonesea.bmp");
            pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn4.rdst = new Rectangle(2300, 540, pnn4.img.Width, pnn4.img.Height);
            seatwo.Add(pnn4);
        }


        void createslm()
        {
            cadvimg pnn = new cadvimg();
            pnn.img = new Bitmap("slm.bmp");
            pnn.rsrc = new Rectangle(0, 0, pnn.img.Width/2, pnn.img.Height);
            pnn.rdst = new Rectangle(2000, 515, 200, 100);
           slm.Add(pnn);

            cadvimg pnn2 = new cadvimg();
            pnn2.img = new Bitmap("slm.bmp");
            pnn2.rsrc = new Rectangle(pnn.img.Width / 2, 0, pnn2.img.Width, pnn2.img.Height);
            pnn2.rdst = new Rectangle(2200, 515, 200, 100);
            slm.Add(pnn2);

            cadvimg pnn3 = new cadvimg();
            pnn3.img = new Bitmap("slm.bmp");
            pnn3.rsrc = new Rectangle(0, 0, pnn.img.Width / 2, pnn.img.Height);
            pnn3.rdst = new Rectangle(2000, 480, 200, 100);
            slm.Add(pnn3);
        }

        void createbus()
        {
            cadvimg pnn2 = new cadvimg();
            pnn2.img = new Bitmap("slm.bmp");
            pnn2.rsrc = new Rectangle(0, 0, pnn2.img.Width/2, pnn2.img.Height);
            pnn2.rdst = new Rectangle(2300, 475, 200, 100);
            pnn2.dir = 1;
            bus.Add(pnn2);
        }

        void createwin()
        {
            cadvimg pnn2 = new cadvimg();
            pnn2.img = new Bitmap("win.bmp");
            pnn2.rsrc = new Rectangle(0, 0, pnn2.img.Width, pnn2.img.Height);
            pnn2.rdst = new Rectangle(background[0].rdst.Width - pnn2.img.Width - 50, 515, pnn2.img.Width, pnn2.img.Height);
            win.Add(pnn2);

        }
        void createland()
        {
            cadvimg pnn4 = new cadvimg();
            pnn4.img = new Bitmap("land.bmp");
            pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn4.rdst = new Rectangle(stone[0].rdst.X , stone[0].rdst.Y-120, 100, 100);
            land.Add(pnn4);
        }

        void loserr()
        {
            cadvimg pnn4 = new cadvimg();
            pnn4.img = new Bitmap("loserrr.bmp");
            pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn4.rdst = new Rectangle(0, 0, ClientSize.Width,ClientSize.Height);
            loser.Add(pnn4);
        }

        void winner()
        {
            cadvimg pnn4 = new cadvimg();
            pnn4.img = new Bitmap("winner.bmp");
            pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn4.rdst = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height);
            winnn.Add(pnn4);
        }
        void createcloud()
        {
            Random rr=new Random();
            int x = rr.Next(2, 3000);
            cadvimg pnn4 = new cadvimg();
            pnn4.img = new Bitmap("cloud.bmp");
            pnn4.img.MakeTransparent(pnn4.img.GetPixel(0,0));
            pnn4.rsrc = new Rectangle(0, 0, pnn4.img.Width, pnn4.img.Height);
            pnn4.rdst = new Rectangle(x, 0, 50, 50);
            cloud.Add(pnn4);
        }


 


    }
}
