using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_8_Ball
{
    public partial class magicBall : Form
    {
        Random randGen = new Random();

        public magicBall()
        {
            InitializeComponent();
        }

        private void clickButton_Click(object sender, EventArgs e)
        {
            int randomNum = randGen.Next(1, 7);

            switch(randomNum)
            {
                case 1:
                    outputLabel.Text = "Reply Hazy, Try Again";
                    break;
                case 2:
                    outputLabel.Text = "Very Doubtful";
                    break;
                case 3:
                    outputLabel.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "Most Likely";
                    break;
                case 5:
                    outputLabel.Text = "Cannot Predict Now, Try Again Later";
                    break;
                case 6:
                    outputLabel.Text = "Yes";
                    break;
            }
        }
    }
}
