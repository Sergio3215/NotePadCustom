namespace StreamApplicationDesktop1
{
    partial class frmFont
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFont = new System.Windows.Forms.Label();
            this.txtFontSearch = new System.Windows.Forms.TextBox();
            this.lstStyles = new System.Windows.Forms.ListBox();
            this.txtFontStyle = new System.Windows.Forms.TextBox();
            this.lbStyleFont = new System.Windows.Forms.Label();
            this.lbFontSize = new System.Windows.Forms.Label();
            this.txtFontSize = new System.Windows.Forms.TextBox();
            this.lstFontSize = new System.Windows.Forms.ListBox();
            this.lstFonts = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSample = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFont.Location = new System.Drawing.Point(12, 19);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(41, 21);
            this.lbFont.TabIndex = 0;
            this.lbFont.Text = "Font";
            // 
            // txtFontSearch
            // 
            this.txtFontSearch.Location = new System.Drawing.Point(12, 43);
            this.txtFontSearch.Name = "txtFontSearch";
            this.txtFontSearch.Size = new System.Drawing.Size(151, 23);
            this.txtFontSearch.TabIndex = 1;
            // 
            // lstStyles
            // 
            this.lstStyles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstStyles.FormattingEnabled = true;
            this.lstStyles.ItemHeight = 21;
            this.lstStyles.Items.AddRange(new object[] {
            "Regular",
            "Bold"});
            this.lstStyles.Location = new System.Drawing.Point(182, 82);
            this.lstStyles.Name = "lstStyles";
            this.lstStyles.Size = new System.Drawing.Size(151, 130);
            this.lstStyles.TabIndex = 5;
            this.lstStyles.SelectedIndexChanged += new System.EventHandler(this.lstStyles_SelectedIndexChanged);
            // 
            // txtFontStyle
            // 
            this.txtFontStyle.Location = new System.Drawing.Point(182, 43);
            this.txtFontStyle.Name = "txtFontStyle";
            this.txtFontStyle.Size = new System.Drawing.Size(151, 23);
            this.txtFontStyle.TabIndex = 4;
            // 
            // lbStyleFont
            // 
            this.lbStyleFont.AutoSize = true;
            this.lbStyleFont.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStyleFont.Location = new System.Drawing.Point(182, 19);
            this.lbStyleFont.Name = "lbStyleFont";
            this.lbStyleFont.Size = new System.Drawing.Size(85, 21);
            this.lbStyleFont.TabIndex = 3;
            this.lbStyleFont.Text = "Font Styles";
            // 
            // lbFontSize
            // 
            this.lbFontSize.AutoSize = true;
            this.lbFontSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFontSize.Location = new System.Drawing.Point(350, 19);
            this.lbFontSize.Name = "lbFontSize";
            this.lbFontSize.Size = new System.Drawing.Size(73, 21);
            this.lbFontSize.TabIndex = 3;
            this.lbFontSize.Text = "Font Size";
            // 
            // txtFontSize
            // 
            this.txtFontSize.Location = new System.Drawing.Point(350, 43);
            this.txtFontSize.Name = "txtFontSize";
            this.txtFontSize.Size = new System.Drawing.Size(151, 23);
            this.txtFontSize.TabIndex = 4;
            // 
            // lstFontSize
            // 
            this.lstFontSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFontSize.FormattingEnabled = true;
            this.lstFontSize.ItemHeight = 21;
            this.lstFontSize.Location = new System.Drawing.Point(350, 82);
            this.lstFontSize.Name = "lstFontSize";
            this.lstFontSize.Size = new System.Drawing.Size(151, 130);
            this.lstFontSize.TabIndex = 5;
            this.lstFontSize.SelectedIndexChanged += new System.EventHandler(this.lstFontSize_SelectedIndexChanged);
            // 
            // lstFonts
            // 
            this.lstFonts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstFonts.FormattingEnabled = true;
            this.lstFonts.ItemHeight = 21;
            this.lstFonts.Items.AddRange(new object[] {
            "Arial",
            "Candara",
            "MS UI Gothic",
            "Times New Roman"});
            this.lstFonts.Location = new System.Drawing.Point(12, 82);
            this.lstFonts.Name = "lstFonts";
            this.lstFonts.Size = new System.Drawing.Size(151, 130);
            this.lstFonts.TabIndex = 7;
            this.lstFonts.SelectedIndexChanged += new System.EventHandler(this.lstFonts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSample);
            this.groupBox1.Location = new System.Drawing.Point(182, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample";
            // 
            // lbSample
            // 
            this.lbSample.AutoSize = true;
            this.lbSample.Location = new System.Drawing.Point(65, 61);
            this.lbSample.Name = "lbSample";
            this.lbSample.Size = new System.Drawing.Size(60, 15);
            this.lbSample.TabIndex = 0;
            this.lbSample.Text = "AaBbYyZz";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(310, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 33);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 496);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstFonts);
            this.Controls.Add(this.lstFontSize);
            this.Controls.Add(this.txtFontSize);
            this.Controls.Add(this.lstStyles);
            this.Controls.Add(this.lbFontSize);
            this.Controls.Add(this.txtFontStyle);
            this.Controls.Add(this.lbStyleFont);
            this.Controls.Add(this.txtFontSearch);
            this.Controls.Add(this.lbFont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFont";
            this.Text = "Editar Fuente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFont;
        private TextBox txtFontSearch;
        private ListBox lstStyles;
        private TextBox txtFontStyle;
        private Label lbStyleFont;
        private Label lbFontSize;
        private TextBox txtFontSize;
        private ListBox lstFontSize;
        private ListBox lstFonts;
        private GroupBox groupBox1;
        private Label lbSample;
        private Button btnSave;
        private Button btnCancel;
    }
}