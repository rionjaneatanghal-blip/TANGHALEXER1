using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TANGHALEXER1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            cmbProgram.Items.AddRange(new string[]
           {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS Computer Engineering"
           });

            cmbGender.Items.AddRange(new string[]
            {
                "Male",
                "Female"
            });

            cmbProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentNo = txtStudentNo.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string middleInitial = txtMI.Text.Trim();
            string ageText = txtAge.Text.Trim();
            string contactNo = txtContactNo.Text.Trim();

            int age;


            if (!System.Text.RegularExpressions.Regex.IsMatch(
                studentNo, @"^[0-9]+$"))
            {
                MessageBox.Show("Student Number must contain numbers only.");
                txtStudentNo.Focus();
                return;
            }


            if (!int.TryParse(ageText, out age) || age < 1 || age > 120)
            {
                MessageBox.Show("Age must be a number between 1 and 120.");
                txtAge.Focus();
                return;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(
                contactNo, @"^[0-9]+$"))
            {
                MessageBox.Show("Contact Number must contain numbers only.");
                txtContactNo.Focus();
                return;
            }


            if (lastName == "" || firstName == "" ||
                cmbProgram.SelectedIndex == -1 ||
                cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }


            string[] registrationData =
            {
        "Student No.:" + studentNo,
        "Full Name:" + lastName + ", " + firstName + ", " + middleInitial,
        "Program: " + cmbProgram.Text,
        "Gender: " + cmbGender.Text,
        "Age: " + ageText,
        "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
        "Contact No.:" + contactNo
    };


            string docPath = Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments);

            string filePath = System.IO.Path.Combine(
                docPath, studentNo + ".txt");

            try
            {
                using (System.IO.StreamWriter outputFile =
                    new System.IO.StreamWriter(filePath))
                {
                    foreach (string data in registrationData)
                    {
                        outputFile.WriteLine(data);
                    }
                }

                MessageBox.Show(
                    "Registration saved successfully!\n\nFile: " +
                    studentNo + ".txt\nLocation: " + docPath,
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save the file:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecord = new FrmStudentRecord();

            studentRecord.Show(this);

            this.Hide();
        }
    }
    }
