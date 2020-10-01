using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Plotable {
	public partial class Form1 : Form {
		private Graphics G;
		public Form1() {
			InitializeComponent();
			var Axis = Axes.GetAxes();
			Axis.SetAxes(new Point(Canvas.Width / 2, Canvas.Height / 2), Canvas.Size);

			G = Canvas.CreateGraphics();
			G.SmoothingMode = SmoothingMode.AntiAlias;
			G.CompositingQuality = CompositingQuality.HighQuality;
			G.CompositingMode = CompositingMode.SourceOver;

			Canvas_Paint(null, new PaintEventArgs(G, Canvas.Bounds));
		}

		private void Canvas_Paint(object sender, PaintEventArgs e) => Axes.GetAxes().Draw(e.Graphics);


		private void Form1_ResizeBegin(object sender, System.EventArgs e) {
			Axes.GetAxes().SetAxes(new Point(Canvas.Width / 2, Canvas.Height / 2), Canvas.Size);
			using(var G = Canvas.CreateGraphics()) {
				Canvas_Paint(sender, new PaintEventArgs(G, Canvas.Bounds));
			}
		}

		private void IsPolar_CheckedChanged(object sender, System.EventArgs e) => IsPolar.Text = IsPolar.Checked ? "Polar" : "Cartesian";

		private void IsParametric_CheckedChanged(object sender, System.EventArgs e) =>
				(IsParametric.Text, fOrX.Text, ExpressionOrX.Text, OrY.Visible, ExpressionY.Visible, ExpressionY.Text) = IsParametric.Checked ?
				("Parametric function", "x(t)=", "t", true, true, "t") :
				("Given function", "f(x)=", "x", false, false, "");

		private void Plot_Click(object sender, System.EventArgs e) {
			if(ListOfPromises.Items.Count == 0) {
				var current = Curve.GetCurve();
				current.SetupCurve(ExpressionToFunction.Go(IsParametric.Checked, ExpressionOrX.Text, ExpressionY.Text), IsPolar.Checked);

				var item = new Promise(PromiseType.Plot, $"{fOrX.Text}{ExpressionOrX.Text} {(IsParametric.Checked ? OrY.Text + ExpressionY.Text : "") }");
				Executor.Push(item);
				ListOfPromises.Items.Add(item);
			}
		}

		private void Transform_Click(object sender, System.EventArgs e) {
			if(ListOfPromises.Items.Count != 0) {
				var tsb = (ToolStripButton)sender;
				Promise item;

				if(tsb == RotateTo) {
					item = new Promise(PromiseType.Rotate, Angle.Text);
				}
				else if(tsb == ScaleBy) {
					item = new Promise(PromiseType.Scale, Scale.Text);
				}
				else {
					item = new Promise(PromiseType.Translate, $"{MoveToX.Text}|{MoveToY.Text}");
				}

				Executor.Push(item);
				ListOfPromises.Items.Add(item);
			}
		}

		private void Angle_TextChanged(object sender, System.EventArgs e) {
			var tstb = (ToolStripTextBox)sender;
			var re = new Regex(@"^[+-]?\d*\,?\d+$");

			(tstb.ForeColor, RotateTo.Enabled, ScaleBy.Enabled, MoveTo.Enabled) = re.IsMatch(tstb.Text) ? (Color.Black, true, true, true) : (Color.Red, false, false, false);
		}

		private void RefreshBtn_Click(object sender, System.EventArgs e) {
			(IsPolar.Checked, IsParametric.Checked, Angle.Text, Scale.Text, MoveToX.Text, MoveToY.Text) = (false, false, "0", "1", "0", "0");
			Canvas_Paint(sender, new PaintEventArgs(G, Canvas.Bounds));
			ListOfPromises.Items.Clear();
			Executor.Clear();
		}

		private void Run_Click(object sender, System.EventArgs e) => Executor.Invoke(G);
	}
}
