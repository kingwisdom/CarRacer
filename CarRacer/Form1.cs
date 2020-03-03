using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacer
{
    public partial class Form1 : Form
    {
        int gamespeed = 0;
        int collectedCoin = 0;
        public Form1()
        {
            InitializeComponent();
            lblGameover.Visible = false;
            btnReplay.Visible = false;
            lblScores.Visible = false;
            
        }

        void GameOver()
        {
            //DialogResult iExit;
            

            if (car.Bounds.IntersectsWith(enemy1.Bounds))
            {
                //do
                //{


                    timer1.Enabled = false;
                    lblGameover.Visible = true;

                    lblScores.Text = "Total " + lblTotalCoin.Text;
                    lblScores.Visible = true;
                    btnReplay.Visible = true;

                     //iExit = MessageBox.Show("Do You want To Try Again ", "Car Race", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //if (iExit == DialogResult.Yes)
                //{
                //    timer1.Enabled = true;
                //    Form1.Refresh();
                //}
                //}
                //while (iExit == DialogResult.Yes);

            }

            if (car.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                lblScores.Text = "Total " + lblTotalCoin.Text;
                lblScores.Visible = true;
                lblGameover.Visible = true;
                btnReplay.Visible = true;
            }
            if (car.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                lblScores.Text = "Total " + lblTotalCoin.Text;
                lblScores.Visible = true;
                lblGameover.Visible = true;
                btnReplay.Visible = true;
            }
                
                
            
        }

        
        int x;

        void CoinCollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedCoin++;
                lblTotalCoin.Text = "Coin: " + collectedCoin;

                x = r.Next(240, 370);
                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedCoin++;
                lblTotalCoin.Text = "Coin: " + collectedCoin;

                x = r.Next(240, 370);
                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedCoin++;
                lblTotalCoin.Text = "Coin: " + collectedCoin;

                x = r.Next(240, 370);
                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedCoin++;
                lblTotalCoin.Text = "Coin: " + collectedCoin;

                x = r.Next(240, 370);
                coin4.Location = new Point(x, 0);
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {            
            moveLine(gamespeed);
            Enemy(gamespeed);
            GameOver();
            Coin(gamespeed);
            CoinCollection();
            lblSpeed.Text = "Speed: " + gamespeed;
      
        }

        Random r = new Random();
        //int x;
        void Enemy(int speed)
        {
            if(enemy3.Top >= 500)
            {
                x = r.Next(10, 120);
                enemy3.Location = new Point(x, 0);
            }
            else
            {
                enemy3.Top += speed;
            }

            //enemy 2
            if (enemy2.Top >= 500)
            {
                x = r.Next(130, 240);
                enemy2.Location = new Point(x, 0);
            }
            else
            {
                enemy2.Top += speed;
            }

            // enemy 3
            if (enemy1.Top >= 500)
            {
                x = r.Next(240, 370);
                enemy1.Location = new Point(x, 0);
            }
            else
            {
                enemy1.Top += speed;
            }
        }

        void Coin(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(10, 120);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(10, 300);
                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin3.Top >= 500)
            {
                x = r.Next(10, 370);
                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(80, 320);
                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }


            void moveLine(int speed)
        {
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }

            

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }


            if (pictureBox5.Top >= 500)
            {
                pictureBox5.Top = 0;
            }
            else
            {
                pictureBox5.Top += speed;
            }
        }
        
        private void Form_1_keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if (car.Left > 13)
                car.Left += -10;
            }
            if(e.KeyCode == Keys.Right)
            {
                if (car.Right < 370)
                car.Left += 10;
            }
            if(e.KeyCode == Keys.Up) 
                if(gamespeed < 21) { gamespeed++; }

            if(e.KeyCode == Keys.Down)
                if(gamespeed > 0) { gamespeed--; }
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            //this.Refresh();
            Application.Restart();

        }
    }
}
