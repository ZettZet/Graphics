using System;
using System.Collections.Generic;
using System.Drawing;

namespace Plotable {
	using Coords = Tuple<Func<double, double>, Func<double, double>>;


	class Curve {
		private static Curve _instance;

		public bool IsParametric { get; private set; }
		public bool IsPolar { get; private set; }
		public Coords Functions { get; private set; }

		public void SetupCurve(Coords func, bool isPolar) {
			if(_instance == null)
				_instance = new Curve();

			_instance.Functions = func;
			_instance.IsParametric = func.Item2 != null;
			_instance.IsPolar = isPolar;
		}

		public static Curve GetCurve() {
			if(_instance == null)
				_instance = new Curve();

			return _instance;
		}
	}
}
