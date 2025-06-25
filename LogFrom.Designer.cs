namespace MiniBiz
{
	partial class LogFrom
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogFrom));
			panel1 = new Panel();
			LogLabel = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.AutoScroll = true;
			panel1.Controls.Add(LogLabel);
			panel1.Location = new Point(12, 7);
			panel1.Name = "panel1";
			panel1.Size = new Size(884, 432);
			panel1.TabIndex = 0;
			// 
			// LogLabel
			// 
			LogLabel.AutoSize = true;
			LogLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			LogLabel.Location = new Point(22, 22);
			LogLabel.Name = "LogLabel";
			LogLabel.Size = new Size(59, 25);
			LogLabel.TabIndex = 0;
			LogLabel.Text = "label1";
			// 
			// LogFrom
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(245, 247, 250);
			ClientSize = new Size(908, 451);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "LogFrom";
			Text = "LogFrom";
			Load += LogFrom_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label LogLabel;
	}
}