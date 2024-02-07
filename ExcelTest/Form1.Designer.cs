namespace ExcelTest
{
	partial class Form1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.TxtSaat = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtDers = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(22, 28);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(854, 417);
			this.dataGridView1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(909, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Saat:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(880, 83);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(308, 40);
			this.button1.TabIndex = 3;
			this.button1.Text = "kaydet";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TxtSaat
			// 
			this.TxtSaat.Location = new System.Drawing.Point(981, 138);
			this.TxtSaat.Name = "TxtSaat";
			this.TxtSaat.Size = new System.Drawing.Size(207, 30);
			this.TxtSaat.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(880, 28);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(308, 39);
			this.button2.TabIndex = 5;
			this.button2.Text = "Listele";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(882, 186);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Ders Adı:";
			// 
			// TxtDers
			// 
			this.TxtDers.Location = new System.Drawing.Point(981, 183);
			this.TxtDers.Name = "TxtDers";
			this.TxtDers.Size = new System.Drawing.Size(207, 30);
			this.TxtDers.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 472);
			this.Controls.Add(this.TxtDers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.TxtSaat);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox TxtSaat;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxtDers;
	}
}

