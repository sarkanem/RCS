using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // šis izveido formu

            labelCount.Text = "Skaits";
            buttonAdd.Click += ButtonAdd_Click;
            buttonSub.Click += ButtonSub_Click;
            buttonCancel.Click += ButtonCancel_Click;
            inputNumber.Text = "1";

        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            inputNumber.Text = "1";
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(inputNumber.Text);
            i--;
            inputNumber.Text = i.ToString();

            //  inputNumber.Text = (Convert.ToInt32(inputNumber.Text) - 1).ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {            
           int i = Convert.ToInt32(inputNumber.Text);
           i++;
           inputNumber.Text = i.ToString();

           //  inputNumber.Text = (Convert.ToInt32(inputNumber.Text) + 1).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
