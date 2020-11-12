using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn =new Button();
            btn.Size = new Size(180,50);
            btn.Text = "deneme";
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
            this.Controls.Add(btn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
        private void btn_click(object sender, EventArgs e)
        {
            MessageBox.Show("deneme");
        }
        void Metod(object o, EventArgs e)//object ve eventargs yoksa click eventi çalışmaz
        {
            MessageBox.Show("Deneme2");
        }
    }
}
