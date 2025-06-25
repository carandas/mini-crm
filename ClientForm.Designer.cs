namespace MiniBiz
{
	partial class ClientForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
			dataGridView1 = new DataGridView();
			SaveToDbButton = new Button();
			ButtonSaveToCsv = new Button();
			saveFileDialog1 = new SaveFileDialog();
			SearchTextBox = new TextBox();
			SearchGroupBox = new GroupBox();
			SearchButton = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SearchGroupBox.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = Color.FromArgb(237, 237, 237);
			dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.BackgroundColor = Color.FromArgb(236, 236, 236);
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(0, 1);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1172, 309);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
			dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;
			// 
			// SaveToDbButton
			// 
			SaveToDbButton.BackColor = Color.FromArgb(37, 99, 235);
			SaveToDbButton.Cursor = Cursors.Hand;
			SaveToDbButton.FlatStyle = FlatStyle.Flat;
			SaveToDbButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			SaveToDbButton.Location = new Point(12, 349);
			SaveToDbButton.Name = "SaveToDbButton";
			SaveToDbButton.Size = new Size(234, 45);
			SaveToDbButton.TabIndex = 1;
			SaveToDbButton.Text = "Сохранить в базу";
			SaveToDbButton.UseVisualStyleBackColor = false;
			SaveToDbButton.Click += SaveToDbButton_Click;
			// 
			// ButtonSaveToCsv
			// 
			ButtonSaveToCsv.BackColor = Color.FromArgb(37, 99, 235);
			ButtonSaveToCsv.BackgroundImageLayout = ImageLayout.None;
			ButtonSaveToCsv.Cursor = Cursors.Hand;
			ButtonSaveToCsv.FlatStyle = FlatStyle.Flat;
			ButtonSaveToCsv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
			ButtonSaveToCsv.Location = new Point(24, 400);
			ButtonSaveToCsv.Name = "ButtonSaveToCsv";
			ButtonSaveToCsv.Size = new Size(206, 45);
			ButtonSaveToCsv.TabIndex = 2;
			ButtonSaveToCsv.Text = "Сохранить в csv";
			ButtonSaveToCsv.UseVisualStyleBackColor = false;
			ButtonSaveToCsv.Click += ButtonSaveToCsv_Click;
			// 
			// saveFileDialog1
			// 
			saveFileDialog1.FileName = "Data.csv";
			saveFileDialog1.Filter = "Csv (*.csv)|*.scv|All Files(*.*)|*.*";
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
			// SearchGroupBox
			// 
			SearchGroupBox.Controls.Add(SearchButton);
			SearchGroupBox.Controls.Add(SearchTextBox);
			SearchGroupBox.Location = new Point(267, 325);
			SearchGroupBox.Name = "SearchGroupBox";
			SearchGroupBox.Size = new Size(294, 125);
			SearchGroupBox.TabIndex = 4;
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
			// ClientForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(245, 247, 250);
			ClientSize = new Size(1175, 462);
			Controls.Add(SearchGroupBox);
			Controls.Add(ButtonSaveToCsv);
			Controls.Add(SaveToDbButton);
			Controls.Add(dataGridView1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "ClientForm";
			Text = "ClientForm";
			FormClosing += ClientForm_FormClosing;
			Load += ClientForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			SearchGroupBox.ResumeLayout(false);
			SearchGroupBox.PerformLayout();
			ResumeLayout(false);
		}



		#endregion

		private DataGridView dataGridView1;
		private Button SaveToDbButton;
		private Button ButtonSaveToCsv;
		private SaveFileDialog saveFileDialog1;
		private TextBox SearchTextBox;
		private GroupBox SearchGroupBox;
		private Button SearchButton;
	}
}