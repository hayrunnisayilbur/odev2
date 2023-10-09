using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if(sayi % 2==0)
            {
            MessageBox.Show("bu bir çift sayıdır.");
            }
            if(sayi % 2==1)
            {
                MessageBox.Show("bu bir tek sayıdır.");
            }

        }
    }
}
