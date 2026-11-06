using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TANGHALEXER1
{
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }

        public static string SetFileName { get; internal set; }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name.",
                    "Invalid File Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtFileName.Focus();
                return;
            }

            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("Please enter a valid file name.",
                    "Invalid File Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtFileName.Focus();
                return;
            }

            if (fileName.EndsWith(".txt",
                StringComparison.OrdinalIgnoreCase))
            {
                fileName = fileName.Substring(
                    0, fileName.Length - 4);
            }

            SetFileName = fileName + ".txt";
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
