using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanCalculator {
	public class Calculate {
		public Vector wv;
		public Vector pv;
		public Calculate() {
			wv = new Vector();
			pv = new Vector();
		}
		public Calculate(Vector pv, Vector wv) {
			this.wv = wv;
			this.pv = pv;
		}
		// Wind corrected
		public Vector trueHeading() {
			// Crab into wind so that unneccassary componets cancel out
			double windX = wv.getVelocity() * Math.Cos(wv.getBearing() * Math.PI / 180);
			double windY = wv.getVelocity() * Math.Sin(wv.getBearing() * Math.PI / 180);
			return null;
		}
		// Magnetic vatiation corrected
		public Vector magHeading() {
			return null;
		}
		// Compass deviation corrected
		public Vector compassHeading() {
			return null;
		}
	}
}
