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
	public partial class Window : Form {
		public Window() {
			InitializeComponent();
		}

		private GPSCoordinates latitudeA;
		private GPSCoordinates latitudeB;
		private GPSCoordinates longitudeA;
		private GPSCoordinates longitudeB;
		private BurnRate burnRate;
		private int airspeed;
		private Vector pv;
		private Vector wv;

		private void Window_Load(object sender, EventArgs e) {
		}

		private void latA_Click(object sender, EventArgs e) {
		}

		private void latA_TextChanged(object sender, EventArgs e) {
			String raw = latA.Text.Replace('\'', ' ').Replace('\"', ' ');
			String[] s = raw.Split(' ');
			double[] dms = new double[3];
			for (int i = 0; i < s.Length; i++) {
				dms[i] = Convert.ToDouble(s[i]);
			}
			latitudeA = new GPSCoordinates((short)dms[0], (short)dms[1], dms[2]);
			latitudeA.convertToDegrees(latitudeA.getDegrees(), latitudeA.getMinutes(), latitudeA.getSeconds());
		}

		private void latB_TextChanged(object sender, EventArgs e) {
			String raw = latA.Text.Replace('\'', ' ').Replace('\"', ' ');
			String[] s = raw.Split(' ');
			double[] dms = new double[3];
			for (int i = 0; i < s.Length; i++) {
				dms[i] = Convert.ToDouble(s[i]);
			}
			latitudeB = new GPSCoordinates((short)dms[0], (short)dms[1], dms[2]);
			latitudeB.convertToDegrees(latitudeB.getDegrees(), latitudeB.getMinutes(), latitudeB.getSeconds());
		}

		private void lonA_TextChanged(object sender, EventArgs e) {
			String raw = latA.Text.Replace('\'', ' ').Replace('\"', ' ');
			String[] s = raw.Split(' ');
			double[] dms = new double[3];
			for (int i = 0; i < s.Length; i++) {
				dms[i] = Convert.ToDouble(s[i]);
			}
			longitudeA = new GPSCoordinates((short)dms[0], (short)dms[1], dms[2]);
			longitudeA.convertToDegrees(longitudeA.getDegrees(), longitudeA.getMinutes(), longitudeA.getSeconds());
		}

		private void lonB_TextChanged(object sender, EventArgs e) {
			String raw = latA.Text.Replace('\'', ' ').Replace('\"', ' ');
			String[] s = raw.Split(' ');
			double[] dms = new double[3];
			for (int i = 0; i < s.Length; i++) {
				dms[i] = Convert.ToDouble(s[i]);
			}
			longitudeB = new GPSCoordinates((short)dms[0], (short)dms[1], dms[2]);
			longitudeB.convertToDegrees(longitudeB.getDegrees(), longitudeB.getMinutes(), longitudeB.getSeconds());
		}

		private void windDirection_TextChanged(object sender, EventArgs e) {
			wv.setBearing(Convert.ToDouble(windDirection.Text));
		}

		private void windVelocity_TextChanged(object sender, EventArgs e) {
			wv.setVelocity(Convert.ToDouble(windVelocity.Text));
		}

		private void planeVelovity_TextChanged(object sender, EventArgs e) {
			pv.setBearing(Convert.ToDouble(planeVelovity.Text));
		}

		private void planeDirection_TextChanged(object sender, EventArgs e) {
			pv.setBearing(Convert.ToDouble(planeDirection.Text));
		}

		private void calculate_Click(object sender, EventArgs e) {
			Calculate calc = new Calculate();
		}
	}
}