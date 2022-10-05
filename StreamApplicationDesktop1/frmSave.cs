using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamApplicationDesktop1
{
    public partial class frmSave : Form
    {
        public frmSave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.oksave = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.oksaveas = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.close = true;
            this.Close();
        }
    }
}
