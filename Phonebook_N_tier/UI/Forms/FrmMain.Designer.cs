namespace UI_WinForm.Forms
{
    partial class FrmMain
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
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            btnDetail = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 235);
            dataGridView1.Margin = new Padding(5, 3, 5, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(706, 384);
            dataGridView1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(14, 146);
            btnSearch.Margin = new Padding(5, 3, 5, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(232, 63);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 93);
            txtSearch.Margin = new Padding(5, 3, 5, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 44);
            txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 27);
            label1.Name = "label1";
            label1.Size = new Size(78, 37);
            label1.TabIndex = 3;
            label1.Text = "جستجو";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(467, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 63);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(467, 77);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(203, 60);
            btnDetail.TabIndex = 5;
            btnDetail.Text = "نمایش جزییات";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(467, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(203, 59);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "افزودن مخاطب جدید";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(258, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(203, 59);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "ویرایش مخاطب";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 619);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnDetail);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Font = new Font("B Nazanin", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6, 3, 6, 3);
            Name = "FrmMain";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private Button btnDelete;
        private Button btnDetail;
        private Button btnAdd;
        private Button btnEdit;
    }
}