namespace Ver1._0
{
    partial class FormLtTracNghiem
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
            this.components = new System.ComponentModel.Container();
            this.lblSoCauDung = new System.Windows.Forms.Label();
            this.lblThuTuCau = new System.Windows.Forms.Label();
            this.btnCauD = new System.Windows.Forms.Button();
            this.btnCauC = new System.Windows.Forms.Button();
            this.btnCauB = new System.Windows.Forms.Button();
            this.btnCauA = new System.Windows.Forms.Button();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.ptbRight = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ptbWrong = new System.Windows.Forms.PictureBox();
            this.timerChuyenCanh = new System.Windows.Forms.Timer(this.components);
            this.pnlCauTraLoi = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWrong)).BeginInit();
            this.pnlCauTraLoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoCauDung
            // 
            this.lblSoCauDung.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoCauDung.AutoSize = true;
            this.lblSoCauDung.Location = new System.Drawing.Point(685, 101);
            this.lblSoCauDung.Name = "lblSoCauDung";
            this.lblSoCauDung.Size = new System.Drawing.Size(91, 19);
            this.lblSoCauDung.TabIndex = 17;
            this.lblSoCauDung.Text = "Số câu đúng: ";
            // 
            // lblThuTuCau
            // 
            this.lblThuTuCau.AutoSize = true;
            this.lblThuTuCau.Location = new System.Drawing.Point(12, 101);
            this.lblThuTuCau.Name = "lblThuTuCau";
            this.lblThuTuCau.Size = new System.Drawing.Size(87, 19);
            this.lblThuTuCau.TabIndex = 16;
            this.lblThuTuCau.Text = "Câu hỏi thứ: ";
            // 
            // btnCauD
            // 
            this.btnCauD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCauD.BackColor = System.Drawing.Color.Black;
            this.btnCauD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCauD.Location = new System.Drawing.Point(405, 88);
            this.btnCauD.Name = "btnCauD";
            this.btnCauD.Size = new System.Drawing.Size(293, 61);
            this.btnCauD.TabIndex = 13;
            this.btnCauD.Text = "button4";
            this.btnCauD.UseVisualStyleBackColor = false;
            this.btnCauD.Click += new System.EventHandler(this.btnCauD_Click);
            // 
            // btnCauC
            // 
            this.btnCauC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCauC.BackColor = System.Drawing.Color.Black;
            this.btnCauC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCauC.Location = new System.Drawing.Point(3, 88);
            this.btnCauC.Name = "btnCauC";
            this.btnCauC.Size = new System.Drawing.Size(293, 61);
            this.btnCauC.TabIndex = 12;
            this.btnCauC.Text = "button3";
            this.btnCauC.UseVisualStyleBackColor = false;
            this.btnCauC.Click += new System.EventHandler(this.btnCauC_Click);
            // 
            // btnCauB
            // 
            this.btnCauB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCauB.BackColor = System.Drawing.Color.Black;
            this.btnCauB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCauB.Location = new System.Drawing.Point(405, 3);
            this.btnCauB.Name = "btnCauB";
            this.btnCauB.Size = new System.Drawing.Size(293, 61);
            this.btnCauB.TabIndex = 11;
            this.btnCauB.Text = "button2";
            this.btnCauB.UseVisualStyleBackColor = false;
            this.btnCauB.Click += new System.EventHandler(this.btnCauB_Click);
            // 
            // btnCauA
            // 
            this.btnCauA.BackColor = System.Drawing.Color.Black;
            this.btnCauA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCauA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCauA.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCauA.Location = new System.Drawing.Point(3, 3);
            this.btnCauA.Name = "btnCauA";
            this.btnCauA.Size = new System.Drawing.Size(293, 61);
            this.btnCauA.TabIndex = 10;
            this.btnCauA.Text = "button1";
            this.btnCauA.UseVisualStyleBackColor = false;
            this.btnCauA.Click += new System.EventHandler(this.btnCauA_Click);
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCauHoi.BackColor = System.Drawing.Color.MediumPurple;
            this.txtCauHoi.Enabled = false;
            this.txtCauHoi.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCauHoi.Location = new System.Drawing.Point(81, 161);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.ReadOnly = true;
            this.txtCauHoi.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCauHoi.Size = new System.Drawing.Size(695, 154);
            this.txtCauHoi.TabIndex = 9;
            this.txtCauHoi.Text = "Câu hỏi";
            // 
            // ptbRight
            // 
            this.ptbRight.BackgroundImage = global::Ver1._0.Properties.Resources.right;
            this.ptbRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbRight.Location = new System.Drawing.Point(538, 29);
            this.ptbRight.Name = "ptbRight";
            this.ptbRight.Size = new System.Drawing.Size(117, 91);
            this.ptbRight.TabIndex = 18;
            this.ptbRight.TabStop = false;
            this.ptbRight.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = global::Ver1._0.Properties.Resources.next_button;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(780, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 60);
            this.btnNext.TabIndex = 15;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::Ver1._0.Properties.Resources.back_button;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(12, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 60);
            this.btnBack.TabIndex = 14;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ptbWrong
            // 
            this.ptbWrong.BackgroundImage = global::Ver1._0.Properties.Resources.wrong;
            this.ptbWrong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbWrong.Location = new System.Drawing.Point(538, 29);
            this.ptbWrong.Name = "ptbWrong";
            this.ptbWrong.Size = new System.Drawing.Size(117, 91);
            this.ptbWrong.TabIndex = 19;
            this.ptbWrong.TabStop = false;
            this.ptbWrong.Visible = false;
            // 
            // timerChuyenCanh
            // 
            this.timerChuyenCanh.Tick += new System.EventHandler(this.timerChuyenCanh_Tick);
            // 
            // pnlCauTraLoi
            // 
            this.pnlCauTraLoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCauTraLoi.Controls.Add(this.btnCauA);
            this.pnlCauTraLoi.Controls.Add(this.btnCauB);
            this.pnlCauTraLoi.Controls.Add(this.btnCauC);
            this.pnlCauTraLoi.Controls.Add(this.btnCauD);
            this.pnlCauTraLoi.Location = new System.Drawing.Point(81, 321);
            this.pnlCauTraLoi.Name = "pnlCauTraLoi";
            this.pnlCauTraLoi.Size = new System.Drawing.Size(695, 165);
            this.pnlCauTraLoi.TabIndex = 20;
            // 
            // FormLtTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(852, 498);
            this.Controls.Add(this.pnlCauTraLoi);
            this.Controls.Add(this.ptbWrong);
            this.Controls.Add(this.ptbRight);
            this.Controls.Add(this.lblSoCauDung);
            this.Controls.Add(this.lblThuTuCau);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCauHoi);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLtTracNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luyện tập trắc nghiệm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLtTracNghiem_FormClosing);
            this.Load += new System.EventHandler(this.FormLtTracNghiem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormLtTracNghiem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbWrong)).EndInit();
            this.pnlCauTraLoi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoCauDung;
        private System.Windows.Forms.Label lblThuTuCau;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCauD;
        private System.Windows.Forms.Button btnCauC;
        private System.Windows.Forms.Button btnCauB;
        private System.Windows.Forms.Button btnCauA;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.PictureBox ptbRight;
        private System.Windows.Forms.PictureBox ptbWrong;
        private System.Windows.Forms.Timer timerChuyenCanh;
        private System.Windows.Forms.Panel pnlCauTraLoi;
    }
}