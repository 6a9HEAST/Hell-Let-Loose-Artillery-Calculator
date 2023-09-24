using System;
using System.Windows.Forms;

namespace Artilery_Calculator
{
    public partial class Form1 : Form
    {
        int meters;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int.TryParse(MetersBox.Text,out meters);
            if (meters >= 100) MilesBox.Text=Calculate(meters).ToString();
            else MilesBox.Clear();
        }

       public int Calculate(int x)
        {
            int hundreds = (x / 100)-1; int units = x % 100;
            return (978 - (hundreds*24 + ((int)(0.24 * units))));
        }
    }
}
