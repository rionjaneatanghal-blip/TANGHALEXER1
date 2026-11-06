namespace TANGHALEXER1
{
    partial class FrmLab1
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
            lblInput = new Label();
            txtInput = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInput.Location = new Point(29, 35);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(109, 30);
            lblInput.TabIndex = 0;
            lblInput.Text = "Enter Text:";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(38, 68);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(270, 33);
            txtInput.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(111, 107);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 34);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += this.btnCreate_Click;
            // 
            // FrmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 235);
            Controls.Add(btnCreate);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Name = "FrmLab1";
            Text = "FrmLab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtInput;
        private Button btnCreate;
    }
}
