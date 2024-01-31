using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_konkeyCrab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            label2.Visible = false;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            pictureBox3.Parent = pictureBox1;
            pictureBox3.BackColor = Color.Transparent;

            pictureBox4.Parent = pictureBox1;
            pictureBox4.BackColor = Color.Transparent;

            pictureBox5.Parent = pictureBox1;
            pictureBox5.BackColor = Color.Transparent;

            pictureBox6.Parent = pictureBox1;
            pictureBox6.BackColor = Color.Transparent;
        }

        Random rd = new Random();
        int x, y;

        public void Kaki(int fall)
        {
            if (pictureBox4.Top >= 500)
            {
                x = rd.Next(50,700);
                pictureBox4.Location = new Point(x, 0);
            }
            else
            {
                pictureBox4.Top += fall;
            }

            if (pictureBox5.Top >= 500)
            {
                x = rd.Next(50, 700);
                pictureBox5.Location = new Point(x, 0);
            }
            else
            {
                pictureBox5.Top += fall;
            }

            if (pictureBox6.Top >= 500)
            {
                x = rd.Next(50, 700);
                pictureBox6.Location = new Point(x, 0);
            }
            else
            {
                pictureBox6.Top += fall;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Kaki(10);
            Collection();
            GameOver();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox2.Left += -10;

            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox2.Left += 10;
            }
        }

        int count = 0;

        public void Collection()
        {
            if (pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                count++;
                label1.Text = "Point" + count.ToString();
                x = rd.Next(50, 700);
                pictureBox4.Location = new Point(x, 0);
            }

            if (pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                count--;
                label1.Text = "Point" + count.ToString();
                x = rd.Next(50, 700);
                pictureBox5.Location = new Point(x, 0);
            }

            if (pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                count--;
                label1.Text = "Point" + count.ToString();
                x = rd.Next(50, 700);
                pictureBox6.Location = new Point(x, 0);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public void GameOver()
        {
            if (count == 5)
            {
                label2.ForeColor = Color.Blue;
                label2.Visible = true;
                timer1.Enabled = false;
            }
            if (count == -3)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "腹を壊した";
                label2.Visible = true;
                timer1.Enabled = false;
            }
            {
                
            }
        }


    }

}
