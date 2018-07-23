namespace Ver1._0
{
    partial class FormHocTap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNghiaTuVung = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTenTuVung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnHien = new System.Windows.Forms.Button();
            this.lblThuTu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackgroundImage = global::Ver1._0.Properties.Resources.anhhocta1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(461, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNghiaTuVung
            // 
            this.txtNghiaTuVung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNghiaTuVung.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghiaTuVung.Location = new System.Drawing.Point(116, 196);
            this.txtNghiaTuVung.Multiline = true;
            this.txtNghiaTuVung.Name = "txtNghiaTuVung";
            this.txtNghiaTuVung.ReadOnly = true;
            this.txtNghiaTuVung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNghiaTuVung.Size = new System.Drawing.Size(327, 132);
            this.txtNghiaTuVung.TabIndex = 0;
            this.txtNghiaTuVung.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNghiaTuVung_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Ver1._0.Properties.Resources.back_button;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 57);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = global::Ver1._0.Properties.Resources.next_button;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(564, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 57);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNext_KeyDown);
            // 
            // lblTenTuVung
            // 
            this.lblTenTuVung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenTuVung.AutoSize = true;
            this.lblTenTuVung.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTuVung.Location = new System.Drawing.Point(116, 140);
            this.lblTenTuVung.Name = "lblTenTuVung";
            this.lblTenTuVung.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTenTuVung.Size = new System.Drawing.Size(113, 31);
            this.lblTenTuVung.TabIndex = 4;
            this.lblTenTuVung.Text = "Từ vựng";
            this.lblTenTuVung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 5;
            // 
            // btnAnHien
            // 
            this.btnAnHien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnHien.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAnHien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnHien.Location = new System.Drawing.Point(461, 288);
            this.btnAnHien.Name = "btnAnHien";
            this.btnAnHien.Size = new System.Drawing.Size(126, 40);
            this.btnAnHien.TabIndex = 6;
            this.btnAnHien.Text = "Hiện nghĩa";
            this.btnAnHien.UseVisualStyleBackColor = false;
            this.btnAnHien.Click += new System.EventHandler(this.btnAnHien_Click);
            this.btnAnHien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHocTap_KeyDown);
            // 
            // lblThuTu
            // 
            this.lblThuTu.AutoSize = true;
            this.lblThuTu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuTu.Location = new System.Drawing.Point(30, 84);
            this.lblThuTu.Name = "lblThuTu";
            this.lblThuTu.Size = new System.Drawing.Size(76, 22);
            this.lblThuTu.TabIndex = 7;
            this.lblThuTu.Text = "Thứ tự: ";
            // 
            // FormHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 405);
            this.Controls.Add(this.lblThuTu);
            this.Controls.Add(this.btnAnHien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenTuVung);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNghiaTuVung);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHocTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học từ vựng";
            this.Load += new System.EventHandler(this.FormHocTap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHocTap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNghiaTuVung;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblTenTuVung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnHien;
        private System.Windows.Forms.Label lblThuTu;
    }
}