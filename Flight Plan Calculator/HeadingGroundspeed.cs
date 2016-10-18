using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanCalculator {
	public class HeadingGroundspeed {
		private double trueAirspeed;
		private double windSpeed;
		private double windDirection;
		private double course;

		public HeadingGroundspeed() {
			trueAirspeed = windDirection = windSpeed = course = 0;
		}
		public HeadingGroundspeed(double windDirection, double windSpeed, double course, double trueAirspeed) {
			this.windDirection = windDirection;
			this.windSpeed = windSpeed;
			this.course = course;
			this.trueAirspeed = trueAirspeed;

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
		// Wind corrected
		public int groundspeed() {
			double WTAngle = bearingToDegrees(course) - (bearingToDegrees(windDirection) + 180);
			return (int) Math.Round((trueAirspeed * Math.Cos(wca() * Math.PI / 180) + windSpeed * Math.Cos(WTAngle * Math.PI / 180)));
		}
		public int wca() {
			double WTAngle = bearingToDegrees(course) - (bearingToDegrees(windDirection) + 180);
			return -(int) Math.Round((Math.Asin(windSpeed * Math.Sin(WTAngle * Math.PI / 180) / trueAirspeed) * (180 / Math.PI)));
		}
		public int heading() {
			return (int) Math.Round((course + wca()));
		}
		// Magnetic vatiation corrected
		public HeadingGroundspeed magHeading() {
			return null;
		}
		// Compass deviation corrected
		public HeadingGroundspeed compassHeading() {
			return null;
		}
	}
}