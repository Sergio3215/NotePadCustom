namespace StreamApplicationDesktop1
{
    using AppClasses;
    public partial class Form1 : Form
    {
        public static bool setFont = false;
        public static Font fnt;
        public static string nameSave = "";
        public static bool oksave = false;
        public static bool oksaveas = false;
        public static bool close = false;

        public bool edited = false;
        public bool save = false;
        public string txtSaved = "";
        public string newSaveString = "";

        FontSettings.FontSettings ftns;
        FilesManager fm;
        importManager im;
        ExportManager em;
        public Form1()
        {
            InitializeComponent();
            ftns = new FontSettings.FontSettings();
            fm = new FilesManager();
            im = new importManager();
            em = new ExportManager();

            string line = fm.OpenFile("font-config");
            rtxtTexto.Font = ftns.setFont(line);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavingFiles();
        }

        private void guardarComoCtrlShiftSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFont frm = new frmFont();
            frm.Show();
        }

        void CloseApp()
        {
            try
            {
                if (edited)
                {
                    frmSave frm = new frmSave();
                    frm.Show();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void TimeChange_Tick(object sender, EventArgs e)
        {
            bool __isNew = this.Text.Contains("*");
            edited = __isNew;
            bool __isTxtSaved = rtxtTexto.Text == txtSaved;
            string quitAsterisc = this.Text.Substring(1, this.Text.Length - 1);

            if (setFont)
            {
                rtxtTexto.Font = fnt;

                setFont = !setFont;
            }
            if (nameSave != "" && !this.Text.Contains(nameSave))
            {
                if (__isNew)
                {
                    this.Text = "NotePad Custom";
                }
                this.Text = nameSave + " - " + this.Text;
                save = true;
            }
            if (save)
            {
                if (!File.Exists(nameSave))
                {
                    File.Create(nameSave+".txt").Close();
                }

                string filenameCustom = nameSave+".txt";

                fm.WriteFile(filenameCustom, rtxtTexto.Text, "noline");

                txtSaved = rtxtTexto.Text;
                save = !save;
            }
            if (!__isTxtSaved && !__isNew)
            {
                this.Text = "*" + this.Text;
            }
            if (__isTxtSaved && __isNew)
            {
                this.Text = quitAsterisc;
            }
            if (oksave)
            {
                oksave = !oksave;
                SaveAs();
                this.Close();
            }
            if (oksaveas)
            {
                oksaveas = !oksaveas;
                SavingFiles();
                this.Close();
            }
            if (close)
            {
                this.Close();
            }
        }

        private void salitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseApp();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFiles();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setNew();
        }

        void SavingFiles()
        {
            if (nameSave == "")
            {
                SaveAs();
            }
            else
            {
                save = true;
            }
        }
        void SaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.txt";
            sfd.Filter = "Text Documents (*.txt)|*.txt| All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                save = true;
                string[] cut = sfd.FileName.Split('\\');
                nameSave = cut[cut.Count() - 1].Split(".")[0];
            }
        }

        void OpenFiles()
        {
            OpenFileDialog ofd = im.OpenFile();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string line = fm.OpenFile(ofd.FileName);
                rtxtTexto.Text = line;
                txtSaved = line;
                nameSave = ofd.SafeFileName.Split('.')[0];
                if (this.Text.Contains("-"))
                {
                    this.Text = "NotePad Custom";
                }
                this.Text = nameSave + " - " + this.Text;

            }
        }

        void setNew()
        {
            try
            {
                rtxtTexto.Text = "";
                txtSaved = "";
                nameSave = "";
                this.Text = this.Text.Split('-')[1].Trim();
            }
            catch
            {

            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SavingFiles();
                return true;
            }
            if (keyData == (Keys.Control | Keys.Shift | Keys.S))
            {
                SaveAs();
                return true;
            }
            if (keyData == (Keys.Control | Keys.O))
            {
                OpenFiles();
                return true;
            }
            if (keyData == (Keys.Control | Keys.N))
            {
                setNew();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }

}