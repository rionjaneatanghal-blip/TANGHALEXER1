using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TANGHALEXER1
{
    internal sealed class FrmStudentRecord : Form
    {
        private readonly ListBox recordFilesList = new ListBox();
        private readonly Button refreshButton = new Button();
        private readonly Button closeButton = new Button();
        private FrmRegistration? registrationForm;

        internal FrmStudentRecord()
        {
            Text = "Student Record Files";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(600, 400);

            recordFilesList.Dock = DockStyle.Fill;
            recordFilesList.Font = new Font("Segoe UI", 11F);
            recordFilesList.DoubleClick += RecordFilesList_DoubleClick;

            refreshButton.Text = "Refresh";
            refreshButton.Width = 100;
            refreshButton.Click += (_, _) => LoadRecordFiles();

            closeButton.Text = "Close";
            closeButton.Width = 100;
            closeButton.Click += (_, _) => Close();

            FlowLayoutPanel buttonsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                FlowDirection = FlowDirection.RightToLeft,
                Padding = new Padding(5)
            };
            buttonsPanel.Controls.Add(closeButton);
            buttonsPanel.Controls.Add(refreshButton);

            Controls.Add(recordFilesList);
            Controls.Add(buttonsPanel);
            Load += (_, _) => LoadRecordFiles();
            FormClosed += (_, _) => registrationForm?.Show();
        }

        internal void Show(FrmRegistration frmRegistration)
        {
            registrationForm = frmRegistration;
            base.Show(frmRegistration);
        }

        private void LoadRecordFiles()
        {
            recordFilesList.Items.Clear();

            string documentsPath = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            try
            {
                string[] files = Directory.GetFiles(documentsPath, "*.txt");

                foreach (string file in files.OrderBy(file => file))
                {
                    recordFilesList.Items.Add(Path.GetFileName(file));
                }

                if (recordFilesList.Items.Count == 0)
                {
                    recordFilesList.Items.Add("No student record files found.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Unable to load record files:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecordFilesList_DoubleClick(object? sender, EventArgs e)
        {
            if (recordFilesList.SelectedItem is not string fileName ||
                fileName == "No student record files found.")
            {
                return;
            }

            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                fileName);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The selected file no longer exists.",
                    "File Not Found", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                LoadRecordFiles();
                return;
            }

            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }
    }
}