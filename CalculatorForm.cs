using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUDT
{
    
    public partial class CalculatorForm : Form
    {
        MainFunction calulator=new MainFunction();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resultTextBox.Text = Convert.ToString(calulator.Add());
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resultTextBox.Text = Convert.ToString(calulator.Substract());
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resultTextBox.Text = Convert.ToString(calulator.Multiply());
           
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            GetValue();
            resultTextBox.Text = Convert.ToString(calulator.Divide());
      
        }

        public void GetValue()
        {
            calulator.firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            calulator.secondNumber = Convert.ToDouble(secondNumberTextBox.Text);   
        }

    }
}
