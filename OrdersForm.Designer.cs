namespace MiniBiz
{
	partial class OrdersForm
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
			dataGridView1 = new DataGridView();
			SaveToDbButton = new Button();
			TotalProfitLabel = new Label();
			ButtonSaveToCsv = new Button();
			saveFileDialog1 = new SaveFileDialog();
			SearchGroupBox = new GroupBox();
			SearchButton = new Button();
			SearchTextBox = new TextBox();
			PanelProfit = new Panel();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SearchGroupBox.SuspendLayout();
			PanelProfit.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 237, 237);
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.BackgroundColor = Color.FromArgb(236, 236, 236);
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(0, 2);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1015, 279);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
			dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
			// 
			// SaveToDbButton
			// 
			SaveToDbButton.BackColor = Color.FromArgb(37, 99, 235);
			SaveToDbButton.FlatStyle = FlatStyle.Flat;
			SaveToDbButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			SaveToDbButton.Location = new Point(12, 312);
			SaveToDbButton.Name = "SaveToDbButton";
			SaveToDbButton.Size = new Size(234, 45);
			SaveToDbButton.TabIndex = 2;
			SaveToDbButton.Text = "Сохранить в базу";
			SaveToDbButton.UseVisualStyleBackColor = false;
			SaveToDbButton.Click += SaveToDbButton_Click;
			// 
			// TotalProfitLabel
			// 
			TotalProfitLabel.AutoSize = true;
			TotalProfitLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
			TotalProfitLabel.Location = new Point(13, 15);
			TotalProfitLabel.Name = "TotalProfitLabel";
			TotalProfitLabel.Size = new Size(115, 31);
			TotalProfitLabel.TabIndex = 3;
			TotalProfitLabel.Text = "Прибыль:";
			// 
			// ButtonSaveToCsv
			// 
			ButtonSaveToCsv.BackColor = Color.FromArgb(37, 99, 235);
			ButtonSaveToCsv.BackgroundImageLayout = ImageLayout.None;
			ButtonSaveToCsv.Cursor = Cursors.Hand;
			ButtonSaveToCsv.FlatStyle = FlatStyle.Flat;
			ButtonSaveToCsv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ButtonSaveToCsv.Location = new Point(23, 377);
			ButtonSaveToCsv.Name = "ButtonSaveToCsv";
			ButtonSaveToCsv.Size = new Size(206, 45);
			ButtonSaveToCsv.TabIndex = 4;
			ButtonSaveToCsv.Text = "Сохранить в csv";
			ButtonSaveToCsv.UseVisualStyleBackColor = false;
			ButtonSaveToCsv.Click += ButtonSaveToCsv_Click;
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.FileName = "Data.csv";
			saveFileDialog1.Filter = "Csv (*.csv)|*.scv|All Files(*.*)|*.*";
			// 
			// SearchGroupBox
			// 
			SearchGroupBox.Controls.Add(SearchButton);
			SearchGroupBox.Controls.Add(SearchTextBox);
			SearchGroupBox.Location = new Point(270, 312);
			SearchGroupBox.Name = "SearchGroupBox";
			SearchGroupBox.Size = new Size(294, 125);
			SearchGroupBox.TabIndex = 5;
			SearchGroupBox.TabStop = false;
			SearchGroupBox.Text = "Поиск";
			// 
			// SearchButton
			// 
			SearchButton.BackColor = Color.FromArgb(37, 99, 235);
			SearchButton.Cursor = Cursors.Hand;
			SearchButton.FlatStyle = FlatStyle.Flat;
			SearchButton.Location = new Point(9, 75);
			SearchButton.Name = "SearchButton";
			SearchButton.Size = new Size(94, 29);
			SearchButton.TabIndex = 4;
			SearchButton.Text = "поиск";
			SearchButton.UseVisualStyleBackColor = false;
			SearchButton.Click += SearchButton_Click;
			// 
			// SearchTextBox
			// 
			SearchTextBox.Cursor = Cursors.IBeam;
			SearchTextBox.Location = new Point(9, 36);
			SearchTextBox.Name = "SearchTextBox";
			SearchTextBox.Size = new Size(235, 27);
			SearchTextBox.TabIndex = 3;
			SearchTextBox.Text = "что искать?";
			// 
			// PanelProfit
			// 
			PanelProfit.Controls.Add(TotalProfitLabel);
			PanelProfit.Location = new Point(570, 324);
			PanelProfit.Name = "PanelProfit";
			PanelProfit.Size = new Size(250, 113);
			PanelProfit.TabIndex = 6;
			// 
			// OrdersForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1014, 450);
			Controls.Add(PanelProfit);
			Controls.Add(SearchGroupBox);
			Controls.Add(ButtonSaveToCsv);
			Controls.Add(SaveToDbButton);
			Controls.Add(dataGridView1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "OrdersForm";
			Text = "OrdersAndCellsForm";
			FormClosing += OrdersForm_FormClosing;
			Load += OrdersAndCellsForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			SearchGroupBox.ResumeLayout(false);
			SearchGroupBox.PerformLayout();
			PanelProfit.ResumeLayout(false);
			PanelProfit.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Button SaveToDbButton;
		private Label TotalProfitLabel;
		private Button ButtonSaveToCsv;
		private SaveFileDialog saveFileDialog1;
		private GroupBox SearchGroupBox;
		private Button SearchButton;
		private TextBox SearchTextBox;
		private Panel PanelProfit;
	}
}