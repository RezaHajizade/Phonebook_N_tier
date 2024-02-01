namespace UI_WinForm.Forms
{
    partial class frmEdit
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
            btnClose = new Button();
            btnSaveEdit = new Button();
            label6 = new Label();
            txtDescription = new RichTextBox();
            txtPhoneNumber = new TextBox();
            txtCompany = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(324, 607);
            btnClose.Margin = new Padding(5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 46);
            btnClose.TabIndex = 26;
            btnClose.Text = "بازگشت";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Location = new Point(62, 607);
            btnSaveEdit.Margin = new Padding(5);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(230, 46);
            btnSaveEdit.TabIndex = 25;
            btnSaveEdit.Text = "ثبت تغیرات";
            btnSaveEdit.UseVisualStyleBackColor = true;
            btnSaveEdit.Click += btnSaveEdit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(160, 31);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 37);
            label6.TabIndex = 24;
            label6.Text = "ویرایش مخاطب";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(145, 376);
            txtDescription.Margin = new Padding(5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(292, 221);
            txtDescription.TabIndex = 23;
            txtDescription.Text = "";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(145, 305);
            txtPhoneNumber.Margin = new Padding(5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(292, 39);
            txtPhoneNumber.TabIndex = 22;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(145, 233);
            txtCompany.Margin = new Padding(5);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(292, 39);
            txtCompany.TabIndex = 21;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(145, 169);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(292, 39);
            txtLastName.TabIndex = 20;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(145, 102);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(292, 39);
            txtFirstName.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(9, 376);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(80, 32);
            label5.TabIndex = 18;
            label5.Text = "توضیحات";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(9, 305);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(58, 32);
            label4.TabIndex = 17;
            label4.Text = "موبایل";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(9, 233);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(60, 32);
            label3.TabIndex = 16;
            label3.Text = "شرکت";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(1, 169);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(102, 32);
            label2.TabIndex = 15;
            label2.Text = "نام خانوادگی";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(14, 102);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(33, 32);
            label1.TabIndex = 14;
            label1.Text = "نام";
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(468, 671);
            Controls.Add(btnClose);
            Controls.Add(btnSaveEdit);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCompany);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Nazanin", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "frmEdit";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmEdit";
            Load += frmEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSaveEdit;
        private Label label6;
        private RichTextBox txtDescription;
        private TextBox txtPhoneNumber;
        private TextBox txtCompany;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}