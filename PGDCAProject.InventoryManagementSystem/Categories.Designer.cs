namespace PGDCAProject.InventoryManagementSystem
{
    partial class Categories
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
            dgCategoryList = new DataGridView();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            UpdateBtn = new Button();
            label10 = new Label();
            label9 = new Label();
            txtCategoryId = new MaskedTextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtCategoryName = new MaskedTextBox();
            label11 = new Label();
            NewBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCategoryList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgCategoryList
            // 
            dgCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategoryList.Location = new Point(297, 482);
            dgCategoryList.Name = "dgCategoryList";
            dgCategoryList.RowHeadersWidth = 51;
            dgCategoryList.Size = new Size(841, 285);
            dgCategoryList.TabIndex = 22;
            dgCategoryList.Click += dgCategoryList_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(488, 128);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(138, 41);
            DeleteBtn.TabIndex = 19;
            DeleteBtn.Text = "Delete Item";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(171, 128);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 41);
            SaveBtn.TabIndex = 20;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Yellow;
            UpdateBtn.Location = new Point(331, 128);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(138, 41);
            UpdateBtn.TabIndex = 21;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 34);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 16;
            label10.Text = "Category ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(296, 446);
            label9.Name = "label9";
            label9.Size = new Size(126, 28);
            label9.TabIndex = 17;
            label9.Text = "Category List";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(16, 57);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(216, 27);
            txtCategoryId.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(296, 180);
            label8.Name = "label8";
            label8.Size = new Size(212, 25);
            label8.TabIndex = 10;
            label8.Text = "Category Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategoryName);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(NewBtn);
            groupBox1.Controls.Add(UpdateBtn);
            groupBox1.Controls.Add(txtCategoryId);
            groupBox1.Controls.Add(DeleteBtn);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Location = new Point(297, 208);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(841, 207);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(283, 57);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(216, 27);
            txtCategoryName.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(283, 34);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 24;
            label11.Text = "Category Name";
            // 
            // NewBtn
            // 
            NewBtn.BackColor = Color.DodgerBlue;
            NewBtn.ForeColor = Color.White;
            NewBtn.Location = new Point(16, 128);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(138, 41);
            NewBtn.TabIndex = 22;
            NewBtn.Text = "New";
            NewBtn.UseVisualStyleBackColor = false;
            NewBtn.Click += NewBtn_Click;
            // 
            // Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1924, 1054);
            Controls.Add(groupBox1);
            Controls.Add(dgCategoryList);
            Controls.Add(label9);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Categories";
            Text = "Categories";
            WindowState = FormWindowState.Maximized;
            Load += Categories_Load;
            ((System.ComponentModel.ISupportInitialize)dgCategoryList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgCategoryList;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Button UpdateBtn;
        private Label label10;
        private Label label9;
        private MaskedTextBox txtCategoryId;
        private Label label8;
        private GroupBox groupBox1;
        private MaskedTextBox txtCategoryName;
        private Label label11;
        private Button NewBtn;
    }
}