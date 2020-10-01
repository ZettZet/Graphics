using System;
using System.Windows.Forms;



namespace Plotable {
	using Coords = Tuple<Func<double, double>, Func<double, double>>;

	using Expr = MathNet.Symbolics.SymbolicExpression;
	class ExpressionToFunction {
		public static Coords Go(bool IsParametric, string X, string Y) {
			try {
				return new Coords(Expr.Parse(X).Compile(IsParametric ? "t" : "x"), IsParametric ? Expr.Parse(Y).Compile("t") : null);
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
				return null;
			}
		}

	}
}
