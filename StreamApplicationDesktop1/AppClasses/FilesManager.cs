using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamApplicationDesktop1.AppClasses
{
    using FontSettings;
    internal class FilesManager
    {
        FontSettings ftns;
        public FilesManager()
        {
            ftns = new FontSettings();
        }

        public Font createFiles(string stringFile, string fontDefault)
        {
            File.Create(stringFile).Close();
            WriteFile(stringFile, fontDefault);
            return ftns.setFont(fontDefault);
        }

        public string OpenFile(string nameFile)
        {
            StreamReader rd = new StreamReader(nameFile);
            string line = rd.ReadLine();
            rd.Close();

            return line;
        }

        public void WriteFile(string nameSave, string txt, string mode = "noline")
        {
            StreamWriter wr = new StreamWriter(nameSave);
            switch (mode)
            {
                case "noline":
                    wr.Write(txt);
                    break;
                case "line":
                    wr.WriteLine(txt);
                    break;
                default:
                    wr.Write(txt);
                    break;
            }
            wr.Close();
        }
    }
}
