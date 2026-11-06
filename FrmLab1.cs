namespace TANGHALEXER1
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter text first.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtInput.Focus();
                return;
            }

            using (FrmFileName fileNameForm = new FrmFileName())
            {
                if (fileNameForm.ShowDialog() != DialogResult.OK)
                    return;
            }

            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            string filePath = Path.Combine(
                docPath, FrmFileName.SetFileName);

            try
            {
                using (StreamWriter outputFile =
                    new StreamWriter(filePath))
                {
                    outputFile.WriteLine(getInput);
                }

                MessageBox.Show("Text file created successfully!\n" +
                    filePath,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating file: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}