using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int widh;
        public Form1(int with)
        {
            InitializeComponent();
            widh = Width;
            Text = (Width).ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (Width > 200)
            {
               // MessageBox.Show("xnj");
                e.Cancel = true;
            }
            Application.OpenForms[0].Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1(widh);
            form1.Width = Width * 20 / 100;
            form1.ShowDialog();
        }
    }
}
