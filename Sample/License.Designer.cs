namespace Bruteforcer
{
	partial class License
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
			this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
			this.darkButton1 = new DarkUI.Controls.DarkButton();
			this.SuspendLayout();
			// 
			// darkTextBox1
			// 
			this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.darkTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.darkTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.darkTextBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.darkTextBox1.Location = new System.Drawing.Point(12, 12);
			this.darkTextBox1.Multiline = true;
			this.darkTextBox1.Name = "darkTextBox1";
			this.darkTextBox1.ReadOnly = true;
			this.darkTextBox1.Size = new System.Drawing.Size(764, 346);
			this.darkTextBox1.TabIndex = 0;
			this.darkTextBox1.Text = resources.GetString("darkTextBox1.Text");
			// 
			// darkButton1
			// 
			this.darkButton1.Location = new System.Drawing.Point(290, 364);
			this.darkButton1.Name = "darkButton1";
			this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
			this.darkButton1.Size = new System.Drawing.Size(202, 23);
			this.darkButton1.TabIndex = 1;
			this.darkButton1.Text = "Close";
			this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
			// 
			// License
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(787, 393);
			this.Controls.Add(this.darkButton1);
			this.Controls.Add(this.darkTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "License";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "License";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DarkUI.Controls.DarkTextBox darkTextBox1;
		private DarkUI.Controls.DarkButton darkButton1;
	}
}