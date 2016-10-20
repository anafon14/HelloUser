/**

 * Name: Ana Luiza Fonseca Teixeira

 * Teacher: Mr. Hadrman

 * Assignment #2, Program #1

 * Date Last Modified: 10/17/2016

 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloUser
{
    public partial class frmHelloUser : Form
    {
        public frmHelloUser()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "Hello User! Can you please fill out the information below?";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            //variables are created 
            String userName;
            String userLastName;
            double userAge;
            double ageDifference;
            double secondAgeDifference;

          
            userName = txtFirstName.Text;
            userLastName = txtLastName.Text;
            userAge = Convert.ToDouble(txtAge.Text);
            ageDifference = 14 - userAge;
            secondAgeDifference = userAge - 14;

            // display this if user is younger than 13 years old
            if (userAge < 13)
            {

                lblDone.Text = " Nice to meet you " + userName + " " + userLastName + '!'.ToString() + "\n You are " + ageDifference + " years younger than me!";

            }

            //display this if user is 13 years old
            else if (userAge == 13)
            {

                lblDone.Text = " Nice to meet you " + userName + " " + userLastName + '!'.ToString() + "\n You are one year younger than me!";

            }

            //display this if user is 14 years old
            else if (userAge == 14)
            {

                lblDone.Text = " Nice to meet you " + userName + " " + userLastName + '!'.ToString() + "\n You are the same age as me!";
            }

            //display this if user is 15 years old
            else if (userAge == 15)
            {

                lblDone.Text = " Nice to meet you " + userName + " " + userLastName + '!'.ToString() + "\n You are one year older than me!";

            }

            //display this if user's age doesn't fit any of the descriptions above, meaning the user is older than 15
            else
            {

                lblDone.Text = " Nice to meet you " + userName + " " + userLastName + '!'.ToString() + "\n You are " + secondAgeDifference + " years older than me!";
            }

        }
    }
}
