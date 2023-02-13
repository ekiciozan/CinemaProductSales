using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaProductSales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label15.Visible = false;
            textBox3.Focus();
        }

        int totalCash;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )
            {
                MessageBox.Show("Please fill the amounts !");
            };
            label15.Visible = true;
            int popCorn, water, chocolate, ticket;
            popCorn = Convert.ToInt16(textBox1.Text);
            water = Convert.ToInt16(textBox2.Text);
            chocolate = Convert.ToInt16(textBox3.Text);
            ticket = Convert.ToInt16(textBox4.Text);

            totalCash = popCorn * 5 + water * 1 + chocolate * 2 + ticket * 10;
            label15.Text = totalCash + "$";
        }


    }
}
