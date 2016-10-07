using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diceSimulator
{
    public partial class dieSimulator : Form
    {
        public dieSimulator()
        {
            InitializeComponent();
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            //Variable to indicate which die is shown
            int dieShown1;
            int dieShown2;

            //Create Random object.
            Random rand = new Random();

            //Get a random interger in the range of 0-6 to correspond with the die number
            dieShown1 = rand.Next(1, 6+1);
            dieShown2 = rand.Next(1, 6 + 1);

            //Display Dice 1 side that is up
            if (dieShown1 == 1)
            {
                //Display Dice 1 with 1:
                dice1PictureBox.Visible = true;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;

                
            }
            else if (dieShown1 == 2)
            {
                //Display Dice 1 with 2:
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = true;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;
            }
            else if (dieShown1 == 3)
            {
                //Display Dice 1 with 3:
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = true;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;
            }
            else if (dieShown1 == 4)
            {
                //Display Dice 1 with 4:
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = true;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = false;
            }
            else if (dieShown1 == 5)
            {
                //Display Dice 1 with 5:
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = true;
                dice6PictureBox.Visible = false;
            }
            else if (dieShown1 == 6)
            {
                //Display Dice 1 with 6:
                dice1PictureBox.Visible = false;
                dice2PictureBox.Visible = false;
                dice3PictureBox.Visible = false;
                dice4PictureBox.Visible = false;
                dice5PictureBox.Visible = false;
                dice6PictureBox.Visible = true;
            }

            

            //Display Dice 2 side that is up
            if (dieShown2 == 1)
            {
                //Display Dice 2 with 1:
                dice1PictureBox2.Visible = true;
                dice2PictureBox2.Visible = false;
                dice3PictureBox2.Visible = false;
                dice4PictureBox2.Visible = false;
                dice5PictureBox2.Visible = false;
                dice6PictureBox2.Visible = false;
            }
            else if (dieShown2 == 2)
            {
                //Display Dice 2 with 2:
                dice1PictureBox2.Visible = false;
                dice2PictureBox2.Visible = true;
                dice3PictureBox2.Visible = false;
                dice4PictureBox2.Visible = false;
                dice5PictureBox2.Visible = false;
                dice6PictureBox2.Visible = false;
            }
            else if (dieShown2 == 3)
            {
                //Display Dice 2 with 3:
                dice1PictureBox2.Visible = false;
                dice2PictureBox2.Visible = false;
                dice3PictureBox2.Visible = true;
                dice4PictureBox2.Visible = false;
                dice5PictureBox2.Visible = false;
                dice6PictureBox2.Visible = false;
            }
            else if (dieShown2 == 4)
            {
                //Display Dice 2 with 4:
                dice1PictureBox2.Visible = false;
                dice2PictureBox2.Visible = false;
                dice3PictureBox2.Visible = false;
                dice4PictureBox2.Visible = true;
                dice5PictureBox2.Visible = false;
                dice6PictureBox2.Visible = false;
            }
            else if (dieShown2 == 5)
            {
                //Display Dice 2 with 5:
                dice1PictureBox2.Visible = false;
                dice2PictureBox2.Visible = false;
                dice3PictureBox2.Visible = false;
                dice4PictureBox2.Visible = false;
                dice5PictureBox2.Visible = true;
                dice6PictureBox2.Visible = false;
            }
            else if (dieShown2 == 6)
            {
                //Display Dice 2 with 6:
                dice1PictureBox2.Visible = false;
                dice2PictureBox2.Visible = false;
                dice3PictureBox2.Visible = false;
                dice4PictureBox2.Visible = false;
                dice5PictureBox2.Visible = false;
                dice6PictureBox2.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
