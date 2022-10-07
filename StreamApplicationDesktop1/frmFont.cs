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
    using AppClasses;
    public partial class frmFont : Form
    {
        string stringFile = "font-config";
        FontSettings.FontSettings ftns;
        FilesManager fm;
        public frmFont()
        {
            InitializeComponent();
            fm = new FilesManager();
            ftns = new FontSettings.FontSettings();


            lstFontSize = ftns.AddFontSize(lstFontSize);

            string fontDefault = "Arial;Regular;8";

            if (!File.Exists(stringFile))
            {
                lbSample.Font = fm.createFiles(stringFile,fontDefault);
            }
            
            string line = fm.OpenFile(stringFile);

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
            string lineStyle = $"{txtFontSearch.Text};{txtFontSize.Text};{txtFontStyle.Text}";
            lb.Font = ftns.setFont(lineStyle);
            return lb;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fm.WriteFile(stringFile, $"{txtFontSearch.Text};{txtFontStyle.Text};{txtFontSize.Text}");

            this.Close();

            Form1.setFont = true;
            Form1.fnt = lbSample.Font;
        }
    }
}
