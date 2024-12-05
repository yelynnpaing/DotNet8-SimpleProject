namespace PGDCAProject.InventoryManagementSystem
{
    partial class FrmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            BtnLogin = new Button();
            Reset = new Label();
            cbShowPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 562);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(141, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(353, 273);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(560, 67);
            label1.Name = "label1";
            label1.Size = new Size(530, 25);
            label1.TabIndex = 1;
            label1.Text = "Wholesale Electronics Inventory Management System";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(776, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F);
            label2.Location = new Point(571, 235);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "User Name";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(571, 263);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(441, 30);
            txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(571, 335);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(441, 30);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F);
            label3.Location = new Point(571, 307);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(192, 192, 255);
            BtnLogin.Location = new Point(714, 410);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(159, 46);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // Reset
            // 
            Reset.AutoSize = true;
            Reset.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold | FontStyle.Underline);
            Reset.ForeColor = Color.Red;
            Reset.Location = new Point(756, 484);
            Reset.Name = "Reset";
            Reset.Size = new Size(58, 20);
            Reset.TabIndex = 8;
            Reset.Text = "Reset";
            Reset.Click += Reset_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPassword.Location = new Point(571, 371);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(151, 24);
            cbShowPassword.TabIndex = 9;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 588);
            Controls.Add(cbShowPassword);
            Controls.Add(Reset);
            Controls.Add(BtnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += FrmLogin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label3;
        private Button BtnLogin;
        private Label Reset;
        private PictureBox pictureBox2;
        private CheckBox cbShowPassword;
    }
}
