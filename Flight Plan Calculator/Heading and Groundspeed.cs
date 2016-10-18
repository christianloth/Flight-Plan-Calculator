using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightPlanCalculator {
	public partial class windowHeadingGroundspeed : Form {
		public windowHeadingGroundspeed() {
			InitializeComponent();
		}

		//private GPSCoordinates latitudeA;
		//private GPSCoordinates latitudeB;
		//private GPSCoordinates longitudeA;
		//private GPSCoordinates longitudeB;

		private void Window_Load(object sender, EventArgs e) {
		}

		/*private void latB_TextChanged(object sender, EventArgs e) {
			String raw = txtboxLatA.Text.Replace('\'', ' ').Replace('\"', ' ');
			String[] s = raw.Split(' ');
			short[] dms = new short[3];
			for (int i = 0; i < s.Length; i++) {
				dms[i] = Convert.ToInt16(s[i]);
			}
			latitudeB = new GPSCoordinates(dms[0], dms[1], dms[2]);
			latitudeB.convertToDegrees(latitudeB.getDegrees(), latitudeB.getMinutes(), latitudeB.getSeconds());
		}*/

		private void calculate_Click(object sender, EventArgs e) {
			HeadingGroundspeed hgs = new HeadingGroundspeed();
			try {
				hgs = new HeadingGroundspeed(Convert.ToDouble(txtboxWindDirection.Text), Convert.ToDouble(txtboxWindSpeed.Text),
					Convert.ToDouble(txtboxCourse.Text), Convert.ToDouble(txtboxAirspeed.Text));
				outputTextbox.AppendText("Groundspeed = " + hgs.groundspeed() + '\n');
				outputTextbox.AppendText("Heading = " + hgs.heading() + '\n');
				outputTextbox.AppendText("Wind Correction Angle = " + hgs.wca() + '\n');
			} catch (FormatException) {
				MessageBox.Show("Please fill out all required values with proper notation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}