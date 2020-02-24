using static JogoDoGalo.Functions;

namespace JogoDoGalo
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusStrip_xWins = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip_oWins = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip_draws = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button1.Location = new System.Drawing.Point(12, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 100);
			this.button1.TabIndex = 0;
			this.button1.TabStop = false;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(ButtonClick);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button2.Location = new System.Drawing.Point(118, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 100);
			this.button2.TabIndex = 1;
			this.button2.TabStop = false;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(ButtonClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button3.Location = new System.Drawing.Point(224, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(100, 100);
			this.button3.TabIndex = 2;
			this.button3.TabStop = false;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(ButtonClick);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button6.Location = new System.Drawing.Point(224, 118);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(100, 100);
			this.button6.TabIndex = 5;
			this.button6.TabStop = false;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(ButtonClick);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button5.Location = new System.Drawing.Point(118, 118);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(100, 100);
			this.button5.TabIndex = 4;
			this.button5.TabStop = false;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(ButtonClick);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button4.Location = new System.Drawing.Point(12, 118);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 100);
			this.button4.TabIndex = 3;
			this.button4.TabStop = false;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(ButtonClick);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button9.Location = new System.Drawing.Point(224, 224);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(100, 100);
			this.button9.TabIndex = 8;
			this.button9.TabStop = false;
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(ButtonClick);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button8.Location = new System.Drawing.Point(118, 224);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(100, 100);
			this.button8.TabIndex = 7;
			this.button8.TabStop = false;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(ButtonClick);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Vladimir Script", 48F);
			this.button7.Location = new System.Drawing.Point(12, 224);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(100, 100);
			this.button7.TabIndex = 6;
			this.button7.TabStop = false;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(ButtonClick);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_xWins,
            this.statusStrip_oWins,
            this.statusStrip_draws});
			this.statusStrip.Location = new System.Drawing.Point(0, 339);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(336, 22);
			this.statusStrip.TabIndex = 13;
			this.statusStrip.Text = "statusStrip1";
			// 
			// statusStrip_xWins
			// 
			this.statusStrip_xWins.Name = "statusStrip_xWins";
			this.statusStrip_xWins.Size = new System.Drawing.Size(29, 17);
			this.statusStrip_xWins.Text = "X : 0";
			// 
			// statusStrip_oWins
			// 
			this.statusStrip_oWins.Margin = new System.Windows.Forms.Padding(30, 3, 0, 2);
			this.statusStrip_oWins.Name = "statusStrip_oWins";
			this.statusStrip_oWins.Size = new System.Drawing.Size(31, 17);
			this.statusStrip_oWins.Text = "O : 0";
			// 
			// statusStrip_draws
			// 
			this.statusStrip_draws.Margin = new System.Windows.Forms.Padding(100, 3, 0, 2);
			this.statusStrip_draws.Name = "statusStrip_draws";
			this.statusStrip_draws.Size = new System.Drawing.Size(51, 17);
			this.statusStrip_draws.Text = "Draws: 0";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 361);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jogo do Galo";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button button1;
		internal System.Windows.Forms.Button button2;
		internal System.Windows.Forms.Button button3;
		internal System.Windows.Forms.Button button6;
		internal System.Windows.Forms.Button button5;
		internal System.Windows.Forms.Button button4;
		internal System.Windows.Forms.Button button9;
		internal System.Windows.Forms.Button button8;
		internal System.Windows.Forms.Button button7;
		internal System.Windows.Forms.StatusStrip statusStrip;
		internal System.Windows.Forms.ToolStripStatusLabel statusStrip_xWins;
		internal System.Windows.Forms.ToolStripStatusLabel statusStrip_oWins;
		internal System.Windows.Forms.ToolStripStatusLabel statusStrip_draws;
	}
}

