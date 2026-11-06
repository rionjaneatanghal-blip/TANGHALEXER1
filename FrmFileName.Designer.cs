namespace TANGHALEXER1
{
    partial class FrmFileName
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
            lblFileName = new Label();
            txtFileName = new TextBox();
            btnOkay = new Button();
            SuspendLayout();
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.Location = new Point(22, 33);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(111, 30);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.Location = new Point(22, 66);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(235, 33);
            txtFileName.TabIndex = 2;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(84, 105);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(111, 34);
            btnOkay.TabIndex = 3;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 211);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            Name = "FrmFileName";
            Text = "FrmFileName";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFileName;
        private TextBox txtFileName;
        private Button btnOkay;
    }
}