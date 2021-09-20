
namespace Calkulator_Better_Code
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Subtract = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.txb_Input1 = new System.Windows.Forms.TextBox();
            this.txb_Input2 = new System.Windows.Forms.TextBox();
            this.lib_Result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(65, 156);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "button1";
            this.btn_Add.UseVisualStyleBackColor = true;
            
            // 
            // btn_Subtract
            // 
            this.btn_Subtract.Location = new System.Drawing.Point(170, 156);
            this.btn_Subtract.Name = "btn_Subtract";
            this.btn_Subtract.Size = new System.Drawing.Size(75, 23);
            this.btn_Subtract.TabIndex = 1;
            this.btn_Subtract.Text = "button2";
            this.btn_Subtract.UseVisualStyleBackColor = true;
            
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Location = new System.Drawing.Point(266, 156);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiply.TabIndex = 2;
            this.btn_Multiply.Text = "button3";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            
            // 
            // btn_Divide
            // 
            this.btn_Divide.Location = new System.Drawing.Point(378, 156);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(75, 23);
            this.btn_Divide.TabIndex = 3;
            this.btn_Divide.Text = "button4";
            this.btn_Divide.UseVisualStyleBackColor = true;
            
            // 
            // txb_Input1
            // 
            this.txb_Input1.Location = new System.Drawing.Point(197, 43);
            this.txb_Input1.Name = "txb_Input1";
            this.txb_Input1.Size = new System.Drawing.Size(100, 22);
            this.txb_Input1.TabIndex = 4;
            // 
            // txb_Input2
            // 
            this.txb_Input2.Location = new System.Drawing.Point(197, 92);
            this.txb_Input2.Name = "txb_Input2";
            this.txb_Input2.Size = new System.Drawing.Size(100, 22);
            this.txb_Input2.TabIndex = 5;
            // 
            // lib_Result
            // 
            this.lib_Result.FormattingEnabled = true;
            this.lib_Result.ItemHeight = 16;
            this.lib_Result.Location = new System.Drawing.Point(170, 227);
            this.lib_Result.Name = "lib_Result";
            this.lib_Result.Size = new System.Drawing.Size(171, 196);
            this.lib_Result.TabIndex = 6;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 526);
            this.Controls.Add(this.lib_Result);
            this.Controls.Add(this.txb_Input2);
            this.Controls.Add(this.txb_Input1);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Subtract);
            this.Controls.Add(this.btn_Add);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Subtract;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.TextBox txb_Input1;
        private System.Windows.Forms.TextBox txb_Input2;
        private System.Windows.Forms.ListBox lib_Result;
    }
}

