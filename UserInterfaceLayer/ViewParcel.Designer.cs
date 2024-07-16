namespace parcelCompany.UserInterfaceLayer
{
    partial class ViewParcel
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
            this.trackIdTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.parcelDataGridView = new System.Windows.Forms.DataGridView();
            this.clearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parcelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // trackIdTextBox
            // 
            this.trackIdTextBox.Location = new System.Drawing.Point(331, 108);
            this.trackIdTextBox.Name = "trackIdTextBox";
            this.trackIdTextBox.Size = new System.Drawing.Size(455, 26);
            this.trackIdTextBox.TabIndex = 45;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(97, 203);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(223, 66);
            this.searchButton.TabIndex = 44;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // parcelDataGridView
            // 
            this.parcelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parcelDataGridView.Location = new System.Drawing.Point(60, 325);
            this.parcelDataGridView.Name = "parcelDataGridView";
            this.parcelDataGridView.RowHeadersWidth = 62;
            this.parcelDataGridView.RowTemplate.Height = 28;
            this.parcelDataGridView.Size = new System.Drawing.Size(868, 144);
            this.parcelDataGridView.TabIndex = 43;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(383, 203);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(223, 66);
            this.clearButton.TabIndex = 42;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Parcel Tracking ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 57);
            this.label1.TabIndex = 40;
            this.label1.Text = "Search parcel";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Info;
            this.backButton.Font = new System.Drawing.Font("Microsoft Uighur", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(667, 205);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(223, 66);
            this.backButton.TabIndex = 46;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(383, 499);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(223, 66);
            this.updateButton.TabIndex = 47;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // ViewParcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 628);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.trackIdTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.parcelDataGridView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "ViewParcel";
            this.Text = "ViewParcel";
            this.Load += new System.EventHandler(this.ViewParcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox trackIdTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView parcelDataGridView;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
    }
}