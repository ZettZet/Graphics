using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Plotable {
	class Axes {
		private static Axes _instance;
		public Point Origin { get; private set; }
		public int PixelsInUnit { get; private set; }
		public Size WindowSize { get; private set; }


		public void SetAxes(Point origin, Size size, int scale = 15) {
			Origin = origin;
			PixelsInUnit = scale;
			WindowSize = size;
		}

		public void Draw(Graphics G) {
			G.Clear(Color.White);

			var major = new Pen(Color.Black, 2);
			
			G.DrawLine(major, new Point(0, Origin.Y), new Point(WindowSize.Width, Origin.Y));
			G.DrawLine(major, new Point(Origin.X, 0), new Point(Origin.X, WindowSize.Height));

			DrawAxis(G);
		}

		private void DrawAxis(Graphics G) {
			var minor = new Pen(Color.Black, 1);
			var font = new Font(FontFamily.GenericSansSerif, 6);
			var brush = new SolidBrush(Color.Black);

			var Xes = GenerateRange(Origin.X, WindowSize.Width, PixelsInUnit);
			var Yes = GenerateRange(Origin.Y, WindowSize.Height, PixelsInUnit);


			foreach(var x in Xes) {
				G.DrawLine(minor, new Point(x, Origin.Y + 2), new Point(x, Origin.Y - 2));
				G.DrawString($"{(x - Origin.X) / PixelsInUnit}", font, brush, new PointF(x, Origin.Y + 3));
			}

			foreach(var y in Yes) {
				G.DrawLine(minor, new Point(Origin.X + 2, y), new Point(Origin.X - 2, y));
				G.DrawString($"{(Origin.Y - y) / PixelsInUnit}", font, brush, new PointF(Origin.X + 3, y));
			}
		}

		private IEnumerable<int> GenerateRange(int start, int end, int step) {
			var local = new List<int>();
			local.AddRange(np.Range(start, end, step));
			local.AddRange(np.Range(start, 0, -step));

			return local;
		}

		public static Axes GetAxes() {
			if(_instance == null) {
				_instance = new Axes();
			}

			return _instance;
		}
	}
}
