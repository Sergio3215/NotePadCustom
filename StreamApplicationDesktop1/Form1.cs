namespace StreamApplicationDesktop1
{
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

        FontSettings.FontSettings ftns;
        public Form1()
        {
            InitializeComponent();
            ftns = new FontSettings.FontSettings();
            StreamReader rd = new StreamReader("font-config");
            string line = rd.ReadLine();
            rd.Close();

            string[] fontPart = line.Split(";");

            rtxtTexto.Font = new Font(fontPart[0], float.Parse(fontPart[2]), ftns.changeStyle(fontPart[1]));
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
            edited = this.Text.Contains("*");
            if (setFont)
            {
                rtxtTexto.Font = fnt;

                setFont = !setFont;
            }
            if (nameSave != "" && !this.Text.Contains(nameSave))
            {
                if (this.Text.Contains("*"))
                {
                    this.Text = this.Text.Substring(1, this.Text.Length - 1);
                }
                this.Text = nameSave + " - " + this.Text;
                save = true;
            }
            if (save)
            {
                if (!File.Exists(nameSave))
                {
                    File.Create(nameSave + ".txt").Close();
                }

                StreamWriter wr = new StreamWriter(nameSave + ".txt");
                wr.Write(rtxtTexto.Text);
                wr.Close();

                txtSaved = rtxtTexto.Text;
                save = !save;
            }
            if (rtxtTexto.Text != txtSaved && !this.Text.Contains("*"))
            {
                this.Text = "*" + this.Text;
            }
            if (rtxtTexto.Text == txtSaved && this.Text.Contains("*"))
            {
                this.Text = this.Text.Substring(1, this.Text.Length - 1);
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
            //frmSave frm = new frmSave();
            //frm.Show();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "*.txt";
            sfd.Filter = "Text Documents (*.txt)|*.txt| All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                save = true;
                string[] cut = sfd.FileName.Split('\\');
                nameSave = cut[cut.Count() - 1];
            }
        }

        void OpenFiles()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Documents (*.txt)|*.txt| All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader rd = new StreamReader(ofd.FileName);
                rtxtTexto.Text = rd.ReadLine();
                txtSaved = rtxtTexto.Text;
                nameSave = ofd.SafeFileName.Split('.')[0];
                if (this.Text.Contains("-"))
                {
                    this.Text = "NotePad Custom";
                }
                this.Text = nameSave + " - " + this.Text;
                rd.Close();

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