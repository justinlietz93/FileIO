using System.Windows.Forms;

namespace JKL.FileIO.UI
{
    public partial class frmFileIO : Form
    {
        string fileName;
        private bool changesMade = false;
        private bool darkThemeSet = false;


        public frmFileIO()
        {
            InitializeComponent();
        }

        // Save function, writes data straight to filePath
        private void SaveToFile(string filePath)
        {
            using (StreamWriter streamWriter = File.CreateText(filePath))
            {
                streamWriter.WriteLine(txtContent.Text);
                streamWriter.Dispose();
                changesMade = false;
            }
            lblStatus.Text = $"{filePath} successfully saved.";
        }

        // Save As function, prompts user with save dialog
        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save As";
            saveFileDialog.InitialDirectory = @"c:\Users\public";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                SaveToFile(fileName);
                changesMade = false;
            }
            else
            {
                throw new Exception("No file selected.");
            }
        }

        private void OpenFile()
        {

            OpenFileDialog openFileDialog;

            openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.InitialDirectory = @"c:\Users\public";
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            // Show open file dialog to user
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lblStatus.Text = openFileDialog.FileName;
                fileName = openFileDialog.FileName;
                try
                {
                    StreamReader streamReader;
                    txtContent.Text = string.Empty;

                    if (File.Exists(fileName))
                    {
                        // User streamreader to read from file
                        streamReader = File.OpenText(fileName);
                        string content = streamReader.ReadToEnd();

                        streamReader.Close();
                        streamReader = null;

                        // Put data from file into textbox
                        txtContent.Text = content;

                        lblStatus.Text = "Opened (" + fileName + ")";
                        changesMade = false;
                    }
                    else
                    {
                        throw new Exception("(" + fileName + ") does not exist.");
                    }

                }
                catch (Exception ex)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = ex.Message;
                }
            }
            else
            {
                throw new Exception("No file selected.");
            }
        }

        // Changes various style settings based on whether dark mode or light mode theme is selected
        private void SetTheme()
        {
            if (darkThemeSet)
            {
                // Dark mode theme
                txtContent.BackColor = Color.FromArgb(30, 30, 30);
                txtContent.ForeColor = Color.White;
                mnuMenuStrip.BackColor = Color.FromArgb(60, 60, 60);
                mnuMenuStrip.ForeColor = Color.White;
                lblStatusStrip.BackColor = Color.FromArgb(60, 60, 60);
                lblDateTime.ForeColor = Color.White;
                this.BackColor = Color.FromArgb(60, 60, 60);
                lblStatus.ForeColor = Color.White;
            }
            else
            {
                // Light mode theme
                txtContent.BackColor = Color.White;
                txtContent.ForeColor = SystemColors.ControlText;
                mnuMenuStrip.BackColor = Color.LightSteelBlue;
                mnuMenuStrip.ForeColor = SystemColors.ControlText;
                lblStatusStrip.BackColor = SystemColors.Control;
                lblDateTime.ForeColor = SystemColors.ControlText;
                this.BackColor = SystemColors.Control;
                lblStatus.ForeColor = SystemColors.ControlText;
            }
        }

        // Checks for theme to make sure Status font color will be visible when necessary
        private void CheckTheme()
        {
            if (darkThemeSet)
            {
                lblStatus.ForeColor = Color.White;
            }
            else
            {
                lblStatus.ForeColor = Color.Black;
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            // Detects when user makes changes and sets bool to true
            changesMade = true;
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTheme();
                lblStatus.Text = string.Empty;

                // Checks if text changes were made, if so prompt for save, if not then start new file
                if (changesMade)
                {
                    DialogResult result = MessageBox.Show("Would you like to save?", "Save Changes", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SaveAs();
                    }
                }

                // Clears the content box, sets the fileName to no file, and sets changes made to false
                txtContent.Text = string.Empty;
                fileName = "";
                changesMade = false;
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTheme();

                lblStatus.Text = string.Empty;

                OpenFileDialog openFileDialog;

                openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Choose File";
                openFileDialog.InitialDirectory = @"c:\Users\public";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (changesMade)
                {
                    DialogResult result = MessageBox.Show("Would you like to save?", "Save Changes", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SaveAs();
                    }
                    OpenFile();
                }
                else
                {
                    // Show open file dialog to user
                    OpenFile();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTheme();

                lblStatus.Text = string.Empty;

                if (!string.IsNullOrEmpty(fileName) && File.Exists(fileName))
                {
                    // A file is already opened, save to that file
                    SaveToFile(fileName);
                }
                else
                {
                    // No file is opened, prompt the user to select a file
                    SaveAs();
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTheme();

                lblStatus.Text = string.Empty;

                SaveAs();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblDateTime.Alignment = ToolStripItemAlignment.Right;
            lblStatusStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter your text content into the content box area.\n" +
                            "To save click File then Save, or Save As.\n" +
                            "To start a new file click File then New.\n" +
                            "To open an existing file click File then Open.\n" +
                            "To change font style/color, background colors and themes click Edit.", "Help");
        }

        private void mnuEditFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                txtContent.Font = fontDialog.Font;
            }
        }

        private void mnuEditColorBackColor_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTheme();

                lblStatus.Text = string.Empty;

                ColorDialog colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    txtContent.BackColor = colorDialog.Color;
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void mnuEditColorFontColor_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTheme();

                lblStatus.Text = string.Empty;

                ColorDialog colorDialog = new ColorDialog();

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    txtContent.ForeColor = colorDialog.Color;
                }
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = ex.Message;
            }
        }

        private void mnuEditThemeDark_Click(object sender, EventArgs e)
        {
            darkThemeSet = true;
            SetTheme();
        }

        private void mnuEditThemeLight_Click(object sender, EventArgs e)
        {
            darkThemeSet = false;
            SetTheme();
        }
    }
}
