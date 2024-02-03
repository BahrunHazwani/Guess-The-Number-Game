using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        ContextMenuStrip emptyStrip = new ContextMenuStrip();
        Random random = new Random();
        int randomNumber = 0;

        static int turns = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblMSG_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxNumber.ContextMenuStrip = emptyStrip;
            listView1.ContextMenuStrip = emptyStrip;
            InitializeGame();

        }

        private void tbxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult game;
            int userInput = 0;
            // control for empty textbox
            if (!(int.TryParse(tbxNumber.Text, out userInput)))
            {
                lblMSG.Text = "You can't leave the textbox empty";
                return;
            }

            // control for range
            if(userInput < 1 || userInput > 500)
            {
                lblMSG.Text = "Enter number in the range of 1 to 500";
                return;
            }
            
            if(turns == 0)
            {
                lblMSG.Text = "Game Over \r\n The secret number is " + randomNumber;
                tbxNumber.ReadOnly = true;
                button1.Enabled = false;
                game = MessageBox.Show("Play Again?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (game == DialogResult.Yes)
                {
                    label6_Click(sender, e);
                    InitializeGame();
                    listView1.Items.Clear();
                }
                if (game != DialogResult.Yes)
                {
                    MessageBox.Show("Thank You");
                    this.Close();
                }
                return;
            }

            if(userInput > randomNumber)
            {
                lblMSG.Text = "Please guess smaller number";
            }
            
            if(userInput < randomNumber) 
            {
                lblMSG.Text = "Please guess bigger number";
            }

            if(userInput == randomNumber)
            {
                lblMSG.Text = "You are win";
                tbxNumber.ReadOnly = true;
                button1.Enabled = false;

                if (turns <= 3)
                {
                    label2.Text = "You managed to guess the number in " + turns + " th turn" + "\r\n" + "GOOD, YOU MADE IT!";
                }
                else if (turns <= 7)
                {
                    label2.Text = "You managed to guess the number in " + turns + " th turn" + "\r\n" + "GREAT, YOU ARE CLEVER";
                }
                else if (turns == 10)
                {
                    label2.Text = "You managed to guess the number in ONE try only"+ "\r\n" + "WOW, YOU ARE A GENIUS";
                }
                else
                {
                    label2.Text = "You managed to guess the number in " + turns + " th turn"+ "\r\n" + "WOW, YOU ARE A GENIUS" + "\r\n";
                }

                game = MessageBox.Show("Play Again?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (game == DialogResult.Yes)
                {
                    label6_Click(sender, e);
                    InitializeGame();
                    listView1.Items.Clear();
                }
                if (game != DialogResult.Yes)
                {
                    MessageBox.Show("Thank You");
                    this.Close();
                }
                return;
            }

            listView1.Items.Add(""+ userInput);
            turns -= 1;
            label3.Text = "Turns left:  " + turns;
            progressBar1.Value = turns;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            randomNumber = random.Next(1, 501);
            turns = 10;
            progressBar1.Value = 10;
            button1.Enabled = true;
            tbxNumber.ReadOnly = false;
            lblMSG.Text = "";
            tbxNumber.Text = "";
            label2.Text = "";
            label3.Text = "Turns Left: ";
            listView1.ContextMenuStrip = emptyStrip;
        }

        private void label6_Click(object sender, EventArgs e)
        {}
    }
}
