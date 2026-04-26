using System;
using System.Drawing;
using System.Windows.Forms;


namespace MDK2LABA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0) 
            {
                try
                {
                    double x = double.Parse(textBox1.Text);
                    double y = double.Parse(textBox2.Text);
                    double z = double.Parse(textBox3.Text);

                    
                    double chislitel = Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1.0 / 3.0);
                    double znamenatel = x * x + y * y + 2;
                    double secondPart = Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x);

                    double u = (chislitel / znamenatel) - secondPart;

                    textBox4.Text = "Результат u = " + Math.Round(u, 4).ToString();
                }
                catch { MessageBox.Show("Ошибка вводе данных!"); }
            }
            else 
            {
                try
                {
                    double x = double.Parse(textBox5.Text);
                    double y = double.Parse(textBox6.Text);
                    double fx = 0;

                   
                    if (radioButton1.Checked) fx = Math.Cos(x);
                    else if (radioButton2.Checked) fx = Math.Pow(x, 2);
                    else if (radioButton3.Checked) fx = Math.Exp(x);

                    double a;
                 
                    if (x / y > 0)
                        a = Math.Log(y + 2) + fx;
                    else if (x / y < 0)
                        a = Math.Log(Math.Abs(y)) - Math.Tan(fx);
                    else
                        a = fx * Math.Pow(y, 3);

                    textBox7.Text = "Результат a = " + Math.Round(a, 4).ToString();

                    
                    textBox7.ForeColor = checkBox1.Checked ? Color.Red : Color.Black;
                }
                catch { MessageBox.Show("Ошибка! Возможно деление на 0 или неверный ввод."); }
            }
        }
    }
}
       
