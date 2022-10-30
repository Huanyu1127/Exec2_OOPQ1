namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.guesstxt = new System.Windows.Forms.TextBox();
			this.guessbtn = new System.Windows.Forms.Button();
			this.answertxt = new System.Windows.Forms.TextBox();
			this.newGamebtn = new System.Windows.Forms.Button();
			this.answerlbl = new System.Windows.Forms.Label();
			this.answerbtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guesstxt
			// 
			this.guesstxt.Location = new System.Drawing.Point(32, 37);
			this.guesstxt.MaxLength = 4;
			this.guesstxt.Name = "guesstxt";
			this.guesstxt.Size = new System.Drawing.Size(119, 30);
			this.guesstxt.TabIndex = 0;
			// 
			// guessbtn
			// 
			this.guessbtn.Location = new System.Drawing.Point(169, 37);
			this.guessbtn.Name = "guessbtn";
			this.guessbtn.Size = new System.Drawing.Size(75, 30);
			this.guessbtn.TabIndex = 1;
			this.guessbtn.Text = "猜猜";
			this.guessbtn.UseVisualStyleBackColor = true;
			this.guessbtn.Click += new System.EventHandler(this.guessbtn_Click);
			// 
			// answertxt
			// 
			this.answertxt.Location = new System.Drawing.Point(32, 86);
			this.answertxt.Multiline = true;
			this.answertxt.Name = "answertxt";
			this.answertxt.ReadOnly = true;
			this.answertxt.Size = new System.Drawing.Size(212, 233);
			this.answertxt.TabIndex = 2;
			// 
			// newGamebtn
			// 
			this.newGamebtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.newGamebtn.Location = new System.Drawing.Point(232, 50);
			this.newGamebtn.Name = "newGamebtn";
			this.newGamebtn.Size = new System.Drawing.Size(218, 64);
			this.newGamebtn.TabIndex = 0;
			this.newGamebtn.Text = "New Game";
			this.newGamebtn.UseVisualStyleBackColor = true;
			this.newGamebtn.Click += new System.EventHandler(this.newGamebtn_Click);
			// 
			// answerlbl
			// 
			this.answerlbl.AutoSize = true;
			this.answerlbl.Location = new System.Drawing.Point(466, 293);
			this.answerlbl.Name = "answerlbl";
			this.answerlbl.Size = new System.Drawing.Size(61, 22);
			this.answerlbl.TabIndex = 4;
			this.answerlbl.Text = "label1";
			// 
			// answerbtn
			// 
			this.answerbtn.Location = new System.Drawing.Point(363, 284);
			this.answerbtn.Name = "answerbtn";
			this.answerbtn.Size = new System.Drawing.Size(75, 35);
			this.answerbtn.TabIndex = 3;
			this.answerbtn.Text = "答案";
			this.answerbtn.UseVisualStyleBackColor = true;
			this.answerbtn.Click += new System.EventHandler(this.answerbtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.answerbtn);
			this.groupBox1.Controls.Add(this.answerlbl);
			this.groupBox1.Controls.Add(this.answertxt);
			this.groupBox1.Controls.Add(this.guessbtn);
			this.groupBox1.Controls.Add(this.guesstxt);
			this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(51, 140);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(571, 338);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 513);
			this.Controls.Add(this.newGamebtn);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(691, 560);
			this.Name = "Form1";
			this.Text = "1A2B";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox guesstxt;
		private System.Windows.Forms.Button guessbtn;
		private System.Windows.Forms.TextBox answertxt;
		private System.Windows.Forms.Button newGamebtn;
		private System.Windows.Forms.Label answerlbl;
		private System.Windows.Forms.Button answerbtn;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

