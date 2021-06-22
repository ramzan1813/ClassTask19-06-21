
namespace Class_task
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Show = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.ShowUp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.AcceptsTab = true;
			this.textBox1.Location = new System.Drawing.Point(159, 152);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox1.Size = new System.Drawing.Size(205, 127);
			this.textBox1.TabIndex = 0;
			// 
			// Show
			// 
			this.Show.Location = new System.Drawing.Point(211, 301);
			this.Show.Name = "Show";
			this.Show.Size = new System.Drawing.Size(75, 23);
			this.Show.TabIndex = 1;
			this.Show.Text = "Show";
			this.Show.UseVisualStyleBackColor = true;
			this.Show.Click += new System.EventHandler(this.Show_Click);
			// 
			// textBox2
			// 
			this.textBox2.AcceptsReturn = true;
			this.textBox2.AcceptsTab = true;
			this.textBox2.Location = new System.Drawing.Point(398, 152);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox2.Size = new System.Drawing.Size(205, 127);
			this.textBox2.TabIndex = 0;
			// 
			// ShowUp
			// 
			this.ShowUp.Location = new System.Drawing.Point(450, 301);
			this.ShowUp.Name = "ShowUp";
			this.ShowUp.Size = new System.Drawing.Size(75, 23);
			this.ShowUp.TabIndex = 1;
			this.ShowUp.Text = "Show";
			this.ShowUp.UseVisualStyleBackColor = true;
			this.ShowUp.Click += new System.EventHandler(this.ShowUp_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ShowUp);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.Show);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Show;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button ShowUp;
	}
}

