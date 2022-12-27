using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class Form1 : Form
    {
        Fraction myFraction = new Fraction();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CopyNumer_Click(object sender, EventArgs e)
        {
            int temp;

            try
            {
               temp = Convert.ToInt32(NumerTextBox.Text);
            }

            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please give a valid value";
                return;
            }

            myFraction.Numerator = temp;
            NumerLabel.Text = Convert.ToString(temp);
        }

        private void CopyDenomi_Click(object sender, EventArgs e)
        {
            int temp;

            try
            {
                temp = Convert.ToInt32(DenomiTextBox.Text);
            }

            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please give a valid value";
                return;
            }

            myFraction.Dominator = temp;
            DenomiLabel.Text = Convert.ToString(temp);

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
            if (DisplayValue.Checked == true)
            {
               if (_3DigRadioButton.Checked == true)
                    ValueLabel.Text = myFraction.Value().ToString("0.000");
                if (_5DigRadioButton.Checked == true)
                    ValueLabel.Text = myFraction.Value().ToString("0.00000");
                if (_10DigRadioButton.Checked == true)
                    ValueLabel.Text = myFraction.Value().ToString("0.0000000000");

            }
            
            else
                ValueLabel.Text = "--";
        

        }
    }
    }

