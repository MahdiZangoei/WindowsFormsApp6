using System;
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
    public partial class Form1 : Form
    {
        Form Add_user = new AddUser();
        Form Show_User = new ShowUser();
        Form Add_Product = new AddProduct();
        Form Show_Product = new ShowProduct();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Show_User.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Product.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Show_Product.Show();
        }
    }
}
