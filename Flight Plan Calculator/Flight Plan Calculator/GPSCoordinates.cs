using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanCalculator {
	public class GPSCoordinates {
		private short degrees;
		private short minutes;
		private double seconds;
		private double converted;
		public GPSCoordinates() {
			degrees = minutes = 0;
			seconds = converted = 0;
		}
		public GPSCoordinates(short deg, short min, double sec) {
			degrees = deg;
			minutes = min;
			seconds = sec;
			converted = 0;
		}

		public void convertToDegrees(short d, short m, double s) {
			converted = d + m / 60 + s / 3600;
		}
		public short getDegrees() {
			return degrees;
		}
		public short getMinutes() {
			return minutes;
		}
		public double getSeconds() {
			return seconds;
		}
		public double getConverted() {
			return converted;
		}

		public void setDegrees(short deg) {
			degrees = deg;
		}
		public void setMinutes(short min) {
			minutes = min;
		}
		public void setSeconds(double sec) {
			seconds = sec;
		}
	}
}