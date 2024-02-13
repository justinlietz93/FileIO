namespace JKL.FileIO.UI
{
    partial class frmFileIO
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
            components = new System.ComponentModel.Container();
            txtContent = new RichTextBox();
            mnuMenuStrip = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuFileNew = new ToolStripMenuItem();
            mnuFileOpen = new ToolStripMenuItem();
            mnuFileSave = new ToolStripMenuItem();
            mnuFileSaveAs = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            mnuEditFont = new ToolStripMenuItem();
            mnuColor = new ToolStripMenuItem();
            mnuEditColorBackColor = new ToolStripMenuItem();
            mnuEditColorFontColor = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            mnuEditThemeDark = new ToolStripMenuItem();
            mnuEditThemeLight = new ToolStripMenuItem();
            mnuHelp = new ToolStripMenuItem();
            lblStatusStrip = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            lblStatusLabel = new ToolStripStatusLabel();
            lblDateTime = new ToolStripStatusLabel();
            tmrClock = new System.Windows.Forms.Timer(components);
            mnuMenuStrip.SuspendLayout();
            lblStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContent.Location = new Point(0, 27);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(526, 446);
            txtContent.TabIndex = 0;
            txtContent.Text = "test";
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // mnuMenuStrip
            // 
            mnuMenuStrip.BackColor = Color.LightSteelBlue;
            mnuMenuStrip.Items.AddRange(new ToolStripItem[] { mnuFile, editToolStripMenuItem, mnuHelp });
            mnuMenuStrip.Location = new Point(0, 0);
            mnuMenuStrip.Name = "mnuMenuStrip";
            mnuMenuStrip.Size = new Size(526, 24);
            mnuMenuStrip.TabIndex = 1;
            mnuMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuFileNew, mnuFileOpen, mnuFileSave, mnuFileSaveAs });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(37, 20);
            mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            mnuFileNew.Name = "mnuFileNew";
            mnuFileNew.Size = new Size(114, 22);
            mnuFileNew.Text = "New";
            mnuFileNew.Click += mnuFileNew_Click;
            // 
            // mnuFileOpen
            // 
            mnuFileOpen.Name = "mnuFileOpen";
            mnuFileOpen.Size = new Size(114, 22);
            mnuFileOpen.Text = "Open";
            mnuFileOpen.Click += mnuFileOpen_Click;
            // 
            // mnuFileSave
            // 
            mnuFileSave.Name = "mnuFileSave";
            mnuFileSave.Size = new Size(114, 22);
            mnuFileSave.Text = "Save";
            mnuFileSave.Click += mnuFileSave_Click;
            // 
            // mnuFileSaveAs
            // 
            mnuFileSaveAs.Name = "mnuFileSaveAs";
            mnuFileSaveAs.Size = new Size(114, 22);
            mnuFileSaveAs.Text = "Save As";
            mnuFileSaveAs.Click += mnuFileSaveAs_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuEditFont, mnuColor, themeToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // mnuEditFont
            // 
            mnuEditFont.Name = "mnuEditFont";
            mnuEditFont.Size = new Size(180, 22);
            mnuEditFont.Text = "Font";
            mnuEditFont.Click += mnuEditFont_Click;
            // 
            // mnuColor
            // 
            mnuColor.DropDownItems.AddRange(new ToolStripItem[] { mnuEditColorBackColor, mnuEditColorFontColor });
            mnuColor.Name = "mnuColor";
            mnuColor.Size = new Size(180, 22);
            mnuColor.Text = "Color";
            // 
            // mnuEditColorBackColor
            // 
            mnuEditColorBackColor.Name = "mnuEditColorBackColor";
            mnuEditColorBackColor.Size = new Size(170, 22);
            mnuEditColorBackColor.Text = "Background Color";
            mnuEditColorBackColor.Click += mnuEditColorBackColor_Click;
            // 
            // mnuEditColorFontColor
            // 
            mnuEditColorFontColor.Name = "mnuEditColorFontColor";
            mnuEditColorFontColor.Size = new Size(170, 22);
            mnuEditColorFontColor.Text = "Font Color";
            mnuEditColorFontColor.Click += mnuEditColorFontColor_Click;
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuEditThemeDark, mnuEditThemeLight });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(180, 22);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // mnuEditThemeDark
            // 
            mnuEditThemeDark.Name = "mnuEditThemeDark";
            mnuEditThemeDark.Size = new Size(180, 22);
            mnuEditThemeDark.Text = "Dark";
            mnuEditThemeDark.Click += mnuEditThemeDark_Click;
            // 
            // mnuEditThemeLight
            // 
            mnuEditThemeLight.Name = "mnuEditThemeLight";
            mnuEditThemeLight.Size = new Size(180, 22);
            mnuEditThemeLight.Text = "Light";
            mnuEditThemeLight.Click += mnuEditThemeLight_Click;
            // 
            // mnuHelp
            // 
            mnuHelp.Name = "mnuHelp";
            mnuHelp.Size = new Size(44, 20);
            mnuHelp.Text = "&Help";
            mnuHelp.Click += mnuHelp_Click;
            // 
            // lblStatusStrip
            // 
            lblStatusStrip.Items.AddRange(new ToolStripItem[] { lblStatus, lblStatusLabel, lblDateTime });
            lblStatusStrip.Location = new Point(0, 476);
            lblStatusStrip.Name = "lblStatusStrip";
            lblStatusStrip.Size = new Size(526, 22);
            lblStatusStrip.TabIndex = 2;
            lblStatusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 17);
            // 
            // lblStatusLabel
            // 
            lblStatusLabel.Name = "lblStatusLabel";
            lblStatusLabel.Size = new Size(255, 17);
            lblStatusLabel.Spring = true;
            lblStatusLabel.Text = "                                          ";
            lblStatusLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDateTime
            // 
            lblDateTime.ImageAlign = ContentAlignment.MiddleRight;
            lblDateTime.Name = "lblDateTime";
            lblDateTime.RightToLeft = RightToLeft.No;
            lblDateTime.Size = new Size(255, 17);
            lblDateTime.Spring = true;
            // 
            // tmrClock
            // 
            tmrClock.Enabled = true;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // frmFileIO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 498);
            Controls.Add(lblStatusStrip);
            Controls.Add(txtContent);
            Controls.Add(mnuMenuStrip);
            MainMenuStrip = mnuMenuStrip;
            Name = "frmFileIO";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File I/O";
            mnuMenuStrip.ResumeLayout(false);
            mnuMenuStrip.PerformLayout();
            lblStatusStrip.ResumeLayout(false);
            lblStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtContent;
        private MenuStrip mnuMenuStrip;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuHelp;
        private StatusStrip lblStatusStrip;
        private System.Windows.Forms.Timer tmrClock;
        private ToolStripMenuItem mnuFileNew;
        private ToolStripMenuItem mnuFileOpen;
        private ToolStripMenuItem mnuFileSave;
        private ToolStripMenuItem mnuFileSaveAs;
        private ToolStripStatusLabel lblStatus;
        private ToolStripStatusLabel lblDateTime;
        private ToolStripStatusLabel lblStatusLabel;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem mnuEditFont;
        private ToolStripMenuItem mnuColor;
        private ToolStripMenuItem mnuEditColorBackColor;
        private ToolStripMenuItem mnuEditColorFontColor;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem mnuEditThemeDark;
        private ToolStripMenuItem mnuEditThemeLight;
    }
}
