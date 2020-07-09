﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dgvReport.DataSource = _Cars;
        }
        //クリアメソッド
        private void allClear() {
            dtpDate.Value = DateTime.Now;
            cbName.Text = "";
            RbCheckClear();
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
        }
        //ラジオボタンメソッド
        private CarMaker RbCheck() {
            //LINQ
            //RadioButton select = (MakerG.Controls.Cast<RadioButton>().FirstOrDefault(RadioButton => rb.Checked));
            //return (Car.CarMaker)int.Parse(select.Tag.ToString());
            Car car = new Car();
            if (rbToyota.Checked) {
                return CarMaker.トヨタ;
            } else if( rbNissan.Checked){
                return CarMaker.日産;
            }else if (rbHonda.Checked) {
                return CarMaker.ホンダ;
            }else if (rbSubaru.Checked) {
                return CarMaker.スバル;
            }else if (rbGaikoku.Checked) {
                return CarMaker.外車;
            }else if(rbOther.Checked){
                return CarMaker.その他;
            } else {
                return CarMaker.DEFAULT;
            }
        }
        private void RbCheckClear() {
            Car car = new Car();
            if (rbToyota.Checked) {
                rbToyota.Checked = false;
            } else if (rbNissan.Checked) {
                rbNissan.Checked = false;
            } else if (rbHonda.Checked) {
                rbHonda.Checked = false;
            } else if (rbSubaru.Checked) {
                rbSubaru.Checked = false;
            } else if (rbGaikoku.Checked) {
                rbGaikoku.Checked = false;
            } else if (rbOther.Checked) {
                rbOther.Checked = false;
            } 
        }

        private void RbChecktrue() {
            Car selecedCar1 = this._Cars[dgvReport.CurrentRow.Index];

            switch (selecedCar1.Maker) {
                case CarMaker.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarMaker.日産:
                    rbNissan.Checked = true;
                    break;
                case CarMaker.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarMaker.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarMaker.外車:
                    rbGaikoku.Checked = true;
                    break;
                case CarMaker.その他:
                    rbOther.Checked = true;
                    break;                    
            }
        }

        private void LoadFile(string value) {
            //Form1.Text = File.ReadAllText(value, Encoding.GetEncoding("Shift_JIS"));
            // ファイル名を保持する
            this.FileName = value;
        }

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



        //追加ボタン
        private void btAddArticle_Click(object sender, EventArgs e) {
            Car cars = new Car {
                Date = dtpDate.Value,
                RecoderName = cbName.Text,
                Maker = RbCheck(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                img = pictureBox1.Image
            };
            this._Cars.Insert(0, cars);
            dgvReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            selecedCar.Maker = RbCheck();
            selecedCar.CarName = cbCarName.Text;
            selecedCar.Report = tbReport.Text;
            selecedCar.img = pictureBox1.Image;
            initButton();
            dgvReport.Refresh();
        }

        //画像開くボタン
        private void btOpenImage_Click(object sender, EventArgs e) {
            ofdOpenImage.ShowDialog();
        }


        //画像削除ボタン
        private void btDeleteImage_Click(object sender, EventArgs e) {
            if (pictureBox1.Image != null) {
                btDeleteImage.Enabled = true;
            }

            DialogResult dr = MessageBox.Show("本当によろしいですか？", "ダメ", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK) {
                pictureBox1.Image = null;
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
                    } catch (SerializationException a) {
                        Console.WriteLine("Failed to deserialize. Reason: " + a.Message);
                        throw;
                    }
            }
        }

        //データを選択したら表示
        private void dgvReport_MouseClick(object sender, EventArgs e) {
            Car selecedCar = _Cars[dgvReport.CurrentRow.Index];
            dtpDate.Value = selecedCar.Date;
            cbName.Text = selecedCar.RecoderName;
            RbChecktrue();
            cbCarName.Text = selecedCar.CarName;
            tbReport.Text = selecedCar.Report;
            pictureBox1.Image = selecedCar.img;
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

        private void Form1_Load(object sender, EventArgs e) {
            initButton();

            timerUpdateStatusStrip = new Timer();
            timerUpdateStatusStrip.Interval = 100;
            timerUpdateStatusStrip.Enabled = true;
            timerUpdateStatusStrip.Tick += TimerUpdateStatusStrip_Tick;

           // sfdSaveData.Filter = ofdOpenData.FileName;
        }

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


        //終了ボタン
        private void btAppEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e) {
            allClear();
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void 名前を付けて保存ToolStripMenuItem_Click(object sender, EventArgs e) {
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

        private void ファイルToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
