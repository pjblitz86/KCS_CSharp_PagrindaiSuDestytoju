using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApplication
{
    public partial class manoAplikacija : Form
    {
        public manoAplikacija()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mygtukas.Text = "Labas";
            Mygtukas.BackColor = Color.Brown;
            TekstoLaukas.Text = "Paspaudete mygtuka";
            pictureBox1.Image = pow;
            
        }
        Bitmap pow = new Bitmap("C:/Users/Public/Pictures/Sample Pictures/Desert.jpg");
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
