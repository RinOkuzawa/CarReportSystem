using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
	[Serializable]
	class Car {
		[System.ComponentModel.DisplayName("日付")]
		public DateTime Date { get; set; }
		//メーカ
		[System.ComponentModel.DisplayName("記録者")]
		public string RecoderName { get; set; }
		//
		[System.ComponentModel.DisplayName("メーカー")]
		public CarMaker Maker { get; set; }
		[System.ComponentModel.DisplayName("車名")]
		public string CarName { get; set; }
		[System.ComponentModel.DisplayName("レポート")]
		public string Report { get; set; }
		//画像
		[System.ComponentModel.DisplayName("画像")]
		public Image img { get; set; }
	}

	public enum CarMaker {
		DEFAULT,
		トヨタ,
		日産,
		ホンダ,
		スバル,
		外車,
		その他
	}
}
