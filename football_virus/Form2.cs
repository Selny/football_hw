using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace football_virus
{
    public partial class Form2 : Form
    {
        string link = @"https://www.countryflags.io/";
        public Form2(string code, string[] pinfo)
        {
            InitializeComponent();

            label11.Text = pinfo[10];
            label10.Text = pinfo[9];
            label9.Text = pinfo[8];
            label8.Text = pinfo[7];
            label7.Text = pinfo[6];
            label6.Text = pinfo[5];
            label5.Text = pinfo[4];
            label4.Text = pinfo[3];
            label3.Text = pinfo[2];
            label2.Text = pinfo[1];
            label1.Text = pinfo[0];
            link += code + @"/flat/64.png";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.LoadAsync(link);
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
