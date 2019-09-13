using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFormApp
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            float firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(firstNumberTB.Text);
            secondNumber = Convert.ToInt32(secondNumberTB.Text);
            result = firstNumber + secondNumber;
            resultTB.Text = result.ToString();
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            float firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(firstNumberTB.Text);
            secondNumber = Convert.ToInt32(secondNumberTB.Text);
            result = firstNumber - secondNumber;
            resultTB.Text = result.ToString();
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            float firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(firstNumberTB.Text);
            secondNumber = Convert.ToInt32(secondNumberTB.Text);
            result = firstNumber * secondNumber;
            resultTB.Text = result.ToString();
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            float firstNumber, secondNumber, result;
            firstNumber = Convert.ToInt32(firstNumberTB.Text);
            secondNumber = Convert.ToInt32(secondNumberTB.Text);
            result = secondNumber / firstNumber;
            resultTB.Text = result.ToString();
        }
    }
}
