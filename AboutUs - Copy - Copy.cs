using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inword_Outword
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contactUs1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contactUs1.Visible = true;
        }

        private void contactUs1_Load(object sender, EventArgs e)
        {

        }
    }
}
