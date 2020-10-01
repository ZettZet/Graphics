using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plotable {
	class np {
		public static IEnumerable<double> Arange(double start, int count) {
			return Enumerable.Range((int)start, count).Select(v => (double)v);
		}

		public static IEnumerable<double> LinSpace(double start, double stop, int num, bool endpoint = true) {
			var result = new List<double>();
			if(num <= 0) {
				return result;
			}

			if(endpoint) {
				if(num == 1) {
					return new List<double>() { start };
				}

				var step = (stop - start) / ((double)num - 1.0d);
				result = Arange(0, num).Select(v => (v * step) + start).ToList();
			}
			else {
				var step = (stop - start) / (double)num;
				result = Arange(0, num).Select(v => (v * step) + start).ToList();
			}

			return result;
		}

		public static IEnumerable<int> Range(int start, int stop, int step = 1) {
			if(step == 0)
				throw new ArgumentException("Parameter step cannot equal zero.");

			if(start < stop && step > 0) {
				for(var i = start; i < stop; i += step) {
					yield return i;
				}
			}
			else if(start > stop && step < 0) {
				for(var i = start; i > stop; i += step) {
					yield return i;
				}
			}
		}

		public static IEnumerable<int> Range(int stop) {
			return Range(0, stop);
		}
	}
}
