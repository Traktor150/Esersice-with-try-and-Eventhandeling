﻿using System;
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

            btn_Add.Click += new EventHandler(btnEvent); 
            btn_Subtract.Click += new EventHandler(btnEvent);
            btn_Multiply.Click += new EventHandler(btnEvent);
            btn_Divide.Click += new EventHandler(btnEvent);
        }

        private void btnEvent(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            double input1 = double.Parse(txb_Input1.Text);
            double input2 = double.Parse(txb_Input2.Text);
            double anser = 0;

            switch (btn.Text)
            {
                case "+":
                    anser = MyEngine.Add(input1, input2);
                    break;
                case "-":
                    anser = MyEngine.Subtract(input1, input2);
                    break;
                case "*":
                    anser = MyEngine.Multiply(input1, input2);
                    break;
                case "/":
                    anser = MyEngine.Divide(input1, input2);
                    break;
                default:
                    break;
            }
            
            Show_Result(input1, input2, anser, btn.Text);
        }

        private void Show_Result(double input1, double input2, double anser, string operation)
        {
            lib_Result.Items.Add($"{input1} {operation} {input2} = {anser}");
        }
    }
}
