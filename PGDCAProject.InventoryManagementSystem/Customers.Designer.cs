namespace PGDCAProject.InventoryManagementSystem
{
    partial class Customers
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
            label8 = new Label();
            label14 = new Label();
            dgItemList = new DataGridView();
            CusId = new DataGridViewTextBoxColumn();
            CusName = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            CusPhone = new DataGridViewTextBoxColumn();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            EditBtn = new Button();
            cboCategory = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtPrice = new MaskedTextBox();
            txtItem = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgItemList).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(297, 68);
            label8.Name = "label8";
            label8.Size = new Size(217, 25);
            label8.TabIndex = 13;
            label8.Text = "Customer Management";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(306, 150);
            label14.Name = "label14";
            label14.Size = new Size(116, 20);
            label14.TabIndex = 26;
            label14.Text = "Customer Name";
            // 
            // dgItemList
            // 
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemList.Columns.AddRange(new DataGridViewColumn[] { CusId, CusName, Gender, CusPhone });
            dgItemList.Location = new Point(306, 360);
            dgItemList.Name = "dgItemList";
            dgItemList.RowHeadersWidth = 51;
            dgItemList.Size = new Size(1164, 282);
            dgItemList.TabIndex = 25;
            // 
            // CusId
            // 
            CusId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CusId.HeaderText = "CusId";
            CusId.MinimumWidth = 6;
            CusId.Name = "CusId";
            CusId.Width = 125;
            // 
            // CusName
            // 
            CusName.HeaderText = "CusName";
            CusName.MinimumWidth = 6;
            CusName.Name = "CusName";
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.MinimumWidth = 6;
            Gender.Name = "Gender";
            // 
            // CusPhone
            // 
            CusPhone.HeaderText = "Phone";
            CusPhone.MinimumWidth = 6;
            CusPhone.Name = "CusPhone";
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(970, 224);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(138, 41);
            DeleteBtn.TabIndex = 22;
            DeleteBtn.Text = "Delete Item";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(826, 224);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 41);
            SaveBtn.TabIndex = 23;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Yellow;
            EditBtn.Location = new Point(682, 224);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(138, 41);
            EditBtn.TabIndex = 24;
            EditBtn.Text = "Edit Item";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(541, 173);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(215, 28);
            cboCategory.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(781, 150);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 18;
            label11.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(541, 150);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 19;
            label10.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(306, 320);
            label9.Name = "label9";
            label9.Size = new Size(130, 28);
            label9.TabIndex = 20;
            label9.Text = "Customer List";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(781, 173);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(216, 27);
            txtPrice.TabIndex = 15;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(306, 173);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(216, 27);
            txtItem.TabIndex = 16;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 751);
            Controls.Add(label14);
            Controls.Add(dgItemList);
            Controls.Add(DeleteBtn);
            Controls.Add(SaveBtn);
            Controls.Add(EditBtn);
            Controls.Add(cboCategory);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtPrice);
            Controls.Add(txtItem);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            Text = "Customers";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgItemList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label14;
        private DataGridView dgItemList;
        private DataGridViewTextBoxColumn CusId;
        private DataGridViewTextBoxColumn CusName;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn CusPhone;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Button EditBtn;
        private ComboBox cboCategory;
        private Label label11;
        private Label label10;
        private Label label9;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtItem;
    }
}