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
    public partial class ShowUser : Form
    {
        public ShowUser()
        {
            InitializeComponent();
        }

        private void ShowUser_Load(object sender, EventArgs e)
        {
            string[] Data = File.ReadAllLines("users.csv");

            for (int i = 0; i < Data.Length; i++)
            {
                listBox1.Items.Add(Data[i]);
            }
        }
    }
}
