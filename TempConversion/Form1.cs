using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class txt_ : Form
    {
        public txt_()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_celsuis_Click(object sender, EventArgs e)
        {

        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {

        }

        private void btn_fahrenheit_Click(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }

        private void convertFromFahrenheit()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_fahrenheit.Text); //convert number to string
            }
            catch (Exception)
            {
                throw;
            }

            float c = 5f / 9f * (f - 32);
            float k = c - 273;

            txt_celsuis.Text = c.ToString(); //string is going to work wit the text field
            txt_kelvin.Text = k.ToString();
        }

        private void onTextChange(object sender, EventArgs e)
        {
            convertFromFahrenheit();
        }
    }
}
