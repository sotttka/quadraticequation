using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double _a;

        private double _b;

        private double _c;

        public Form1()
        {
            InitializeComponent();
        }

        private void solveEquationBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(inputA.Text, out _a))
            {
                _a = Convert.ToDouble(inputA.Text);
            }
            else
            {
                MessageBox.Show("Неверный формат у коэффициента а");
                return;
            }

            if (double.TryParse(inputB.Text, out _b))
            {
                _b = Convert.ToDouble(inputB.Text);
            }
            else
            {
                MessageBox.Show("Неверный формат у коэффициента b");
                return;
            }

            if (double.TryParse(inputC.Text, out _c))
            {
                _c = Convert.ToDouble(inputC.Text);
            }
            else
            {
                MessageBox.Show("Неверный формат у коэффициента c");
                return;
            }


            double discriminant = Math.Pow(_b, 2) - 4 * _a * _c;
            if(discriminant < 0)
            {
                output.Text = "Нет корней.";
                return;
            } else if (discriminant == 0)
            {
                double x = _b / (2 * _a);
                output.Text = $"x: {x}";
                return;
            }

            double x1 = (-_b + Math.Sqrt(discriminant)) / (2 * _a); 
            double x2 = (-_b - Math.Sqrt(discriminant)) / (2 * _a);

            output.Text = $"x1: {x1}; x2: {x2}";
        }
    }
}
