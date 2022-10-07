using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApplicationDesktop1.AppClasses
{
    internal class importManager
    {
        public importManager()
        {

        }

        public OpenFileDialog OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Documents (*.txt)|*.txt| All Files (*.*)|*.*";
            return ofd;
        }
    }
}
