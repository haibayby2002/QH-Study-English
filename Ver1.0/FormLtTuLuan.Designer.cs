namespace Ver1._0
{
    partial class FormLtTuLuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLtTuLuan));
            this.txtCauTraLoi = new System.Windows.Forms.TextBox();
            this.ptbHocBai = new System.Windows.Forms.PictureBox();
            this.lblCauTraLoi = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblThuTuCau = new System.Windows.Forms.Label();
            this.lblSoCauDung = new System.Windows.Forms.Label();
            this.btnChiuThua = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHocBai)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCauTraLoi
            // 
            this.txtCauTraLoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauTraLoi.Location = new System.Drawing.Point(95, 287);
            this.txtCauTraLoi.Name = "txtCauTraLoi";
            this.txtCauTraLoi.Size = new System.Drawing.Size(286, 26);
            this.txtCauTraLoi.TabIndex = 1;
            this.txtCauTraLoi.TextChanged += new System.EventHandler(this.txtCauTraLoi_TextChanged);
            this.txtCauTraLoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCauTraLoi_KeyDown);
            // 
            // ptbHocBai
            // 
            this.ptbHocBai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbHocBai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbHocBai.BackgroundImage")));
            this.ptbHocBai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbHocBai.Location = new System.Drawing.Point(409, 122);
            this.ptbHocBai.Name = "ptbHocBai";
            this.ptbHocBai.Size = new System.Drawing.Size(145, 128);
            this.ptbHocBai.TabIndex = 2;
            this.ptbHocBai.TabStop = false;
            // 
            // lblCauTraLoi
            // 
            this.lblCauTraLoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCauTraLoi.AutoSize = true;
            this.lblCauTraLoi.Location = new System.Drawing.Point(10, 290);
            this.lblCauTraLoi.Name = "lblCauTraLoi";
            this.lblCauTraLoi.Size = new System.Drawing.Size(79, 19);
            this.lblCauTraLoi.TabIndex = 3;
            this.lblCauTraLoi.Text = "Câu trả lời: ";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauHoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCauHoi.Location = new System.Drawing.Point(95, 122);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCauHoi.Size = new System.Drawing.Size(286, 128);
            this.txtCauHoi.TabIndex = 4;
            this.txtCauHoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCauHoi_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(529, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 6;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblThuTuCau
            // 
            this.lblThuTuCau.AutoSize = true;
            this.lblThuTuCau.Location = new System.Drawing.Point(17, 74);
            this.lblThuTuCau.Name = "lblThuTuCau";
            this.lblThuTuCau.Size = new System.Drawing.Size(41, 19);
            this.lblThuTuCau.TabIndex = 7;
            this.lblThuTuCau.Text = "Câu: ";
            // 
            // lblSoCauDung
            // 
            this.lblSoCauDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoCauDung.AutoSize = true;
            this.lblSoCauDung.Location = new System.Drawing.Point(408, 74);
            this.lblSoCauDung.Name = "lblSoCauDung";
            this.lblSoCauDung.Size = new System.Drawing.Size(48, 19);
            this.lblSoCauDung.TabIndex = 8;
            this.lblSoCauDung.Text = "Đúng: ";
            // 
            // btnChiuThua
            // 
            this.btnChiuThua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChiuThua.Location = new System.Drawing.Point(409, 282);
            this.btnChiuThua.Name = "btnChiuThua";
            this.btnChiuThua.Size = new System.Drawing.Size(145, 34);
            this.btnChiuThua.TabIndex = 9;
            this.btnChiuThua.Text = "Chịu thua";
            this.btnChiuThua.UseVisualStyleBackColor = true;
            this.btnChiuThua.Click += new System.EventHandler(this.btnChiuThua_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(412, 334);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 45);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormLtTuLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 391);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnChiuThua);
            this.Controls.Add(this.lblSoCauDung);
            this.Controls.Add(this.lblThuTuCau);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCauHoi);
            this.Controls.Add(this.lblCauTraLoi);
            this.Controls.Add(this.ptbHocBai);
            this.Controls.Add(this.txtCauTraLoi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLtTuLuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luyện tập tự luận";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLtTuLuan_FormClosing);
            this.Load += new System.EventHandler(this.FormLtTuLuan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLtTuLuan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHocBai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCauTraLoi;
        private System.Windows.Forms.PictureBox ptbHocBai;
        private System.Windows.Forms.Label lblCauTraLoi;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblThuTuCau;
        private System.Windows.Forms.Label lblSoCauDung;
        private System.Windows.Forms.Button btnChiuThua;
        private System.Windows.Forms.Button btnSubmit;
    }
}