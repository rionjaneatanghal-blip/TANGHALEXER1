namespace TANGHALEXER1
{
    partial class FrmRegistration
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
            lblStudentNo = new Label();
            lblProgram = new Label();
            lblLastName = new Label();
            lblGender = new Label();
            lblFirstName = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblMI = new Label();
            lblContactNo = new Label();
            btnRegister = new Button();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            dtpBirthday = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbProgram = new ComboBox();
            txtMI = new TextBox();
            btnStudentRecord = new Button();
            SuspendLayout();
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentNo.Location = new Point(12, 35);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(94, 21);
            lblStudentNo.TabIndex = 0;
            lblStudentNo.Text = "Student No.:";
            lblStudentNo.Click += label1_Click;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProgram.Location = new Point(273, 35);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(74, 21);
            lblProgram.TabIndex = 1;
            lblProgram.Text = "Program:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(12, 97);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(87, 21);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(273, 146);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 21);
            lblGender.TabIndex = 3;
            lblGender.Text = "Gender:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(273, 97);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(89, 21);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(12, 146);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(40, 21);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthday.Location = new Point(12, 196);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(71, 21);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Birthday:";
            // 
            // lblMI
            // 
            lblMI.AutoSize = true;
            lblMI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMI.Location = new Point(495, 97);
            lblMI.Name = "lblMI";
            lblMI.Size = new Size(37, 21);
            lblMI.TabIndex = 7;
            lblMI.Text = "M.I.:";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactNo.Location = new Point(305, 196);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(91, 21);
            lblContactNo.TabIndex = 8;
            lblContactNo.Text = "Contact No:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(183, 258);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(111, 34);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(112, 33);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(155, 23);
            txtStudentNo.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(112, 95);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 23);
            txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(359, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(140, 23);
            txtFirstName.TabIndex = 12;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(58, 144);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(107, 23);
            txtAge.TabIndex = 13;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(402, 191);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(155, 23);
            txtContactNo.TabIndex = 14;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(89, 195);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(343, 144);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(186, 23);
            cmbGender.TabIndex = 16;
            // 
            // cmbProgram
            // 
            cmbProgram.FormattingEnabled = true;
            cmbProgram.Location = new Point(343, 33);
            cmbProgram.Name = "cmbProgram";
            cmbProgram.Size = new Size(186, 23);
            cmbProgram.TabIndex = 17;
            // 
            // txtMI
            // 
            txtMI.Location = new Point(535, 95);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(54, 23);
            txtMI.TabIndex = 18;
            // 
            // btnStudentRecord
            // 
            btnStudentRecord.Location = new Point(478, 258);
            btnStudentRecord.Name = "btnStudentRecord";
            btnStudentRecord.Size = new Size(111, 34);
            btnStudentRecord.TabIndex = 19;
            btnStudentRecord.Text = "Records";
            btnStudentRecord.UseVisualStyleBackColor = true;
            btnStudentRecord.Click += btnStudentRecord_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 352);
            Controls.Add(btnStudentRecord);
            Controls.Add(txtMI);
            Controls.Add(cmbProgram);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthday);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(btnRegister);
            Controls.Add(lblContactNo);
            Controls.Add(lblMI);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblFirstName);
            Controls.Add(lblGender);
            Controls.Add(lblLastName);
            Controls.Add(lblProgram);
            Controls.Add(lblStudentNo);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentNo;
        private Label lblProgram;
        private Label lblLastName;
        private Label lblGender;
        private Label lblFirstName;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblMI;
        private Label lblContactNo;
        private Button btnRegister;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private DateTimePicker dtpBirthday;
        private ComboBox cmbGender;
        private ComboBox cmbProgram;
        private TextBox txtMI;
        private Button btnStudentRecord;
    }
}