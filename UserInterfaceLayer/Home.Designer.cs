namespace parcelCompany
{
    partial class Home
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
            this.staffbttn = new System.Windows.Forms.Button();
            this.customerbttn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO UML LOGISTICS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your one stop delivery partner";
            // 
            // staffbttn
            // 
            this.staffbttn.BackColor = System.Drawing.Color.White;
            this.staffbttn.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffbttn.ForeColor = System.Drawing.Color.Red;
            this.staffbttn.Location = new System.Drawing.Point(80, 257);
            this.staffbttn.Name = "staffbttn";
            this.staffbttn.Size = new System.Drawing.Size(289, 78);
            this.staffbttn.TabIndex = 4;
            this.staffbttn.Text = "Staff";
            this.staffbttn.UseVisualStyleBackColor = false;
            this.staffbttn.Click += new System.EventHandler(this.staffbttn_Click);
            // 
            // customerbttn
            // 
            this.customerbttn.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerbttn.ForeColor = System.Drawing.Color.Red;
            this.customerbttn.Location = new System.Drawing.Point(80, 417);
            this.customerbttn.Name = "customerbttn";
            this.customerbttn.Size = new System.Drawing.Size(289, 76);
            this.customerbttn.TabIndex = 5;
            this.customerbttn.Text = "Customer";
            this.customerbttn.UseVisualStyleBackColor = true;
            this.customerbttn.Click += new System.EventHandler(this.customerbttn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::parcelCompany.Properties.Resources.pngtree_courier_with_a_lot_of_parcels_isolated_on_white_background_illustration_png_image_13122701;
            this.pictureBox2.Location = new System.Drawing.Point(741, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(483, 401);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::parcelCompany.Properties.Resources.UML__1_;
            this.pictureBox1.Location = new System.Drawing.Point(154, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 674);
            this.Controls.Add(this.customerbttn);
            this.Controls.Add(this.staffbttn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button staffbttn;
        private System.Windows.Forms.Button customerbttn;
    }
}

