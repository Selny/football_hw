using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace football_virus
{
    public partial class Form1 : Form
    {
        string[] pinfo = new string[11];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var countryCodesMapping = new Dictionary<string, RegionInfo>();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (var culture in cultures)
{
                RegionInfo region = new RegionInfo(culture.LCID);
                listBox1.Items.Add(region.TwoLetterISORegionName);
            }
            selectionUC1.textBox1.Text = "F";
            selectionUC2.textBox1.Text = "F";
            selectionUC3.textBox1.Text = "F";
            selectionUC4.textBox1.Text = "MD";
            selectionUC5.textBox1.Text = "MD";
            selectionUC6.textBox1.Text = "MD";
            selectionUC7.textBox1.Text = "DD";
            selectionUC8.textBox1.Text = "DD";
            selectionUC9.textBox1.Text = "DD";
            selectionUC10.textBox1.Text = "DD";
            selectionUC11.textBox1.Text = "GK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pinfo[0] = selectionUC1.textBox2.Text + " " + selectionUC1.textBox3.Text;
            pinfo[1] = selectionUC2.textBox2.Text + " " + selectionUC2.textBox3.Text;
            pinfo[2] = selectionUC3.textBox2.Text + " " + selectionUC3.textBox3.Text;
            pinfo[3] = selectionUC4.textBox2.Text + " " + selectionUC4.textBox3.Text;
            pinfo[4] = selectionUC5.textBox2.Text + " " + selectionUC5.textBox3.Text;
            pinfo[5] = selectionUC6.textBox2.Text + " " + selectionUC6.textBox3.Text;
            pinfo[6] = selectionUC7.textBox2.Text + " " + selectionUC7.textBox3.Text;
            pinfo[7] = selectionUC8.textBox2.Text + " " + selectionUC8.textBox3.Text;
            pinfo[8] = selectionUC9.textBox2.Text + " " + selectionUC9.textBox3.Text;
            pinfo[9] = selectionUC10.textBox2.Text + " " + selectionUC10.textBox3.Text;
            pinfo[10] = selectionUC11.textBox2.Text + " " + selectionUC11.textBox3.Text;
            string code = listBox1.Text;
            Form2 f2  = new Form2(code, pinfo);
            f2.ShowDialog();
            
        }
    }
}
