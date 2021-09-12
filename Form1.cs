using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        double a, b, h, m, result;
        public Form1()
        {
            InitializeComponent();
        }
        private void checkDoubleInput(TextBox textBox, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox.Text.IndexOf('.') != -1 && textBox.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDoubleInput(textBoxA, e);
        }
        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDoubleInput(textBoxB, e);
        }
        private void textBoxH_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDoubleInput(textBoxH, e);
        }
        private void textBoxM_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkDoubleInput(textBoxM, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                h = Convert.ToDouble(textBoxH.Text);
                m = Convert.ToDouble(textBoxM.Text);

                Props triangle = new Props(a, b, h, m);
                result = triangle.findDensity();
                
                if (double.IsNaN(result) || result == double.PositiveInfinity)
                {
                    throw new FormatException();
                }

                labelResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                string message = "";
                if (textBoxA.Text == "" || textBoxB.Text == "" || textBoxH.Text == "" || textBoxM.Text == "")
                {
                    message += "Заполните пустые поля! ";
                }
                if (a == 0 && textBoxA.Text != "" || b == 0 && textBoxB.Text != "" || h == 0 && textBoxH.Text != "" || m == 0 && textBoxM.Text != "")
                {
                    message += "Есть неположительные значения!";
                }
                MessageBox.Show(message);
            }
        }
    }
}
