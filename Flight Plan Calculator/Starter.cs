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
	public partial class windowStarter : Form {
		public windowStarter() {
			InitializeComponent();
		}

		private void windowFPC_Load(object sender, EventArgs e) {

		}

		private void btnHeadingAndGroundspeed_Click(object sender, EventArgs e) {
			Form f = new windowHeadingGroundspeed();
			f.Show();
		}
	}
}
