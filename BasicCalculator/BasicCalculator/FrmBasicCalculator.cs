using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {

            float first, second, result = 0;

            if (!float.TryParse(txtNumber1.Text, out first) ||
                !float.TryParse(txtNumber2.Text, out second))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            switch (cbOperator.Text)
            {
                case "+":
                    result = BasicComputation.Addition(first, second);
                    break;
                case "-":
                    result = BasicComputation.Subtraction(first, second);
                    break;
                case "*":
                    result = BasicComputation.Multiplication(first, second);
                    break;
                case "/":
                    if (second == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = BasicComputation.Division(first, second);
                    break;
            }

            lblTotal.Text = result.ToString();
        }
    }
}
