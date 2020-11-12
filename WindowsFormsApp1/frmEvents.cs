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
    public partial class frmEvents : Form
    {
        int sonuc;
        public frmEvents()
        {
            InitializeComponent();

            Random rnd = new Random();
            button1.Text = $"{rnd.Next(99)}";
            button2.Text = $"{rnd.Next(99)}";
            button3.Text = $"{rnd.Next(99)}";
            button4.Text = ("Sonuç");




        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show($"Sayılar Toplamı = {sonuc}");
        }

       


        private void Button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            b.Enabled = false;

            sonuc += int.Parse(b.Text);
            
        }

        private void frmEvents_Load(object sender, EventArgs e)
        {
            //Load eventinde iş mantığını kurgulayabiliriz..Form açıldığında yapılacak işler.

            tmrButton.Start();

        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
