using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Created by: Mackenzie Brown Plourde
 * Created on: 20 02 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Circumfernence
 * This program calculates circumfrenece
*/
namespace CircumfranceMack
{
    
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {

            //hide lables
            InitializeComponent();
            this.lblAnswer.Hide();
            this.lblCircumference.Hide();
        }

        private void CircumfranceForm_Load(object sender, EventArgs e)
        {

        }

        private void lblCircumference_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { //declares variables
            double radius,answer;
            
            //shows hiden lables
            this.lblAnswer.Show();
            this.lblCircumference.Show();
            //get input from text box to use in formula
            radius = double.Parse(txtInput.Text);
            answer = 2 * 3.14 * radius;
            this.lblAnswer.Text = Convert.ToString(answer);


        }
    }
}
