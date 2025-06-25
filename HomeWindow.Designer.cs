namespace MiniBiz
{
	partial class HomeWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeWindow));
			OpenCilentsFormButton = new Button();
			OpenCellsFormButton = new Button();
			OpenLogFormButton = new Button();
			TitleLabel = new Label();
			label1 = new Label();
			WarehouseButton = new Button();
			GrphFromOpenButton = new Button();
			SuspendLayout();
			// 
			// OpenCilentsFormButton
			// 
			OpenCilentsFormButton.BackColor = Color.FromArgb(37, 99, 235);
			OpenCilentsFormButton.Cursor = Cursors.Hand;
			OpenCilentsFormButton.FlatStyle = FlatStyle.Flat;
			OpenCilentsFormButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
			OpenCilentsFormButton.ForeColor = Color.Black;
			OpenCilentsFormButton.Location = new Point(12, 12);
			OpenCilentsFormButton.Name = "OpenCilentsFormButton";
			OpenCilentsFormButton.Size = new Size(206, 46);
			OpenCilentsFormButton.TabIndex = 0;
			OpenCilentsFormButton.Text = "Клиенты";
			OpenCilentsFormButton.UseVisualStyleBackColor = false;
			OpenCilentsFormButton.Click += OpenCilentsFormButton_Click;
			// 
			// OpenCellsFormButton
			// 
			OpenCellsFormButton.BackColor = Color.FromArgb(37, 99, 235);
			OpenCellsFormButton.Cursor = Cursors.Hand;
			OpenCellsFormButton.FlatStyle = FlatStyle.Flat;
			OpenCellsFormButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
			OpenCellsFormButton.ForeColor = Color.Black;
			OpenCellsFormButton.Location = new Point(260, 12);
			OpenCellsFormButton.Name = "OpenCellsFormButton";
			OpenCellsFormButton.Size = new Size(206, 46);
			OpenCellsFormButton.TabIndex = 1;
			OpenCellsFormButton.Text = "Заказы";
			OpenCellsFormButton.UseVisualStyleBackColor = false;
			OpenCellsFormButton.Click += OpenCellsFormButton_Click;
			// 
			// OpenLogFormButton
			// 
			OpenLogFormButton.BackColor = Color.FromArgb(37, 99, 235);
			OpenLogFormButton.Cursor = Cursors.Hand;
			OpenLogFormButton.FlatStyle = FlatStyle.Flat;
			OpenLogFormButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
			OpenLogFormButton.ForeColor = Color.Black;
			OpenLogFormButton.Location = new Point(499, 12);
			OpenLogFormButton.Name = "OpenLogFormButton";
			OpenLogFormButton.Size = new Size(206, 46);
			OpenLogFormButton.TabIndex = 2;
			OpenLogFormButton.Text = "Посмотреть логи";
			OpenLogFormButton.UseVisualStyleBackColor = false;
			OpenLogFormButton.Click += OpenFinanceFormButton_Click;
			// 
			// TitleLabel
			// 
			TitleLabel.AutoSize = true;
			TitleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
			TitleLabel.ForeColor = Color.FromArgb(46, 46, 46);
			TitleLabel.Location = new Point(383, 131);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new Size(268, 38);
			TitleLabel.TabIndex = 3;
			TitleLabel.Text = "Добро пожаловать!";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.ForeColor = Color.FromArgb(46, 46, 46);
			label1.Location = new Point(12, 194);
			label1.Name = "label1";
			label1.Size = new Size(1021, 217);
			label1.TabIndex = 4;
			label1.Text = resources.GetString("label1.Text");
			// 
			// WarehouseButton
			// 
			WarehouseButton.BackColor = Color.FromArgb(37, 99, 235);
			WarehouseButton.Cursor = Cursors.Hand;
			WarehouseButton.FlatStyle = FlatStyle.Flat;
			WarehouseButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
			WarehouseButton.ForeColor = Color.Black;
			WarehouseButton.Location = new Point(734, 12);
			WarehouseButton.Name = "WarehouseButton";
			WarehouseButton.Size = new Size(206, 46);
			WarehouseButton.TabIndex = 5;
			WarehouseButton.Text = "товары/услуги";
			WarehouseButton.UseVisualStyleBackColor = false;
			WarehouseButton.Click += WarehouseButton_Click;
			// 
			// GrphFromOpenButton
			// 
			GrphFromOpenButton.BackColor = Color.FromArgb(37, 99, 235);
			GrphFromOpenButton.Cursor = Cursors.Hand;
			GrphFromOpenButton.FlatStyle = FlatStyle.Flat;
			GrphFromOpenButton.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 204);
			GrphFromOpenButton.ForeColor = Color.Black;
			GrphFromOpenButton.Location = new Point(975, 12);
			GrphFromOpenButton.Name = "GrphFromOpenButton";
			GrphFromOpenButton.Size = new Size(206, 46);
			GrphFromOpenButton.TabIndex = 6;
			GrphFromOpenButton.Text = "графики";
			GrphFromOpenButton.UseVisualStyleBackColor = false;
			GrphFromOpenButton.Click += GrphFromOpenButton_Click;
			// 
			// HomeWindow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(245, 247, 250);
			ClientSize = new Size(1247, 453);
			Controls.Add(GrphFromOpenButton);
			Controls.Add(WarehouseButton);
			Controls.Add(label1);
			Controls.Add(TitleLabel);
			Controls.Add(OpenLogFormButton);
			Controls.Add(OpenCellsFormButton);
			Controls.Add(OpenCilentsFormButton);
			ForeColor = Color.Black;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "HomeWindow";
			Text = "Home Window";
			Load += HomeWindow_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button OpenCilentsFormButton;
		private Button OpenCellsFormButton;
		private Button OpenLogFormButton;
		private Label TitleLabel;
		private Label label1;
		private Button WarehouseButton;
		private Button GrphFromOpenButton;
	}
}
