using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanCalculator {
	public class GPSCoordinates {
		private short degrees;
		private short minutes;
		private short seconds;
		private int converted;
		public GPSCoordinates() {
			degrees = minutes = seconds = 0;
			converted = 0;
		}
		public GPSCoordinates(short deg, short min, short sec) {
			degrees = deg;
			minutes = min;
			seconds = sec;
			converted = 0;
		}

		public void convertToDegrees(short d, short m, short s) {
			converted = d + m / 60 + s / 3600;
		}
		public short getDegrees() {
			return degrees;
		}
		public short getMinutes() {
			return minutes;
		}
		public short getSeconds() {
			return seconds;
		}
		public int getConverted() {
			return converted;
		}
		public void setDegrees(short deg) {
			degrees = deg;
		}
		public void setMinutes(short min) {
			minutes = min;
		}
		public void setSeconds(short sec) {
			seconds = sec;
		}
	}
}