namespace PGDCAProject.InventoryManagementSystem
{
    partial class Billing
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
            groupBox1 = new GroupBox();
            cboItems = new ComboBox();
            label14 = new Label();
            ResetBtn = new Button();
            AddToBillBtn = new Button();
            label12 = new Label();
            txtStock = new MaskedTextBox();
            cbEmoney = new CheckBox();
            cbCards = new CheckBox();
            cbCash = new CheckBox();
            groupBox2 = new GroupBox();
            PrintBtn = new Button();
            label1 = new Label();
            cboCustomers = new ComboBox();
            dgClientBillList = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            dgItemList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label9 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientBillList).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgItemList).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label8.Location = new Point(273, 178);
            label8.Name = "label8";
            label8.Size = new Size(244, 29);
            label8.TabIndex = 16;
            label8.Text = "Billing Management";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboItems);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(ResetBtn);
            groupBox1.Controls.Add(AddToBillBtn);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Location = new Point(273, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 215);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // cboItems
            // 
            cboItems.FormattingEnabled = true;
            cboItems.Location = new Point(35, 68);
            cboItems.Name = "cboItems";
            cboItems.Size = new Size(335, 28);
            cboItems.TabIndex = 62;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(35, 46);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 58;
            label14.Text = "Item Name";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Red;
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(202, 144);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(138, 41);
            ResetBtn.TabIndex = 56;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.BackColor = Color.FromArgb(0, 192, 0);
            AddToBillBtn.ForeColor = Color.White;
            AddToBillBtn.Location = new Point(35, 144);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(138, 41);
            AddToBillBtn.TabIndex = 57;
            AddToBillBtn.Text = "Add to Bill";
            AddToBillBtn.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(419, 46);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 54;
            label12.Text = "Item Quantity";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(419, 69);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(161, 27);
            txtStock.TabIndex = 50;
            // 
            // cbEmoney
            // 
            cbEmoney.AutoSize = true;
            cbEmoney.Font = new Font("Segoe UI", 10F);
            cbEmoney.Location = new Point(264, 121);
            cbEmoney.Name = "cbEmoney";
            cbEmoney.Size = new Size(93, 27);
            cbEmoney.TabIndex = 61;
            cbEmoney.Text = "EMoney";
            cbEmoney.UseVisualStyleBackColor = true;
            // 
            // cbCards
            // 
            cbCards.AutoSize = true;
            cbCards.Font = new Font("Segoe UI", 10F);
            cbCards.Location = new Point(140, 121);
            cbCards.Name = "cbCards";
            cbCards.Size = new Size(75, 27);
            cbCards.TabIndex = 60;
            cbCards.Text = "Cards";
            cbCards.UseVisualStyleBackColor = true;
            // 
            // cbCash
            // 
            cbCash.AutoSize = true;
            cbCash.Font = new Font("Segoe UI", 10F);
            cbCash.Location = new Point(25, 121);
            cbCash.Name = "cbCash";
            cbCash.Size = new Size(69, 27);
            cbCash.TabIndex = 59;
            cbCash.Text = "Cash";
            cbCash.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PrintBtn);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboCustomers);
            groupBox2.Controls.Add(cbEmoney);
            groupBox2.Controls.Add(dgClientBillList);
            groupBox2.Controls.Add(cbCards);
            groupBox2.Controls.Add(cbCash);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(1023, 207);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(889, 813);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.FromArgb(128, 128, 255);
            PrintBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(725, 36);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(138, 41);
            PrintBtn.TabIndex = 69;
            PrintBtn.Text = "Print Bill";
            PrintBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label1.Location = new Point(25, 78);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 68;
            label1.Text = "Payment Methods";
            // 
            // cboCustomers
            // 
            cboCustomers.FormattingEnabled = true;
            cboCustomers.Location = new Point(174, 246);
            cboCustomers.Name = "cboCustomers";
            cboCustomers.Size = new Size(216, 28);
            cboCustomers.TabIndex = 67;
            // 
            // dgClientBillList
            // 
            dgClientBillList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClientBillList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientBillList.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            dgClientBillList.Location = new Point(25, 291);
            dgClientBillList.Name = "dgClientBillList";
            dgClientBillList.RowHeadersWidth = 51;
            dgClientBillList.Size = new Size(838, 500);
            dgClientBillList.TabIndex = 65;
            // 
            // Column5
            // 
            Column5.HeaderText = "#";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "ItemName";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "ItemPrice";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Quantity";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Total";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label10.Location = new Point(25, 246);
            label10.Name = "label10";
            label10.Size = new Size(109, 30);
            label10.TabIndex = 64;
            label10.Text = "Client Bill";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(174, 223);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 66;
            label11.Text = "Customer Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgItemList);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(273, 466);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(726, 557);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            // 
            // dgItemList
            // 
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgItemList.Location = new Point(18, 51);
            dgItemList.Name = "dgItemList";
            dgItemList.RowHeadersWidth = 51;
            dgItemList.Size = new Size(688, 484);
            dgItemList.TabIndex = 32;
            // 
            // Column1
            // 
            Column1.HeaderText = "ItemName";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Stock";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Manufacturer";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(18, 13);
            label9.Name = "label9";
            label9.Size = new Size(102, 31);
            label9.TabIndex = 31;
            label9.Text = "Item List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label2.Location = new Point(1023, 175);
            label2.Name = "label2";
            label2.Size = new Size(189, 29);
            label2.TabIndex = 37;
            label2.Text = "Billing Process";
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1054);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            Text = "Billing";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgClientBillList).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgItemList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private GroupBox groupBox1;
        private ComboBox cboItems;
        private CheckBox cbEmoney;
        private CheckBox cbCards;
        private CheckBox cbCash;
        private Label label14;
        private Button ResetBtn;
        private Button AddToBillBtn;
        private Label label12;
        private MaskedTextBox txtStock;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboCustomers;
        private DataGridView dgClientBillList;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Label label10;
        private Label label11;
        private GroupBox groupBox3;
        private DataGridView dgItemList;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label9;
        private Button PrintBtn;
        private Label label2;
    }
}