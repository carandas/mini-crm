namespace MiniBiz
{
	partial class GraphForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphForm));
			cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
			ShowProfitGraphButton = new Button();
			ShowLossesGraphButton = new Button();
			SuspendLayout();
			// 
			// cartesianChart1
			// 
			cartesianChart1.Location = new Point(12, 104);
			cartesianChart1.MatchAxesScreenDataRatio = false;
			cartesianChart1.Name = "cartesianChart1";
			cartesianChart1.Size = new Size(776, 396);
			cartesianChart1.TabIndex = 0;
			// 
			// ShowProfitGraphButton
			// 
			ShowProfitGraphButton.BackColor = Color.FromArgb(37, 99, 235);
			ShowProfitGraphButton.Cursor = Cursors.Hand;
			ShowProfitGraphButton.FlatStyle = FlatStyle.Flat;
			ShowProfitGraphButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ShowProfitGraphButton.Location = new Point(12, 38);
			ShowProfitGraphButton.Name = "ShowProfitGraphButton";
			ShowProfitGraphButton.Size = new Size(127, 38);
			ShowProfitGraphButton.TabIndex = 5;
			ShowProfitGraphButton.Text = "Прибыль";
			ShowProfitGraphButton.UseVisualStyleBackColor = false;
			ShowProfitGraphButton.Click += ShowProfitGraphButton_Click;
			// 
			// ShowLossesGraphButton
			// 
			ShowLossesGraphButton.BackColor = Color.FromArgb(37, 99, 235);
			ShowLossesGraphButton.Cursor = Cursors.Hand;
			ShowLossesGraphButton.FlatStyle = FlatStyle.Flat;
			ShowLossesGraphButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ShowLossesGraphButton.Location = new Point(231, 38);
			ShowLossesGraphButton.Name = "ShowLossesGraphButton";
			ShowLossesGraphButton.Size = new Size(127, 38);
			ShowLossesGraphButton.TabIndex = 6;
			ShowLossesGraphButton.Text = "Убытки";
			ShowLossesGraphButton.UseVisualStyleBackColor = false;
			ShowLossesGraphButton.Click += ShowLossesGraphButton_Click;
			// 
			// GraphForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 521);
			Controls.Add(ShowLossesGraphButton);
			Controls.Add(ShowProfitGraphButton);
			Controls.Add(cartesianChart1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "GraphForm";
			Text = "GraphForm";
			Load += GraphForm_Load;
			ResumeLayout(false);
		}

		#endregion

		private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
		private Button ShowProfitGraphButton;
		private Button ShowLossesGraphButton;
	}
}