using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XXO
{
    public partial class Form1 : Form
    {

        private Boolean flag = false;

        private int winCounterPlayer1 = 1;

        private int winCounterPlayer2 = 1;

        private int[,] gameBoard = new int[3,3];

        public Form1()
        {
            InitializeComponent();
        }

        //Draw grid
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Create pen.
            Pen pen = new Pen(Color.Black, 3);

            // Create points that define the lines.
            Point point1 = new Point(5, 175);
            Point point2 = new Point(575, 175);
            Point point3 = new Point(5, 375);
            Point point4 = new Point(575, 375);
            Point point5 = new Point(200, 5);
            Point point6 = new Point(200, 550);
            Point point7 = new Point(400, 5);
            Point point8 = new Point(400, 550);

            //Draw grid
            e.Graphics.DrawLine(pen, point1, point2);
            e.Graphics.DrawLine(pen, point3, point4);
            e.Graphics.DrawLine(pen, point5, point6);
            e.Graphics.DrawLine(pen, point7, point8);
        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box1.Image = Properties.Resources.O;
                flag = false;
                gameBoard[0, 0] = 0;
            }
            else
            {
                this.box1.Image = Properties.Resources.X;
                flag = true;
                gameBoard[0, 0] = 1;
            }
            box1.Enabled = false;
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box2.Image = Properties.Resources.O;
                flag = false;
                gameBoard[0, 1] = 0;
            }
            else
            {
                this.box2.Image = Properties.Resources.X;
                flag = true;
                gameBoard[0, 1] = 1;
            }
            box2.Enabled = false;
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box3.Image = Properties.Resources.O;
                flag = false;
                gameBoard[0, 2] = 0;
            }
            else
            {
                this.box3.Image = Properties.Resources.X;
                flag = true;
                gameBoard[0, 2] = 1;
            }
            box3.Enabled = false;
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box4.Image = Properties.Resources.O;
                flag = false;
                gameBoard[1, 0] = 0;
            }
            else
            {
                this.box4.Image = Properties.Resources.X;
                flag = true;
                gameBoard[1, 0] = 1;
            }
            box4.Enabled = false;
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box5.Image = Properties.Resources.O;
                flag = false;
                gameBoard[1, 1] = 0;
            }
            else
            {
                this.box5.Image = Properties.Resources.X;
                flag = true;
                gameBoard[1, 1] = 1;
            }
            box5.Enabled = false;
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box6.Image = Properties.Resources.O;
                flag = false;
                gameBoard[1, 2] = 0;
            }
            else
            {
                this.box6.Image = Properties.Resources.X;
                flag = true;
                gameBoard[1, 2] = 1;
            }
            box6.Enabled = false;
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box7.Image = Properties.Resources.O;
                flag = false;
                gameBoard[2, 0] = 0;
            }
            else
            {
                this.box7.Image = Properties.Resources.X;
                flag = true;
                gameBoard[2, 0] = 1;
            }
            box7.Enabled = false;
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box8.Image = Properties.Resources.O;
                flag = false;
                gameBoard[2, 1] = 0;
            }
            else
            {
                this.box8.Image = Properties.Resources.X;
                flag = true;
                gameBoard[2, 1] = 1;
            }
            box8.Enabled = false;
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box9.Image = Properties.Resources.O;
                flag = false;
                gameBoard[2, 2] = 0;
            }
            else
            {
                this.box9.Image = Properties.Resources.X;
                flag = true;
                gameBoard[2, 2] = 1;
            }
            box9.Enabled = false;
        }
    }
}
