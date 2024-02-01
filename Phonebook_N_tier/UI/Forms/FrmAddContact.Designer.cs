namespace UI_WinForm.Forms
{
    partial class FrmAddContact
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtCompany = new TextBox();
            txtPhoneNumber = new TextBox();
            txtDescription = new RichTextBox();
            label6 = new Label();
            btnAdd = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(25, 98);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(39, 37);
            label1.TabIndex = 0;
            label1.Text = "نام";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(22, 170);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(117, 37);
            label2.TabIndex = 1;
            label2.Text = "نام خانوادگی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(25, 245);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(69, 37);
            label3.TabIndex = 2;
            label3.Text = "شرکت";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(25, 314);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(67, 37);
            label4.TabIndex = 3;
            label4.Text = "موبایل";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(25, 386);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(93, 37);
            label5.TabIndex = 4;
            label5.Text = "توضیحات";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(158, 91);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(307, 44);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(158, 163);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(307, 44);
            txtLastName.TabIndex = 6;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(158, 236);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(307, 44);
            txtCompany.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(158, 310);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(307, 44);
            txtPhoneNumber.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(158, 386);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(307, 186);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(148, 24);
            label6.Name = "label6";
            label6.Size = new Size(185, 37);
            label6.TabIndex = 11;
            label6.Text = "افزودن مخاطب جدید";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 590);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(281, 47);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ثبت مخاطب جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(326, 590);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 47);
            btnClose.TabIndex = 13;
            btnClose.Text = "بازگشت";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmAddContact
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(491, 649);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
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
            Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FrmAddContact";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtCompany;
        private TextBox txtPhoneNumber;
        private RichTextBox txtDescription;
        private Label label6;
        private Button btnAdd;
        private Button btnClose;
    }
}