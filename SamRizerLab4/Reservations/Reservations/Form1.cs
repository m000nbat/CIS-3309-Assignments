using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public bool IsValidData()
        //{

        //}

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //public bool IsDateTime(TextBox textBox, string name)
        //{

        //}

        //public bool IsWithinRange(TextBox textBox, string name,
        //    DateTime min, DateTime max)
        //{

        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = Convert.ToDateTime(txtArrivalDate.ToString());
            DateTime departureDate = Convert.ToDateTime(txtDepartureDate.ToString());


        }
    }
}