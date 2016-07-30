using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.Show("Back to main", button1, 255);
            Form1 frm = new Form1();

            if (frm.Visible == true)
            {
                frm.Show();
            }

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            Form2 frm2 = new Form2();
            ToolTip tip = new ToolTip();

            if(frm1.Visible == true && frm2.Visible != false)
            {
                frm1.Visible = false;
                frm2.Show();
            }
            tip.Show("Page2",button3,255);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
