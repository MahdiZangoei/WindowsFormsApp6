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
    public partial class ShowProduct : Form
    {
        public ShowProduct()
        {
            InitializeComponent();
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            string[] Data = File.ReadAllLines("products.csv");

            for (int i = 0; i < Data.Length; i++)
            {
                listBox1.Items.Add(Data[i]);
            }
        }
    }
}
