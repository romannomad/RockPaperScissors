using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    
    public partial class form1 : Form
    {
        Random random = new Random();
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int computerTurn = random.Next(1, 4);
            int playerTurn = random.Next(1, 4);

            switch (computerTurn)
            {
                case 1:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Rock.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Paper.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Scissors.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox2.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Rock.png";
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            switch (playerTurn)
            {
                case 1:
                    pictureBox3.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Rock.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pictureBox3.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Paper.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 3:
                    pictureBox3.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Scissors.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox3.ImageLocation = @"D:\C# Projects\Windows Forms Projects\10 Rock Paper Scissors\Images\Rock.png";
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }

            determineWinner(computerTurn, playerTurn);
        }
        public void determineWinner(int computerScore, int playerScore)
        {
            if (computerScore == 1 && playerScore == 2)
            {
                label1.Text = "You win, congrats!";
            }
            else if (computerScore == 1 && playerScore == 3)
            {
                label1.Text = "You lose, the computer wins!";
            }
            else if (computerScore == 2 && playerScore == 1)
            {
                label1.Text = "You lose, the computer wins!";
            }
            else if (computerScore == 2 && playerScore == 3)
            {
                label1.Text = "You win, congrats!";
            }
            else if (computerScore == 3 && playerScore == 1)
            {
                label1.Text = "You win, congrats!";
            }
            else if (computerScore == 3 && playerScore == 2)
            {
                label1.Text = "You lose, the computer wins!";
            }
            else
            {
                label1.Text = "There is a tie!";
            }

        }
    }
}
