using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HafizaOyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();//hide
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OYUN NASIL OYNANIR: Sağ tarafta bulunan sayıları belirtilen süre içerisinde aklınızda tutup sol taraftaki kutulara aynen yazmanız beklenmektedir.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
