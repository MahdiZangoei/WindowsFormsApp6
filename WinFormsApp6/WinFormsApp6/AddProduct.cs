using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProductـName = textBox1.Text;
            string Price = textBox2.Text;
            string Catgory = textBox3.Text;
            string Id = textBox4.Text;
            string data = ProductـName + "," + Price + "," + Catgory + Id + "\n";
            File.AppendAllText("products.csv", data);
        }
    }
}
