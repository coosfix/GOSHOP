namespace Members
{
    partial class SignUp
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Password = new MyControl.InputControl();
            this.Account = new MyControl.InputControl();
            this.label3 = new System.Windows.Forms.Label();
            this.SignUP_B = new System.Windows.Forms.Button();
            this.SignIN_B = new System.Windows.Forms.Button();
            this.Email = new MyControl.InputControl();
            this.Phone = new MyControl.InputControl();
            this.City = new System.Windows.Forms.ComboBox();
            this.RegionId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Addres = new MyControl.InputControl();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(488, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 498);
            this.panel4.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Members.img.artwork_cat_close_up_1406282__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(493, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 498);
            this.panel3.TabIndex = 32;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(87, 224);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(328, 43);
            this.Password.TabIndex = 31;
            this.Password.Text = "密碼";
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.Location = new System.Drawing.Point(87, 175);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(328, 43);
            this.Account.TabIndex = 30;
            this.Account.Text = "帳號";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(159, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 43);
            this.label3.TabIndex = 29;
            this.label3.Text = "歡迎您的加入";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUP_B
            // 
            this.SignUP_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.SignUP_B.FlatAppearance.BorderSize = 0;
            this.SignUP_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUP_B.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SignUP_B.ForeColor = System.Drawing.Color.White;
            this.SignUP_B.Location = new System.Drawing.Point(87, 457);
            this.SignUP_B.Name = "SignUP_B";
            this.SignUP_B.Size = new System.Drawing.Size(328, 23);
            this.SignUP_B.TabIndex = 27;
            this.SignUP_B.Text = "註冊";
            this.SignUP_B.UseVisualStyleBackColor = false;
            // 
            // SignIN_B
            // 
            this.SignIN_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.SignIN_B.FlatAppearance.BorderSize = 0;
            this.SignIN_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIN_B.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SignIN_B.ForeColor = System.Drawing.Color.White;
            this.SignIN_B.Location = new System.Drawing.Point(87, 486);
            this.SignIN_B.Name = "SignIN_B";
            this.SignIN_B.Size = new System.Drawing.Size(328, 23);
            this.SignIN_B.TabIndex = 28;
            this.SignIN_B.Text = "以建立帳號?";
            this.SignIN_B.UseVisualStyleBackColor = false;
            this.SignIN_B.Click += new System.EventHandler(this.SignIN_B_Click);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.Location = new System.Drawing.Point(87, 279);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(328, 43);
            this.Email.TabIndex = 30;
            this.Email.Text = "Email";
            // 
            // Phone
            // 
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Location = new System.Drawing.Point(87, 328);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(186, 43);
            this.Phone.TabIndex = 31;
            this.Phone.Text = "手機";
            // 
            // City
            // 
            this.City.FormattingEnabled = true;
            this.City.Items.AddRange(new object[] {
            "台北市",
            "測試2"});
            this.City.Location = new System.Drawing.Point(152, 376);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(121, 20);
            this.City.TabIndex = 34;
            // 
            // RegionId
            // 
            this.RegionId.FormattingEnabled = true;
            this.RegionId.Items.AddRange(new object[] {
            "南港區"});
            this.RegionId.Location = new System.Drawing.Point(288, 376);
            this.RegionId.Name = "RegionId";
            this.RegionId.Size = new System.Drawing.Size(121, 20);
            this.RegionId.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(88, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "收件地址";
            // 
            // Addres
            // 
            this.Addres.BackColor = System.Drawing.Color.Transparent;
            this.Addres.Location = new System.Drawing.Point(87, 376);
            this.Addres.Name = "Addres";
            this.Addres.Size = new System.Drawing.Size(328, 55);
            this.Addres.TabIndex = 36;
            this.Addres.Text = "帳號";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "女",
            "男"});
            this.Gender.Location = new System.Drawing.Point(288, 346);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(121, 20);
            this.Gender.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(284, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "性別";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegionId);
            this.Controls.Add(this.City);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignUP_B);
            this.Controls.Add(this.SignIN_B);
            this.Controls.Add(this.Addres);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Controls.SetChildIndex(this.Addres, 0);
            this.Controls.SetChildIndex(this.SignIN_B, 0);
            this.Controls.SetChildIndex(this.SignUP_B, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Account, 0);
            this.Controls.SetChildIndex(this.Password, 0);
            this.Controls.SetChildIndex(this.Email, 0);
            this.Controls.SetChildIndex(this.Phone, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.City, 0);
            this.Controls.SetChildIndex(this.RegionId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Gender, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MyControl.InputControl Password;
        private MyControl.InputControl Account;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignUP_B;
        private System.Windows.Forms.Button SignIN_B;
        private MyControl.InputControl Email;
        private MyControl.InputControl Phone;
        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.ComboBox RegionId;
        private System.Windows.Forms.Label label1;
        private MyControl.InputControl Addres;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label2;
    }
}