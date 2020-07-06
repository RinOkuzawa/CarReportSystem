using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        BindingList<Car> _Cars = new BindingList<Car>();
        public Form1() {
            InitializeComponent();
            dgvReport.DataSource = _Cars;
        }

        private void allClear() {
            dtpDate = null;
            cbName.Text = "";
            cbToyota.Text = "";
            cbCarName.Text = "";
            tbReport.Text = "";
             pictureBox1.Image = null;
        }

        private void initButton() {
            if (_Cars.Count > 0) {
                btDeleteArticle.Enabled = true;
                btUpdateArticle.Enabled = true;
            } else {
                btDeleteArticle.Enabled = false;
                btUpdateArticle.Enabled = false;
            }
        }

        private void btAppEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btAddArticle_Click(object sender, EventArgs e) {
            Car cars = new Car {
                Date = dtpDate.Value,
                RecoderName = cbName.Text,
                //Maker = ,
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                img = pictureBox1.Image
            };
            this._Cars.Insert(0, cars);
            dgvReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void btOpenImage_Click(object sender, EventArgs e) {
            ofdOpenImage.ShowDialog();
        }

        private void ofdOpenImage_FileOk(object sender, CancelEventArgs e) {
                this.Activate();
                pictureBox1.Image = Image.FromFile(ofdOpenImage.FileName);        
        }

        private void btDeleteImage_Click(object sender, EventArgs e) {
            this.pictureBox1.Image = null;
        }

        private void btDeleteArticle_Click(object sender, EventArgs e) {
            Car selecedCar = this._Cars[dgvReport.CurrentRow.Index];
            _Cars.RemoveAt(dgvReport.CurrentRow.Index);
            initButton();
            
        }
    }
}
