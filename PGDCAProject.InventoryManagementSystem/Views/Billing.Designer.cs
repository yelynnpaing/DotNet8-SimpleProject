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
            label6 = new Label();
            label5 = new Label();
            txtInvoiceNum = new MaskedTextBox();
            txtTotalCost = new MaskedTextBox();
            label4 = new Label();
            txtPrice = new MaskedTextBox();
            InvoiceNoBtn = new Button();
            cboItems = new ComboBox();
            label14 = new Label();
            ResetBtn = new Button();
            AddToBillBtn = new Button();
            label12 = new Label();
            txtQuantity = new MaskedTextBox();
            cbEmoney = new CheckBox();
            cbCards = new CheckBox();
            cbCash = new CheckBox();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            SaveBtn = new Button();
            txtBillInvoiceNum = new MaskedTextBox();
            label3 = new Label();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            PrintBtn = new Button();
            label1 = new Label();
            cboCustomers = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            dgItemList = new DataGridView();
            label9 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtInvoiceNum);
            groupBox1.Controls.Add(txtTotalCost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(InvoiceNoBtn);
            groupBox1.Controls.Add(cboItems);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(ResetBtn);
            groupBox1.Controls.Add(AddToBillBtn);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Location = new Point(273, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 302);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 36);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 77;
            label6.Text = "Invoice Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 165);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 67;
            label5.Text = "Total Cost";
            // 
            // txtInvoiceNum
            // 
            txtInvoiceNum.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txtInvoiceNum.Location = new Point(35, 59);
            txtInvoiceNum.Name = "txtInvoiceNum";
            txtInvoiceNum.Size = new Size(335, 27);
            txtInvoiceNum.TabIndex = 76;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(423, 188);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(283, 27);
            txtTotalCost.TabIndex = 66;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 101);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 65;
            label4.Text = "Item Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(423, 124);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(283, 27);
            txtPrice.TabIndex = 64;
            // 
            // InvoiceNoBtn
            // 
            InvoiceNoBtn.BackColor = Color.DodgerBlue;
            InvoiceNoBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InvoiceNoBtn.ForeColor = Color.White;
            InvoiceNoBtn.Location = new Point(35, 243);
            InvoiceNoBtn.Name = "InvoiceNoBtn";
            InvoiceNoBtn.Size = new Size(205, 41);
            InvoiceNoBtn.TabIndex = 63;
            InvoiceNoBtn.Text = "Generate Invoice Number";
            InvoiceNoBtn.UseVisualStyleBackColor = false;
            InvoiceNoBtn.Click += InvoiceNoBtn_Click;
            // 
            // cboItems
            // 
            cboItems.FormattingEnabled = true;
            cboItems.Location = new Point(35, 123);
            cboItems.Name = "cboItems";
            cboItems.Size = new Size(335, 28);
            cboItems.TabIndex = 62;
            cboItems.Leave += cboItems_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(35, 101);
            label14.Name = "label14";
            label14.Size = new Size(83, 20);
            label14.TabIndex = 58;
            label14.Text = "Item Name";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Red;
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(411, 243);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(111, 41);
            ResetBtn.TabIndex = 56;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            // 
            // AddToBillBtn
            // 
            AddToBillBtn.BackColor = Color.FromArgb(0, 192, 0);
            AddToBillBtn.ForeColor = Color.White;
            AddToBillBtn.Location = new Point(269, 243);
            AddToBillBtn.Name = "AddToBillBtn";
            AddToBillBtn.Size = new Size(111, 41);
            AddToBillBtn.TabIndex = 57;
            AddToBillBtn.Text = "Add to Bill";
            AddToBillBtn.UseVisualStyleBackColor = false;
            AddToBillBtn.Click += AddToBillBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(35, 165);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 54;
            label12.Text = "Item Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(35, 188);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(335, 27);
            txtQuantity.TabIndex = 50;
            txtQuantity.Leave += txtQuantity_Leave;
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
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(SaveBtn);
            groupBox2.Controls.Add(txtBillInvoiceNum);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(UpdateBtn);
            groupBox2.Controls.Add(DeleteBtn);
            groupBox2.Controls.Add(PrintBtn);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboCustomers);
            groupBox2.Controls.Add(cbEmoney);
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
            // listView1
            // 
            listView1.Location = new Point(25, 270);
            listView1.Name = "listView1";
            listView1.Size = new Size(838, 524);
            listView1.TabIndex = 75;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.CornflowerBlue;
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(597, 36);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(122, 41);
            SaveBtn.TabIndex = 74;
            SaveBtn.Text = "Save Bill";
            SaveBtn.UseVisualStyleBackColor = false;
            // 
            // txtBillInvoiceNum
            // 
            txtBillInvoiceNum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBillInvoiceNum.Location = new Point(215, 28);
            txtBillInvoiceNum.Name = "txtBillInvoiceNum";
            txtBillInvoiceNum.Size = new Size(280, 34);
            txtBillInvoiceNum.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(25, 25);
            label3.Name = "label3";
            label3.Size = new Size(172, 30);
            label3.TabIndex = 72;
            label3.Text = "Invoice Number";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.Yellow;
            UpdateBtn.Location = new Point(597, 223);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(122, 41);
            UpdateBtn.TabIndex = 70;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Red;
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(741, 223);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(122, 41);
            DeleteBtn.TabIndex = 71;
            DeleteBtn.Text = "Delete Item";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // PrintBtn
            // 
            PrintBtn.BackColor = Color.FromArgb(128, 128, 255);
            PrintBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrintBtn.ForeColor = Color.White;
            PrintBtn.Location = new Point(741, 36);
            PrintBtn.Name = "PrintBtn";
            PrintBtn.Size = new Size(122, 41);
            PrintBtn.TabIndex = 69;
            PrintBtn.Text = "Print Bill";
            PrintBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(22, 85);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 68;
            label1.Text = "Payment Methods";
            // 
            // cboCustomers
            // 
            cboCustomers.FormattingEnabled = true;
            cboCustomers.Location = new Point(174, 236);
            cboCustomers.Name = "cboCustomers";
            cboCustomers.Size = new Size(216, 28);
            cboCustomers.TabIndex = 67;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(22, 236);
            label10.Name = "label10";
            label10.Size = new Size(97, 28);
            label10.TabIndex = 64;
            label10.Text = "Client Bill";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(174, 208);
            label11.Name = "label11";
            label11.Size = new Size(116, 20);
            label11.TabIndex = 66;
            label11.Text = "Customer Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgItemList);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(273, 518);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(726, 505);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            // 
            // dgItemList
            // 
            dgItemList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgItemList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgItemList.Location = new Point(18, 51);
            dgItemList.Name = "dgItemList";
            dgItemList.RowHeadersWidth = 51;
            dgItemList.Size = new Size(688, 432);
            dgItemList.TabIndex = 32;
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
            Load += Billing_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private MaskedTextBox txtQuantity;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboCustomers;
        private Label label10;
        private Label label11;
        private GroupBox groupBox3;
        private DataGridView dgItemList;
        private Label label9;
        private Button PrintBtn;
        private Label label2;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private MaskedTextBox txtBillInvoiceNum;
        private Label label3;
        private Button InvoiceNoBtn;
        private Button SaveBtn;
        private Label label5;
        private MaskedTextBox txtTotalCost;
        private Label label4;
        private MaskedTextBox txtPrice;
        private Label label6;
        private MaskedTextBox txtInvoiceNum;
        private ListView listView1;
    }
}