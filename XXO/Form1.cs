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

        Random Rnd = new Random(); // initialisiert die Zufallsklasse

        private int winCounterPlayer1 = 1;

        private int winCounterPlayer2 = 1;

        private int[,] gameBoard = new int[3, 3];

        List<int> diceArray = new List<int>();

        public int i = 8;

        public Form1()
        {
            InitializeComponent();
            fillArray();
        }

        private void fillArray()
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    gameBoard[i, j] = 0;
                }
            }
            for (int i = 1; i <= 9; i++)
            {
                diceArray.Add(i);
            }
        }

        public void clearBoard()
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    gameBoard[i, j] = 0;
                }
            }

            System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
            this.Close(); //to turn off current app

            box1.Image = null;
            box2.Image = null;
            box3.Image = null;
            box4.Image = null;
            box5.Image = null;
            box6.Image = null;
            box7.Image = null;
            box8.Image = null;
            box9.Image = null;

            box1.Enabled = true;
            box2.Enabled = true;
            box3.Enabled = true;
            box4.Enabled = true;
            box5.Enabled = true;
            box6.Enabled = true;
            box7.Enabled = true;
            box8.Enabled = true;
            box9.Enabled = true;

            this.i = 8;

            diceArray.Clear();

            for (int i = 1; i <= 9; i++)
            {
                diceArray.Add(i);
            }
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



        public Boolean calcWinnerXHori()
        {
            if ((gameBoard[0, 0] == 2 && gameBoard[0, 1] == 2 && gameBoard[0, 2] == 2) || (gameBoard[1, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[1, 2] == 2) || (gameBoard[2, 0] == 2 && gameBoard[2, 1] == 2 && gameBoard[2, 2] == 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean calcWinnerXVert()
        {
            if ((gameBoard[0, 0] == 2 && gameBoard[1, 0] == 2 && gameBoard[2, 0] == 2) || (gameBoard[0, 1] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 1] == 2) || (gameBoard[0, 2] == 2 && gameBoard[1, 2] == 2 && gameBoard[2, 2] == 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean calcWinnerXDiag()
        {
            if ((gameBoard[0, 0] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 2] == 2) || (gameBoard[0, 2] == 2 && gameBoard[1, 1] == 2 && gameBoard[2, 0] == 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean calcWinnerOHori()
        {
            if ((gameBoard[0, 0] == 1 && gameBoard[0, 1] == 1 && gameBoard[0, 2] == 1) || (gameBoard[1, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[1, 2] == 1) || (gameBoard[2, 0] == 1 && gameBoard[2, 1] == 1 && gameBoard[2, 2] == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean calcWinnerOVert()
        {
            if ((gameBoard[0, 0] == 1 && gameBoard[1, 0] == 1 && gameBoard[2, 0] == 1) || (gameBoard[0, 1] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 1] == 1) || (gameBoard[0, 2] == 1 && gameBoard[1, 2] == 1 && gameBoard[2, 2] == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean calcWinnerODiag()
        {
            if ((gameBoard[0, 0] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 2] == 1) || (gameBoard[0, 2] == 1 && gameBoard[1, 1] == 1 && gameBoard[2, 0] == 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void xPlayerTurn(int field)
        {
            i--;
            if (i > 0)
                diceArray.Remove(field);
        }

        private void oPlayerTurn(int field)
        {

            int rnd = 0;
            i--;
            if (i > 0)
            {
                rnd = Rnd.Next(0, i);
                diceArray.Remove(field);
            }
            else
            {
                rnd = 0;

            }

            switch (diceArray[rnd])
            {
                case 1:
                    box1_Click(null, null);
                    break;
                case 2:
                    box2_Click(null, null);
                    break;
                case 3:
                    box3_Click(null, null);
                    break;
                case 4:
                    box4_Click(null, null);
                    break;
                case 5:
                    box5_Click(null, null);
                    break;
                case 6:
                    box6_Click(null, null);
                    break;
                case 7:
                    box7_Click(null, null);
                    break;
                case 8:
                    box8_Click(null, null);
                    break;
                case 9:
                    box9_Click(null, null);
                    break;
            }
        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box1.Image = Properties.Resources.O;
                flag = false;
                gameBoard[0, 0] = 1;
                xPlayerTurn(1);
            }
            else
            {
                this.box1.Image = Properties.Resources.X;
                flag = true;
                gameBoard[0, 0] = 2;
                oPlayerTurn(1);
            }
            box1.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }

        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box2.Image = Properties.Resources.O;
                flag = false;
                gameBoard[0, 1] = 1;
                xPlayerTurn(2);
            }
            else
            {
                this.box2.Image = Properties.Resources.X;
                flag = true;
                gameBoard[0, 1] = 2;
                oPlayerTurn(2);

            }
            box2.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box3.Image = Properties.Resources.O;
                flag = false;
                gameBoard[0, 2] = 1;
                xPlayerTurn(3);
            }
            else
            {
                this.box3.Image = Properties.Resources.X;
                flag = true;
                gameBoard[0, 2] = 2;
                oPlayerTurn(3);
            }
            box3.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box4.Image = Properties.Resources.O;
                flag = false;
                gameBoard[1, 0] = 1;
                xPlayerTurn(4);
            }
            else
            {
                this.box4.Image = Properties.Resources.X;
                flag = true;
                gameBoard[1, 0] = 2;
                oPlayerTurn(4);
            }
            box4.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box5.Image = Properties.Resources.O;
                flag = false;
                gameBoard[1, 1] = 1;
                xPlayerTurn(5);
            }
            else
            {
                this.box5.Image = Properties.Resources.X;
                flag = true;
                gameBoard[1, 1] = 2;
                oPlayerTurn(5);
            }
            box5.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box6.Image = Properties.Resources.O;
                flag = false;
                gameBoard[1, 2] = 1;
                xPlayerTurn(6);
            }
            else
            {
                this.box6.Image = Properties.Resources.X;
                flag = true;
                gameBoard[1, 2] = 2;
                oPlayerTurn(6);
            }
            box6.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box7.Image = Properties.Resources.O;
                flag = false;
                gameBoard[2, 0] = 1;
                xPlayerTurn(7);
            }
            else
            {
                this.box7.Image = Properties.Resources.X;
                flag = true;
                gameBoard[2, 0] = 2;
                oPlayerTurn(7);
            }
            box7.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box8.Image = Properties.Resources.O;
                flag = false;
                gameBoard[2, 1] = 1;
                xPlayerTurn(8);
            }
            else
            {
                this.box8.Image = Properties.Resources.X;
                flag = true;
                gameBoard[2, 1] = 2;
                oPlayerTurn(8);
            }
            box8.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                this.box9.Image = Properties.Resources.O;
                flag = false;
                gameBoard[2, 2] = 1;
                xPlayerTurn(9);
            }
            else
            {
                this.box9.Image = Properties.Resources.X;
                flag = true;
                gameBoard[2, 2] = 2;
                oPlayerTurn(9);
            }
            box9.Enabled = false;
            if (calcWinnerXHori() || calcWinnerXVert() || calcWinnerXDiag())
            {
                MessageBox.Show("You Win");
                clearBoard();
            }
            if (calcWinnerOHori() || calcWinnerOVert() || calcWinnerODiag())
            {
                MessageBox.Show("You Loose");
                clearBoard();
            }
        }
    }
}

/*private int toDecimal(int x, int y)
{
    int result = 0;
    switch (x)
    {
        case 0:
            switch (y)
            {
                case 0:
                    result = 1;
                    break;
                case 1:
                    result = 2;
                    break;
                case 2:
                    result = 3;
                    break;
            }
            break;
        case 1:
            switch (y)
            {
                case 0:
                    result = 4;
                    break;
                case 1:
                    result = 5;
                    break;
                case 2:
                    result = 6;
                    break;
            }
            break;
        case 2:
            switch (y)
            {
                case 0:
                    result = 7;
                    break;
                case 1:
                    result = 8;
                    break;
                case 2:
                    result = 9;
                    break;
            }
            break;
    }
    return result;
}*/

/* private int[] calcDiceArray()
{

for (int j = 0; j < 9; j++)
{
 if (j != rnd && diceArray[j] != 0)
 {
     diceArray[j] = j + 1;
 }
 else
 {
     diceArray[j] = 0;
 }
}

/* for (int k = 0; k < 8 - i; k++)
{
 if (k < rnd)
 {
     resultDiceArray[k] = diceArray[k];
 }
 else
 {
     resultDiceArray[k] = diceArray[k + 1];

 }
}

return diceArray;
}*/