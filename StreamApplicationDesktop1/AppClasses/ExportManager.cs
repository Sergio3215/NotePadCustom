using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApplicationDesktop1.AppClasses
{
    internal class ExportManager
    {
        public ExportManager()
        {

        }
        public SaveFileDialog SaveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.txt";
            sfd.Filter = "Text Documents (*.txt)|*.txt| All Files (*.*)|*.*";
            return sfd;
        }
    }
}
