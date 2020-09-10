namespace Graphics {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.IsExplicit = new System.Windows.Forms.ToolStripButton();
			this.fOrX = new System.Windows.Forms.ToolStripLabel();
			this.ExpressionOrX = new System.Windows.Forms.ToolStripTextBox();
			this.OrY = new System.Windows.Forms.ToolStripLabel();
			this.ExpressionY = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.Angle = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.Scale = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.MoveToX = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.MoveToY = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IsExplicit,
            this.fOrX,
            this.ExpressionOrX,
            this.OrY,
            this.ExpressionY,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.Angle,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.Scale,
            this.toolStripSeparator3,
            this.toolStripButton3,
            this.MoveToX,
            this.toolStripLabel2,
            this.MoveToY,
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.RefreshBtn});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1126, 26);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// IsExplicit
			// 
			this.IsExplicit.Checked = true;
			this.IsExplicit.CheckOnClick = true;
			this.IsExplicit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.IsExplicit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.IsExplicit.Image = ((System.Drawing.Image)(resources.GetObject("IsExplicit.Image")));
			this.IsExplicit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.IsExplicit.Name = "IsExplicit";
			this.IsExplicit.Size = new System.Drawing.Size(97, 23);
			this.IsExplicit.Text = "Explicit function";
			this.IsExplicit.CheckedChanged += new System.EventHandler(this.toolStripButton4_CheckedChanged);
			// 
			// fOrX
			// 
			this.fOrX.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fOrX.Name = "fOrX";
			this.fOrX.Size = new System.Drawing.Size(43, 23);
			this.fOrX.Text = "f(x)=";
			// 
			// ExpressionOrX
			// 
			this.ExpressionOrX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExpressionOrX.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ExpressionOrX.Name = "ExpressionOrX";
			this.ExpressionOrX.Size = new System.Drawing.Size(90, 26);
			this.ExpressionOrX.Text = "x";
			this.ExpressionOrX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
			// 
			// OrY
			// 
			this.OrY.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OrY.Name = "OrY";
			this.OrY.Size = new System.Drawing.Size(43, 23);
			this.OrY.Text = "y(t)=";
			this.OrY.Visible = false;
			// 
			// ExpressionY
			// 
			this.ExpressionY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ExpressionY.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ExpressionY.Name = "ExpressionY";
			this.ExpressionY.Size = new System.Drawing.Size(90, 26);
			this.ExpressionY.Text = "t";
			this.ExpressionY.Visible = false;
			this.ExpressionY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(59, 23);
			this.toolStripButton1.Text = "Rotate to";
			// 
			// Angle
			// 
			this.Angle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Angle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Angle.Name = "Angle";
			this.Angle.Size = new System.Drawing.Size(30, 26);
			this.Angle.Text = "0";
			this.Angle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Angle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(54, 23);
			this.toolStripButton2.Text = "Scale by";
			// 
			// Scale
			// 
			this.Scale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Scale.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Scale.Name = "Scale";
			this.Scale.Size = new System.Drawing.Size(30, 26);
			this.Scale.Text = "1";
			this.Scale.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Scale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(62, 23);
			this.toolStripButton3.Text = "Move to (";
			// 
			// MoveToX
			// 
			this.MoveToX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MoveToX.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MoveToX.Name = "MoveToX";
			this.MoveToX.Size = new System.Drawing.Size(30, 26);
			this.MoveToX.Text = "0";
			this.MoveToX.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MoveToX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(10, 23);
			this.toolStripLabel2.Text = ";";
			// 
			// MoveToY
			// 
			this.MoveToY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.MoveToY.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.MoveToY.Name = "MoveToY";
			this.MoveToY.Size = new System.Drawing.Size(30, 26);
			this.MoveToY.Text = "0";
			this.MoveToY.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.MoveToY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(11, 23);
			this.toolStripLabel3.Text = ")";
			// 
			// RefreshBtn
			// 
			this.RefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
			this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RefreshBtn.Name = "RefreshBtn";
			this.RefreshBtn.Size = new System.Drawing.Size(50, 23);
			this.RefreshBtn.Text = "Refresh";
			this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 26);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1126, 534);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel fOrX;
		private System.Windows.Forms.ToolStripTextBox ExpressionOrX;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripTextBox Angle;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripTextBox Scale;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripTextBox MoveToX;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripTextBox MoveToY;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripButton IsExplicit;
		private System.Windows.Forms.ToolStripLabel OrY;
		private System.Windows.Forms.ToolStripTextBox ExpressionY;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton RefreshBtn;
	}
}

