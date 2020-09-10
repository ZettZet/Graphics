using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Coords = System.Tuple<System.Func<double, double>, System.Func<double, double>>;

namespace Graphics {
	class Curve {
		private Coords _functions;
		private bool _isExcplicit;

		public Curve(Func<double, double> X, Func<double, double> Y) {
			_functions = new Coords(X, Y);
			_isExcplicit = false;
		}

		public Curve(Func<double, double> func) {
			_functions = new Coords(func, null);
			_isExcplicit = true;
		}
	}
}
