namespace Plotable {
	partial class Form1 {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.IsPolar = new System.Windows.Forms.ToolStripButton();
			this.IsParametric = new System.Windows.Forms.ToolStripButton();
			this.fOrX = new System.Windows.Forms.ToolStripLabel();
			this.ExpressionOrX = new System.Windows.Forms.ToolStripTextBox();
			this.OrY = new System.Windows.Forms.ToolStripLabel();
			this.ExpressionY = new System.Windows.Forms.ToolStripTextBox();
			this.Plot = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.RotateTo = new System.Windows.Forms.ToolStripButton();
			this.Angle = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ScaleBy = new System.Windows.Forms.ToolStripButton();
			this.Scale = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.MoveTo = new System.Windows.Forms.ToolStripButton();
			this.MoveToX = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.MoveToY = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.Run = new System.Windows.Forms.ToolStripButton();
			this.AnimationTick = new System.Windows.Forms.Timer(this.components);
			this.ListOfPromises = new System.Windows.Forms.CheckedListBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Canvas = new System.Windows.Forms.Panel();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsPolar,
            this.IsParametric,
            this.fOrX,
            this.ExpressionOrX,
            this.OrY,
            this.ExpressionY,
            this.Plot,
            this.toolStripSeparator1,
            this.RotateTo,
            this.Angle,
            this.toolStripSeparator2,
            this.ScaleBy,
            this.Scale,
            this.toolStripSeparator3,
            this.MoveTo,
            this.MoveToX,
            this.toolStripLabel2,
            this.MoveToY,
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.RefreshBtn,
            this.toolStripSeparator5,
            this.Run});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1190, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// IsPolar
			// 
			this.IsPolar.CheckOnClick = true;
			this.IsPolar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.IsPolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IsPolar.Image = ((System.Drawing.Image)(resources.GetObject("IsPolar.Image")));
			this.IsPolar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.IsPolar.Name = "IsPolar";
			this.IsPolar.Size = new System.Drawing.Size(69, 22);
			this.IsPolar.Text = "Cartesian";
			this.IsPolar.CheckedChanged += new System.EventHandler(this.IsPolar_CheckedChanged);
			// 
			// IsParametric
			// 
			this.IsParametric.CheckOnClick = true;
			this.IsParametric.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.IsParametric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IsParametric.Image = ((System.Drawing.Image)(resources.GetObject("IsParametric.Image")));
			this.IsParametric.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.IsParametric.Name = "IsParametric";
			this.IsParametric.Size = new System.Drawing.Size(95, 22);
			this.IsParametric.Text = "Given function";
			this.IsParametric.CheckedChanged += new System.EventHandler(this.IsParametric_CheckedChanged);
			// 
			// fOrX
			// 
			this.fOrX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fOrX.Name = "fOrX";
			this.fOrX.Size = new System.Drawing.Size(32, 22);
			this.fOrX.Text = "f(x)=";
			// 
			// ExpressionOrX
			// 
			this.ExpressionOrX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExpressionOrX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ExpressionOrX.Name = "ExpressionOrX";
			this.ExpressionOrX.Size = new System.Drawing.Size(90, 25);
			this.ExpressionOrX.Text = "x";
			// 
			// OrY
			// 
			this.OrY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OrY.Name = "OrY";
			this.OrY.Size = new System.Drawing.Size(33, 22);
			this.OrY.Text = "y(t)=";
			this.OrY.Visible = false;
			// 
			// ExpressionY
			// 
			this.ExpressionY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExpressionY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ExpressionY.Name = "ExpressionY";
			this.ExpressionY.Size = new System.Drawing.Size(90, 25);
			this.ExpressionY.Text = "t";
			this.ExpressionY.Visible = false;
			// 
			// Plot
			// 
			this.Plot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Plot.Image = ((System.Drawing.Image)(resources.GetObject("Plot.Image")));
			this.Plot.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Plot.Name = "Plot";
			this.Plot.Size = new System.Drawing.Size(35, 22);
			this.Plot.Text = "Plot";
			this.Plot.Click += new System.EventHandler(this.Plot_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// RotateTo
			// 
			this.RotateTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.RotateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RotateTo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RotateTo.Name = "RotateTo";
			this.RotateTo.Size = new System.Drawing.Size(66, 22);
			this.RotateTo.Text = "Rotate to";
			this.RotateTo.Click += new System.EventHandler(this.Transform_Click);
			// 
			// Angle
			// 
			this.Angle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Angle.Name = "Angle";
			this.Angle.Size = new System.Drawing.Size(30, 25);
			this.Angle.Text = "0";
			this.Angle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Angle.TextChanged += new System.EventHandler(this.Angle_TextChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// ScaleBy
			// 
			this.ScaleBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ScaleBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ScaleBy.Image = ((System.Drawing.Image)(resources.GetObject("ScaleBy.Image")));
			this.ScaleBy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ScaleBy.Name = "ScaleBy";
			this.ScaleBy.Size = new System.Drawing.Size(65, 22);
			this.ScaleBy.Text = "Scale by";
			this.ScaleBy.Click += new System.EventHandler(this.Transform_Click);
			// 
			// Scale
			// 
			this.Scale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Scale.Name = "Scale";
			this.Scale.Size = new System.Drawing.Size(30, 25);
			this.Scale.Text = "1";
			this.Scale.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Scale.TextChanged += new System.EventHandler(this.Angle_TextChanged);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// MoveTo
			// 
			this.MoveTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.MoveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MoveTo.Image = ((System.Drawing.Image)(resources.GetObject("MoveTo.Image")));
			this.MoveTo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.MoveTo.Name = "MoveTo";
			this.MoveTo.Size = new System.Drawing.Size(67, 22);
			this.MoveTo.Text = "Move to (";
			this.MoveTo.Click += new System.EventHandler(this.Transform_Click);
			// 
			// MoveToX
			// 
			this.MoveToX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MoveToX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MoveToX.Name = "MoveToX";
			this.MoveToX.Size = new System.Drawing.Size(30, 25);
			this.MoveToX.Text = "0";
			this.MoveToX.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MoveToX.TextChanged += new System.EventHandler(this.Angle_TextChanged);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(10, 22);
			this.toolStripLabel2.Text = ";";
			// 
			// MoveToY
			// 
			this.MoveToY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MoveToY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MoveToY.Name = "MoveToY";
			this.MoveToY.Size = new System.Drawing.Size(30, 25);
			this.MoveToY.Text = "0";
			this.MoveToY.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MoveToY.TextChanged += new System.EventHandler(this.Angle_TextChanged);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(11, 22);
			this.toolStripLabel3.Text = ")";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
			this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new System.Drawing.Size(59, 22);
			this.RefreshBtn.Text = "Refresh";
			this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// Run
			// 
			this.Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Run.Image = ((System.Drawing.Image)(resources.GetObject("Run.Image")));
			this.Run.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Run.Name = "Run";
			this.Run.Size = new System.Drawing.Size(36, 22);
			this.Run.Text = "Run";
			this.Run.Click += new System.EventHandler(this.Run_Click);
			// 
			// AnimationTick
			// 
			this.AnimationTick.Interval = 16;
			// 
			// ListOfPromises
			// 
			this.ListOfPromises.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ListOfPromises.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListOfPromises.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ListOfPromises.FormattingEnabled = true;
			this.ListOfPromises.Location = new System.Drawing.Point(0, 0);
			this.ListOfPromises.Name = "ListOfPromises";
			this.ListOfPromises.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ListOfPromises.Size = new System.Drawing.Size(305, 647);
			this.ListOfPromises.TabIndex = 2;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Canvas);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.ListOfPromises);
			this.splitContainer1.Size = new System.Drawing.Size(1190, 647);
			this.splitContainer1.SplitterDistance = 881;
			this.splitContainer1.TabIndex = 3;
			// 
			// Canvas
			// 
			this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canvas.Location = new System.Drawing.Point(0, 0);
			this.Canvas.Name = "Canvas";
			this.Canvas.Size = new System.Drawing.Size(881, 647);
			this.Canvas.TabIndex = 0;
			this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
			this.Canvas.Resize += new System.EventHandler(this.Form1_ResizeBegin);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1190, 673);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.splitContainer1);
			this.DoubleBuffered = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel fOrX;
		private System.Windows.Forms.ToolStripTextBox ExpressionOrX;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton RotateTo;
		private System.Windows.Forms.ToolStripTextBox Angle;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton ScaleBy;
		private System.Windows.Forms.ToolStripTextBox Scale;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton MoveTo;
		private System.Windows.Forms.ToolStripTextBox MoveToX;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripTextBox MoveToY;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripButton IsParametric;
		private System.Windows.Forms.ToolStripLabel OrY;
		private System.Windows.Forms.ToolStripTextBox ExpressionY;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton RefreshBtn;
		private System.Windows.Forms.ToolStripButton IsPolar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton Run;
		private System.Windows.Forms.Timer AnimationTick;
		private System.Windows.Forms.CheckedListBox ListOfPromises;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel Canvas;
		private System.Windows.Forms.ToolStripButton Plot;
	}
}

