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
            dgCustomerList = new DataGridView();
            DeleteBtn = new Button();
            SaveBtn = new Button();
            UpdateBtn = new Button();
            cboGender = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtCusPhone = new MaskedTextBox();
            txtCusName = new MaskedTextBox();
            NewBtn = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtCusID = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgCustomerList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(297, 174);
            label8.Name = "label8";
            label8.Size = new Size(217, 25);
            label8.TabIndex = 13;
            label8.Text = "Customer Management";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(305, 45);
            label14.Name = "label14";
            label14.Size = new Size(116, 20);
            label14.TabIndex = 26;
            label14.Text = "Customer Name";
            // 
            // dgCustomerList
            // 
            dgCustomerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomerList.Location = new Point(297, 567);
            dgCustomerList.Name = "dgCustomerList";
            dgCustomerList.RowHeadersWidth = 51;
            dgCustomerList.Size = new Size(1164, 282);
            dgCustomerList.TabIndex = 25;
            dgCustomerList.Click += dgCustomerList_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(522, 120);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(138, 41);
            DeleteBtn.TabIndex = 22;
            DeleteBtn.Text = "Delete Customer";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(0, 192, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(182, 120);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 41);
            SaveBtn.TabIndex = 23;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Yellow;
            UpdateBtn.Location = new Point(351, 120);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(138, 41);
            UpdateBtn.TabIndex = 24;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(590, 69);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(215, 28);
            cboGender.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(861, 46);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 18;
            label11.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(590, 47);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 19;
            label10.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(297, 527);
            label9.Name = "label9";
            label9.Size = new Size(130, 28);
            label9.TabIndex = 20;
            label9.Text = "Customer List";
            // 
            // txtCusPhone
            // 
            txtCusPhone.Location = new Point(861, 68);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(237, 27);
            txtCusPhone.TabIndex = 15;
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(305, 68);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(216, 27);
            txtCusName.TabIndex = 16;
            // 
            // NewBtn
            // 
            NewBtn.BackColor = Color.DodgerBlue;
            NewBtn.ForeColor = Color.White;
            NewBtn.Location = new Point(14, 120);
            NewBtn.Name = "NewBtn";
            NewBtn.Size = new Size(138, 41);
            NewBtn.TabIndex = 27;
            NewBtn.Text = "New";
            NewBtn.UseVisualStyleBackColor = false;
            NewBtn.Click += NewBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCusID);
            groupBox1.Controls.Add(NewBtn);
            groupBox1.Controls.Add(DeleteBtn);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(UpdateBtn);
            groupBox1.Controls.Add(SaveBtn);
            groupBox1.Controls.Add(txtCusName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cboGender);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtCusPhone);
            groupBox1.Location = new Point(306, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1138, 235);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 46);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 29;
            label1.Text = "Customer ID";
            // 
            // txtCusID
            // 
            txtCusID.Location = new Point(14, 69);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(216, 27);
            txtCusID.TabIndex = 28;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1054);
            Controls.Add(dgCustomerList);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            Text = "Customers";
            WindowState = FormWindowState.Maximized;
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomerList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label14;
        private DataGridView dgCustomerList;
        private Button DeleteBtn;
        private Button SaveBtn;
        private Button UpdateBtn;
        private ComboBox cboGender;
        private Label label11;
        private Label label10;
        private Label label9;
        private MaskedTextBox txtCusPhone;
        private MaskedTextBox txtCusName;
        private Button NewBtn;
        private GroupBox groupBox1;
        private Label label1;
        private MaskedTextBox txtCusID;
    }
}