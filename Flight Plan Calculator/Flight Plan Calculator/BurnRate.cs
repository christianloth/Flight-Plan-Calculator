using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPlanCalculator {
	public class BurnRate {
		private short burnRate;
		public BurnRate() {
			burnRate = 0;
		}
		public BurnRate(short burnRate) {
			this.burnRate = burnRate;
		}
		public short getburnRate() {
			return burnRate;
		}
		public void setburnRate(short burnRate) {
			this.burnRate = burnRate;
		}
	}
}
