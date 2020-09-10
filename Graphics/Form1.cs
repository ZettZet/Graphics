using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;

namespace Graphics {
	public partial class Form1 : Form {
		private Func<double, double> NonExplicitX;
		private Func<double, double> NonExplicitY;
		private Func<double, double> Explicit;


		public Form1() {
			InitializeComponent();
		}

		private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Enter) {
				UpdateCurve();
			}
		}

		private void UpdateCurve() {


			try {
				if(IsExplicit.Checked) {
					Explicit = Expr.Parse(ExpressionOrX.Text).Compile("x");
				}
				else {
					NonExplicitX = Expr.Parse(ExpressionOrX.Text).Compile("t");
					NonExplicitY = Expr.Parse(ExpressionY.Text).Compile("t");

				}
			}
			catch(Exception A) {
				MessageBox.Show(A.Message);
			}
		}

		private void toolStripButton4_CheckedChanged(object sender, EventArgs e) {
			if(IsExplicit.Checked) {
				IsExplicit.Text = IsExplicit.Text.Substring(3);

				fOrX.Text = "f(x)=";
				ExpressionOrX.Text = "x";
				(OrY.Visible, ExpressionY.Visible) = (false, false);
			}
			else {
				IsExplicit.Text = $"Non{IsExplicit.Text}";

				fOrX.Text = "x(t)=";
				ExpressionOrX.Text = "t";
				(OrY.Visible, ExpressionY.Visible) = (true, true);
				ExpressionY.Text = "t";
			}
		}

		private void RefreshBtn_Click(object sender, EventArgs e) {
			Angle.Text = "0";
			Scale.Text = "1";
			(MoveToX.Text, MoveToY.Text) = ("0", "0");
			UpdateCurve();
		}
	}
}
