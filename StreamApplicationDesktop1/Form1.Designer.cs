namespace StreamApplicationDesktop1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.txtTextinput = new System.Windows.Forms.TextBox();
            this.rtxtTexto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoCtrlShiftSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atrásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adelanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimeChange = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(101, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(234, 39);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Ingrese un Texto";
            // 
            // txtTextinput
            // 
            this.txtTextinput.Font = new System.Drawing.Font("Corbel", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTextinput.Location = new System.Drawing.Point(101, 61);
            this.txtTextinput.Name = "txtTextinput";
            this.txtTextinput.Size = new System.Drawing.Size(274, 47);
            this.txtTextinput.TabIndex = 1;
            // 
            // rtxtTexto
            // 
            this.rtxtTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtTexto.Location = new System.Drawing.Point(0, 27);
            this.rtxtTexto.Name = "rtxtTexto";
            this.rtxtTexto.Size = new System.Drawing.Size(1039, 731);
            this.rtxtTexto.TabIndex = 0;
            this.rtxtTexto.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem1,
            this.ediciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1039, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoCtrlShiftSToolStripMenuItem,
            this.salitToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivoToolStripMenuItem.Text = "Archivos";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo (Ctrl+N)";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.abrirToolStripMenuItem.Text = "Abrir  (Ctrl+O)";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.guardarToolStripMenuItem.Text = "Guardar (Ctrl+S)";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoCtrlShiftSToolStripMenuItem
            // 
            this.guardarComoCtrlShiftSToolStripMenuItem.Name = "guardarComoCtrlShiftSToolStripMenuItem";
            this.guardarComoCtrlShiftSToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.guardarComoCtrlShiftSToolStripMenuItem.Text = "Guardar como (Ctrl+Shift+S)";
            this.guardarComoCtrlShiftSToolStripMenuItem.Click += new System.EventHandler(this.guardarComoCtrlShiftSToolStripMenuItem_Click);
            // 
            // salitToolStripMenuItem
            // 
            this.salitToolStripMenuItem.Name = "salitToolStripMenuItem";
            this.salitToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.salitToolStripMenuItem.Text = "Salir";
            this.salitToolStripMenuItem.Click += new System.EventHandler(this.salitToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem1
            // 
            this.ediciónToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrásToolStripMenuItem,
            this.adelanteToolStripMenuItem});
            this.ediciónToolStripMenuItem1.Name = "ediciónToolStripMenuItem1";
            this.ediciónToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem1.Text = "Edición";
            // 
            // atrásToolStripMenuItem
            // 
            this.atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            this.atrásToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.atrásToolStripMenuItem.Text = "Atrás";
            // 
            // adelanteToolStripMenuItem
            // 
            this.adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            this.adelanteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.adelanteToolStripMenuItem.Text = "Adelante";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuentesToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ediciónToolStripMenuItem.Text = "Formato";
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            this.fuentesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.fuentesToolStripMenuItem.Text = "Fuentes...";
            this.fuentesToolStripMenuItem.Click += new System.EventHandler(this.fuentesToolStripMenuItem_Click);
            // 
            // TimeChange
            // 
            this.TimeChange.Enabled = true;
            this.TimeChange.Tick += new System.EventHandler(this.TimeChange_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1039, 756);
            this.Controls.Add(this.rtxtTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "NotePad Custom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitle;
        private TextBox txtTextinput;
        private RichTextBox rtxtTexto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem salitToolStripMenuItem;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private ToolStripMenuItem fuentesToolStripMenuItem;
        private ToolStripMenuItem ediciónToolStripMenuItem1;
        private ToolStripMenuItem atrásToolStripMenuItem;
        private ToolStripMenuItem adelanteToolStripMenuItem;
        private System.Windows.Forms.Timer TimeChange;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem guardarComoCtrlShiftSToolStripMenuItem;
    }
}