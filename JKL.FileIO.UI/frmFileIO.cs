namespace JKL.FileIO.UI
{
    public partial class frmFileIO : Form
    {
        string fileName = null;
        private bool changesMade = false;


        public frmFileIO()
        {
            InitializeComponent();
        }

        private void SaveToFile(string filePath)
        {
            using (StreamWriter streamWriter = File.CreateText(filePath))
            {
                streamWriter.WriteLine(txtContent.Text);
                streamWriter.Dispose();
            }
            lblStatus.Text = $"{filePath} successfully saved.";
        }

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
            }
            else
            {
                throw new Exception("No file selected.");
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            changesMade = true;
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            try
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                // Checks if text changes were made
                if (changesMade)
                {
                    DialogResult result = MessageBox.Show("Would you like to save?", "Save Changes", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        SaveAs();
                    }
                }
                txtContent.Text = string.Empty;
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
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = string.Empty;

                OpenFileDialog openFileDialog;

                openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Choose File";
                openFileDialog.InitialDirectory = @"c:\Users\public";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                // Show dialog to user
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblStatus.Text = openFileDialog.FileName;
                    fileName = openFileDialog.FileName;
                    try
                    {
                        lblStatus.ForeColor = Color.Blue;

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
                lblStatus.ForeColor = Color.Blue;
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
                lblStatus.ForeColor = Color.Blue;
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
            MessageBox.Show("Enter your text content into the content box area. To save click File then Save, or Save As. To open a new" +
                            " file click File then New. You can also open an existing file by clicking File then Open.", "Help");
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
                lblStatus.ForeColor = Color.Blue;
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
    }
}
