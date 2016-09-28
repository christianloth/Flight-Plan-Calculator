using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanCalculator {
	public class Vector {
		private double bearing;
		private double velocity;
		public Vector() {
			bearing = velocity = 0;
		}
		public Vector(double bearing, double velocity) {
			this.bearing = bearing;
			this.velocity = velocity;
		}
		public double getBearing() {
			return bearing;
		}
		public double getVelocity() {
			return velocity;
		}
		public void setBearing(double bearing) {
			this.bearing = bearing;
		}
		public void setVelocity(double velocity) {
			this.velocity = velocity;
		}
		public double bearingToDegrees(double bearing) {
			if (bearing > 360) {
				return bearingToDegrees(bearing - 360);
			}
			if (bearing < 0) {
				return bearingToDegrees(bearing + 360);
			}
			if (0 <= bearing && bearing <= 90) {
				return 90 - bearing;
			}
			if (90 < bearing && bearing <= 360) {
				return 360 - (bearing - 90);
			}
			return 0;
		}
	}
}
