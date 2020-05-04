using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Strength
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstimateStrength_Click(object sender, EventArgs e)
        {
            // Variable
            string password = txtPassword.Text;

            // Good result based on the "Basic" password most websites require at a minimum
            if (password.Length > 10 && password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Any(char.IsPunctuation))
            {
                lblResult.Text = "Good";  // Setting Label to Good Text
                lblResult.BackColor = Color.LightGreen;  // Setting Label to Green Color
            }
            // Ok result based on slightly less advanced password, and all around less secure
            else if (password.Length > 7 && password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                lblResult.Text = "Ok";  // Setting Label to Ok Text
                lblResult.BackColor = Color.Orange;  // Setting Label to Orange Color
            }
            else
            // Poor result based on very weak password without much complexity
            {
                lblResult.Text = "Poor";  // Setting Label to Poor Text
                lblResult.BackColor = Color.Red;  // Setting Label to Red Color
            }
        }
    }
}
