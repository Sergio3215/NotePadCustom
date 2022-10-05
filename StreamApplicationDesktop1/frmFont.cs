using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamApplicationDesktop1
{
    public partial class frmFont : Form
    {
        FontSettings.FontSettings ftns;
        public frmFont()
        {
            InitializeComponent();

            ftns = new FontSettings.FontSettings();


            lstFontSize = ftns.AddFontSize(lstFontSize);
            if (!File.Exists("font-config"))
            {
                File.Create("font-config").Close();
                StreamWriter wr = new StreamWriter("font-config");
                wr.WriteLine("Arial;Regular;8");
                wr.Close();
                lbSample.Font = new Font("Arial", 8, FontStyle.Regular);
            }

            StreamReader rd = new StreamReader("font-config");
            string line = rd.ReadLine();
            rd.Close();

            string[] fontPart = line.Split(";");

            txtFontSearch.Text = fontPart[0];
            txtFontStyle.Text = fontPart[1];
            txtFontSize.Text = fontPart[2];

            ChangeLabel(lbSample);
        }

        private void lstFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFontSearch = ftns.AddingText(lstFonts, txtFontSearch);
            ChangeLabel(lbSample);
        }

        private void lstStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFontStyle = ftns.AddingText(lstStyles, txtFontStyle);
            ChangeLabel(lbSample);
        }

        private void lstFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFontSize = ftns.AddingText(lstFontSize, txtFontSize);
            ChangeLabel(lbSample);
        }

        Label ChangeLabel(Label lb)
        {
            lb.Font = new Font(txtFontSearch.Text, float.Parse(txtFontSize.Text), ftns.changeStyle(txtFontStyle.Text));
            return lb;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter("font-config");
            wr.WriteLine($"{txtFontSearch.Text};{txtFontStyle.Text};{txtFontSize.Text}");
            wr.Close();

            this.Close();

            Form1.setFont = true;
            Form1.fnt = lbSample.Font;
        }
    }
}
