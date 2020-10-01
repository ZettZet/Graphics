using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Plotable {
	static class Executor {
		private static readonly Queue<Promise> promises = new Queue<Promise>();

		public static void Push(Promise item) => promises.Enqueue(item);
		public static Promise Pop() => promises.Dequeue();

		public static void Clear() => promises.Clear();

		// TODO: HERE IS PROBLEM
		public static void Invoke(Graphics G) {
			var pen = new Pen(Color.Black, 1);
			int accuracy = 1000;
			int steps = 20;

			foreach(var item in promises) {
				if(item.Type == PromiseType.Plot) {
					var calced = Calculator.Calculate(item, accuracy, 0);
					foreach(var i in np.Range(0, calced.Length - 1)) {
						var next = PointToClient(calced[i + 1]);
						G.DrawLine(pen, PointToClient(calced[i]), next);
					}
				}
				else {
					//var calced = new List<PointF[]>();

					foreach(var step in np.Range(0, steps)) {
						var calced = (Calculator.Calculate(item, accuracy, steps, step));


						foreach(var j in np.Range(calced.Length)) {
							var temp = calced[j];
							Console.WriteLine(temp);
							calced[j] = PointToClient(calced[j]);
							Console.WriteLine(calced[j]);
						}

						foreach(var i in np.Range(accuracy - 1)) {
							G.DrawLine(pen, calced[i], calced[i+1]);
						}

					}
				}
			}
		}

		private static PointF PointToClient(PointF point) {
			var t = Axes.GetAxes();
			int X_0 = t.Origin.X;
			int Y_0 = t.Origin.Y;
			int piu = t.PixelsInUnit;

			float new_x = (point.X * piu) + X_0;
			float new_y = (-point.Y * piu * (-1)) + Y_0;

			return new PointF(new_x, new_y);
		}
	}

	class Calculator {
		static private PointF[] state { get; set; }

		public static PointF[] Calculate(Promise prom, int acc, int steps, int step = 0) {
			switch(prom.Type) {
				case PromiseType.Rotate:
					float valR = (float)DegToRad(step * -float.Parse(prom.Values) / steps);

					foreach(var i in np.Range(state.Length)) {
						var X = state[i].X;
						var Y = state[i].Y;

						state[i].X = (float)(Math.Cos(valR) * X - Math.Sin(valR) * Y);
						state[i].Y = (float)(Math.Sin(valR) * X + Math.Cos(valR) * Y);
					}
					break;
				case PromiseType.Scale:
					float valS = step * Axes.GetAxes().PixelsInUnit * float.Parse(prom.Values) / steps;

					foreach(var i in np.Range(state.Length)) {
						state[i].X *= valS;
						state[i].Y *= valS;
					}
					break;
				case PromiseType.Translate:
					var strings = prom.Values.Split('|');
					var dx = step  * float.Parse(strings[0]) / steps;
					var dy = step  * (-1) * float.Parse(strings[1]) / steps;

					foreach(var i in np.Range(state.Length)) {
						state[i].X += dx;
						state[i].Y += dy;
					}
					break;
				case PromiseType.Plot:
					var tempState = new List<PointF>();
					foreach(var point in CalculatePoints(acc)) {
						tempState.Add(point);
					}
					state = tempState.ToArray();
					break;
			}

			return state;
		}

		private static IEnumerable<PointF> CalculatePoints(int accuracyPoint) {
			var instance = Curve.GetCurve();
			var ax = Axes.GetAxes();

			if(instance == null)
				throw new NullReferenceException("Instance isn`t initialized");

			if(instance.Functions.Item1 == null || (instance.Functions.Item2 == null && instance.IsParametric))
				throw new NullReferenceException("Functions aren`t valid");

			var bound = (ax.WindowSize.Width - ax.Origin.X) / ax.PixelsInUnit;

			foreach(var x in np.LinSpace(-bound, bound, accuracyPoint, true)) {
				yield return CalcPoint(instance, x);
			}
		}

		private static double DegToRad(double deg) => Math.PI * deg / 180f;

		private static PointF CalcPoint(Curve instance, double x) => instance.IsParametric ? new PointF((float)instance.Functions.Item1(x), (float)instance.Functions.Item2(x)) : new PointF((float)x, (float)instance.Functions.Item1(x));
	}
}
