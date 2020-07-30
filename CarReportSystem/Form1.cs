using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarReportSystem {
    

    public partial class Form : System.Windows.Forms.Form {

        private string FileName = "";

        Timer timerUpdateStatusStrip;

        BindingList<Car> _Cars = new BindingList<Car>();

        public Form() {
            InitializeComponent();
        }
        //クリアメソッド
        private void allClear() {
            dtpDate.Value = DateTime.Now;
            cbName.Text = "";
            RadioButtonClear();
            cbCarName.Text = "";
            tbReport.Text = "";
             pbImage.Image = null;
        }
        //ボタンマスクメソッド
        private void initButton() {
            if (dgvReport.Rows.Count > 0) {
                btDeleteArticle.Enabled = true;
                btUpdateArticle.Enabled = true;
            } else {
                btDeleteArticle.Enabled = false;
                btUpdateArticle.Enabled = false;
            }

            if (pbImage.Image != null) {
                btDeleteImage.Enabled = true;
            }
        }
        //ラジオボタンメソッド
        private string ReMakerButton() {
            string button = "";
            if (rbToyota.Checked) {
                button = "トヨタ";
            } else if (rbNissan.Checked) {
                button = "日産";
            } else if (rbHonda.Checked) {
                button = "ホンダ";
            } else if (rbSubaru.Checked) {
                button = "スバル";
            } else if (rbGaikoku.Checked) {
                button = "外車";
            } else if (rbOther.Checked) {
                button = "その他";
            } else {
                button = "DEFAULT";
            }

            return button;
        }

        private void RadioButtonClear() {
            rbToyota.Checked = false;
            rbNissan.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbGaikoku.Checked = false;
            rbOther.Checked = false;
        }

        private void RadioButtontrue() {
            

            switch (dgvReport.CurrentRow.Cells[3].Value.ToString()) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "外車":
                    rbGaikoku.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;                    
            }
        }
        //現在時刻の表示メソッド
        private void UpdateDateTimeStatusBar() {
            //現在の日時を取得する
            DateTime nowTime = DateTime.Now;
            //日時を文字列に変換する
            string newText = nowTime.ToString();
            //表示する文字列が前と違う場合は、更新する
            if (!sttsTime.Text.Equals(newText,StringComparison.Ordinal)) {
                sttsTime.Text = newText;
            }
        }
        //ファイル名表示メソッド(Form)
        private void titlebarFileName(string fileName){
            FileName = fileName;
           this.Text += FileName;
            this.保存ToolStripMenuItem.Enabled = true;
        }

        private void setcbName(string Name) { //メーカーのコンボボックスの入力候補の登録
            if (!cbName.Items.Contains(Name)) {
                cbName.Items.Add(Name);
            }
        }
        private void setcbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }



        //追加ボタン
        private void btAddArticle_Click(object sender, EventArgs e) {
            
                carReportTableAdapter.Insert(
                    dtpDate.Value,
                    cbName.Text,
                    ReMakerButton(),
                    cbCarName.Text,
                    tbReport.Text,
                    ImageToByteArray(pbImage.Image));

                setcbName(cbName.Text);
                setcbCarName(cbCarName.Text);
                

        
            //this._Cars.Insert(0, cars);
            ////dgvReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allClear();
            initButton();
            dgvReport.Refresh();
        }

        //削除ボタン
        private void btDeleteArticle_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("データを削除してもいいですか？", "確認", MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.OK) {
                carReportTableAdapter.Delete(int.Parse(dgvReport.CurrentRow.Cells[0].Value.ToString()),
                    DateTime.Parse(dgvReport.CurrentRow.Cells[1].Value.ToString()),
                    dgvReport.CurrentRow.Cells[2].Value.ToString(),
                    dgvReport.CurrentRow.Cells[3].Value.ToString(),
                    dgvReport.CurrentRow.Cells[4].Value.ToString(),
                    dgvReport.CurrentRow.Cells[5].Value.ToString()
                );

                保存ToolStripMenuItem_Click(sender, e);
                initButton();

            }

        }

        //更新ボタン
        private void btUpdateArticle_Click(object sender, EventArgs e) {
            
            dgvReport.CurrentRow.Cells[2].Value = cbName.Text;
            dgvReport.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvReport.CurrentRow.Cells[3].Value = ReMakerButton();
            dgvReport.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvReport.CurrentRow.Cells[5].Value = tbReport.Text;
            if (pbImage.Image != null) {
                dgvReport.CurrentRow.Cells[6].Value = ImageToByteArray(pbImage.Image);
            } else {
                dgvReport.CurrentRow.Cells[6].Value = null;
            }
            

            btSaveArticle_Click(sender, e);

            setcbName(cbName.Text);
            setcbCarName(cbCarName.Text);
            dgvReport.Refresh();

            保存ToolStripMenuItem.Enabled = true;

            
        }

        //画像開くボタン
        private void btOpenImage_Click(object sender, EventArgs e) {
            ofdOpenImage.ShowDialog();
            initButton();
        }

        //画像削除ボタン
        private void btDeleteImage_Click(object sender, EventArgs e) {

            DialogResult dr = MessageBox.Show("本当によろしいですか？", "ダメ", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK) {
                pbImage.Image = null;
                btDeleteImage.Enabled = false;
            } else if (dr == DialogResult.Cancel) {
                MessageBox.Show("キャンセルされました");
            } 

            
            
        }
    
        //開くボタン
        private void btOpenArticle_Click(object sender, EventArgs e) {
            if (ofdOpenData.ShowDialog() == DialogResult.OK) {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                    try {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読込
                        _Cars = (BindingList<Car>)formatter.Deserialize(fs);
                        //dgvのデータの中にデータをバインドされた_Carsを入れる
                        dgvReport.DataSource = _Cars;
                        //選択されている箇所を各コントロールへ表示
                        dgvReport_MouseClick(sender, e);
                        titlebarFileName(ofdOpenData.FileName);
                    } catch (SerializationException a) {
                        Console.WriteLine("Failed to deserialize. Reason: " + a.Message);
                        throw;
                    }
                initButton();
            }
        }

        //データを選択したら表示
        private void dgvReport_MouseClick(object sender, EventArgs e) {
 
            try {
                dtpDate.Value = (DateTime)dgvReport.CurrentRow.Cells[1].Value;
                cbName.Text = dgvReport.CurrentRow.Cells[2].Value.ToString();
                RadioButtontrue();
                cbCarName.Text = dgvReport.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvReport.CurrentRow.Cells[5].Value.ToString();
                pbImage.Image = ByteArrayToImage((byte[])dgvReport.CurrentRow.Cells[6].Value);
            } catch (InvalidCastException) {
                pbImage.Image = null;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            initButton();
        }

        //保存ボタン
        private void btSaveArticle_Click(object sender, EventArgs e) {
            //データベース更新(反映)
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202011DataSet);
        }

        //終了ボタン
        private void btAppEnd_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("本当に終了しますか？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) {
                Application.Exit();
            } 
        }

        private void Form1_Load(object sender, EventArgs e) {
            
            initButton();

            timerUpdateStatusStrip = new Timer();
            timerUpdateStatusStrip.Interval = 100;
            timerUpdateStatusStrip.Enabled = true;
            timerUpdateStatusStrip.Tick += TimerUpdateStatusStrip_Tick;

            pbImage.SizeMode = PictureBoxSizeMode.Zoom;

            
            
        }
        //タイマー
        private void TimerUpdateStatusStrip_Tick(object sender, EventArgs e) {
            //現在の日時を更新する
            UpdateDateTimeStatusBar();
        }

        private void ofdOpenImage_FileOk(object sender, CancelEventArgs e) {
            this.Activate();
            pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
        }
        private void ofdOpenData_FileOk(object sender, CancelEventArgs e) {
            this.Activate();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("本当に終了しますか？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) {
                Application.Exit();
            } 
            
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            //データベース更新(反映)
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202011DataSet);
            
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            //データベース更新(反映)
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202011DataSet);

            //if (sfdSaveData.ShowDialog() == DialogResult.OK) {

            //    //ファイルストリームを生成
            //    BinaryFormatter formatter = new BinaryFormatter();
            //    using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create)) {
            //        try {
            //            //シリアル化して保存
            //            formatter.Serialize(fs, this._Cars);
            //            titlebarFileName(sfdSaveData.FileName);
            //        } catch (SerializationException a) {
            //            Console.WriteLine("Failed to serialize. Reason: " + a.Message);
            //            throw;
            //        }
            //    }
            //}

        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202011DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202011DataSet.CarReport);

        }

        //バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] byteData) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }
        //Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }

        private void btSearchExe_Click(object sender, EventArgs e) {
            if (checkDateSearch.Checked) {
                this.carReportTableAdapter.FillByDateNull(this.infosys202011DataSet.CarReport, tbSearchCarName.Text, cbSearchMaker.Text,tbAuthorSearch.Text);
            } else {
                this.carReportTableAdapter.FillByCarName(this.infosys202011DataSet.CarReport, tbSearchCarName.Text, cbSearchMaker.Text, dtpSearchDate.Value.ToString(), tbAuthorSearch.Text);
            }
        }
    }
}
