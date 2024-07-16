namespace parcelCompany
{
    partial class loginPageStaff
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
            this.log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(448, 59);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(144, 62);
            this.log.TabIndex = 0;
            this.log.Text = "LOGIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(415, 198);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(322, 26);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(415, 327);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(322, 26);
            this.password.TabIndex = 4;
            // 
            // loginbttn
            // 
            this.loginbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginbttn.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbttn.Location = new System.Drawing.Point(459, 472);
            this.loginbttn.Name = "loginbttn";
            this.loginbttn.Size = new System.Drawing.Size(111, 61);
            this.loginbttn.TabIndex = 5;
            this.loginbttn.Text = "Login";
            this.loginbttn.UseVisualStyleBackColor = false;
            this.loginbttn.Click += new System.EventHandler(this.loginbttn_Click);
            // 
            // loginPageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1017, 623);
            this.Controls.Add(this.loginbttn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log);
            this.Name = "loginPageStaff";
            this.Text = "loginPageStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginbttn;
    }
}