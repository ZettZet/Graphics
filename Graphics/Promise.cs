using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

using MathNet.Symbolics;

namespace Plotable {
	enum PromiseType {
		Rotate = 0,
		Scale = 1,
		Translate = 2,
		Plot = 3
	};

	class Promise {
		public PromiseType Type { get; private set; }
		public string Values { get; private set; }
		public bool IsDone { get; set; }

		public Promise(PromiseType type, string _val) {
			Type = type;
			Values = _val;
		}

		public override string ToString() => $"{Type} {Values}";
	}
}
