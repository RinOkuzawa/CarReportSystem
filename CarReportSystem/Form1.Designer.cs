﻿namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.btOpenArticle = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btSaveArticle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btAddArticle = new System.Windows.Forms.Button();
            this.btUpdateArticle = new System.Windows.Forms.Button();
            this.btDeleteArticle = new System.Windows.Forms.Button();
            this.btAppEnd = new System.Windows.Forms.Button();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbGaikoku = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(94, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(94, 69);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(212, 20);
            this.cbName.TabIndex = 2;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(94, 168);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(290, 100);
            this.tbReport.TabIndex = 4;
            // 
            // btOpenArticle
            // 
            this.btOpenArticle.Location = new System.Drawing.Point(33, 312);
            this.btOpenArticle.Name = "btOpenArticle";
            this.btOpenArticle.Size = new System.Drawing.Size(75, 23);
            this.btOpenArticle.TabIndex = 5;
            this.btOpenArticle.Text = "開く";
            this.btOpenArticle.UseVisualStyleBackColor = true;
            this.btOpenArticle.Click += new System.EventHandler(this.btOpenArticle_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(123, 291);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowTemplate.Height = 21;
            this.dgvReport.Size = new System.Drawing.Size(619, 186);
            this.dgvReport.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(462, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 153);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "記録者:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "レポート:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "メーカー:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "車名:";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(94, 131);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(212, 20);
            this.cbCarName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "記事一覧:";
            // 
            // btSaveArticle
            // 
            this.btSaveArticle.Location = new System.Drawing.Point(33, 341);
            this.btSaveArticle.Name = "btSaveArticle";
            this.btSaveArticle.Size = new System.Drawing.Size(75, 23);
            this.btSaveArticle.TabIndex = 5;
            this.btSaveArticle.Text = "保存";
            this.btSaveArticle.UseVisualStyleBackColor = true;
            this.btSaveArticle.Click += new System.EventHandler(this.btSaveArticle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "画像:";
            // 
            // btAddArticle
            // 
            this.btAddArticle.Location = new System.Drawing.Point(437, 262);
            this.btAddArticle.Name = "btAddArticle";
            this.btAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btAddArticle.TabIndex = 5;
            this.btAddArticle.Text = "追加";
            this.btAddArticle.UseVisualStyleBackColor = true;
            this.btAddArticle.Click += new System.EventHandler(this.btAddArticle_Click);
            // 
            // btUpdateArticle
            // 
            this.btUpdateArticle.Location = new System.Drawing.Point(534, 262);
            this.btUpdateArticle.Name = "btUpdateArticle";
            this.btUpdateArticle.Size = new System.Drawing.Size(75, 23);
            this.btUpdateArticle.TabIndex = 5;
            this.btUpdateArticle.Text = "修正";
            this.btUpdateArticle.UseVisualStyleBackColor = true;
            this.btUpdateArticle.Click += new System.EventHandler(this.btUpdateArticle_Click);
            // 
            // btDeleteArticle
            // 
            this.btDeleteArticle.Location = new System.Drawing.Point(634, 262);
            this.btDeleteArticle.Name = "btDeleteArticle";
            this.btDeleteArticle.Size = new System.Drawing.Size(75, 23);
            this.btDeleteArticle.TabIndex = 5;
            this.btDeleteArticle.Text = "削除";
            this.btDeleteArticle.UseVisualStyleBackColor = true;
            this.btDeleteArticle.Click += new System.EventHandler(this.btDeleteArticle_Click);
            // 
            // btAppEnd
            // 
            this.btAppEnd.Location = new System.Drawing.Point(667, 483);
            this.btAppEnd.Name = "btAppEnd";
            this.btAppEnd.Size = new System.Drawing.Size(75, 23);
            this.btAppEnd.TabIndex = 5;
            this.btAppEnd.Text = "終了";
            this.btAppEnd.UseVisualStyleBackColor = true;
            this.btAppEnd.Click += new System.EventHandler(this.btAppEnd_Click);
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(498, 31);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btOpenImage.TabIndex = 5;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Location = new System.Drawing.Point(594, 31);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(75, 23);
            this.btDeleteImage.TabIndex = 5;
            this.btDeleteImage.Text = "削除";
            this.btDeleteImage.UseVisualStyleBackColor = true;
            this.btDeleteImage.Click += new System.EventHandler(this.btDeleteImage_Click);
            // 
            // ofdOpenImage
            // 
            this.ofdOpenImage.FileName = "openFileDialog1";
            this.ofdOpenImage.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenImage_FileOk);
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 9);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 9;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbGaikoku);
            this.groupBox1.Controls.Add(this.rbSubaru);
            this.groupBox1.Controls.Add(this.rbHonda);
            this.groupBox1.Controls.Add(this.rbNissan);
            this.groupBox1.Controls.Add(this.rbToyota);
            this.groupBox1.Location = new System.Drawing.Point(94, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 30);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(281, 8);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 12;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbGaikoku
            // 
            this.rbGaikoku.AutoSize = true;
            this.rbGaikoku.Location = new System.Drawing.Point(227, 9);
            this.rbGaikoku.Name = "rbGaikoku";
            this.rbGaikoku.Size = new System.Drawing.Size(47, 16);
            this.rbGaikoku.TabIndex = 11;
            this.rbGaikoku.TabStop = true;
            this.rbGaikoku.Text = "外車";
            this.rbGaikoku.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(169, 9);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 10;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(112, 9);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 9;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(59, 9);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 9;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // ofdOpenData
            // 
            this.ofdOpenData.FileName = "openFileDialog1";
            this.ofdOpenData.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdOpenData_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 518);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btSaveArticle);
            this.Controls.Add(this.btAppEnd);
            this.Controls.Add(this.btDeleteArticle);
            this.Controls.Add(this.btDeleteImage);
            this.Controls.Add(this.btUpdateArticle);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.btAddArticle);
            this.Controls.Add(this.btOpenArticle);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button btOpenArticle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btSaveArticle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAddArticle;
        private System.Windows.Forms.Button btUpdateArticle;
        private System.Windows.Forms.Button btDeleteArticle;
        private System.Windows.Forms.Button btAppEnd;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbGaikoku;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
