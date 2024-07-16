namespace parcelCompany.UserInterfaceLayer
{
    partial class DeleteCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIdTextBox = new System.Windows.Forms.TextBox();
            this.deletebttn = new System.Windows.Forms.Button();
            this.clearbttn = new System.Windows.Forms.Button();
            this.backbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete existing customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // customerIdTextBox
            // 
            this.customerIdTextBox.Location = new System.Drawing.Point(395, 103);
            this.customerIdTextBox.Name = "customerIdTextBox";
            this.customerIdTextBox.Size = new System.Drawing.Size(341, 26);
            this.customerIdTextBox.TabIndex = 6;
            // 
            // deletebttn
            // 
            this.deletebttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deletebttn.Location = new System.Drawing.Point(844, 87);
            this.deletebttn.Name = "deletebttn";
            this.deletebttn.Size = new System.Drawing.Size(98, 50);
            this.deletebttn.TabIndex = 11;
            this.deletebttn.Text = "DELETE";
            this.deletebttn.UseVisualStyleBackColor = false;
            this.deletebttn.Click += new System.EventHandler(this.deletebttn_Click);
            // 
            // clearbttn
            // 
            this.clearbttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearbttn.Location = new System.Drawing.Point(844, 169);
            this.clearbttn.Name = "clearbttn";
            this.clearbttn.Size = new System.Drawing.Size(98, 50);
            this.clearbttn.TabIndex = 12;
            this.clearbttn.Text = "CLEAR";
            this.clearbttn.UseVisualStyleBackColor = false;
            this.clearbttn.Click += new System.EventHandler(this.clearbttn_Click);
            // 
            // backbttn
            // 
            this.backbttn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backbttn.Location = new System.Drawing.Point(844, 259);
            this.backbttn.Name = "backbttn";
            this.backbttn.Size = new System.Drawing.Size(98, 49);
            this.backbttn.TabIndex = 14;
            this.backbttn.Text = "BACK";
            this.backbttn.UseVisualStyleBackColor = false;
            this.backbttn.Click += new System.EventHandler(this.backbttn_Click);
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1194, 694);
            this.Controls.Add(this.backbttn);
            this.Controls.Add(this.clearbttn);
            this.Controls.Add(this.deletebttn);
            this.Controls.Add(this.customerIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIdTextBox;
        private System.Windows.Forms.Button deletebttn;
        private System.Windows.Forms.Button clearbttn;
        private System.Windows.Forms.Button backbttn;
    }
}