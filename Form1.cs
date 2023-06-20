using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        private bool isGameOver = false;

        public Form1()
        {
            InitializeComponent();
            gameOverPanel.Visible = false;
            button1.Click += button1_Click;
            isGameOver = false;
        }

        private void gameTimmerEvent(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipeisBottom.Left -= pipeSpeed;
            pipeisTop.Left -= pipeSpeed;
            label1.Text = score.ToString();

            if(pipeisBottom.Left < -150)
            {
                pipeisBottom.Left = 800;
                score++;
            }
            if(pipeisTop.Left <-80)
            {
                pipeisTop.Left = 850;
                score++;
            }

            if(flappy.Bounds.IntersectsWith(pipeisBottom.Bounds) || 
                flappy.Bounds.IntersectsWith(pipeisTop.Bounds)||
                flappy.Bounds.IntersectsWith(ground .Bounds))
            {
                gameEnd();
            }


            if(score > 5)
            {
                pipeSpeed = 15;
            }

            if(flappy.Top < -25)
            {
                gameEnd();
            }

        }

        private void flalppy_Click(object sender, EventArgs e)
        {

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver && e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void gameEnd()
        {
            timer1.Stop();
            label3.Text += score;
            isGameOver = true;
            gameOverPanel.Visible = true;
            
        }

        private void Text1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pipeSpeed = 8;
            gravity = 5;
            score = 0;
            label1.Text = score.ToString();

            pipeisBottom.Left = 800;
            pipeisTop.Left = 850;

            flappy.Top = 15;


            timer1.Start();

            gameOverPanel.Visible = false;
        }
    }
}
