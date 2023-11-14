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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string last = textBox2.Text;
            string phone_number = textBox3.Text;
            string data = name + "," + last + "," + phone_number + "\n" ;
            File.AppendAllText("users.csv", data);
        }
    }
}
