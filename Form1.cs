using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NrPrim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool IsPrime = true;
            int.TryParse(textBox1.Text, out int integerValue);
            for (int i = 2; i <= integerValue / 2; i++)
            {

                if (integerValue % i == 0)
                {
                    IsPrime = false;
                }
            }
            if (IsPrime == true)
            {
                this.BackColor = Color.Green;
            }
            else if (IsPrime == false)
            {
                this.BackColor = Color.Red;


            }
            if (integerValue) ;
        }

    }
}
