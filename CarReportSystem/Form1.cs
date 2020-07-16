using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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
            //dgvReport.DataSource = _Cars;
        }
        //クリアメソッド
        private void allClear() {
            dtpDate.Value = DateTime.Now;
            cbName.Text = "";
            radioButtonClear();
            cbCarName.Text = "";
            tbReport.Text = "";
             pictureBox1.Image = null;
        }
        //ボタンマスクメソッド
        private void initButton() {
            if (_Cars.Count > 0) {
                btDeleteArticle.Enabled = true;
                btUpdateArticle.Enabled = true;
            } else {
                btDeleteArticle.Enabled = false;
                btUpdateArticle.Enabled = false;
            }

            if (pictureBox1.Image != null) {
                btDeleteImage.Enabled = true;
            }
        }
        //ラジオボタンメソッド
        private CarMaker ReMakerButton() {
            var RadioButtonChecked_InGroup = MakerG.Controls.OfType<RadioButton>().SingleOrDefault(rb => rb.Checked == true);
            string str = "";
            if (RadioButtonChecked_InGroup == null) {
                str = "DEFAULT";
            } else {
                str = RadioButtonChecked_InGroup.Text;
            }
            CarMaker cm = (CarMaker)Enum.Parse(typeof(CarMaker), str);
            return cm;

             //LINQ
            //RadioButton select = (MakerG.Controls.Cast<RadioButton>().FirstOrDefault(RadioButton => rb.Checked));
            //return (Car.CarMaker)int.Parse(select.Tag.ToString());
        }

        private void radioButtonClear() {
            rbToyota.Checked = false;
            rbNissan.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbGaikoku.Checked = false;
            rbOther.Checked = false;
        }

        private void radioButtontrue() {
            

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



        //追加ボタン
        private void btAddArticle_Click(object sender, EventArgs e) {

            Car cars = new Car {
                Date = dtpDate.Value,
                RecoderName = cbName.Text,
                Maker = ReMakerButton(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                img = pictureBox1.Image
            };
            this._Cars.Insert(0, cars);
            //dgvReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            allClear();
            initButton();
        }

        //削除ボタン
        private void btDeleteArticle_Click(object sender, EventArgs e) {
            Car selecedCar = this._Cars[dgvReport.CurrentRow.Index];
            _Cars.RemoveAt(dgvReport.CurrentRow.Index);
            initButton();


        }

        //更新ボタン
        private void btUpdateArticle_Click(object sender, EventArgs e) {
            Car selecedCar = this._Cars[dgvReport.CurrentRow.Index];
            selecedCar.Date = dtpDate.Value;
            selecedCar.RecoderName = cbName.Text;
            selecedCar.Maker = ReMakerButton();
            selecedCar.CarName = cbCarName.Text;
            selecedCar.Report = tbReport.Text;
            selecedCar.img = pictureBox1.Image;
            initButton();
            dgvReport.Refresh();
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
                pictureBox1.Image = null;
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
            string Maker = dgvReport.CurrentRow.Cells[3].Value.ToString(); //選択している行の指定したセルの値を取得
            radioButtontrue();
            cbName.Text = dgvReport.CurrentRow.Cells[2].Value.ToString();
            cbCarName.Text = dgvReport.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dgvReport.CurrentRow.Cells[5].Value.ToString();
            dtpDate.Value = DateTime.Parse(dgvReport.CurrentRow.Cells[1].Value.ToString());

            //Car selecedCar = _Cars[dgvReport.CurrentRow.Index];
            //dtpDate.Value = selecedCar.Date;
            //cbName.Text = selecedCar.RecoderName;
            //radioButtontrue();
            //cbCarName.Text = selecedCar.CarName;
            //tbReport.Text = selecedCar.Report;
            //pictureBox1.Image = selecedCar.img;
        }

        //保存ボタン
        private void btSaveArticle_Click(object sender, EventArgs e) {
            if (sfdSaveData.ShowDialog() == DialogResult.OK) {

                //ファイルストリームを生成
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create)) {
                    try {
                        //シリアル化して保存
                        formatter.Serialize(fs, this._Cars);
                    } catch (SerializationException a) {
                        Console.WriteLine("Failed to serialize. Reason: " + a.Message);
                        throw;
                    }
                }
            }
        }

        //終了ボタン
        private void btAppEnd_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("本当に終了しますか？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) {
                Application.Exit();
            } 
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202011DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableAdapter.Fill(this.infosys202011DataSet.CarReport);
            dgvReport.Columns[0].Visible = false; //IDを非表示にする
            initButton();

            timerUpdateStatusStrip = new Timer();
            timerUpdateStatusStrip.Interval = 100;
            timerUpdateStatusStrip.Enabled = true;
            timerUpdateStatusStrip.Tick += TimerUpdateStatusStrip_Tick;

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            
        }
        //タイマー
        private void TimerUpdateStatusStrip_Tick(object sender, EventArgs e) {
            //現在の日時を更新する
            UpdateDateTimeStatusBar();
        }

        private void ofdOpenImage_FileOk(object sender, CancelEventArgs e) {
            this.Activate();
            pictureBox1.Image = Image.FromFile(ofdOpenImage.FileName);
        }
        private void ofdOpenData_FileOk(object sender, CancelEventArgs e) {
            this.Activate();
        }

        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e) {
            allClear();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult dr = MessageBox.Show("本当に終了しますか？","警告",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes) {
                Application.Exit();
            } 
            
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            

            BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(FileName, FileMode.Create)) {
                    try {
                        //シリアル化して保存
                        formatter.Serialize(fs, this._Cars);
                    } catch (SerializationException a) {
                        MessageBox.Show("Failed to serialize. Reason: " + a.Message);
                        throw;
                    }
                }
            
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e) {

            if (sfdSaveData.ShowDialog() == DialogResult.OK) {

                //ファイルストリームを生成
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create)) {
                    try {
                        //シリアル化して保存
                        formatter.Serialize(fs, this._Cars);
                        titlebarFileName(sfdSaveData.FileName);
                    } catch (SerializationException a) {
                        Console.WriteLine("Failed to serialize. Reason: " + a.Message);
                        throw;
                    }
                }
            }
        }

        private void 接続ToolStripMenuItem_Click(object sender, EventArgs e) {
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

        //バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte [] byteData) {
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


    }
}
