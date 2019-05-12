namespace Members
{
    partial class SignInAndForgotPW
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SignIN_B = new System.Windows.Forms.Button();
            this.SignUP_B = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Password = new MyControl.InputControl();
            this.Account = new MyControl.InputControl();
            this.button3 = new System.Windows.Forms.Button();
            this.inputControl1 = new MyControl.InputControl();
            this.inputControl2 = new MyControl.InputControl();
            this.label1 = new System.Windows.Forms.Label();
            this.GetNewPW = new System.Windows.Forms.Button();
            this.GoLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignIN_B
            // 
            this.SignIN_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.SignIN_B.FlatAppearance.BorderSize = 0;
            this.SignIN_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIN_B.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SignIN_B.ForeColor = System.Drawing.Color.White;
            this.SignIN_B.Location = new System.Drawing.Point(87, 364);
            this.SignIN_B.Name = "SignIN_B";
            this.SignIN_B.Size = new System.Drawing.Size(328, 23);
            this.SignIN_B.TabIndex = 20;
            this.SignIN_B.Text = "登入";
            this.SignIN_B.UseVisualStyleBackColor = false;
            this.SignIN_B.Click += new System.EventHandler(this.SignIN_B_Click);
            // 
            // SignUP_B
            // 
            this.SignUP_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.SignUP_B.FlatAppearance.BorderSize = 0;
            this.SignUP_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUP_B.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SignUP_B.ForeColor = System.Drawing.Color.White;
            this.SignUP_B.Location = new System.Drawing.Point(87, 393);
            this.SignUP_B.Name = "SignUP_B";
            this.SignUP_B.Size = new System.Drawing.Size(328, 23);
            this.SignUP_B.TabIndex = 20;
            this.SignUP_B.Text = "加入我們";
            this.SignUP_B.UseVisualStyleBackColor = false;
            this.SignUP_B.Click += new System.EventHandler(this.SignUP_B_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(158, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 43);
            this.label3.TabIndex = 22;
            this.label3.Text = "歡迎回來";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Members.img.barcode_boutique_brand_1243362;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(500, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 498);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(495, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 498);
            this.panel4.TabIndex = 26;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Location = new System.Drawing.Point(87, 278);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(328, 43);
            this.Password.TabIndex = 24;
            this.Password.Text = "密碼";
            // 
            // Account
            // 
            this.Account.BackColor = System.Drawing.Color.Transparent;
            this.Account.Location = new System.Drawing.Point(87, 229);
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(328, 43);
            this.Account.TabIndex = 23;
            this.Account.Text = "帳號";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(87, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(328, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "忘記密碼?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inputControl1
            // 
            this.inputControl1.BackColor = System.Drawing.Color.Transparent;
            this.inputControl1.Location = new System.Drawing.Point(589, 319);
            this.inputControl1.Name = "inputControl1";
            this.inputControl1.Size = new System.Drawing.Size(328, 43);
            this.inputControl1.TabIndex = 32;
            this.inputControl1.Text = "Email";
            // 
            // inputControl2
            // 
            this.inputControl2.BackColor = System.Drawing.Color.Transparent;
            this.inputControl2.Location = new System.Drawing.Point(589, 270);
            this.inputControl2.Name = "inputControl2";
            this.inputControl2.Size = new System.Drawing.Size(328, 43);
            this.inputControl2.TabIndex = 31;
            this.inputControl2.Text = "帳號";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(660, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 43);
            this.label1.TabIndex = 30;
            this.label1.Text = "忘記密碼";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetNewPW
            // 
            this.GetNewPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.GetNewPW.FlatAppearance.BorderSize = 0;
            this.GetNewPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetNewPW.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GetNewPW.ForeColor = System.Drawing.Color.White;
            this.GetNewPW.Location = new System.Drawing.Point(589, 405);
            this.GetNewPW.Name = "GetNewPW";
            this.GetNewPW.Size = new System.Drawing.Size(328, 23);
            this.GetNewPW.TabIndex = 29;
            this.GetNewPW.Text = "取得新密碼";
            this.GetNewPW.UseVisualStyleBackColor = false;
            // 
            // GoLogIn
            // 
            this.GoLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.GoLogIn.FlatAppearance.BorderSize = 0;
            this.GoLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoLogIn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GoLogIn.ForeColor = System.Drawing.Color.White;
            this.GoLogIn.Location = new System.Drawing.Point(589, 434);
            this.GoLogIn.Name = "GoLogIn";
            this.GoLogIn.Size = new System.Drawing.Size(328, 23);
            this.GoLogIn.TabIndex = 28;
            this.GoLogIn.Text = "嘗試登入";
            this.GoLogIn.UseVisualStyleBackColor = false;
            this.GoLogIn.Click += new System.EventHandler(this.GoLogIn_Click);
            // 
            // SignInAndForgotPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 603);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SignUP_B);
            this.Controls.Add(this.SignIN_B);
            this.Controls.Add(this.inputControl1);
            this.Controls.Add(this.inputControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoLogIn);
            this.Controls.Add(this.GetNewPW);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SignInAndForgotPW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.GetNewPW, 0);
            this.Controls.SetChildIndex(this.GoLogIn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.inputControl2, 0);
            this.Controls.SetChildIndex(this.inputControl1, 0);
            this.Controls.SetChildIndex(this.SignIN_B, 0);
            this.Controls.SetChildIndex(this.SignUP_B, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Account, 0);
            this.Controls.SetChildIndex(this.Password, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SignIN_B;
        private System.Windows.Forms.Button SignUP_B;
        private System.Windows.Forms.Label label3;
        private MyControl.InputControl Account;
        private MyControl.InputControl Password;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private MyControl.InputControl inputControl1;
        private MyControl.InputControl inputControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetNewPW;
        private System.Windows.Forms.Button GoLogIn;
    }
}

