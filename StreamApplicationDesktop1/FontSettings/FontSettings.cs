using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamApplicationDesktop1.FontSettings
{
    internal class FontSettings
    {
        public ListBox AddFontSize(ListBox lst)
        {
            for(int ii = 8; ii <= 72; ii++)
            {
                if(ii%2 == 0)
                {
                    lst.Items.Add(ii);
                }
            }

            return lst;
        }

        public TextBox AddingText(ListBox lst, TextBox txt)
        {
            txt.Text = lst.SelectedItem.ToString();
            return txt;
        }
        
       private FontStyle changeStyle(string style)
        {
            FontStyle fs = new FontStyle();

            switch (style)
            {
                case "Regular":
                    fs = FontStyle.Regular;
                    break;
                case "Bold":
                    fs = FontStyle.Bold;
                    break;
            }

            return fs;
        }
        public Font setFont(string line)
        {
            string[] fontPart = line.Split(";");

            try
            {
                return new Font(fontPart[0], float.Parse(fontPart[2]), changeStyle(fontPart[1]));
            }
            catch (Exception)
            {
                return new Font(fontPart[0], float.Parse(fontPart[1]), changeStyle(fontPart[2]));
            }
        }
    }
}
