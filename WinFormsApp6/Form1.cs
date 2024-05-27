using System.Collections.Specialized;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        DelayPUbey delay = new();

        public Form1()
        {
            InitializeComponent();
          
        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            delay.Tick();

        }





        private void cokisinzoom()
        {
            pictureBox1.Size = new(350, 350);
            pictureBox1.Location = new(347, 131);
            pictureBox1.Image = Resource1.cookis2;
        } 
        private void cokisoutzoom()
        {
            pictureBox1.Size = new(444, 444);
            pictureBox1.Location = new(303, 83);
            pictureBox1.Image = Resource1.cookis;
        }

        int count = 0;


        private void showCookis()
        { 
            cokisoutzoom();
        }





        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          timer1.Start();
            cokisinzoom();
            delay.Start(timer1, 3, showCookis); 
            count++;
            label1.Text = "Счет: " + count.ToString() + "¢";
        }
    }
}
