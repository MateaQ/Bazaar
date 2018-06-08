namespace ArtBazaar
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Button2
			// 
			this.Button2.BackColor = System.Drawing.Color.DarkSalmon;
			this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button2.Location = new System.Drawing.Point(574, 14);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(104, 38);
			this.Button2.TabIndex = 27;
			this.Button2.Text = "Odjava";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Button1
			// 
			this.Button1.BackColor = System.Drawing.Color.DarkSalmon;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button1.Location = new System.Drawing.Point(439, 13);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(104, 40);
			this.Button1.TabIndex = 26;
			this.Button1.Text = "Profil";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Button4
			// 
			this.Button4.BackColor = System.Drawing.SystemColors.Control;
			this.Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button4.BackgroundImage")));
			this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button4.Location = new System.Drawing.Point(341, 60);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(273, 271);
			this.Button4.TabIndex = 29;
			this.Button4.UseVisualStyleBackColor = false;
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// Button5
			// 
			this.Button5.BackColor = System.Drawing.SystemColors.Control;
			this.Button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button5.BackgroundImage")));
			this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button5.Location = new System.Drawing.Point(12, 23);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(323, 308);
			this.Button5.TabIndex = 30;
			this.Button5.UseVisualStyleBackColor = false;
			this.Button5.UseWaitCursor = true;
			// 
			// Button6
			// 
			this.Button6.BackColor = System.Drawing.SystemColors.Control;
			this.Button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button6.BackgroundImage")));
			this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Button6.Location = new System.Drawing.Point(114, 337);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(364, 203);
			this.Button6.TabIndex = 31;
			this.Button6.UseVisualStyleBackColor = false;
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(682, 548);
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form4";
			this.Text = "ArtBazaar";
			this.Load += new System.EventHandler(this.Form4_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button Button4;
		private System.Windows.Forms.Button Button5;
		private System.Windows.Forms.Button Button6;
	}
}