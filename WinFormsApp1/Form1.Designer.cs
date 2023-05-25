
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputC = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.solveEquationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(58, 58);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(311, 23);
            this.inputA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "B:";
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(58, 103);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(311, 23);
            this.inputB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "C:";
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(58, 146);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(311, 23);
            this.inputC.TabIndex = 4;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.Location = new System.Drawing.Point(58, 230);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(218, 37);
            this.output.TabIndex = 6;
            this.output.Text = "Тута будет ответ";
            // 
            // solveEquationBtn
            // 
            this.solveEquationBtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.solveEquationBtn.Location = new System.Drawing.Point(58, 183);
            this.solveEquationBtn.Name = "solveEquationBtn";
            this.solveEquationBtn.Size = new System.Drawing.Size(311, 34);
            this.solveEquationBtn.TabIndex = 7;
            this.solveEquationBtn.Text = "Решить";
            this.solveEquationBtn.UseVisualStyleBackColor = true;
            this.solveEquationBtn.Click += new System.EventHandler(this.solveEquationBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(496, 303);
            this.Controls.Add(this.solveEquationBtn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputC;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button solveEquationBtn;
    }
}

