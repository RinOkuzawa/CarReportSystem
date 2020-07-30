namespace CarReportSystem {
    partial class Form {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202011DataSet = new CarReportSystem.infosys202011DataSet();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btAddArticle = new System.Windows.Forms.Button();
            this.btUpdateArticle = new System.Windows.Forms.Button();
            this.btDeleteArticle = new System.Windows.Forms.Button();
            this.btOpenImage = new System.Windows.Forms.Button();
            this.btDeleteImage = new System.Windows.Forms.Button();
            this.ofdOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.MakerG = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbGaikoku = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.ofdOpenData = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssLabelTime = new System.Windows.Forms.StatusStrip();
            this.sttsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbSearchCarName = new System.Windows.Forms.TextBox();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAuthorSearch = new System.Windows.Forms.TextBox();
            this.checkDateSearch = new System.Windows.Forms.CheckBox();
            this.cbSearchMaker = new System.Windows.Forms.ComboBox();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.carReportTableAdapter = new CarReportSystem.infosys202011DataSetTableAdapters.CarReportTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202011DataSetTableAdapters.TableAdapterManager();
            this.rbAndSearch = new System.Windows.Forms.RadioButton();
            this.rbOrSearch = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202011DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.MakerG.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tssLabelTime.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "日付:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(94, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 0;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(94, 69);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(212, 20);
            this.cbName.TabIndex = 1;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(94, 168);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(290, 100);
            this.tbReport.TabIndex = 4;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dgvReport.DataSource = this.carReportBindingSource;
            this.dgvReport.Location = new System.Drawing.Point(92, 291);
            this.dgvReport.MultiSelect = false;
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowTemplate.Height = 21;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(711, 218);
            this.dgvReport.TabIndex = 4;
            this.dgvReport.TabStop = false;
            this.dgvReport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvReport_MouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // createdDateDataGridViewTextBoxColumn
            // 
            this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.HeaderText = "CreatedDate";
            this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "Picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.Width = 125;
            // 
            // carReportBindingSource
            // 
            this.carReportBindingSource.DataMember = "CarReport";
            this.carReportBindingSource.DataSource = this.infosys202011DataSet;
            // 
            // infosys202011DataSet
            // 
            this.infosys202011DataSet.DataSetName = "infosys202011DataSet";
            this.infosys202011DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(462, 81);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(236, 153);
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "記録者:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "レポート:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "メーカー:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "車名:";
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(94, 131);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(212, 20);
            this.cbCarName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "記事一覧:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "画像:";
            // 
            // btAddArticle
            // 
            this.btAddArticle.Location = new System.Drawing.Point(437, 262);
            this.btAddArticle.Name = "btAddArticle";
            this.btAddArticle.Size = new System.Drawing.Size(75, 23);
            this.btAddArticle.TabIndex = 11;
            this.btAddArticle.TabStop = false;
            this.btAddArticle.Text = "追加";
            this.btAddArticle.UseVisualStyleBackColor = true;
            this.btAddArticle.Click += new System.EventHandler(this.btAddArticle_Click);
            // 
            // btUpdateArticle
            // 
            this.btUpdateArticle.Location = new System.Drawing.Point(534, 262);
            this.btUpdateArticle.Name = "btUpdateArticle";
            this.btUpdateArticle.Size = new System.Drawing.Size(75, 23);
            this.btUpdateArticle.TabIndex = 9;
            this.btUpdateArticle.TabStop = false;
            this.btUpdateArticle.Text = "修正";
            this.btUpdateArticle.UseVisualStyleBackColor = true;
            this.btUpdateArticle.Click += new System.EventHandler(this.btUpdateArticle_Click);
            // 
            // btDeleteArticle
            // 
            this.btDeleteArticle.Location = new System.Drawing.Point(634, 262);
            this.btDeleteArticle.Name = "btDeleteArticle";
            this.btDeleteArticle.Size = new System.Drawing.Size(75, 23);
            this.btDeleteArticle.TabIndex = 7;
            this.btDeleteArticle.TabStop = false;
            this.btDeleteArticle.Text = "削除";
            this.btDeleteArticle.UseVisualStyleBackColor = true;
            this.btDeleteArticle.Click += new System.EventHandler(this.btDeleteArticle_Click);
            // 
            // btOpenImage
            // 
            this.btOpenImage.Location = new System.Drawing.Point(498, 31);
            this.btOpenImage.Name = "btOpenImage";
            this.btOpenImage.Size = new System.Drawing.Size(75, 23);
            this.btOpenImage.TabIndex = 10;
            this.btOpenImage.TabStop = false;
            this.btOpenImage.Text = "開く";
            this.btOpenImage.UseVisualStyleBackColor = true;
            this.btOpenImage.Click += new System.EventHandler(this.btOpenImage_Click);
            // 
            // btDeleteImage
            // 
            this.btDeleteImage.Enabled = false;
            this.btDeleteImage.Location = new System.Drawing.Point(594, 31);
            this.btDeleteImage.Name = "btDeleteImage";
            this.btDeleteImage.Size = new System.Drawing.Size(75, 23);
            this.btDeleteImage.TabIndex = 8;
            this.btDeleteImage.TabStop = false;
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
            this.rbToyota.TabIndex = 5;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // MakerG
            // 
            this.MakerG.Controls.Add(this.rbOther);
            this.MakerG.Controls.Add(this.rbGaikoku);
            this.MakerG.Controls.Add(this.rbSubaru);
            this.MakerG.Controls.Add(this.rbHonda);
            this.MakerG.Controls.Add(this.rbNissan);
            this.MakerG.Controls.Add(this.rbToyota);
            this.MakerG.Location = new System.Drawing.Point(94, 95);
            this.MakerG.Name = "MakerG";
            this.MakerG.Size = new System.Drawing.Size(342, 30);
            this.MakerG.TabIndex = 2;
            this.MakerG.TabStop = false;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(281, 8);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 0;
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
            this.rbGaikoku.TabIndex = 1;
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
            this.rbSubaru.TabIndex = 2;
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
            this.rbHonda.TabIndex = 3;
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
            this.rbNissan.TabIndex = 4;
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.接続ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.終了XToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 接続ToolStripMenuItem
            // 
            this.接続ToolStripMenuItem.Name = "接続ToolStripMenuItem";
            this.接続ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.接続ToolStripMenuItem.Text = "接続(&O)";
            this.接続ToolStripMenuItem.Click += new System.EventHandler(this.接続ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Enabled = false;
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.保存ToolStripMenuItem.Text = "保存(&S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.終了XToolStripMenuItem_Click);
            // 
            // tssLabelTime
            // 
            this.tssLabelTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttsTime});
            this.tssLabelTime.Location = new System.Drawing.Point(0, 512);
            this.tssLabelTime.Name = "tssLabelTime";
            this.tssLabelTime.Size = new System.Drawing.Size(1172, 22);
            this.tssLabelTime.TabIndex = 0;
            this.tssLabelTime.Text = "statusStrip1";
            // 
            // sttsTime
            // 
            this.sttsTime.Name = "sttsTime";
            this.sttsTime.Size = new System.Drawing.Size(0, 17);
            // 
            // tbSearchCarName
            // 
            this.tbSearchCarName.Location = new System.Drawing.Point(66, 122);
            this.tbSearchCarName.Name = "tbSearchCarName";
            this.tbSearchCarName.Size = new System.Drawing.Size(211, 19);
            this.tbSearchCarName.TabIndex = 21;
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(213, 202);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(75, 23);
            this.btSearchExe.TabIndex = 22;
            this.btSearchExe.Text = "実行";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.rbOrSearch);
            this.groupBox1.Controls.Add(this.rbAndSearch);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbAuthorSearch);
            this.groupBox1.Controls.Add(this.checkDateSearch);
            this.groupBox1.Controls.Add(this.cbSearchMaker);
            this.groupBox1.Controls.Add(this.dtpSearchDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelCar);
            this.groupBox1.Controls.Add(this.btSearchExe);
            this.groupBox1.Controls.Add(this.tbSearchCarName);
            this.groupBox1.Location = new System.Drawing.Point(823, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 231);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "記録者";
            // 
            // tbAuthorSearch
            // 
            this.tbAuthorSearch.Location = new System.Drawing.Point(66, 71);
            this.tbAuthorSearch.Name = "tbAuthorSearch";
            this.tbAuthorSearch.Size = new System.Drawing.Size(211, 19);
            this.tbAuthorSearch.TabIndex = 26;
            // 
            // checkDateSearch
            // 
            this.checkDateSearch.AutoSize = true;
            this.checkDateSearch.Location = new System.Drawing.Point(66, 49);
            this.checkDateSearch.Name = "checkDateSearch";
            this.checkDateSearch.Size = new System.Drawing.Size(41, 16);
            this.checkDateSearch.TabIndex = 25;
            this.checkDateSearch.Text = "ダメ";
            this.checkDateSearch.UseVisualStyleBackColor = true;
            // 
            // cbSearchMaker
            // 
            this.cbSearchMaker.FormattingEnabled = true;
            this.cbSearchMaker.Items.AddRange(new object[] {
            "トヨタ",
            "日産",
            "ホンダ",
            "スバル",
            "外車",
            "その他",
            "DEFAULT"});
            this.cbSearchMaker.Location = new System.Drawing.Point(66, 96);
            this.cbSearchMaker.Name = "cbSearchMaker";
            this.cbSearchMaker.Size = new System.Drawing.Size(211, 20);
            this.cbSearchMaker.TabIndex = 24;
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.Location = new System.Drawing.Point(66, 23);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(211, 19);
            this.dtpSearchDate.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "メーカー";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "日付";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(17, 125);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(29, 12);
            this.labelCar.TabIndex = 22;
            this.labelCar.Text = "車名";
            // 
            // carReportTableAdapter
            // 
            this.carReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportTableAdapter = this.carReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202011DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rbAndSearch
            // 
            this.rbAndSearch.AutoSize = true;
            this.rbAndSearch.Location = new System.Drawing.Point(60, 169);
            this.rbAndSearch.Name = "rbAndSearch";
            this.rbAndSearch.Size = new System.Drawing.Size(47, 16);
            this.rbAndSearch.TabIndex = 28;
            this.rbAndSearch.TabStop = true;
            this.rbAndSearch.Text = "AND";
            this.rbAndSearch.UseVisualStyleBackColor = true;
            // 
            // rbOrSearch
            // 
            this.rbOrSearch.AutoSize = true;
            this.rbOrSearch.Location = new System.Drawing.Point(113, 169);
            this.rbOrSearch.Name = "rbOrSearch";
            this.rbOrSearch.Size = new System.Drawing.Size(39, 16);
            this.rbOrSearch.TabIndex = 28;
            this.rbOrSearch.TabStop = true;
            this.rbOrSearch.Text = "OR";
            this.rbOrSearch.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tssLabelTime);
            this.Controls.Add(this.MakerG);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btDeleteArticle);
            this.Controls.Add(this.btDeleteImage);
            this.Controls.Add(this.btUpdateArticle);
            this.Controls.Add(this.btOpenImage);
            this.Controls.Add(this.btAddArticle);
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
            this.Name = "Form";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202011DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.MakerG.ResumeLayout(false);
            this.MakerG.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tssLabelTime.ResumeLayout(false);
            this.tssLabelTime.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btAddArticle;
        private System.Windows.Forms.Button btUpdateArticle;
        private System.Windows.Forms.Button btDeleteArticle;
        private System.Windows.Forms.Button btOpenImage;
        private System.Windows.Forms.Button btDeleteImage;
        private System.Windows.Forms.OpenFileDialog ofdOpenImage;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.GroupBox MakerG;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbGaikoku;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.OpenFileDialog ofdOpenData;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip tssLabelTime;
        private System.Windows.Forms.ToolStripStatusLabel sttsTime;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 接続ToolStripMenuItem;
        private System.Windows.Forms.BindingSource carReportBindingSource;
        private infosys202011DataSet infosys202011DataSet;
        private infosys202011DataSetTableAdapters.CarReportTableAdapter carReportTableAdapter;
        private infosys202011DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.TextBox tbSearchCarName;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSearchMaker;
        private System.Windows.Forms.CheckBox checkDateSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAuthorSearch;
        private System.Windows.Forms.RadioButton rbOrSearch;
        private System.Windows.Forms.RadioButton rbAndSearch;
    }
}

