using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calkulator_Better_Code
{
    public partial class Calculator : Form
    {
        Calc_Engine MyEngine = new Calc_Engine();
        public Calculator()
        {
            InitializeComponent();
            btn_Add.Text = "+";
            btn_Subtract.Text = "-";
            btn_Multiply.Text = "*";
            btn_Divide.Text = "/";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            double input1 = double.Parse(txb_Input1.Text);
            double input2 = double.Parse(txb_Input2.Text);

            double anser = MyEngine.Add(input1, input2);
            Show_Result(input1, input2, anser, (sender as Button).Text);
        }

       

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            double input1 = double.Parse(txb_Input1.Text);
            double input2 = double.Parse(txb_Input2.Text);

            double anser = MyEngine.Subtract(input1, input2);
            Show_Result(input1, input2, anser, (sender as Button).Text);
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            double input1 = double.Parse(txb_Input1.Text);
            double input2 = double.Parse(txb_Input2.Text);

            double anser = MyEngine.Multiply(input1, input2);
            Show_Result(input1, input2, anser, (sender as Button).Text);
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            double input1 = double.Parse(txb_Input1.Text);
            double input2 = double.Parse(txb_Input2.Text);

            double anser = MyEngine.Divide(input1, input2);
            Show_Result(input1, input2, anser, (sender as Button).Text);
        } 
        private void Show_Result(double input1, double input2, double anser, string operation)
        {
            lib_Result.Items.Add($"{input1} {operation} {input2} = {anser}");
        }
    }
}
