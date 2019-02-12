using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelKalk.Text = "KALKULĀTORS 2019 EDITION";
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
            button5.Click += Button5_Click;
            button6.Click += Button6_Click;
            button7.Click += Button7_Click;
            button8.Click += Button8_Click;
            button9.Click += Button9_Click;
            button0.Click += Button0_Click;
            buttonAdd.Click += ButtonAdd_Click;
            buttonSub.Click += ButtonSub_Click;
            buttonMul.Click += ButtonMul_Click;
            buttonDiv.Click += ButtonDiv_Click;
            buttonCancel.Click += ButtonCancel_Click;
            buttonResult.Click += ButtonResult_Click;
            inputNumber.Text = "";            
        }

        string enteredNumber = "";
        string operation = "";
        bool isOperationClicked = false;

        private void ButtonResult_Click(object sender, EventArgs e)
        {
         /// te būs kaut kas
        }

        public void numberClicked(int num)
        {
            if (isOperationClicked) // ja nospiesta operācija
            {
                inputNumber.Text = "";
                isOperationClicked = false; // lai spiežot neiztīra atkal
            };

            if (inputNumber.Text == "0")
            {
                inputNumber.Text = "";
            };                   
           
            inputNumber.Text += num.ToString();
        }

        public void operationClicked(string op)
        {
            // 1. šobrīd attēlotais skaitlis jāsaglabā kā "enteredNumber"
            enteredNumber = inputNumber.Text;
            // 2. izvēlētā darbība jāsaglabā kā operation
            operation = op;
            // 3. spiežot ciparu pēc darbības, jāsāk jauna ievade
            isOperationClicked = true;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            numberClicked(0);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            numberClicked(9);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            numberClicked(8);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            numberClicked(7);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            numberClicked(6);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            numberClicked(5);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            numberClicked(4);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numberClicked(3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            numberClicked(2);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            numberClicked(1);
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            operationClicked("/");
        }

        private void ButtonMul_Click(object sender, EventArgs e)
        {
            operationClicked("*");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            inputNumber.Text = "";
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            operationClicked("-");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            operationClicked("+");
        }
    }
}
